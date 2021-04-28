using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.TwoFactorAuth.Models;
using Xunit;

namespace Bandwidth.StandardTests.Mfa
{
    public class VerifyMessagingMultiFactorTests
    {
        private BandwidthClient _client;
        
        public VerifyMessagingMultiFactorTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .TwoFactorAuthBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task VerifyMessagingMultiFactorReturnsOk()
        {
            var accountId = TestConstants.AccountId;
            var applicationId = TestConstants.VoiceApplicationId;
            var to = TestConstants.To;
            var scope = "test";
            var code = "123456";
            var expirationTimeInMinutes = 3;

            var request = new TwoFactorVerifyRequestSchema
            {
                ApplicationId = applicationId,
                To = to,
                Scope = scope,
                Code = code,
                ExpirationTimeInMinutes = expirationTimeInMinutes
            };

            var response = await _client.TwoFactorAuth.MFAController.CreateVerifyTwoFactorAsync(accountId, request);

            Assert.IsType<bool>(response.Data.Valid);
        }
    }
}