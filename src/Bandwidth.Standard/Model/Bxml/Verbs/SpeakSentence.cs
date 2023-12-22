using Bandwidth.Standard.Model.Bxml;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The SpeakSentence verb is used to convert any text into speak for the caller.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/speakSentence.html" /></para>
    /// </summary>
    public class SpeakSentence : IVerb
    {
        /// <summary>
        ///   Default constructor.
        /// </summary>
        public SpeakSentence()
        {
        }

        /// <summary>
        /// The text to speak. 
        /// </summary>
        [XmlText]
        public string Text { get; set; }

        /// <summary>
        /// The voice of the speaker, limited by gender.
        /// </summary>
        [XmlAttribute("voice")]
        public string Voice { get; set; }

        /// <summary>
        /// The gender of the speaker.
        /// </summary>
        [XmlAttribute("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The accent of the speaker.
        /// </summary>
        [XmlAttribute("locale")]
        public string Locale { get; set; }
    }
}
