using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Bridge verb is used to bridge another party (target call) onto the current call.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/bridge.html" /></para>
    /// </summary>
    public class Bridge : IVerb
    {

        /// <summary>
        ///  String containing the callId of the call to be bridged.
        /// </summary>
        [XmlText]
        public string TargetCall { get; set; }

        /// <summary>
        ///   (optional) URL to send the Bridge Complete event to and request new BXML.
        /// </summary>
        [XmlAttribute("bridgeCompleteUrl")]
        public string BridgeCompleteUrl { get; set; }

        /// <summary>
        ///   (optional) The HTTP method to use for the request to bridgeCompleteUrl.
        /// </summary>
        [XmlAttribute("bridgeCompleteMethod")]
        public string BridgeCompleteMethod { get; set; }

        /// <summary>
        /// (optional) A fallback url which, if provided, will be used to retry the Bridge Complete webhook delivery in case bridgeCompleteUrl fails to respond.
        /// </summary>
        [XmlAttribute("bridgeCompleteFallbackUrl")]
        public string BridgeCompleteFallbackUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use to deliver the Bridge Complete webhook to bridgeCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("bridgeCompleteFallbackMethod")]
        public string BridgeCompleteFallbackMethod { get; set; }

        /// <summary>
        ///  (optional) URL to send the Bridge Target Complete event to and request new BXML.
        ///  If this attribute is specified, then the BXML returned in this callback is executed on the target call.
        ///  If this attribute is not specified then no callback will be sent, and the target call will be hung up.
        /// </summary>
        [XmlAttribute("bridgeTargetCompleteUrl")]
        public string BridgeTargetCompleteUrl { get; set; }

        /// <summary>
        ///   (optional) The HTTP method to use for the request to bridgeTargetCompleteUrl.
        /// </summary>
        [XmlAttribute("bridgeTargetCompleteMethod")]
        public string BridgeTargetCompleteMethod { get; set; }

        /// <summary>
        /// (optional) A fallback url which, if provided, will be used to retry the Bridge Target Complete webhook delivery in case bridgeTargetCompleteUrl fails to respond.
        /// </summary>
        [XmlAttribute("bridgeTargetCompleteFallbackUrl")]
        public string BridgeTargetCompleteFallbackUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use to deliver the Bridge Target Complete webhook to bridgeTargetCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("bridgeTargetCompleteFallbackMethod")]
        public string BridgeTargetCompleteFallbackMethod { get; set; }

        /// <summary>
        /// (optional) Username for basic auth on the bridgeCompleteUrl and bridgeTargetCompleteUrl.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// (optional) Password for basic auth on the bridgeCompleteUrl and bridgeTargetCompleteUrl.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// (optional) The username to send in the HTTP request to bridgeCompleteFallbackUrl and to bridgeTargetCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to bridgeCompleteFallbackUrl and to bridgeTargetCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// (optional) A custom string that will be sent with this and all future callbacks unless overwritten by a future tag attribute or cleared.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }
    }
}
