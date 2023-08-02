using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    ///   Bxml class for Bandwidth XML
    /// </summary>
    [XmlRoot(ElementName = "Bxml")]
    public class BXML : Root
    {
        public BXML() : base()
        {
            _serializer = new XmlSerializer(typeof(BXML), "");
        }

        public BXML(params IVerb[] verbs) : base(verbs)
        {
            _serializer = new XmlSerializer(typeof(BXML), "");
        }
    }
}
