using Xunit;
using System;
using Bandwidth.Standard.Model;
using Newtonsoft.Json;

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

        [Fact]
        public void SerializationTest()
        {
            string json = instance.ToJson();
            Assert.Contains("\"type\"", json);
            Assert.Contains("\"direction\"", json);
            Assert.Contains("\"eventCallbackUrl\"", json);
            Assert.Contains("\"eventFallbackUrl\"", json);
            Assert.Contains("\"tag\"", json);
            Assert.Contains("WEBRTC", json);
            Assert.Contains("BIDIRECTIONAL", json);
            Assert.Contains("https://myapp.com/callback", json);
            Assert.Contains("https://fallback.myapp.com/callback", json);
        }

        [Fact]
        public void DeserializationTest()
        {
            string json = @"{
                ""type"": ""WEBRTC"",
                ""direction"": ""OUTBOUND"",
                ""eventCallbackUrl"": ""https://example.com/cb"",
                ""tag"": ""my-tag""
            }";

            CreateWebRtcConnectionRequest deserialized = JsonConvert.DeserializeObject<CreateWebRtcConnectionRequest>(json);

            Assert.NotNull(deserialized);
            Assert.Equal(EndpointTypeEnum.WEBRTC, deserialized.Type);
            Assert.Equal(EndpointDirectionEnum.OUTBOUND, deserialized.Direction);
            Assert.Equal("https://example.com/cb", deserialized.EventCallbackUrl);
            Assert.Null(deserialized.EventFallbackUrl);
            Assert.Equal("my-tag", deserialized.Tag);
        }
    }
}
