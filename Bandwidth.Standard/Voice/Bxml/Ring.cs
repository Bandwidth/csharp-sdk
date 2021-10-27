using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    ///   The Ring verb is used to play ringing audio on a call.
    ///   <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/ring.html"/></para>
    /// </summary>
    public class Ring : IVerb
    {
        /// <summary>
        ///  (optional) How many seconds to play ringing on the call. Default value is 5. Range: decimal values between 0.1 - 86400.
        /// </summary>
        [XmlAttribute("duration")]
        public double Duration { get; set; }

        /// <summary>
        ///  (optional) A boolean indicating whether or not to answer the call when Ring is executed on an unanswered incoming call. Default value is 'true'.
        /// </summary>
        [XmlAttribute("answerCall")]
        public bool AnswerCall { get; set; }

        /// <summary>
        /// Initialize the double fields to Bandwidth's default value
        /// </summary>
        public Ring()
        {
            Duration = 5;
            AnswerCall = true;
        }
    }
}
