using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Conference verb is used to play an audio file in the call.
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/conference.html" /></para>
  /// </summary>
  public class Conference : IXmlSerializable, IVerb
  {
    /// <summary>
    ///   Name of the conference
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Username for basic auth on the Conference url
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Password for basic auth on the Conference url
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Tag for basic auth on the Conference url
    /// </summary>
    public string Tag { get; set; }

    /// <summary>
    /// (optional) A boolean value to indicate whether the member should be on mute in the conference. When muted, a member can hear others speak, but others cannot hear them speak. Defaults to false
    /// </summary>
    public bool Mute { get; set; }

    /// <summary>
    /// (optional) A boolean value to indicate whether the member should be on hold in the conference. When on hold, a member cannot hear others, and they cannot be heard. Defaults to false
    /// </summary>
    public bool Hold { get; set; }

    /// <summary>
    /// (optional) A comma-separated list of call ids to coach. When a call joins a conference with this attribute set, it will coach the listed calls. Those calls will be able to hear and be heard by the coach, but other calls in the conference will not hear the coach.
    /// Calls may be added to the conference in any order - if the matching calls are not already in the conference, then once the matching calls are added, the coach will be able to hear and speak to the matching calls. Note that this will not add the matching calls to the conference; each call must individually execute a <Conference> verb to join.
    /// A conference may only have one coach.
    /// </summary>
    public string CallIdsToCoach { get; set; }

    /// <summary>
    /// (optional) URL to send Conference events to. The URL, method, username, and password are set by the BXML document that creates the conference, and all events related to that conference will be delivered to that same endpoint. If more calls join afterwards and also have this property (or any other callback related properties like username and password), they will be ignored and the original callback information will be used.
    /// </summary>
    public string ConferenceEventUrl { get; set; }

    /// <summary>
    /// (optional) The HTTP method to use for the request to conferenceEventUrl. GET or POST. Default value is POST.
    /// </summary>
    public string ConferenceEventMethod { get; set; }

    public string ConferenceEventFallbackUrl {get; set;}

    public string ConferenceEventFallbackMethod {get; set;}

    public string FallbackUsername {get; set;}

    public string FallbackPassword {get; set;}


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
      if (!string.IsNullOrEmpty(Username))
      {
        writer.WriteAttributeString("username", Username);
      }
      if (!string.IsNullOrEmpty(Password))
      {
        writer.WriteAttributeString("password", Password);
      }
      if (!string.IsNullOrEmpty(Tag))
      {
        writer.WriteAttributeString("tag", Tag);
      }

      if (Mute)
      {
        writer.WriteAttributeString("mute", "true");
      }
      if (Hold)
      {
        writer.WriteAttributeString("hold", "true");
      }

      if (!string.IsNullOrEmpty(CallIdsToCoach))
      {
        writer.WriteAttributeString("callIdsToCoach", CallIdsToCoach);
      }

      if (!string.IsNullOrEmpty(ConferenceEventMethod))
      {
        writer.WriteAttributeString("conferenceEventMethod", ConferenceEventMethod);
      }

      if (!string.IsNullOrEmpty(ConferenceEventUrl))
      {
        writer.WriteAttributeString("conferenceEventUrl", ConferenceEventUrl);
      }

      if (!string.IsNullOrEmpty(ConferenceEventFallbackUrl))
      {
        writer.WriteAttributeString("conferenceEventFallbackUrl", ConferenceEventFallbackUrl);
      }

      if (!string.IsNullOrEmpty(ConferenceEventFallbackMethod))
      {
        writer.WriteAttributeString("conferenceEventFallbackMethod", ConferenceEventFallbackMethod);
      }

      if (!string.IsNullOrEmpty(FallbackUsername))
      {
        writer.WriteAttributeString("fallbackUsername", FallbackUsername);
      }

      if (!string.IsNullOrEmpty(FallbackPassword))
      {
        writer.WriteAttributeString("fallbackPassword", FallbackPassword);
      }

      writer.WriteString(Name);
    }
  }
}
