using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The Tag verb is used to set a new tag value without executing a callback.
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/tag.html" /></para>
    /// /// </summary>
    public class Tag : IVerb
    {
        /// <summary>
        ///   The new tag value. Leading and trailing whitespace is trimmed. Leave blank to clear the tag.
        /// </summary>
        [XmlText]
        public string Tag { get; set; }
    }
}
