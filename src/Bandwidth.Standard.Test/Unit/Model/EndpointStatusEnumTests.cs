using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointStatusEnumTests
    {
        [Fact]
        public void ConnectedEnumTest()
        {
            Assert.Equal(EndpointStatusEnum.CONNECTED, EndpointStatusEnum.CONNECTED);
        }

        [Fact]
        public void DisconnectedEnumTest()
        {
            Assert.Equal(EndpointStatusEnum.DISCONNECTED, EndpointStatusEnum.DISCONNECTED);
        }
    }
}
