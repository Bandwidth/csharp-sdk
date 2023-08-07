using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
  /// <summary>
  ///   The StopStream verb is used to stop a stream that was started with a previous `<StartStream>` verb.
  ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/stopStream.html" /></para>
  /// </summary>
  public class StopStream : IVerb
  {
    /// <summary>
    /// The name of the stream to stop.
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; set; }
  }
}
