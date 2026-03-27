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
        public void SipConnectionMetadataInstanceTest()
        {
            Assert.IsType<SipConnectionMetadata>(instance);
        }

        [Fact]
        public void IpAddressTest()
        {
            Assert.Equal("192.168.0.1", instance.IpAddress);
        }

        [Fact]
        public void PortTest()
        {
            Assert.Equal(5060, instance.Port);
        }

        [Fact]
        public void CredentialsTest()
        {
            Assert.NotNull(instance.Credentials);
            Assert.Equal("sipuser", instance.Credentials.Username);
            Assert.Equal("sippass", instance.Credentials.Password);
        }

        [Fact]
        public void UuiHeaderTest()
        {
            Assert.Equal("my-uui-header", instance.UuiHeader);
        }
    }
}
