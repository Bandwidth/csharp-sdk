using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Endpoint verb is used within Connect to specify the endpoint to connect to.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/connect.html" /></para>
    /// </summary>
    public class Endpoint : IVerb
    {
        /// <summary>
        /// The ID of the endpoint to connect to.
        /// </summary>
        [XmlText]
        public string EndpointId { get; set; }
    }
}
