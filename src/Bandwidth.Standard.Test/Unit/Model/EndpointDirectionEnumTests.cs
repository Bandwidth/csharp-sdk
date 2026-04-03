using Xunit;
using Newtonsoft.Json;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointDirectionEnumTests
    {
        [Fact]
        public void EndpointDirectionEnumSerializationTest()
        {
            Assert.Equal("\"INBOUND\"", JsonConvert.SerializeObject(EndpointDirectionEnum.INBOUND));
            Assert.Equal("\"OUTBOUND\"", JsonConvert.SerializeObject(EndpointDirectionEnum.OUTBOUND));
            Assert.Equal("\"BIDIRECTIONAL\"", JsonConvert.SerializeObject(EndpointDirectionEnum.BIDIRECTIONAL));

            Assert.Equal(EndpointDirectionEnum.INBOUND, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"INBOUND\""));
            Assert.Equal(EndpointDirectionEnum.OUTBOUND, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"OUTBOUND\""));
            Assert.Equal(EndpointDirectionEnum.BIDIRECTIONAL, JsonConvert.DeserializeObject<EndpointDirectionEnum>("\"BIDIRECTIONAL\""));
        }
    }
}
