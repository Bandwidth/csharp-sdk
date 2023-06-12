using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    public class StopTranscription : IVerb
    {
        public StopTranscription()
        {
        }

        [XmlAttribute("name")]
        public string Name { get; set; }

    }
}
