using Xunit;
using Newtonsoft.Json;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointEventTypeEnumTests
    {
        [Fact]
        public void EndpointEventTypeEnumSerializationTest()
        {
            Assert.Equal("\"DEVICE_CONNECTED\"", JsonConvert.SerializeObject(EndpointEventTypeEnum.CONNECTED));
            Assert.Equal("\"DEVICE_DISCONNECTED\"", JsonConvert.SerializeObject(EndpointEventTypeEnum.DISCONNECTED));

            Assert.Equal(EndpointEventTypeEnum.CONNECTED, JsonConvert.DeserializeObject<EndpointEventTypeEnum>("\"DEVICE_CONNECTED\""));
            Assert.Equal(EndpointEventTypeEnum.DISCONNECTED, JsonConvert.DeserializeObject<EndpointEventTypeEnum>("\"DEVICE_DISCONNECTED\""));
        }
    }
}
