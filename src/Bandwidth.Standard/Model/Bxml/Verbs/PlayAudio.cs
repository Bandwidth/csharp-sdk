using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The PlayAudio verb is used to play an audio file in the call.
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/playAudio.html" /></para>
    /// </summary>
    public class PlayAudio : IVerb
    {
        /// <summary>
        /// The URL of the audio file to play. May be a relative URL.
        /// </summary>
        [XmlText]
        public string AudioUri { get; set; }

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
    }
}
