using Xunit;
using Bandwidth.Standard.Model;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class DeviceStatusEnumTests
    {
        [Fact]
        public void ConnectedEnumTest()
        {
            Assert.Equal(1, (int)DeviceStatusEnum.CONNECTED);
        }

        [Fact]
        public void DisconnectedEnumTest()
        {
            Assert.Equal(2, (int)DeviceStatusEnum.DISCONNECTED);
        }

        [Fact]
        public void ConnectedSerializationTest()
        {
            string json = JsonConvert.SerializeObject(DeviceStatusEnum.CONNECTED);
            Assert.Equal("\"CONNECTED\"", json);
        }

        [Fact]
        public void DisconnectedSerializationTest()
        {
            string json = JsonConvert.SerializeObject(DeviceStatusEnum.DISCONNECTED);
            Assert.Equal("\"DISCONNECTED\"", json);
        }

        [Fact]
        public void ConnectedDeserializationTest()
        {
            DeviceStatusEnum result = JsonConvert.DeserializeObject<DeviceStatusEnum>("\"CONNECTED\"");
            Assert.Equal(DeviceStatusEnum.CONNECTED, result);
        }

        [Fact]
        public void DisconnectedDeserializationTest()
        {
            DeviceStatusEnum result = JsonConvert.DeserializeObject<DeviceStatusEnum>("\"DISCONNECTED\"");
            Assert.Equal(DeviceStatusEnum.DISCONNECTED, result);
        }
    }
}
