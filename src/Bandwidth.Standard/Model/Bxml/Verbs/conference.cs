using System.Collections.Generic;
using System;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
  /// <summary>
  ///   The Conference verb is used to play an audio file in the call.
  ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/conference/" /></para>
  /// </summary>
  public class Conference : Verb
  {
    /// <summary>
    ///   Name of the conference
    /// </summary>
    public string Name { get; set; }

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

    /// <summary>
    ///	(optional) A fallback url which, if provided, will be used to retry the conference webhook deliveries in case 
    /// conferenceEventUrl fails to respond.
    /// </summary>
    public string ConferenceEventFallbackUrl {get; set;}

    /// <summary>
    /// (optional) The HTTP method to use to deliver the conference webhooks to 
    /// onferenceEventFallbackUrl. GET or POST. Default value is POST.
    ///</summary>
    public string ConferenceEventFallbackMethod {get; set;}

    /// <summary>
    /// Username for basic auth on the Conference url
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Password for basic auth on the Conference url
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// (optional) The username to send in the HTTP request to conferenceEventFallbackUrl.
    /// </summary>
    public string FallbackUsername {get; set;}

    /// <summary>
    /// (optional) The password to send in the HTTP request to conferenceEventFallbackUrl.
    /// </summary>
    public string FallbackPassword {get; set;}
    
    /// <summary>
    /// Tag for basic auth on the Conference url
    /// </summary>
    public string Tag { get; set; }

    /// <summary>
    /// (optional) This is the timeout (in seconds) to use when delivering webhooks for the conference. If not set,
    /// it will inherit the webhook timeout from the call that creates the conference. Can be any numeric value 
    /// (including decimals) between 1 and 25.
    public string CallbackTimeout { get; set;}

    public Conference(){

      Dictionary<string, string> attributes = new Dictionary<string, string> ();
      
      if(this.Mute){
        attributes.Add("mute","true");
      }
      if(this.Hold)
      {
        attributes.Add("hold","true");
      }
      if(!string.IsNullOrEmpty(this.CallIdsToCoach))
      {
        attributes.Add("callIdsToCoach",this.CallIdsToCoach);
      }
      if(!string.IsNullOrEmpty(this.ConferenceEventUrl))
      {
        attributes.Add("conferenceEventUrl",this.ConferenceEventUrl);
      }
      if(!string.IsNullOrEmpty(this.ConferenceEventMethod))
      {
        attributes.Add("conferenceEventMethod",this.ConferenceEventMethod);
      }
      if(!string.IsNullOrEmpty(this.ConferenceEventFallbackUrl))
      {
        attributes.Add("conferenceEventFallbackUrl",this.ConferenceEventFallbackUrl);
      }
      if(!string.IsNullOrEmpty(this.ConferenceEventFallbackMethod))
      {
        attributes.Add("conferenceEventFallbackMethod",this.ConferenceEventFallbackMethod);
      }
      if(!string.IsNullOrEmpty(this.Username))
      {
        attributes.Add("username",this.Username);
      }
      if(!string.IsNullOrEmpty(this.Password))
      {
        attributes.Add("password",this.Password);
      }
      if(!string.IsNullOrEmpty(this.FallbackUsername))
      {
        attributes.Add("fallbackUsername",this.FallbackUsername);
      }
      if(!string.IsNullOrEmpty(this.FallbackPassword))
      {
        attributes.Add("fallbackPassword",this.FallbackPassword);
      }
      if(!string.IsNullOrEmpty(this.Tag))
      {
        attributes.Add("tag",this.Tag);
      }
      if(!string.IsNullOrEmpty(this.CallbackTimeout))
      {
        attributes.Add("callbackTimeout",this.CallbackTimeout);
      }
    }
  }
}
