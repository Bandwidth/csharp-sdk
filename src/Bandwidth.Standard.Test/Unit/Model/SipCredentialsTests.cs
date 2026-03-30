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
        public void SipCredentialsFieldsTest()
        {
            Assert.IsType<SipCredentials>(instance);
            Assert.Equal("sipuser", instance.Username);
            Assert.Equal("sippass", instance.Password);
        }
    }
}
