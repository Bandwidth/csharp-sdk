using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The PauseRecording verb is used to pause a recording that was previously started by a <StartRecording> verb.
  ///   Audio that occurs between a <PauseRecording> verb and a <ResumeRecording> verb will not be present in the recording.
  ///   The paused period will not be included in the duration of the recording and therefore will not contribute to the recording portion of the bill.
  ///   If there is not an ongoing recording at the time of this verb's execution, it has no effect.
  /// </summary>
  /// <seealso href="https://dev.bandwidth.com/voice/bxml/verbs/pauseRecording.html" />
  public class PauseRecording : IVerb
  {

   
  }
}
