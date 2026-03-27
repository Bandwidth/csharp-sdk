using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointEventTypeEnumTests
    {
        [Fact]
        public void ConnectedEnumTest()
        {
            Assert.Equal(EndpointEventTypeEnum.CONNECTED, EndpointEventTypeEnum.CONNECTED);
        }

        [Fact]
        public void DisconnectedEnumTest()
        {
            Assert.Equal(EndpointEventTypeEnum.DISCONNECTED, EndpointEventTypeEnum.DISCONNECTED);
        }
    }
}
