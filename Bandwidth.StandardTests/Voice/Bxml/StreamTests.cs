using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class StreamTests
    {

        [Fact]
        public void StartStreamBxmlVerbTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StartStream destination=\"https://www.test.com/stream\" name=\"test_stream\" streamEventUrl=\"https://www.test.com/event\" streamEventMethod=\"POST\" username=\"username\" password=\"password\" /></Response>";
            var startStream = new StartStream();
            startStream.Destination = "https://www.test.com/stream";
            startStream.Name = "test_stream";
            startStream.StreamEventUrl = "https://www.test.com/event";
            startStream.StreamEventMethod = "POST";
            startStream.Username = "username";
            startStream.Password = "password";

            var response = new Response(startStream);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void StopStreamBxmlVerbTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <StopStream name=\"test_stream\" /></Response>";
            var stopStream = new StopStream();
            stopStream.Name = "test_stream";

            var response = new Response(stopStream);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual);
        }
    }
}
