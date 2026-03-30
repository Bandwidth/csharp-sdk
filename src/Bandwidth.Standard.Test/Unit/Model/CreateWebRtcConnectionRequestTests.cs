using Xunit;
using System;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class CreateWebRtcConnectionRequestTests
    {
        private CreateWebRtcConnectionRequest instance;

        public CreateWebRtcConnectionRequestTests()
        {
            instance = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: "https://myapp.com/callback",
                eventFallbackUrl: "https://fallback.myapp.com/callback",
                tag: "test-tag"
            );
        }

        [Fact]
        public void CreateWebRtcConnectionRequestFieldsTest()
        {
            Assert.IsType<CreateWebRtcConnectionRequest>(instance);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Type);
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, instance.Direction);
            Assert.Equal("https://myapp.com/callback", instance.EventCallbackUrl);
            Assert.Equal("https://fallback.myapp.com/callback", instance.EventFallbackUrl);
            Assert.Equal("test-tag", instance.Tag);
        }
    }
}
