using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class SipCredentialsTests
    {
        private SipCredentials instance;

        public SipCredentialsTests()
        {
            instance = new SipCredentials(
                username: "sipuser",
                password: "sippass"
            );
        }

        [Fact]
        public void SipCredentialsInstanceTest()
        {
            Assert.IsType<SipCredentials>(instance);
        }

        [Fact]
        public void UsernameTest()
        {
            Assert.Equal("sipuser", instance.Username);
        }

        [Fact]
        public void PasswordTest()
        {
            Assert.Equal("sippass", instance.Password);
        }
    }
}
