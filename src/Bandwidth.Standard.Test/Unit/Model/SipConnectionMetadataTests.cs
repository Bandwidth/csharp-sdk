using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class SipConnectionMetadataTests
    {
        private SipConnectionMetadata instance;

        public SipConnectionMetadataTests()
        {
            var credentials = new SipCredentials(
                username: "sipuser",
                password: "sippass"
            );

            instance = new SipConnectionMetadata(
                ipAddress: "192.168.0.1",
                port: 5060,
                credentials: credentials,
                uuiHeader: "my-uui-header"
            );
        }

        [Fact]
        public void SipConnectionMetadataFieldsTest()
        {
            Assert.IsType<SipConnectionMetadata>(instance);
            Assert.Equal("192.168.0.1", instance.IpAddress);
            Assert.Equal(5060, instance.Port);
            Assert.NotNull(instance.Credentials);
            Assert.Equal("sipuser", instance.Credentials.Username);
            Assert.Equal("sippass", instance.Credentials.Password);
            Assert.Equal("my-uui-header", instance.UuiHeader);
        }
    }
}
