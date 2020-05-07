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
    ///  (optional) The length (in milliseconds) of each DTMF tone. Default value is 200. Range: decimal values between 50 - 5000.
    /// </summary>
    public Nullable<double> ToneDuration { get; set; }

    /// <summary>
    ///   (optional) The duration of silence (in milliseconds) following each DTMF tone. Default value is 400. Range: decimal values between 50 - 5000.
    /// </summary>
    public Nullable<double> ToneInterval { get; set; }

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
