using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointDirectionEnumTests
    {
        [Fact]
        public void InboundEnumTest()
        {
            Assert.Equal(EndpointDirectionEnum.INBOUND, EndpointDirectionEnum.INBOUND);
        }

        [Fact]
        public void OutboundEnumTest()
        {
            Assert.Equal(EndpointDirectionEnum.OUTBOUND, EndpointDirectionEnum.OUTBOUND);
        }

        [Fact]
        public void BidirectionalEnumTest()
        {
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, EndpointDirectionEnum.BIDIRECTIONAL);
        }
    }
}
