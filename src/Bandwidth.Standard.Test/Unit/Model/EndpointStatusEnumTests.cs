using Xunit;
using Bandwidth.Standard.Model;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointStatusEnumTests
    {
        [Fact]
        public void ConnectedEnumTest()
        {
            Assert.Equal(1, (int)EndpointStatusEnum.CONNECTED);
        }

        [Fact]
        public void DisconnectedEnumTest()
        {
            Assert.Equal(2, (int)EndpointStatusEnum.DISCONNECTED);
        }

        [Fact]
        public void ConnectedSerializationTest()
        {
            string json = JsonConvert.SerializeObject(EndpointStatusEnum.CONNECTED);
            Assert.Equal("\"CONNECTED\"", json);
        }

        [Fact]
        public void DisconnectedSerializationTest()
        {
            string json = JsonConvert.SerializeObject(EndpointStatusEnum.DISCONNECTED);
            Assert.Equal("\"DISCONNECTED\"", json);
        }

        [Fact]
        public void ConnectedDeserializationTest()
        {
            EndpointStatusEnum result = JsonConvert.DeserializeObject<EndpointStatusEnum>("\"CONNECTED\"");
            Assert.Equal(EndpointStatusEnum.CONNECTED, result);
        }

        [Fact]
        public void DisconnectedDeserializationTest()
        {
            EndpointStatusEnum result = JsonConvert.DeserializeObject<EndpointStatusEnum>("\"DISCONNECTED\"");
            Assert.Equal(EndpointStatusEnum.DISCONNECTED, result);
        }
    }
}
