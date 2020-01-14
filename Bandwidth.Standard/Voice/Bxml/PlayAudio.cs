using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The PlayAudio verb is used to play an audio file in the call.
  /// </summary>
  /// <seealso href="http://ap.bandwidth.com/docs/xml/playaudio/" />
  public class PlayAudio : IXmlSerializable, IVerb
  {
    /// <summary>
    ///   Url of media resourse to play
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Username for basic auth on the audio url
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Password for basic auth on the audio url
    /// </summary>
    public string Password { get; set; }

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
      if (!string.IsNullOrEmpty(Username))
      {
        writer.WriteAttributeString("username", Username);
      }
      if (!string.IsNullOrEmpty(Password))
      {
        writer.WriteAttributeString("password", Password);
      }
      writer.WriteString(Url);
    }
  }
}
