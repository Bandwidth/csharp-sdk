using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    /// The StartRecording verb allows a segment of audio to be recorded during a call. At the end of the recording, a Record Complete event is generated.
    /// <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/startRecording.html" /></para>
    /// </summary>
    public class StartRecording : IVerb
  {

    /// <summary>
    ///   (optional) A boolean value.  If true, the recording will be submitted for transcription upon completion.  Defaults to false.
    /// </summary>
    [XmlAttribute("transcribe")]
    public bool Transcribe { get; set; }

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
    ///   (optional) The format that the recording will be saved in - mp3 or wav. Default value is wav.
    /// </summary>
    [XmlAttribute("fileFormat")]
    public string FileFormat { get; set; }

    /// <summary>
    ///   (optional) A boolean value indicating whether or not the recording file should separate each side of the call into its own audio channel. Default value is false. true results in two channels.
    /// </summary>
    [XmlAttribute("multiChannel")]
    public bool MultiChannel { get; set; }

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
  }
}
