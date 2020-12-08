namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    ///   The StopRecording verb is used to stop a recording that was previously started by a <![CDATA[<StartRecording>]]> verb.
    ///   If there is not an ongoing recording at the time of this verb's execution, it has no effect. If a previous recording was paused, will end it.
    ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/StopRecording.html" /></para>
    /// </summary>
    public class StopRecording : IVerb
    {
    }
}
