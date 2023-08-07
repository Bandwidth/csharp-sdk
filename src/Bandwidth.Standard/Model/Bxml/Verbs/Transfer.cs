using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Transfer verb is used to transfer the call to another number.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/transfer.html"/></para>
    /// </summary>
    public class Transfer : IVerb
    {
        /// <summary>
        /// Initialize the integer fields to Bandwidth's default value.
        /// </summary>
        public Transfer()
        {
            CallTimeout = 30;
        }

        /// <summary>
        ///  The phone number making the transfer call.
        /// </summary>
        [XmlAttribute("transferCallerId")]
        public string TransferCallerId { get; set; }

        /// <summary>
        /// (optional) The caller display name to use when the call is transferred.
        /// </summary>
        [XmlAttribute("transferCallerDisplayName")]
        public string TransferCallerDisplayName { get; set; }

        /// <summary>
        /// Timeout for the transfer in seconds.
        /// </summary>
        [XmlIgnore]
        public double? CallTimeout { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("callTimeout")]
        public string callTimeoutAsText
        {
            get { return (ToneInterval.HasValue) ? ToneInterval.ToString() : null; }
            set { }
        }

        /// <summary>
        /// Url to receive the transfer complete callback.
        /// </summary>
        [XmlAttribute("transferCompleteUrl")]
        public string TransferCompleteUrl { get; set; }

        /// <summary>
        /// HTTP method to send the transfer complete callback.
        /// </summary>
        [XmlAttribute("transferCompleteMethod")]
        public string TransferCompleteMethod { get; set; }

        /// <summary>
        /// (optional) A fallback url which, if provided, will be used to retry the Transfer Complete callback delivery in case transferCompleteUrl fails to respond.
        /// </summary>
        [XmlAttribute("transferCompleteFallbackUrl")]
        public string TransferCompleteFallbackUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use to deliver the Transfer Complete callback to transferCompleteFallbackUrl. 
        /// </summary>
        [XmlAttribute("transferCompleteFallbackMethod")]
        public string TransferCompleteFallbackMethod { get; set; }

        /// <summary>
        /// Username for basic auth for the callback.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// Password for basic auth for the callback.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// (optional) The username to send in the HTTP request to transferCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to transferCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// Optional custom string to include in callbacks.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Diversion treatment for the transfer.
        /// </summary>
        [XmlAttribute("diversionTreatment")]
        public string DiversionTreatment { get; set; }

        /// <summary>
        /// Diversion reason for the transfer.
        /// </summary>
        [XmlAttribute("diversionReason")]
        public string DiversionReason { get; set; }

        /// <summary>
        ///  Phone numbers to attempt to transfer the call to.
        /// </summary>
        [XmlElement("PhoneNumber")]
        public PhoneNumber[] PhoneNumbers { get; set; }

        /// <summary>
        /// SIP URIs to transfer the call to (e.g. sip:user@server.com).
        /// </summary>
        [XmlElement("SipUri")]
        public SipUri[] SipUris { get; set; }
    }
}
