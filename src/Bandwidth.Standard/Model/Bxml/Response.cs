using System.Collections.Generic;
using System;
namespace Bandwidth.Standard.Model.Bxml
{
    /// <summary>
    /// Response class for Bandwidth XML
    /// </summary>
    /// [XmlRoot(ElementName = "Response")]
    public class Response : Root
    {
        
        public Response() : base("Response"){}

        public Response(List<IVerb> verbs) : base("Response", verbs){}
        
    }
}
