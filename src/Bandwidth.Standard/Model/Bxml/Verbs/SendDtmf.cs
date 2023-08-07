using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   Send digits on a live call
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/sendDtmf.html" /></para>
    /// </summary>
    public class SendDtmf : IVerb
    {

        /// <summary>
        ///   String containing the DTMF characters to be sent in a call (maximum of 92 characters).
        /// </summary>
        [XmlText]
        public string Digits { get; set; }
        
        /// <summary>
        ///  (optional) The length (in milliseconds) of each DTMF tone.
        /// </summary>
        [XmlIgnore]
        public double? ToneDuration { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("toneDuration")]
        public string ToneDurationAsText
        {
            get { return (ToneDuration.HasValue) ? ToneDuration.ToString() : null; }
            set { }
        }

        /// <summary>
        ///   (optional) The duration of silence (in milliseconds) following each DTMF tone.
        /// </summary>
        [XmlIgnore]
        public double? ToneInterval { get; set; }

        /// <summary>
        ///  The setter does nothing! This is just a surrogate field for nullable xml attribute serialization.
        /// </summary>
        [XmlAttribute("toneInterval")]
        public string ToneIntervalAsText
        {
            get { return (ToneInterval.HasValue) ? ToneInterval.ToString() : null; }
            set { }
        }
    }
}
