using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   BXML tag to represent phone numbers for the transfer verb 
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/transfer.html"/></para>
    /// </summary>
    public class PhoneNumber : IVerb
    {

        /// <summary>
        ///   The actual phone number.
        /// </summary>
        [XmlText]
        public string Number { get; set; }

        /// <summary>
        ///   The url to receive the answer callback.
        /// </summary>
        [XmlAttribute("transferAnswerUrl")]
        public string TransferAnswerUrl { get; set; }

        /// <summary>
        ///   The http method of the answer callback.
        /// </summary>
        [XmlAttribute("transferAnswerMethod")]
        public string TransferAnswerMethod { get; set; }

        /// <summary>
        ///   (optional) A fallback url which, if provided, will be used to retry the Transfer Answer callback delivery in case transferAnswerUrl fails to respond.
        /// </summary>
        [XmlAttribute("TransferAnswerFallbackUrl")]
        public string TransferAnswerFallbackUrl { get; set; }

        /// <summary>
        ///   	(optional) The HTTP method to use to deliver the Transfer Answer callback to transferAnswerFallbackUrl. 
        /// </summary>
        [XmlAttribute("transferAnswerFallbackMethod")]
        public string TransferAnswerFallbackMethod { get; set; }

        /// <summary>
        ///   The url to receive the disconnect callback.
        /// </summary>
        [XmlAttribute("transferDisconnectUrl")]
        public string TransferDisconnectUrl { get; set; }

        /// <summary>
        ///   The http method of the disconnect callback.
        /// </summary>
        [XmlAttribute("transferDisconnectMethod")]
        public string TransferDisconnectMethod { get; set; }

        /// <summary>
        /// Username for basic auth on the audio url.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// Password for basic auth on the audio url.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        ///   (optional) The username to send in the HTTP request to transferAnswerFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        ///   (optional) The password to send in the HTTP request to transferAnswerFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// Optional custom string to include in callbacks.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }

    }
}
