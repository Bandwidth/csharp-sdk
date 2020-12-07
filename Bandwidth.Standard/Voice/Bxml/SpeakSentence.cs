using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  /// The SpeakSentence verb is used to convert any text into speak for the caller.
  /// <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/speakSentence.html" /></para>
  /// </summary>
  public class SpeakSentence : IXmlSerializable, IVerb, IAudioProducer
  {
    /// <summary>
    ///   Default constructor
    /// </summary>
    public SpeakSentence()
    {
    }

    /// <summary>
    ///   The gender of the speaker
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    ///   The accent of the speaker
    /// </summary>
    public string Locale { get; set; }

    /// <summary>
    ///   The voice of the speaker, limited by gender
    /// </summary>
    public string Voice { get; set; }


    /// <summary>
    ///   Sentence to speak
    /// </summary>
    public string Sentence { get; set; }

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
      if (!string.IsNullOrEmpty(Gender))
      {
        writer.WriteAttributeString("gender", Gender);
      }
      if (!string.IsNullOrEmpty(Locale))
      {
        writer.WriteAttributeString("locale", Locale);
      }
      if (!string.IsNullOrEmpty(Voice))
      {
        writer.WriteAttributeString("voice", Voice);
      }
      writer.WriteString(Sentence);
    }
  }
}
