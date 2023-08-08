using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Gather verb is used to collect digits for some period of time.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/gather.html" /></para>
    /// </summary>
    public class Gather : IVerb
    {
        /// <summary>
        /// Initialize the integer fields to Bandwidth's default value.
        /// </summary>
        public Gather()
        {
            MaxDigits = 50;
            InterDigitTimeout = 5;
            FirstDigitTimeout = 5;
            RepeatCount = 1;
        }

        /// <summary>
        ///   Relative or absolute URL to send event to and request.
        /// </summary>
        [XmlAttribute("gatherUrl")]
        public string GatherUrl { get; set; }

        /// <summary>
        /// HTTP method used to send the gather callback.
        /// </summary>
        [XmlAttribute("gatherMethod")]
        public string GatherMethod { get; set; }

        /// <summary>
        /// (optional) A fallback url which, if provided, will be used to retry the Gather event callback delivery in case gatherUrl fails to respond.
        /// </summary>
        [XmlAttribute("gatherFallbackUrl")]
        public string GatherFallbackUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use to deliver the Gather event callback to gatherFallbackUrl. 
        /// </summary>
        [XmlAttribute("gatherFallbackMethod")]
        public string GatherFallbackMethod { get; set; }

        /// <summary>
        /// Username for http authentication.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// Password for http authentication.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// (optional) The username to send in the HTTP request to gatherFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to gatherFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// Optional string to be included in callbacks.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// String of digits to terminate the gather.
        /// </summary>
        [XmlAttribute("terminatingDigits")]
        public string TerminatingDigits { get; set; }

        /// <summary>
        ///   Quantity of digits to collect.
        /// </summary>
        [XmlIgnore]
        public Nullable<int> MaxDigits { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("maxDigits")]
        public string MaxDigitsAsText
        {
            get { return (MaxDigits.HasValue) ? MaxDigits.ToString() : null; }
            set { }
        }

        /// <summary>
        ///   Integer time indicating the timeout between digits.
        /// </summary>
        [XmlIgnore]
        public double? InterDigitTimeout { get; set; }

        /// <summary>
        ///   The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("interDigitTimeout")]
        public string InterDigitTimeoutAsText
        {
            get { return (InterDigitTimeout.HasValue) ? InterDigitTimeout.ToString() : null; }
            set { }
        }

        /// <summary>
        /// Timeout in seconds for first digit press.
        /// </summary>
        [XmlIgnore]
        public double? FirstDigitTimeout { get; set; }

        /// <summary>
        /// The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("firstDigitTimeout")]
        public string FirstDigitTimeoutAsText
        {
            get { return (FirstDigitTimeout.HasValue) ? FirstDigitTimeout.ToString() : null; }
            set { }
        }

        /// <summary>
        ///  Integer between 1 and 30 that specifies how many times to play the audio. This parameter will be honored both inside and outside of a Gather verb.
        ///  </summary>
        [XmlIgnore]
        public Nullable<int> RepeatCount { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("repeatCount")]
        public string RepeatCountAsText
        {
            get { return (RepeatCount.HasValue) ? RepeatCount.ToString() : null; }
            set { }
        }

        /// <summary>
        ///  Using the SpeakSentence inside the Gather verb will speak the text to the callee.
        /// </summary>
        [XmlElement("SpeakSentence")]
        public SpeakSentence SpeakSentence { get; set; }

        /// <summary>
        /// Using the PlayAudio inside the Gather verb will play the media to the callee.
        /// </summary>
        [XmlElement("PlayAudio")]
        public PlayAudio PlayAudio { get; set; }
    }
}
