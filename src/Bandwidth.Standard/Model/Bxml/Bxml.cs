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
        private static readonly XmlSerializer s_serializer = new XmlSerializer(typeof(BXML), "");

        internal override XmlSerializer Serializer => s_serializer;

        /// <summary>
        /// initializes a new instance of the "Bxml" class.
        /// </summary>
        public BXML() { }

        /// <summary>
        /// initializes a new instance of the "Bxml" class with nested verbs.
        /// </summary>
        public BXML(params IVerb[] verbs) : base(verbs) { }
    }
}
