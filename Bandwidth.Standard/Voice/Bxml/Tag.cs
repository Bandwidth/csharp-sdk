using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    ///   The Tag verb is used to set a new tag value without executing a callback.
    ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/tag.html" /></para>
    /// </summary>
    public class Tag : IXmlSerializable, IVerb
    {
        /// <summary>
        ///   The new tag value. Leading and trailing whitespace is trimmed. Leave blank to clear the tag.
        /// </summary>
        public string Value { get; set; }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            writer.WriteString(Value);
        }
    }
}
