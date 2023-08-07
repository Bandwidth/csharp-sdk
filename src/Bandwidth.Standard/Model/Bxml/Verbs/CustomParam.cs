using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// BXML tag to represent custom params for the startTranscription verb.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/startTranscription.html"/></para>
    /// /// </summary>
    public class CustomParam : IVerb
    {
        public CustomParam()
        {
        }

        /// <summary>
        /// (required) The name of this parameter.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// (required) The value of this parameter.
        /// </summary>
        [XmlAttribute("value")]
        public string Value { get; set; }

    }
}
