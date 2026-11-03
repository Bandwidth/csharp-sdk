using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml
{
    /// <summary>
    ///   Bxml response class for Bandwidth XML
    /// </summary>
    public class Response : Root
    {
        private static readonly XmlSerializer s_serializer = new XmlSerializer(typeof(Response), "");

        internal override XmlSerializer Serializer => s_serializer;

        /// <summary>
        ///     Initializes a new instance of the "Response" class.
        /// </summary> 
        public Response() { }

        /// <summary>
        ///     Initializes a new instance of the "Response" class with nested verbs.
        /// </summary> 
        public Response(params IVerb[] verbs) : base(verbs) { }
    }
}
