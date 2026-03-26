using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class EndpointTypeEnumTests
    {
        [Fact]
        public void WebRtcEnumTest()
        {
            Assert.Equal(EndpointTypeEnum.WEBRTC, EndpointTypeEnum.WEBRTC);
        }
    }
}
