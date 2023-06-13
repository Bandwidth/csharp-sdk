using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class StartStopTranscriptionTests
    {

        [Fact]
        public void StartTranscriptionBxmlVerbTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartTranscription name=\"test_transcription\" stabilized=\"true\">    <CustomParam name=\"name1\" value=\"value1\" />    <CustomParam name=\"name2\" value=\"value2\" />  </StartTranscription></Response>";

            var customParam1 = new CustomParam();
            customParam1.Name = "name1";
            customParam1.Value = "value1";

            var customParam2 = new CustomParam();
            customParam2.Name = "name2";
            customParam2.Value = "value2";

            var startTranscription = new StartTranscription();
            startTranscription.Name = "test_transcription";
            startTranscription.CustomParams = new List<CustomParam>()
            {
                customParam1,
                customParam2
            };

            var response = new Response(startTranscription);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }

        [Fact]
        public void StopTranscriptionmBxmlVerbTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StopTranscription name=\"test_transcription\" /></Response>";
            var stopTranscription = new StopTranscription();
            stopTranscription.Name = "test_transcription";

            var response = new Response(stopTranscription);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }
    }
}
