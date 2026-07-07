using Bandwidth.Standard.Model.Bxml;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Refer verb is used to hand off a call to a SIP endpoint.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/refer"/></para>
    /// </summary>
    public class Refer : IVerb
    {
        private string referCompleteMethod;
        private SipUri sipUriElement;

        /// <summary>
        /// URL to receive the refer complete callback.
        /// </summary>
        [XmlAttribute("referCompleteUrl")]
        public string ReferCompleteUrl { get; set; }

        /// <summary>
        /// HTTP method to send the refer complete callback. GET or POST. Default value is POST.
        /// </summary>
        [XmlAttribute("referCompleteMethod")]
        public string ReferCompleteMethod
        {
            get { return referCompleteMethod; }
            set
            {
                if (value != null && value != "GET" && value != "POST")
                {
                    throw new ArgumentException("ReferCompleteMethod must be either 'GET' or 'POST'.");
                }
                referCompleteMethod = value;
            }
        }

        /// <summary>
        /// Optional custom string to include in callbacks.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// SIP URI destination for the REFER. This is the same <see cref="SipUri"/> type used by
        /// <see cref="Transfer"/> - only <see cref="SipUri.Uri"/> is valid in a REFER context.
        /// Setting any Transfer-only attribute (e.g. TransferAnswerUrl, Username, Uui) on the
        /// SipUri assigned here throws immediately. Note: this check runs when the SipUri is
        /// assigned to Refer - mutating those attributes on the SipUri instance afterward is not
        /// re-validated before serialization.
        /// </summary>
        [XmlElement("SipUri")]
        public SipUri SipUriElement
        {
            get { return sipUriElement; }
            set
            {
                ValidateSipUriForRefer(value);
                sipUriElement = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Refer class.
        /// </summary>
        public Refer()
        {
            /// <summary>
            /// Explicitly set to "POST" so the attribute is always serialized in BXML output,
            /// matching the server's default and making the intent explicit to consumers.
            /// </summary>
            ReferCompleteMethod = "POST";
        }

        /// <summary>
        /// Sets the SIP URI destination from a string.
        /// </summary>
        public Refer WithSipUri(string sipUri)
        {
            SipUriElement = new SipUri { Uri = sipUri };
            return this;
        }

        /// <summary>
        /// Sets the SIP URI destination from a SipUri object. Only <see cref="SipUri.Uri"/> may be
        /// set - Transfer-only attributes are rejected. See <see cref="SipUriElement"/>.
        /// </summary>
        public Refer WithSipUri(SipUri sipUri)
        {
            SipUriElement = sipUri;
            return this;
        }

        /// <summary>
        /// Sets referCompleteUrl.
        /// </summary>
        public Refer WithReferCompleteUrl(string referCompleteUrl)
        {
            ReferCompleteUrl = referCompleteUrl;
            return this;
        }

        /// <summary>
        /// Sets referCompleteMethod.
        /// </summary>
        public Refer WithReferCompleteMethod(string referCompleteMethod)
        {
            ReferCompleteMethod = referCompleteMethod;
            return this;
        }

        /// <summary>
        /// Sets tag.
        /// </summary>
        public Refer WithTag(string tag)
        {
            Tag = tag;
            return this;
        }

        /// <summary>
        /// Throws if the given SipUri has any attribute set that is only valid for &lt;Transfer&gt;,
        /// or if Uri does not start with "sip:". Preserves the validation the old Refer-only
        /// SipUri type used to perform on its own, now enforced at the point of attachment instead.
        /// </summary>
        private static void ValidateSipUriForRefer(SipUri sipUri)
        {
            if (sipUri == null)
            {
                return;
            }

            if (sipUri.Uri != null && !sipUri.Uri.StartsWith("sip:", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("SipUri must start with 'sip:'.");
            }

            var illegalAttributes = new List<string>();
            if (sipUri.Uui != null) illegalAttributes.Add(nameof(SipUri.Uui));
            if (sipUri.TransferAnswerUrl != null) illegalAttributes.Add(nameof(SipUri.TransferAnswerUrl));
            if (sipUri.TransferAnswerMethod != null) illegalAttributes.Add(nameof(SipUri.TransferAnswerMethod));
            if (sipUri.TransferAnswerFallbackUrl != null) illegalAttributes.Add(nameof(SipUri.TransferAnswerFallbackUrl));
            if (sipUri.TransferAnswerFallbackMethod != null) illegalAttributes.Add(nameof(SipUri.TransferAnswerFallbackMethod));
            if (sipUri.TransferDisconnectUrl != null) illegalAttributes.Add(nameof(SipUri.TransferDisconnectUrl));
            if (sipUri.TransferDisconnectMethod != null) illegalAttributes.Add(nameof(SipUri.TransferDisconnectMethod));
            if (sipUri.Username != null) illegalAttributes.Add(nameof(SipUri.Username));
            if (sipUri.Password != null) illegalAttributes.Add(nameof(SipUri.Password));
            if (sipUri.FallbackUsername != null) illegalAttributes.Add(nameof(SipUri.FallbackUsername));
            if (sipUri.FallbackPassword != null) illegalAttributes.Add(nameof(SipUri.FallbackPassword));
            if (sipUri.Tag != null) illegalAttributes.Add(nameof(SipUri.Tag));

            if (illegalAttributes.Count > 0)
            {
                throw new ArgumentException(
                    "SipUri attached to <Refer> may only set Uri. The following Transfer-only " +
                    $"attribute(s) are not valid in a REFER context: {string.Join(", ", illegalAttributes)}."
                );
            }
        }
    }
}
