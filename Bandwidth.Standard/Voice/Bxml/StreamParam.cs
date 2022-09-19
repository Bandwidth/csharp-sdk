using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The StreamParam verb defines optional user specified parameters that will be sent to the destination URL when the stream is first started.
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/startStream" /></para>
  /// </summary>
  public class StreamParam : IXmlSerializable, IVerb
  {
    /// <summary>
    /// The name of this parameter, up to 256 characters
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The value of this parameter, up to 2048 characters
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
      writer.WriteAttributeString("name", Name);
      writer.WriteAttributeString("value", Value);
    }
  }
}
