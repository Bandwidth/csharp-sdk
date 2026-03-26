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
        public void CreateWebRtcConnectionRequestInstanceTest()
        {
            Assert.IsType<CreateWebRtcConnectionRequest>(instance);
        }

        [Fact]
        public void TypeTest()
        {
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Type);
        }

        [Fact]
        public void DirectionTest()
        {
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, instance.Direction);
        }

        [Fact]
        public void EventCallbackUrlTest()
        {
            Assert.Equal("https://myapp.com/callback", instance.EventCallbackUrl);
        }

        [Fact]
        public void EventFallbackUrlTest()
        {
            Assert.Equal("https://fallback.myapp.com/callback", instance.EventFallbackUrl);
        }

        [Fact]
        public void TagTest()
        {
            Assert.Equal("test-tag", instance.Tag);
        }
    }
}
