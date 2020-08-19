using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Gather verb is used to collect digits for some period of time.
  /// </summary>
  /// <seealso href="http://ap.bandwidth.com/docs/xml/gather/" />
  public class Gather : IVerb, IXmlSerializable
  {
    /// <summary>
    /// Initialize the integer fields to Bandwidth's default value
    /// </summary>
    public Gather()
    {
        MaxDigits = 50;
        InterDigitTimeout = 5;
        FirstDigitTimeout = 5;
        RepeatCount = 1;
    }

    /// <summary>
    ///   Relative or absolute URL to send event to and request
    /// </summary>
    [XmlAttribute("gatherUrl")]
    public string GatherUrl { get; set; }

    /// <summary>
    /// HTTP method used to send the gather callback
    /// </summary>
    [XmlAttribute("gatherMethod")]
    public string GatherMethod { get; set; }

    /// <summary>
    /// String of digits to terminate the gather
    /// </summary>
    [XmlAttribute("terminatingDigits")]
    public string TerminatingDigits { get; set; }

    /// <summary>
    /// Optional string to be included in callbacks
    /// </summary>
    [XmlAttribute("tag")]
    public string Tag { get; set; }

    /// <summary>
    ///   Quantity of digits to collect
    /// </summary>
    [XmlIgnore]
    public Nullable<int> MaxDigits { get; set; }

    /// <summary>
    ///  The setter does nothing! This is just a surrogate feild for nullable xml attribute serialization.
    /// </summary>
    [XmlAttribute("maxDigits")]
    public string MaxDigitsAsText {
        get {return (MaxDigits.HasValue) ? MaxDigits.ToString() : null ;}
        set {}
    }

    /// <summary>
    ///   Integer time indicating the timeout between digits
    /// </summary>
    [XmlAttribute("interDigitTimeout")]
    public double InterDigitTimeout { get; set; }

    /// <summary>
    /// Username for http authentication
    /// </summary>
    [XmlAttribute("username")]
    public string Username { get; set; }

    /// <summary>
    /// Password for http authentication
    /// </summary>
    [XmlAttribute("password")]
    public string Password { get; set; }

    /// <summary>
    /// Timeout in secods for first digit press
    /// </summary>
    [XmlAttribute("firstDigitTimeout")]
    public double FirstDigitTimeout { get; set; }

    /// <summary>
    ///  Integer between 1 and 30 that specifies how many times to play the audio. This parameter will be honored both inside and outside of a Gather verb. Default is 1.
    ///  </summary>
    [XmlIgnore]    
    public Nullable<int> RepeatCount { get; set; }

    /// <summary>
    ///  The setter does nothing! This is just a surrogate feild for nullable xml attribute serialization.
    /// </summary>
    [XmlAttribute("repeatCount")]
    public string RepeatCountAsText {
        get {return (RepeatCount.HasValue) ? RepeatCount.ToString() : null ;}
        set {}
    }

    /// <summary>
    ///  Using the SpeakSentence inside the Gather verb will speak the text to the callee.
    /// </summary>
    public SpeakSentence SpeakSentence { get; set; }

    /// <summary>
    /// Using the PlayAudio inside the Gather verb will play the media to the callee.
    /// </summary>
    public PlayAudio PlayAudio { get; set; }

    /// <summary>
    /// Using the PlayAudio inside the Gather verb will play the media to the callee.
    /// </summary>
    public List<IAudioProducer> AudioProducers { get; set; }

    public string GatherFallbackUrl {get; set;}

    public string GatherFallbackMethod {get; set;}

    public string FallbackPassword {get; set;}

    public string FallbackUsername {get; set;}

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            if (!string.IsNullOrEmpty(GatherUrl))
            {
                writer.WriteAttributeString("gatherUrl", GatherUrl);
            }
            if (!string.IsNullOrEmpty(GatherMethod))
            {
                writer.WriteAttributeString("gatherMethod", GatherMethod);
            }
            if (!string.IsNullOrEmpty(TerminatingDigits))
            {
                writer.WriteAttributeString("terminatingDigits", TerminatingDigits);
            }
            if (!string.IsNullOrEmpty(Tag))
            {
                writer.WriteAttributeString("tag", Tag);
            }
            if (MaxDigits.HasValue)
            {
                writer.WriteAttributeString("maxDigits", MaxDigits.ToString());
            }
            
            writer.WriteAttributeString("interDigitTimeout", InterDigitTimeout.ToString());

            if (!string.IsNullOrEmpty(Username))
            {
                writer.WriteAttributeString("username", Username);
            }

            if (!string.IsNullOrEmpty(Password))
            {
                writer.WriteAttributeString("password", Password);
            }

            if (!string.IsNullOrEmpty(FallbackUsername))
            {
                writer.WriteAttributeString("fallbackUsername", FallbackUsername);
            }

            if (!string.IsNullOrEmpty(FallbackPassword))
            {
                writer.WriteAttributeString("fallbackPassword", FallbackPassword);
            }

            if (!string.IsNullOrEmpty(GatherFallbackUrl))
            {
                writer.WriteAttributeString("gatherFallbackUrl", GatherFallbackUrl);
            }

            if (!string.IsNullOrEmpty(GatherFallbackMethod))
            {
                writer.WriteAttributeString("gatherFallbackMethod", GatherFallbackMethod);
            }

            writer.WriteAttributeString("firstDigitTimeout", FirstDigitTimeout.ToString());

            if (RepeatCount.HasValue)
            {
                writer.WriteAttributeString("repeatCount", RepeatCount.ToString());
            }

            if (SpeakSentence != null)
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var serializer = new XmlSerializer(SpeakSentence.GetType(), "");
                serializer.Serialize(writer, SpeakSentence, ns);
                
            }

            if (PlayAudio != null)
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                var serializer = new XmlSerializer(PlayAudio.GetType(), "");
                serializer.Serialize(writer, PlayAudio, ns);
            }

            if (AudioProducers != null && AudioProducers.Count > 0)
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");
 
                foreach (var verb in AudioProducers)
                {
                    var serializer = new XmlSerializer(verb.GetType(), "");
                    serializer.Serialize(writer, verb, ns);
                }
            }
        }
  }
}
