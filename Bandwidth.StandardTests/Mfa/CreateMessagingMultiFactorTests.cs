using System;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.MultiFactorAuth.Exceptions;
using Bandwidth.Standard.MultiFactorAuth.Models;
using Xunit;

namespace Bandwidth.StandardTests.Mfa
{
    public class CreateMessagingMultiFactorTests
    {
        private BandwidthClient _client;

        public CreateMessagingMultiFactorTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .MultiFactorAuthBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task CreateMessagingMultiFactorReturnsOk()
        {
            var accountId = TestConstants.AccountId;
            var applicationId = TestConstants.MessagingApplicationId;
            var to = TestConstants.To;
            var from = TestConstants.From;
            var scope = "test";
            var digits = 6;
            var message = "Your temporary {NAME} {SCOPE} code is {CODE}";

            var request = new TwoFactorCodeRequestSchema
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                Scope = scope,
                Digits = digits,
                Message = message
            };

            var response = await _client.MultiFactorAuth.MFAController.CreateMessagingTwoFactorAsync(accountId, request);

            Assert.Equal(200, response.StatusCode);

            Assert.NotEmpty(response.Data.MessageId);
        }

        [Fact]
        public async Task CreateMessagingMultiFactorInvalidToPhoneNumberThrows()
        {
            var accountId = TestConstants.AccountId;
            var applicationId = TestConstants.MessagingApplicationId;
            var to = "invalid";
            var from = TestConstants.From;
            var scope = "test";
            var digits = 6;
            var message = "Your temporary {NAME} {SCOPE} code is {CODE}.";

            var request = new TwoFactorCodeRequestSchema
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                Scope = scope,
                Digits = digits,
                Message = message
            };

            var ex = await Assert.ThrowsAsync<ErrorWithRequestException>(() => _client.MultiFactorAuth.MFAController.CreateMessagingTwoFactorAsync(accountId, request));
            
            Assert.Equal("If there is any issue with values passed in by the user", ex.Message);
        }

        [Fact]
        public async Task CreateMessagingMultiFactorInvalidFromPhoneNumberThrows()
        {
            var accountId = TestConstants.AccountId;
            var applicationId = TestConstants.MessagingApplicationId;
            var to = TestConstants.To;
            var from = "invalid";
            var scope = "test";
            var digits = 6;
            var message = "Your temporary {NAME} {SCOPE} code is {CODE}.";

            var request = new TwoFactorCodeRequestSchema
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                Scope = scope,
                Digits = digits,
                Message = message
            };

            var ex = await Assert.ThrowsAsync<ErrorWithRequestException>(() => _client.MultiFactorAuth.MFAController.CreateMessagingTwoFactorAsync(accountId, request));
            
            Assert.Equal("If there is any issue with values passed in by the user", ex.Message);
        }
    }
}