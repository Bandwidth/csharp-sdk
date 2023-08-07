using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The Ring verb is used to play ringing audio on a call.
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/ring.html"/></para>
    /// </summary>
    public class Ring : IVerb
    {
        /// <summary>
        ///  (optional) How many seconds to play ringing on the call.
        /// </summary>
        [XmlIgnore]
        public double? Duration { get; set; }

        /// <summary>
        /// The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("duration")]
        public string DurationAsText
        {
            get { return (Duration.HasValue) ? Duration.ToString() : null; }
            set { }
        }

        /// <summary>
        ///  (optional) A boolean indicating whether or not to answer the call when Ring is executed on an unanswered incoming call.
        /// </summary>
        [XmlAttribute("answerCall")]
        public bool AnswerCall { get; set; }

        /// <summary>
        /// Initialize the double fields to Bandwidth's default value.
        /// </summary>
        public Ring()
        {
            Duration = 5;
            AnswerCall = true;
        }
    }
}
