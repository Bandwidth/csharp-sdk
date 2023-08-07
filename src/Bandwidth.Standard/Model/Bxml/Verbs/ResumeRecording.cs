namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The ResumeRecording verb is used to resume a recording that was previously paused by a <![CDATA[<PauseRecording>]]> verb.
    /// Audio that occurs between a <![CDATA[<PauseRecording>]]> verb and a <![CDATA[<ResumeRecording>]]> verb will not be present in the recording.
    /// The paused period will not be included in the duration of the recording and therefore will not contribute to the recording portion of the bill.
    /// If there is not an ongoing recording at the time of this verb's execution, it has no effect.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/resumeRecording.html"/></para>
    /// </summary>
    public class ResumeRecording : IVerb
    {
    }
}
