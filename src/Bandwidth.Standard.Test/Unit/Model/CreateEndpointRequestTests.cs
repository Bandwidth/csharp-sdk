using Xunit;
using System;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class CreateEndpointRequestTests
    {
        private CreateEndpointRequest instance;

        public CreateEndpointRequestTests()
        {
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: "https://myapp.com/callback",
                tag: "test-tag"
            );
            instance = new CreateEndpointRequest(webRtcRequest);
        }

        [Fact]
        public void CreateEndpointRequestFieldsTest()
        {
            Assert.IsType<CreateEndpointRequest>(instance);
            Assert.NotNull(instance.ActualInstance);
            Assert.IsType<CreateWebRtcConnectionRequest>(instance.ActualInstance);

            var actual = instance.GetCreateWebRtcConnectionRequest();
            Assert.IsType<CreateWebRtcConnectionRequest>(actual);
            Assert.Equal(EndpointTypeEnum.WEBRTC, actual.Type);
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, actual.Direction);
            Assert.Equal("https://myapp.com/callback", actual.EventCallbackUrl);
            Assert.Equal("test-tag", actual.Tag);
        }

        [Fact]
        public void NullActualInstanceTest()
        {
            Assert.Throws<ArgumentException>(() => new CreateEndpointRequest(null));
        }
    }
}
