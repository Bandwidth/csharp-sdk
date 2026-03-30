using Xunit;
using Newtonsoft.Json;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointDirectionEnumTests
    {
        [Fact]
        public void EndpointDirectionEnumValuesTest()
        {
            Assert.Equal(1, (int)EndpointDirectionEnum.INBOUND);
            Assert.Equal(2, (int)EndpointDirectionEnum.OUTBOUND);
            Assert.Equal(3, (int)EndpointDirectionEnum.BIDIRECTIONAL);

            Assert.Equal("\"INBOUND\"", JsonConvert.SerializeObject(EndpointDirectionEnum.INBOUND));
            Assert.Equal("\"OUTBOUND\"", JsonConvert.SerializeObject(EndpointDirectionEnum.OUTBOUND));
            Assert.Equal("\"BIDIRECTIONAL\"", JsonConvert.SerializeObject(EndpointDirectionEnum.BIDIRECTIONAL));

            Assert.Equal(EndpointDirectionEnum.INBOUND, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"INBOUND\""));
            Assert.Equal(EndpointDirectionEnum.OUTBOUND, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"OUTBOUND\""));
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"BIDIRECTIONAL\""));

            Assert.NotEqual(EndpointDirectionEnum.INBOUND, EndpointDirectionEnum.OUTBOUND);
            Assert.NotEqual(EndpointDirectionEnum.OUTBOUND, EndpointDirectionEnum.BIDIRECTIONAL);
            Assert.NotEqual(EndpointDirectionEnum.INBOUND, EndpointDirectionEnum.BIDIRECTIONAL);
        }
    }
}
