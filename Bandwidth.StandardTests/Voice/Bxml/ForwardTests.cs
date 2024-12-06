using Bandwidth.Standard.Voice.Bxml;
using Xunit;

namespace Bandwidth.StandardTests.Voice.Bxml
{
    public class ForwardTests
    {

        [Fact]
        public void SimpleForwardTest()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Forward to=\"+19195551234\" callTimeout=\"30\" /></Response>";
            var forward = new Forward
            {
                To = "+19195551234"
            };

            var response = new Response(forward);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }

        [Fact]
        public void ForwardWithPrivacy()
        {
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Response>  <Forward to=\"+19195551234\" privacy=\"true\" callerDisplayName=\"Anonymous\" callTimeout=\"30\" /></Response>";
            var forward = new Forward
            {
                To = "+19195551234",
                Privacy = true,
                CallerDisplayName = Standard.Voice.Models.DisplayNameEnum.Anonymous
            };

            var response = new Response(forward);
            var actual = response.ToBXML();

            Assert.Equal(expected, actual.Replace("\n", "").Replace("\r", ""));
        }
    }
}
