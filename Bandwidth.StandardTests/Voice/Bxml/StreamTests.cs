using System.Collections.Generic;
using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class StreamTests
    {

        [Fact]
        public void StartStreamBxmlVerbTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartStream destination=\"https://www.test.com/stream\" name=\"test_stream\" tracks=\"inbound\" streamEventUrl=\"https://www.test.com/event\" streamEventMethod=\"POST\" username=\"username\" password=\"password\">    <StreamParam name=\"name1\" value=\"value1\" />    <StreamParam name=\"name2\" value=\"value2\" />  </StartStream></Response>";

            var streamParam1 = new StreamParam();
            streamParam1.Name = "name1";
            streamParam1.Value = "value1";

            var streamParam2 = new StreamParam();
            streamParam2.Name = "name2";
            streamParam2.Value = "value2";

            var startStream = new StartStream();
            startStream.Destination = "https://www.test.com/stream";
            startStream.Name = "test_stream";
            startStream.Tracks = "inbound";
            startStream.StreamEventUrl = "https://www.test.com/event";
            startStream.StreamEventMethod = "POST";
            startStream.Username = "username";
            startStream.Password = "password";
            startStream.StreamParams.Add(streamParam1);
            startStream.StreamParams.Add(streamParam2);

            var response = new Response(startStream);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", ""));
        }

        [Fact]
        public void StopStreamBxmlVerbTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StopStream name=\"test_stream\" /></Response>";
            var stopStream = new StopStream();
            stopStream.Name = "test_stream";

            var response = new Response(stopStream);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", ""));
        }
    }
}
