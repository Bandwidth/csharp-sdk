using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class RingTests
    {
        [Fact]
        public void RingShouldBeDefaults()
        {
            var ring = new Ring();

            Assert.Equal(5, ring.Duration);
            Assert.True(ring.AnswerCall);
        }

        [Fact]
        public void RingDurationShouldBeTen()
        {
            var ring = new Ring();
            ring.Duration = 10;

            Assert.Equal(10, ring.Duration);
        }

        [Fact]
        public void RingAnswerCallShouldBeFalse()
        {
            var ring = new Ring();
            ring.AnswerCall = false;

            Assert.False(ring.AnswerCall);
        }

        [Fact]
        public void RingResponseToBXMLShouldBeDefaults()
        {
            var ring = new Ring();
            var response = new Response(ring);

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Ring duration=\"5\" answerCall=\"true\" /></Response>", response.ToBXML().Replace("\n", ""));
        }

        [Fact]
        public void RingDurationResponseToBXMLShouldBeThirty()
        {
            var ring = new Ring();
            ring.Duration = 30;

            var response = new Response(ring);

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Ring duration=\"30\" answerCall=\"true\" /></Response>", response.ToBXML().Replace("\n", ""));
        }

        [Fact]
        public void RingAnswerCallResponseToBXMLShouldBeFalse()
        {
            var ring = new Ring();
            ring.AnswerCall = false;

            var response = new Response(ring);

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Ring duration=\"5\" answerCall=\"false\" /></Response>", response.ToBXML().Replace("\n", ""));
        }
    }
}
