using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
    /// <summary>
    /// Pause the execution of an ongoing BXML document
    /// <para><seealso href="https://dev.bandwidth.com/voice/bxml/verbs/pause.html" /></para>
    /// </summary>
    public class Pause : IVerb
    {
        /// <summary>
        ///  How many seconds Bandwidth will wait silently before continuing on.
        /// </summary>
        [XmlAttribute("duration")]
        public double Duration { get; set; }

        /// <summary>
        /// Initialize the double fields to Bandwidth's default value
        /// </summary>
        public Pause()
        {
            Duration = 1;
        }
    }
}
