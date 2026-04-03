using Xunit;
using Newtonsoft.Json;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointStatusEnumTests
    {
        [Fact]
        public void EndpointStatusEnumSerializationTest()
        {
            Assert.Equal("\"CONNECTED\"", JsonConvert.SerializeObject(EndpointStatusEnum.CONNECTED));
            Assert.Equal("\"DISCONNECTED\"", JsonConvert.SerializeObject(EndpointStatusEnum.DISCONNECTED));

            Assert.Equal(EndpointStatusEnum.CONNECTED, JsonConvert.DeserializeObject<EndpointStatusEnum>("\"CONNECTED\""));
            Assert.Equal(EndpointStatusEnum.DISCONNECTED, JsonConvert.DeserializeObject<EndpointStatusEnum>("\"DISCONNECTED\""));
        }
    }
}
