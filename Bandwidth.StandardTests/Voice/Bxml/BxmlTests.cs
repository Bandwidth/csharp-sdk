using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class BxmlTests
    {

        [Fact]
        public void EmptyBxmlTest()
        {
            var bxml = new BXML();
            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Bxml />", bxml.ToBXML().Replace("\n", "").Replace("\r", ""));
        }

        [Fact]
        public void RingAnswerCallResponseToBXMLShouldBeFalse()
        {
            var ring = new Ring();
            ring.AnswerCall = false;

            var bxml = new BXML(ring);

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><Bxml>  <Ring duration=\"5\" answerCall=\"false\" /></Bxml>", bxml.ToBXML().Replace("\n", "").Replace("\r", ""));
        }
    }
}
