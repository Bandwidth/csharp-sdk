using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;


namespace Bandwidth.Standard.Model.Bxml
{
    /// <summary>
    ///   Bxml class for Bandwidth XML
    /// </summary>
    [XmlRoot(ElementName = "Bxml")]
    public class BXML : Root
    {
        /// <summary>
        /// initializes a new instance of the "Bxml" class.
        /// </summary>
        public BXML() : base()
        {
            _serializer = new XmlSerializer(typeof(BXML), "");
        }

        /// <summary>
        /// initializes a new instance of the "Bxml" class with nested verbs.
        /// </summary>
        public BXML(params IVerb[] verbs) : base(verbs)
        {
            _serializer = new XmlSerializer(typeof(BXML), "");
        }
    }
}
