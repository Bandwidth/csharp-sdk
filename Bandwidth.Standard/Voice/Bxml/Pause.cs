using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   Pause the execution of an ongoing BXML document
  /// </summary>
  /// <seealso href="http://ap.bandwidth.com/docs/xml/pause/" />
  public class Pause : IVerb
  {

    /// <summary>
    /// Initialize the double fields to Bandwidth's default value
    /// </summary>
    public Pause() {
        Duration = 1;
    }
    /// <summary>
    ///  How many seconds Bandwidth will wait silently before continuing on.
    /// </summary>
    [XmlAttribute("duration")]
    public double Duration { get; set; }
}
}
