using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   Send digits on a live call
  /// </summary>
  /// <seealso href="http://ap.bandwidth.com/docs/xml/dtmf/" />
  public class SendDtmf : IXmlSerializable, IVerb
  {
    /// <summary>
    ///   String containing the DTMF characters to be sent in a call (maximum of 92 characters)
    /// </summary>
    public string Digits { get; set; }

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
      writer.WriteString(Digits);
    }
  }
}
