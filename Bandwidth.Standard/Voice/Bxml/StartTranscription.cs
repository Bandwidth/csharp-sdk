using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    public class StartTranscription : IVerb
    {
        public StartTranscription()
        {
            Stabilized = true;
        }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("tracks")]
        public string Tracks { get; set; }

        [XmlAttribute("transcriptionEventUrl")]
        public string TranscriptionEventUrl { get; set; }

        [XmlAttribute("transcriptionEventMethod")]
        public string TranscriptionEventMethod { get; set; }

        [XmlAttribute("username")]
        public string Username { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }

        [XmlAttribute("destination")]
        public string Destination { get; set; }

        [XmlAttribute("stabilized")]
        public bool Stabilized { get; set; }

        [XmlElement("CustomParam")]
        public List<CustomParam> CustomParams { get; set; }

    }
}
