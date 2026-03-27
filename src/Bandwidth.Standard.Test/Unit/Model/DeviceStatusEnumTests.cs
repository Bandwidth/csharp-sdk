using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class DeviceStatusEnumTests
    {
        [Fact]
        public void ConnectedEnumTest()
        {
            Assert.Equal(DeviceStatusEnum.CONNECTED, DeviceStatusEnum.CONNECTED);
        }

        [Fact]
        public void DisconnectedEnumTest()
        {
            Assert.Equal(DeviceStatusEnum.DISCONNECTED, DeviceStatusEnum.DISCONNECTED);
        }
    }
}
