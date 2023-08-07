using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The StartGather verb is used to Start a Gather on the current call.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/startGather.html"/></para>
    /// </summary>
    public class StartGather : IVerb
    {
        /// <summary>
        ///   URL to send the DTMF event to. May be a relative URL.
        /// </summary>
        [XmlAttribute("dtmfUrl")]
        public string DtmfUrl { get; set; }

        /// <summary>
        ///   (optional) The HTTP method to use for the request to dtmfUrl. GET or POST. Default value is POST.
        /// </summary>
        [XmlAttribute("dtmfMethod")]
        public string DtmfMethod { get; set; }


        /// <summary>
        /// (optional) The username to send in the HTTP request to dtmfUrl.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to dtmfUrl.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// (optional) A custom string that will be sent with this and all future callbacks unless overwritten by a future tag attribute or cleared.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }
    }
}
