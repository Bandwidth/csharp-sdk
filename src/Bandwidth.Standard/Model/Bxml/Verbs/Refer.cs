using Bandwidth.Standard.Model.Bxml;
using System;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// The Refer verb is used to hand off a call to a SIP endpoint.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/refer.html"/></para>
    public class Refer : IVerb
    {
        private string referCompleteMethod;

        /// URL to receive the refer complete callback.
        [XmlAttribute("referCompleteUrl")]
        public string ReferCompleteUrl { get; set; }

        /// HTTP method to send the refer complete callback.
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

        /// Optional custom string to include in callbacks.
        [XmlAttribute("tag")]
        public string Tag { get; set; }

        /// SIP URI destination for the REFER.
        [XmlElement("SipUri")]
        public SipUri SipUriElement { get; set; }

        /// Initializes a new instance of the Refer class.
        public Refer()
        {
            ReferCompleteMethod = "POST";
        }

        /// Sets the SIP URI destination from a string.
        public Refer WithSipUri(string sipUri)
        {
            SipUriElement = new SipUri { Uri = sipUri };
            return this;
        }

        /// Sets the SIP URI destination from a SipUri object.
        public Refer WithSipUri(SipUri sipUri)
        {
            SipUriElement = sipUri;
            return this;
        }

        /// Sets referCompleteUrl.
        public Refer WithReferCompleteUrl(string referCompleteUrl)
        {
            ReferCompleteUrl = referCompleteUrl;
            return this;
        }

        /// Sets referCompleteMethod.
        public Refer WithReferCompleteMethod(string referCompleteMethod)
        {
            ReferCompleteMethod = referCompleteMethod;
            return this;
        }

        /// Sets tag.
        public Refer WithTag(string tag)
        {
            Tag = tag;
            return this;
        }

        /// BXML tag to represent a SIP URI for the refer verb.
        public class SipUri : IVerb
        {
            private string _uri;

            /// SIP URI to refer the call to (must start with sip:).
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