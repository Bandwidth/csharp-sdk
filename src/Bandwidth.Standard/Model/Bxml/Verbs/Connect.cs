using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Connect verb is used to connect calls to endpoints.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/connect.html" /></para>
    /// </summary>
    public class Connect : IVerb
    {
        /// <summary>
        /// (optional) URL to send events to for this Connect verb.
        /// </summary>
        [XmlAttribute("eventCallbackUrl")]
        public string EventCallbackUrl { get; set; }

        /// <summary>
        /// The endpoint destination to connect to.
        /// </summary>
        [XmlElement("Endpoint")]
        public Endpoint Destination { get; set; }
    }
}
