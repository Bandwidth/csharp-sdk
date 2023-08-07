using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// BXML tag to represent a SIP URI for the transfer verb.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/transfer.html"/></para>
    /// </summary>
    public class SipUri : IVerb
    {
        /// <summary>
        /// A SIP URI to transfer the call to (e.g. sip:user@server.com).
        /// </summary>
        [XmlText]
        public string Uri { get; set; }

        /// <summary>
        /// (optional) The value of the User-To-User header to send within the initial INVITE.
        /// </summary>
        [XmlAttribute("uui")]
        public string Uui { get; set; }

        /// <summary>
        /// (optional) URL, if any, to send the Transfer Answer event to and request BXML to be executed for the called party before the call is bridged.
        /// </summary>
        [XmlAttribute("transferAnswerUrl")]
        public string TransferAnswerUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use for the request to transferAnswerUrl.
        /// </summary>
        [XmlAttribute("transferAnswerMethod")]
        public string TransferAnswerMethod { get; set; }

        /// <summary>
        /// A fallback url which, if provided, will be used to retry the Transfer Answer callback delivery in case transferAnswerUrl fails to respond.
        /// </summary>
        [XmlAttribute("transferAnswerFallbackUrl")]
        public string TransferAnswerFallbackUrl { get; set; }

        /// <summary>
        /// The HTTP method to use to deliver the Transfer Answer callback to transferAnswerFallbackUrl.
        /// </summary>
        [XmlAttribute("transferAnswerFallbackMethod")]
        public string TransferAnswerFallbackMethod { get; set; }

        /// <summary>
        /// URL, if any, to send the Transfer Disconnect event to.
        /// </summary>
        [XmlAttribute("transferDisconnectUrl")]
        public string TransferDisconnectUrl { get; set; }

        /// <summary>
        /// The HTTP method to use for the request to transferDisconnectUrl.
        /// </summary>
        [XmlAttribute("transferDisconnectMethod")]
        public string TransferDisconnectMethod { get; set; }

        /// <summary>
        /// The username to send in the HTTP request to transferAnswerUrl and transferDisconnectUrl.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// The password to send in the HTTP request to transferAnswerUrl and transferDisconnectUrl.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// The username to send in the HTTP request to transferAnswerFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// The password to send in the HTTP request to transferAnswerFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// A custom string that will be sent with these and all future callbacks unless overwritten by a future tag attribute or cleared.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }
    }
}
