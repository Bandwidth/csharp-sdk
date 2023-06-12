using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    public class CustomParam : IVerb
    {
        public CustomParam()
        {
        }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }

    }
}
