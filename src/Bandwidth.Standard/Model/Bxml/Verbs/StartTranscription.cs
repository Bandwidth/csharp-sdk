using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The StartTranscription verb allows a segment of a call to be transcribed, and optionally for the live transcription to be sent off to another destination for additional processing. 
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/startTranscription.html" /></para>
    /// </summary>
    public class StartTranscription : IVerb
    {
        public StartTranscription()
        {
            Stabilized = true;
        }

        /// <summary>
        /// (optional) A name to refer to this transcription by.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// (optional) The part of the call to send a transcription from.
        /// </summary>
        [XmlAttribute("tracks")]
        public string Tracks { get; set; }

        /// <summary>
        /// (optional) URL to send the associated Webhook events to during this real-time transcription's lifetime.
        /// </summary>
        [XmlAttribute("transcriptionEventUrl")]
        public string TranscriptionEventUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use for the request to transcriptionEventUrl.
        /// </summary>
        [XmlAttribute("transcriptionEventMethod")]
        public string TranscriptionEventMethod { get; set; }

        /// <summary>
        /// (optional) The username to send in the HTTP request to transcriptionEventUrl.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to transcriptionEventUrl.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// (optional) A websocket URI to send the transcription to.
        /// </summary>
        [XmlAttribute("destination")]
        public string Destination { get; set; }


        /// <summary>
        /// (optional) Whether to send transcription update events to the specified destination only after they have become stable.
        /// </summary>
        [XmlAttribute("stabilized")]
        public bool Stabilized { get; set; }


        /// <summary>
        /// You may specify up to 12 <CustomParam/> elements nested within a <StartTranscription> tag.
        /// </summary>
        [XmlElement("CustomParam")]
        public List<CustomParam> CustomParams { get; set; }

    }
}
