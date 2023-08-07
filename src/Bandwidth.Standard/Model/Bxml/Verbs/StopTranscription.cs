using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The StopTranscription verb is used to stop a real-time transcription that was started with a previous <StartTranscription> verb.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/stopTranscription.html" /></para>
    /// </summary>
    public class StopTranscription : IVerb
    {
        public StopTranscription()
        {
        }

        /// <summary>
        /// (optional) The name of the real-time transcription to stop.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

    }
}
