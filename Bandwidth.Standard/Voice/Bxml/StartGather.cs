
using System;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The StartGather verb is used to Start a Gather on the current call.
  /// </summary>
  /// <seealso href="https://dev.bandwidth.com/voice/bxml/verbs/startGather.html" />
  public class StartGather : IVerb
  {

    /// <summary>
    ///   URL to send the DTMF event to. May be a relative URL.
    /// </summary>
    [XmlAttribute("dtmfUrl")]
    public string DtmfUrl { get; set; }

    /// <summary>
    ///   (optional) The HTTP method to use for the request to dtmfUrl. GET or POST. Default value is POST.
    /// </summary>
    [XmlAttribute("dtmfMethod")]
    public string DtmfMethod { get; set; }


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
    /// (optional) A custom string that will be sent with this and all future callbacks unless overwritten by a future tag attribute or cleared.
    ///   May be cleared by setting tag = ""
    ///   Max length 256 characters.
    /// </summary>
    [XmlAttribute("tag")]
    public string Tag { get; set; }

  }
}
