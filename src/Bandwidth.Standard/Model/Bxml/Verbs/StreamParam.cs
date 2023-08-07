using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
  /// <summary>
  ///   The StreamParam verb defines optional user specified parameters that will be sent to the destination URL when the stream is first started.
  ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/startStream.html" /></para>
  /// </summary>
  public class StreamParam : IVerb
  {
    /// <summary>
    /// The name of this parameter, up to 256 characters
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; set; }

    /// <summary>
    /// The value of this parameter, up to 2048 characters
    /// </summary>
    [XmlAttribute("value")]
    public string Value { get; set; }
  }
}
