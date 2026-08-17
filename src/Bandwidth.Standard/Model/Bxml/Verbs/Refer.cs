using Bandwidth.Standard.Model.Bxml;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Model.Bxml.Verbs
{
    /// <summary>
    /// The Refer verb is used to hand off a call to a SIP endpoint.
    /// <para><seealso href="https://dev.bandwidth.com/docs/voice/bxml/refer"/></para>
    /// </summary>
    public class Refer : IVerb
    {

        /// <summary>
        /// Initializes a new instance of the Refer class with defaults.
        /// </summary>
        public Refer()
        {
            ReferCompleteMethod = "POST";
        }

        /// <summary>
        /// URL to receive the refer complete callback.
        /// </summary>
        [XmlAttribute("referCompleteUrl")]
        public string ReferCompleteUrl { get; set; }

        /// <summary>
        /// HTTP method to send the refer complete callback. GET or POST. Default value is POST.
        /// </summary>
        [XmlAttribute("referCompleteMethod")]
        public string ReferCompleteMethod { get; set; }

        /// <summary>
        /// Optional custom string to include in callbacks.
        /// </summary>
        [XmlAttribute("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// A SIP URI specifying the refer destination
        /// </summary>
        [XmlElement("SipUri")]
        public SipUri SipUri { get; set; }
    }
}
