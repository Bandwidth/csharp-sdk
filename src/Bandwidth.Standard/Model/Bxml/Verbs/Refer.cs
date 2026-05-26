using Bandwidth.Standard.Model.Bxml;
using System;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Refer verb is used to hand off a call to a SIP endpoint.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/refer.html"/></para>
    /// </summary>
    public class Refer : IVerb
    {
        private string referCompleteMethod;

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
        /// SIP URI destination for the REFER.
        /// </summary>
        [XmlElement("SipUri")]
        public SipUri SipUriElement { get; set; }

        /// <summary>
        /// Initializes a new instance of the Refer class.
        /// </summary>
        public Refer()
        {
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
        /// Sets the SIP URI destination from a SipUri object.
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
        /// BXML tag to represent a SIP URI for the refer verb.
        /// </summary>
        public class SipUri : IVerb
        {
            private string _uri;

            /// <summary>
            /// SIP URI to refer the call to (must start with sip:).
            /// </summary>
            [XmlText]
            public string Uri
            {
                get { return _uri; }
                set
                {
                    if (value != null && !value.StartsWith("sip:", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException("SipUri must start with 'sip:'.");
                    }
                    _uri = value;
                }
            }
        }
    }
}