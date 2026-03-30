using Xunit;
using Newtonsoft.Json;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class DeviceStatusEnumTests
    {
        [Fact]
        public void DeviceStatusEnumValuesTest()
        {
            Assert.Equal(1, (int)DeviceStatusEnum.CONNECTED);
            Assert.Equal(2, (int)DeviceStatusEnum.DISCONNECTED);

            Assert.Equal("\"CONNECTED\"", JsonConvert.SerializeObject(DeviceStatusEnum.CONNECTED));
            Assert.Equal("\"DISCONNECTED\"", JsonConvert.SerializeObject(DeviceStatusEnum.DISCONNECTED));

            Assert.Equal(DeviceStatusEnum.CONNECTED, JsonConvert.DeserializeObject<DeviceStatusEnum>("\"CONNECTED\""));
            Assert.Equal(DeviceStatusEnum.DISCONNECTED, JsonConvert.DeserializeObject<DeviceStatusEnum>("\"DISCONNECTED\""));

            Assert.NotEqual(DeviceStatusEnum.CONNECTED, DeviceStatusEnum.DISCONNECTED);
        }
    }
}
