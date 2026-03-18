using Xunit;
using Bandwidth.Standard.Model;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointTypeEnumTests
    {
        [Fact]
        public void WebRtcEnumTest()
        {
            Assert.Equal(1, (int)EndpointTypeEnum.WEBRTC);
        }

        [Fact]
        public void WebRtcSerializationTest()
        {
            string json = JsonConvert.SerializeObject(EndpointTypeEnum.WEBRTC);
            Assert.Equal("\"WEBRTC\"", json);
        }

        [Fact]
        public void WebRtcDeserializationTest()
        {
            EndpointTypeEnum result = JsonConvert.DeserializeObject<EndpointTypeEnum>("\"WEBRTC\"");
            Assert.Equal(EndpointTypeEnum.WEBRTC, result);
        }
    }
}
