using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Transfer verb is used to transfer the call to another number.
  /// </summary>
  /// <seealso href="http://ap.bandwidth.com/docs/xml/transfer/" />
  public class Transfer : IVerb
  {
    /// <summary>
    /// Initialize the integer fields to Bandwidth's default value
    /// </summary>
    public Transfer() {
        CallTimeout = 30;
    }

    /// <summary>
    ///  The phone number making the transfer call 
    /// </summary>
    [XmlAttribute("transferCallerId")]
    public string TransferCallerId { get; set; }

    /// <summary>
    /// Timeout for the transfer in seconds
    /// </summary>
    [XmlAttribute("callTimeout")]
    public double CallTimeout { get; set; }

    /// <summary>
    /// Optional custom string to include in callbacks
    /// </summary>
    [XmlAttribute("tag")]
    public string Tag { get; set; }

    /// <summary>
    /// Url to receive the transfer complete callback
    /// </summary>
    [XmlAttribute("transferCompleteUrl")]
    public string TransferCompleteUrl { get; set; }

    /// <summary>
    /// HTTP method to send the transfer complete callback
    /// </summary>
    [XmlAttribute("transferCompleteMethod")]
    public string TransferCompleteMethod { get; set; }

    /// <summary>
    /// Username for basic auth for the callback
    /// </summary>
    [XmlAttribute("username")]
    public string Username { get; set; }

    /// <summary>
    /// Password for basic auth for the callback
    /// </summary>
    [XmlAttribute("password")]
    public string Password { get; set; }

    /// <summary>
    /// Diversion treatment for the transfer
    /// </summary>
    [XmlAttribute("diversionTreatment")]
    public string DiversionTreatment { get; set; }

    /// <summary>
    /// Diversion reason for the transfer
    /// </summary>
    [XmlAttribute("diversionReason")]
    public string DiversionReason { get; set; }

    /// <summary>
    /// Phone numbers to attempt to transfer the call to
    /// </summary>
    [XmlElement("PhoneNumber")]
    public PhoneNumber[] PhoneNumbers { get; set; }
  }
}
