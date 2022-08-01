using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The StopStream verb is used to stop a stream that was started with a previous `<StartStream>` verb.
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/stopStream" /></para>
  /// </summary>
  public class StopStream : IXmlSerializable, IVerb, IAudioProducer
  {    
    /// <summary>
    /// The name of the stream to stop
    /// </summary>
    public string Name { get; set; }

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
    }
  }
}
