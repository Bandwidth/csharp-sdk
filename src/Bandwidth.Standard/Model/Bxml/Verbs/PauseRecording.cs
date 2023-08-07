namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The PauseRecording verb is used to pause a recording that was previously started by a <![CDATA[<StartRecording>]]> verb.
    ///   Audio that occurs between a <![CDATA[<PauseRecording>]]> verb and a <![CDATA[<ResumeRecording>]]> verb will not be present in the recording.
    ///   The paused period will not be included in the duration of the recording and therefore will not contribute to the recording portion of the bill.
    ///   If there is not an ongoing recording at the time of this verb's execution, it has no effect.
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/pauseRecording.html" /></para>
    /// </summary>
    public class PauseRecording : IVerb
    {
    }
}
