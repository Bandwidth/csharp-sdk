using Xunit;
using Newtonsoft.Json;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointTypeEnumTests
    {
        [Fact]
        public void EndpointTypeEnumSerializationTest()
        {
            Assert.Equal("\"WEBRTC\"", JsonConvert.SerializeObject(EndpointTypeEnum.WEBRTC));

            Assert.Equal(EndpointTypeEnum.WEBRTC, JsonConvert.DeserializeObject<EndpointTypeEnum>("\"WEBRTC\""));
        }
    }
}
