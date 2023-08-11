using Bandwidth.Standard.Model.Bxml;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    ///   The StartStream verb allows a segment of a call to be sent off to another destination for additional processing.
    ///   <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/startStream.html" /></para>
    /// </summary>
    public class StartStream : IVerb
    {
        /// <summary>
        /// Initialize the StreamParams list.
        /// </summary>
        public StartStream()
        {
            StreamParams = new List<StreamParam>();
        }

        /// <summary>
        /// A name to refer to this stream by.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// The part of the call to send a stream from.
        /// </summary>
        [XmlAttribute("tracks")]
        public string Tracks { get; set; }

        /// <summary>
        ///   A websocket URI to send the stream to.
        /// </summary>
        [XmlAttribute("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// URL to send the associated Webhook events to during this stream's lifetime.
        /// </summary>
        [XmlAttribute("streamEventUrl")]
        public string StreamEventUrl { get; set; }

        /// <summary>
        /// The HTTP method to use for the request to `streamEventUrl`.
        /// </summary>
        [XmlAttribute("streamEventMethod")]
        public string StreamEventMethod { get; set; }

        /// <summary>
        /// The username to send in the HTTP request to `streamEventUrl`.
        /// </summary>
        [XmlAttribute("username")]
        public string Username { get; set; }

        /// <summary>
        /// The password to send in the HTTP request to `streamEventUrl`.
        /// </summary>
        [XmlAttribute("password")]
        public string Password { get; set; }

        /// <summary>
        /// List of StreamParam verbs.
        /// </summary>
        [XmlElement("StreamParams")]
        public List<StreamParam> StreamParams { get; set; }
    }
}
