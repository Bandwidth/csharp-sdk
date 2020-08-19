using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Ring verb is used to play ringing audio on a call.
  /// </summary>
  /// <seealso href="https://dev.bandwidth.com/voice/bxml/verbs/ring.html" />
  public class Ring : IVerb
  {

    /// <summary>
    /// Initialize the double fields to Bandwidth's default value
    /// </summary>
    public Ring() {
        Duration = 5;
    }
    /// <summary>
    ///  (optional) How many seconds to play ringing on the call. Default value is 5. Range: decimal values between 0.1 - 86400.
    /// </summary>
    [XmlAttribute("duration")]
    public double Duration { get; set; }
  }
}
