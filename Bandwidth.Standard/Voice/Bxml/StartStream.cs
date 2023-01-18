using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The StartStream verb allows a segment of a call to be sent off to another destination for additional processing.
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/startStream" /></para>
  /// </summary>
  public class StartStream : IXmlSerializable, IVerb, IAudioProducer
  {
    /// <summary>
    /// Initialize the StreamParams list
    /// </summary>
    public StartStream()
    {
      StreamParams = new List<StreamParam>();
    }

    /// <summary>
    ///   A websocket URI to send the stream to
    /// </summary>
    public string Destination { get; set; }

    /// <summary>
    /// A name to refer to this stream by
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The part of the call to send a stream from. `inbound`, `outbound` or `both`.
    /// </summary>
    public string Tracks { get; set; }

    /// <summary>
    /// URL to send the associated Webhook events to during this stream's lifetime
    /// </summary>
    public string StreamEventUrl { get; set; }

    /// <summary>
    /// The HTTP method to use for the request to `streamEventUrl`
    /// </summary>
    public string StreamEventMethod { get; set; }

    /// <summary>
    /// The username to send in the HTTP request to `streamEventUrl`
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The password to send in the HTTP request to `streamEventUrl`
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// List of StreamParam verbs
    /// </summary>
    public List<StreamParam> StreamParams { get; set; }

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
      writer.WriteAttributeString("destination", Destination);
      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteAttributeString("name", Name);
      }
      if (!string.IsNullOrEmpty(Tracks))
      {
        writer.WriteAttributeString("tracks", Tracks);
      }
      if (!string.IsNullOrEmpty(StreamEventUrl))
      {
        writer.WriteAttributeString("streamEventUrl", StreamEventUrl);
      }
      if (!string.IsNullOrEmpty(StreamEventMethod))
      {
        writer.WriteAttributeString("streamEventMethod", StreamEventMethod);
      }
      if (!string.IsNullOrEmpty(Username))
      {
        writer.WriteAttributeString("username", Username);
      }
      if (!string.IsNullOrEmpty(Password))
      {
        writer.WriteAttributeString("password", Password);
      }
      if (StreamParams != null && StreamParams.Count > 0)
      {
          var ns = new XmlSerializerNamespaces();
          ns.Add("", "");

          foreach (var verb in StreamParams)
          {
              Console.WriteLine(verb.Name);
              var serializer = new XmlSerializer(verb.GetType(), "");
              serializer.Serialize(writer, verb, ns);
          }
      }
    }
  }
}
