using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class StartRecordingTests
    {

        [Fact]
        public void RecordingShouldHaveDetectLanguage()
        {
            var recording = new StartRecording();
            recording.DetectLanguage = true;


            var bxml = new BXML(recording);

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Bxml>  <StartRecording detectLanguage=\"true\" transcribe=\"false\" multiChannel=\"false\" /></Bxml>", bxml.ToBXML().Replace("\n", "").Replace("\r", ""));
        }
    }
}
