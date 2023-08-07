using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
  /// <summary>
  ///   The Redirect verb is used to redirect the current XML execution to another URL.
  ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/redirect.html" /></para>
  /// /// </summary>
  public class Redirect : IVerb
  {
    /// <summary>
    ///   Relative or absolute URL to send event and request new BaML.
    /// </summary>
    [XmlAttribute("redirectUrl")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// HTTP method for the redirect url callback.
    /// </summary>
    [XmlAttribute("redirectMethod")]
    public string RedirectMethod { get; set; }

    /// <summary>
    /// (optional) A fallback url which, if provided, will be used to retry the Redirect callback delivery in case redirectUrl fails to respond.
    /// </summary>
    [XmlAttribute("redirectFallbackUrl")]
    public string RedirectFallbackUrl { get; set; }

    /// <summary>
    /// (optional) The HTTP method to use to deliver the Redirect callback to redirectFallbackUrl.
    /// </summary>
    [XmlAttribute("redirectFallbackMethod")]
    public string RedirectFallbackMethod { get; set; }

    /// <summary>
    /// Username for basic auth for the callback.
    /// </summary>
    [XmlAttribute("username")]
    public string Username { get; set; }

    /// <summary>
    /// Password for basic auth for the callback.
    /// </summary>
    [XmlAttribute("password")]
    public string Password { get; set; }

    /// <summary>
    /// (optional) The username to send in the HTTP request to redirectFallbackUrl.
    /// </summary>
    [XmlAttribute("fallbackUsername")]
    public string FallbackUsername { get; set; }

    /// <summary>
    /// (optional) The password to send in the HTTP request to redirectFallbackUrl.
    /// </summary>
    [XmlAttribute("fallbackPassword")]
    public string FallbackPassword { get; set; }

    /// <summary>
    /// Optional custom string to include in callbacks.
    /// </summary>
    [XmlAttribute("tag")]
    public string Tag { get; set; }
  }
}
