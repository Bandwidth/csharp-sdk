using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The Record verb allows a segment of audio to be recorded during a call. At the end of the recording, a Record Complete event is generated.
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/record.html" /></para>
    /// </summary>
    public class Record : IVerb
    {

        /// <summary>
        ///   (optional) URL to send the Record Complete event to and request new BXML.
        /// </summary>
        [XmlAttribute("recordCompleteUrl")]
        public string RecordCompleteUrl { get; set; }

        /// <summary>
        ///   (optional) The HTTP method to use for the request to recordCompleteUrl.
        /// </summary>
        [XmlAttribute("recordCompleteMethod")]
        public string RecordCompleteMethod { get; set; }

        /// <summary>
        /// (optional) A fallback url which, if provided, will be used to retry the Record Complete callback delivery in case recordCompleteUrl fails to respond.
        /// </summary>
        [XmlAttribute("recordCompleteFallbackUrl")]
        public string RecordCompleteFallbackUrl { get; set; }

        /// <summary>
        /// (optional) The HTTP method to use to deliver the Record Complete callback to recordCompleteFallbackUrl. 
        /// </summary>
        [XmlAttribute("recordCompleteFallbackMethod")]
        public string RecordCompleteFallbackMethod { get; set; }

        /// <summary>
        /// Optional custom string to include in callbacks.
        /// </summary>
        [XmlAttribute("recordingAvailableUrl")]
        public string RecordingAvailableUrl { get; set; }

        /// <summary>
        ///    (optional) The HTTP method to use for the request to recordingAvailableUrl.
        /// </summary>
        [XmlAttribute("recordingAvailableMethod")]
        public string RecordingAvailableMethod { get; set; }

        /// <summary>
        ///   (optional) A boolean value.  If true, the recording will be submitted for transcription upon completion.
        /// </summary>
        [XmlAttribute("transcribe")]
        public bool Transcribe { get; set; }

        /// <summary>
        ///   (optional) A boolean value. Indicates that the recording may not be in English, and the transcription service will need to detect the dominant language the recording is in and transcribe accordingly. Current supported languages are English, French, and Spanish.
        /// </summary>
        [XmlAttribute("detectLanguage")]
        public bool DetectLanguage { get; set; }

        /// <summary>
        ///   (optional) URL to send the transcriptionAvailable event to.
        /// </summary>
        [XmlAttribute("transcriptionAvailableUrl")]
        public string TranscriptionAvailableUrl { get; set; }

        /// <summary>
        ///   (optional) The HTTP method to use for the request to transcriptionAvailableUrl.
        /// </summary>
        [XmlAttribute("transcriptionAvailableMethod")]
        public string TranscriptionAvailableMethod { get; set; }

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
        /// (optional) The username to send in the HTTP request to recordCompleteFallbackUrl. 
        /// </summary>
        [XmlAttribute("fallbackUsername")]
        public string FallbackUsername { get; set; }

        /// <summary>
        /// (optional) The password to send in the HTTP request to recordCompleteFallbackUrl.
        /// </summary>
        [XmlAttribute("fallbackPassword")]
        public string FallbackPassword { get; set; }

        /// <summary>
        /// (optional) A custom string that will be sent with this and all future callbacks unless overwritten by a future tag attribute or cleared.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }

        /// <summary>
        ///   (optional) When pressed, this digit will terminate the recording.
        /// </summary>
        [XmlAttribute("terminatingDigits")]
        public string TerminatingDigits { get; set; }

        /// <summary>
        ///   (optional) Maximum length of recording (in seconds). Max 10800 (3 hours).
        /// </summary>
        [XmlIgnore]
        public Nullable<int> MaxDuration { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("maxDuration")]
        public string MaxDurationAsText
        {
            get { return (MaxDuration.HasValue) ? MaxDuration.ToString() : null; }
            set { }
        }

        /// <summary>
        ///   (optional) Length of silence after which to end the recording (in seconds). Max is equivalent to the maximum maxDuration value.
        /// </summary>
        [XmlIgnore]
        public Nullable<int> SilenceTimeout { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("silenceTimeout")]
        public string SilenceTimeoutAsText
        {
            get { return (SilenceTimeout.HasValue) ? SilenceTimeout.ToString() : null; }
            set { }
        }

        /// <summary>
        ///   (optional) The format that the recording will be saved in - mp3 or wav.
        /// </summary>
        [XmlAttribute("fileFormat")]
        public string FileFormat { get; set; }
    }
}
