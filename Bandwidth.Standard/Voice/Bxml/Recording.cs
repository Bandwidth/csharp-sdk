using System;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Record verb allows a segment of audio to be recorded during a call. At the end of the recording, a Record Complete event is generated.
  ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/record.html" /></para>
  /// </summary>
  public class Record : IVerb
  {

    /// <summary>
    ///   (optional) A boolean value. Indicates that the recording may not be in English, and the transcription service will need to detect the dominant language the recording is in and transcribe accordingly. Current supported languages are English, French, and Spanish.
    /// </summary>
    [XmlAttribute("detectLanguage")]
    public bool DetectLanguage { get; set; }

    /// <summary>
    ///   (optional) A boolean value.  If true, the recording will be submitted for transcription upon completion.  Defaults to false.
    /// </summary>
    [XmlAttribute("transcribe")]
    public bool Transcribe { get; set; }

    /// <summary>
    ///   (optional) Length of silence after which to end the recording (in seconds). Max is equivalent to the maximum maxDuration value. Default value is 0, which means no timeout.
    /// </summary>
    [XmlIgnore]
    public Nullable<int> SilenceTimeout { get; set; }

    /// <summary>
    ///  The setter does nothing! This is just a surrogate feild for nullable xml attribute serialization.
    /// </summary>
    [XmlAttribute("silenceTimeout")]
    public string SilenceTimeoutAsText {
        get {return (SilenceTimeout.HasValue) ? SilenceTimeout.ToString() : null ;}
        set {}
    }


    /// <summary>
    ///   (optional) URL to send the transcriptionAvailable event to.
    /// </summary>
    [XmlAttribute("transcriptionAvailableUrl")]
    public string TranscriptionAvailableUrl { get; set; }

    /// <summary>
    ///   (optional) The HTTP method to use for the request to transcriptionAvailableUrl. GET or POST. Default Value is POST.
    /// </summary>
    [XmlAttribute("transcriptionAvailableMethod")]
    public string TranscriptionAvailableMethod { get; set; }

    /// <summary>
    ///   (optional) URL to send the Record Complete event to and request new BXML.
    /// </summary>
    [XmlAttribute("recordCompleteUrl")]
    public string RecordCompleteUrl { get; set; }

    /// <summary>
    ///   (optional) The HTTP method to use for the request to recordCompleteUrl. GET or POST. Default value is POST.
    /// </summary>
    [XmlAttribute("recordCompleteMethod")]
    public string RecordCompleteMethod { get; set; }

    /// <summary>
    /// Optional custom string to include in callbacks
    /// </summary>
    [XmlAttribute("recordingAvailableUrl")]
    public string RecordingAvailableUrl { get; set; }

    /// <summary>
    ///    (optional) The HTTP method to use for the request to recordingAvailableUrl. GET or POST. Default value is POST.
    /// </summary>
    [XmlAttribute("recordingAvailableMethod")]
    public string RecordingAvailableMethod { get; set; }

    /// <summary>
    /// (optional) A custom string that will be sent with this and all future callbacks unless overwritten by a future tag attribute or cleared.
    ///   May be cleared by setting tag = ""
    ///   Max length 256 characters.
    /// </summary>
    [XmlAttribute("tag")]
    public string Tag { get; set; }

    /// <summary>
    ///   (optional) When pressed, this digit will terminate the recording. Default value is “#”.
    /// </summary>
    [XmlAttribute("terminatingDigits")]
    public string TerminatingDigits { get; set; }

    /// <summary>
    ///   (optional) Maximum length of recording (in seconds). Max 10800 (3 hours). Default value is 60.
    /// </summary>
    [XmlIgnore]
    public Nullable<int> MaxDuration { get; set; }

    /// <summary>
    ///  The setter does nothing! This is just a surrogate feild for nullable xml attribute serialization.
    /// </summary>
    [XmlAttribute("maxDuration")]
    public string MaxDurationAsText {
        get {return (MaxDuration.HasValue) ? MaxDuration.ToString() : null ;}
        set {}
    }

    /// <summary>
    ///   (optional) The format that the recording will be saved in - mp3 or wav. Default value is wav.
    /// </summary>
    [XmlAttribute("fileFormat")]
    public string FileFormat { get; set; }

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

    [XmlAttribute("recordCompleteFallbackUrl")]
    public string RecordCompleteFallbackUrl { get; set; }

    [XmlAttribute("recordCompleteFallbackMethod")]
    public string RecordCompleteFallbackMethod { get; set; }
  }
}
