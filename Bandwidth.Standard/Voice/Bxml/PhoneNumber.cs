using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   BXML tag to represent phone numbers for the transfer verb 
  /// </summary>
  public class PhoneNumber : IXmlSerializable, IVerb
  {

    /// <summary>
    ///   The actual phone number
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    ///   The url to receive the answer callback
    /// </summary>
    public string TransferAnswerUrl { get; set; }

    /// <summary>
    ///   The http method of the answer callback
    /// </summary>
    public string TransferAnswerMethod { get; set; }

    /// <summary>
    ///   The url to receive the disconnect callback
    /// </summary>
    public string TransferDisconnectUrl  { get; set; }

    /// <summary>
    ///   The http method of the disconnect callback
    /// </summary>
    public string TransferDisconnectMethod  { get; set; } 

    /// <summary>
    /// Username for basic auth on the audio url
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Password for basic auth on the audio url
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Optional custom string to include in callbacks
    /// </summary>
    public string Tag { get; set; }

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

      if (!string.IsNullOrEmpty(Tag))
      {
        writer.WriteAttributeString("tag", Tag);
      }
      if (!string.IsNullOrEmpty(Username))
      {
        writer.WriteAttributeString("username", Username);
      }
      if (!string.IsNullOrEmpty(Password))
      {
        writer.WriteAttributeString("password", Password);
      }
      if (!string.IsNullOrEmpty(TransferAnswerUrl))
      {
        writer.WriteAttributeString("transferAnswerUrl", TransferAnswerUrl);
      }
      if (!string.IsNullOrEmpty(TransferAnswerMethod))
      {
        writer.WriteAttributeString("transferAnswerMethod", TransferAnswerMethod);
      }
      if (!string.IsNullOrEmpty(TransferDisconnectUrl ))
      {
        writer.WriteAttributeString("transferDisconnectUrl", TransferDisconnectUrl );
      }
      if (!string.IsNullOrEmpty(TransferDisconnectMethod))
      {
        writer.WriteAttributeString("transferDisconnectMethod ", TransferDisconnectMethod );
      }
      writer.WriteString(Number);
    }
  }
}
