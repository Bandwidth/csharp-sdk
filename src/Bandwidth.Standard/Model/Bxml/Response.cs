using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml
{
    /// <summary>
    ///   Bxml response class for Bandwidth XML
    /// </summary>
    public class Response : Root
    {
        public Response() : base()
        {
            _serializer = new XmlSerializer(typeof(Response), "");
        }

        public Response(params IVerb[] verbs) : base(verbs)
        {
            _serializer = new XmlSerializer(typeof(Response), "");
        }
    }
}
