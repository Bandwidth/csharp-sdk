using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// Pause the execution of an ongoing BXML document
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/pause.html" /></para>
    /// </summary>
    public class Pause : IVerb
    {
        /// <summary>
        ///  How many seconds Bandwidth will wait silently before continuing on.
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
        /// Initialize the double fields to Bandwidth's default value.
        /// </summary>
        public Pause()
        {
            Duration = 1;
        }
    }
}
