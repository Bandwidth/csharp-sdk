using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Forward verb is used to transfer the call to another number.
  /// </summary>
  public class Forward : IVerb
  {
    /// <summary>
    /// Initialize the integer fields to Bandwidth's default value
    /// </summary>
    public Forward() {
        CallTimeout = 30;
    }

    /// <summary>
    /// The phone number destination of the call
    /// </summary>
    [XmlAttribute("to")]
    public string To { get; set; }

    /// <summary>
    /// The phone number that will make the forward call
    /// </summary>
    [XmlAttribute("from")]
    public string From { get; set; }

    /// <summary>
    /// The number of seconds to wait before timing out the call
    /// </summary>
    [XmlAttribute("callTimeout")]
    public Nullable<int> CallTimeout { get; set; }

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
  }
}
