using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   Send digits on a live call
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/sendDtmf.html" /></para>
  /// </summary>
  public class SendDtmf : IXmlSerializable, IVerb
{
    /// <summary>
    ///  (optional) The length (in milliseconds) of each DTMF tone. Default value is 200. Range: decimal values between 50 - 5000.
    /// </summary>
    [XmlIgnore]
    public Nullable<double> ToneDuration { get; set; }

    /// <summary>
    ///  The setter does nothing! This is just a surrogate feild for nullable xml attribute serialization.
    /// </summary>
    [XmlAttribute("toneDuration")]
    public string ToneDurationAsText {
        get {return (ToneDuration.HasValue) ? ToneDuration.ToString() : null ;}
        set {}
    }

    /// <summary>
    ///   (optional) The duration of silence (in milliseconds) following each DTMF tone. Default value is 400. Range: decimal values between 50 - 5000.
    /// </summary>
    [XmlIgnore]
    public Nullable<double> ToneInterval { get; set; }

    /// <summary>
    ///  The setter does nothing! This is just a surrogate feild for nullable xml attribute serialization.
    /// </summary>
    [XmlAttribute("toneInterval")]
    public string ToneIntervalAsText {
        get {return (ToneInterval.HasValue) ? ToneInterval.ToString() : null ;}
        set {}
    }

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
        if (ToneInterval != null)
        {
            writer.WriteAttributeString("toneInterval", ToneInterval.ToString());
        }
        if (ToneDuration != null)
        {
            writer.WriteAttributeString("toneDuration", ToneDuration.ToString());
        }

        writer.WriteString(Digits);
    }
}
}
