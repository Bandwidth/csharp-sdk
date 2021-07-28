using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Voice.Exceptions;
using Bandwidth.Standard.Voice.Models;
using Xunit;

namespace Bandwidth.StandardTests.Voice
{
    public class CreateCallTests
    {
        private BandwidthClient _client;

        public CreateCallTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .VoiceBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task CreateCallReturnsCreated()
        {
            var accountId = TestConstants.AccountId;
            var to = TestConstants.To;
            var from = TestConstants.From;
            var applicationId = TestConstants.VoiceApplicationId;
            var answerUrl = string.Concat(TestConstants.BaseCallbackUrl, "/callbacks/answer");

            var request = new CreateCallRequest()
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                AnswerUrl = answerUrl
            };

            var createCallResponse = await _client.Voice.APIController.CreateCallAsync(accountId, request);

            Assert.Equal(201, createCallResponse.StatusCode);

            Assert.Equal(applicationId, createCallResponse.Data.ApplicationId);
            Assert.Equal(to, createCallResponse.Data.To);
            Assert.Equal(from, createCallResponse.Data.From);
        }

        [Fact]
        public async Task CreateCallInvalidToPhoneNumberThrows()
        {
            var accountId = TestConstants.AccountId;
            var applicationId = TestConstants.VoiceApplicationId;
            var to = "abc";
            var from = TestConstants.From;
            var answerUrl = string.Concat(TestConstants.BaseCallbackUrl, "/callbacks/answer");

            var request = new CreateCallRequest()
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                AnswerUrl = answerUrl
            };

            var ex = await Assert.ThrowsAsync<ApiErrorException>(() => _client.Voice.APIController.CreateCallAsync(accountId, request));
            
            Assert.Equal("Something's not quite right... Your request is invalid. Please fix it before trying again.", ex.Message);
        }

        [Fact]
        public async Task CreateCallInvalidFromPhoneNumberThrows()
        {
            var accountId = TestConstants.AccountId;
            var to = TestConstants.To;
            var from = "abc";
            var applicationId = TestConstants.VoiceApplicationId;
            var answerUrl = string.Concat(TestConstants.BaseCallbackUrl, "/callbacks/answer");

            var request = new CreateCallRequest()
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                AnswerUrl = answerUrl
            };

            var ex = await Assert.ThrowsAsync<ApiErrorException>(() => _client.Voice.APIController.CreateCallAsync(accountId, request));
            
            Assert.Equal("Something's not quite right... Your request is invalid. Please fix it before trying again.", ex.Message);
        }
    }
}