using Xunit;
using System;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class CreateEndpointRequestBaseTests
    {
        private CreateEndpointRequestBase instance;

        public CreateEndpointRequestBaseTests()
        {
            instance = new CreateEndpointRequestBase(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.INBOUND,
                eventCallbackUrl: "https://myapp.com/callback",
                eventFallbackUrl: "https://fallback.myapp.com/callback",
                tag: "test-tag"
            );
        }

        [Fact]
        public void CreateEndpointRequestBaseFieldsTest()
        {
            Assert.IsType<CreateEndpointRequestBase>(instance);
            Assert.Equal(EndpointTypeEnum.WEBRTC, instance.Type);
            Assert.Equal(EndpointDirectionEnum.INBOUND, instance.Direction);
            Assert.Equal("https://myapp.com/callback", instance.EventCallbackUrl);
            Assert.Equal("https://fallback.myapp.com/callback", instance.EventFallbackUrl);
            Assert.Equal("test-tag", instance.Tag);
        }
    }
}
