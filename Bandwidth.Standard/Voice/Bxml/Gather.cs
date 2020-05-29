using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Bandwidth.Standard.Voice.Bxml
{
  /// <summary>
  ///   The Gather verb is used to collect digits for some period of time.
  /// </summary>
  /// <seealso href="http://ap.bandwidth.com/docs/xml/gather/" />
  public class Gather : IVerb
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
  }
}
