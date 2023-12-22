using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///     The Conference verb is used to play an audio file in the call.
    ///     <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/conference.html" /></para>
    /// </summary>
    public class Conference : IVerb
    {
        /// <summary>
        ///     Name of the conference.
        /// </summary>
        [XmlText]
        public string Name { get; set; }

        /// <summary>
        ///     (optional) A boolean value to indicate whether the member should be on mute in the conference. When muted, a member can hear others speak, but others cannot hear them speak.
        /// </summary>
        [XmlAttribute("mute")]
        public bool Mute { get; set; }

        /// <summary>
        ///     (optional) A boolean value to indicate whether the member should be on hold in the conference. When on hold, a member cannot hear others, and they cannot be heard.
        /// </summary>
        [XmlAttribute("hold")]
        public bool Hold { get; set; }

        /// <summary>
        ///     (optional) A comma-separated list of call ids to coach.
        /// </summary>
        [XmlAttribute("callIdsToCoach")]
        public string CallIdsToCoach { get; set; }

        /// <summary>
        /// (optional) URL to send Conference events to. The URL, method, username, and password are set by the BXML document that creates the conference, and all events related to that conference will be delivered to that same endpoint. If more calls join afterwards and also have this property (or any other callback related properties like username and password), they will be ignored and the original callback information will be used.
        /// </summary>
        [XmlAttribute("conferenceEventUrl")]
        public string ConferenceEventUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use for the request to conferenceEventUrl.
        /// </summary>
        [XmlAttribute("conferenceEventMethod")]
        public string ConferenceEventMethod { get; set; }

        /// <summary>
        /// (optional) A fallback url which, if provided, will be used to retry the conference webhook deliveries in case conferenceEventUrl fails to respond.
        /// </summary>
        [XmlAttribute("conferenceEventFallbackUrl")]
        public string ConferenceEventFallbackUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use to deliver the conference webhooks to conferenceEventFallbackUrl.
        /// </summary>
        [XmlAttribute("conferenceEventFallbackMethod")]
        public string ConferenceEventFallbackMethod { get; set; }

        /// <summary>
        /// (optional) Username for basic auth on the Conference url.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// (optional) Password for basic auth on the Conference url.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// (optional) The username to send in the HTTP request to conferenceEventFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to conferenceEventFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// Tag for basic auth on the Conference url.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }


        /// <summary>
        /// The number of seconds to wait before timing out the call.
        /// </summary>
        [XmlIgnore]
        public double? CallbackTimeout { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("callbackTimeout")]
        public string CallbackTimeoutAsText
        {
            get { return (CallbackTimeout.HasValue) ? CallbackTimeout.ToString() : null; }
            set { }
        }
    }
}
