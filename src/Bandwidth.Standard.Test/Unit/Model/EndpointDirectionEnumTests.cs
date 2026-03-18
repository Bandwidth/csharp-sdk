using Xunit;
using Bandwidth.Standard.Model;
using Newtonsoft.Json;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointDirectionEnumTests
    {
        [Fact]
        public void InboundEnumTest()
        {
            Assert.Equal(1, (int)EndpointDirectionEnum.INBOUND);
        }

        [Fact]
        public void OutboundEnumTest()
        {
            Assert.Equal(2, (int)EndpointDirectionEnum.OUTBOUND);
        }

        [Fact]
        public void BidirectionalEnumTest()
        {
            Assert.Equal(3, (int)EndpointDirectionEnum.BIDIRECTIONAL);
        }

        [Fact]
        public void InboundSerializationTest()
        {
            string json = JsonConvert.SerializeObject(EndpointDirectionEnum.INBOUND);
            Assert.Equal("\"INBOUND\"", json);
        }

        [Fact]
        public void OutboundSerializationTest()
        {
            string json = JsonConvert.SerializeObject(EndpointDirectionEnum.OUTBOUND);
            Assert.Equal("\"OUTBOUND\"", json);
        }

        [Fact]
        public void BidirectionalSerializationTest()
        {
            string json = JsonConvert.SerializeObject(EndpointDirectionEnum.BIDIRECTIONAL);
            Assert.Equal("\"BIDIRECTIONAL\"", json);
        }

        [Fact]
        public void InboundDeserializationTest()
        {
            EndpointDirectionEnum result = JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"INBOUND\"");
            Assert.Equal(EndpointDirectionEnum.INBOUND, result);
        }

        [Fact]
        public void OutboundDeserializationTest()
        {
            EndpointDirectionEnum result = JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"OUTBOUND\"");
            Assert.Equal(EndpointDirectionEnum.OUTBOUND, result);
        }

        [Fact]
        public void BidirectionalDeserializationTest()
        {
            EndpointDirectionEnum result = JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"BIDIRECTIONAL\"");
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, result);
        }
    }
}
