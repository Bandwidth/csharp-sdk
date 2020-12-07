using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Redirect verb is used to redirect the current XML execution to another URL.
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/redirect.html" /></para>
  /// </summary>
  public class Redirect : IVerb
  {
    /// <summary>
    ///   Relative or absolute URL to send event and request new BaML
    /// </summary>
    [XmlAttribute("redirectUrl")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// HTTP method for the redirect url callback
    /// </summary>
    [XmlAttribute("redirectMethod")]
    public string RedirectMethod { get; set; }

    /// <summary>
    /// Optional custom string to include in callbacks
    /// </summary>
    [XmlAttribute("tag")]
    public string Tag { get; set; }

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

    [XmlAttribute("fallbackPassword")]
    public string FallbackPassword { get; set; }

    [XmlAttribute("fallbackUsername")]
    public string FallbackUsername { get; set; }

    [XmlAttribute("redirectFallbackUrl")]
    public string RedirectFallbackUrl { get; set; }

    [XmlAttribute("redirectFallbackMethod")]
    public string RedirectFallbackMethod { get; set; }
  }
}
