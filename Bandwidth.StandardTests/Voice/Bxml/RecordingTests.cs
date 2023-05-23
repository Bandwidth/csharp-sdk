using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class RecordingTests
    {

        [Fact]
        public void RecordingShouldHaveDetectLanguage()
        {
            var recording = new Bandwidth.Standard.Voice.Bxml.Record();
            recording.DetectLanguage = true;


            var bxml = new BXML(recording);

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Bxml>  <Record detectLanguage=\"true\" transcribe=\"false\" /></Bxml>", bxml.ToBXML().Replace("\n", "").Replace("\r", ""));
        }
    }
}
