using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Voice.Exceptions;
using Bandwidth.Standard.Voice.Models;
using Xunit;

namespace Bandwidth.StandardTests.Voice
{
    public class GetCallTests
    {
        private BandwidthClient _client;

        public GetCallTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .VoiceBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task GetCallReturnsOk()
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

            var callId = createCallResponse.Data.CallId;

            // Get the call's state after it has been created.
            var getCallStateResponse = await _client.Voice.APIController.GetCallAsync(accountId, callId);

            Assert.Equal(200, getCallStateResponse.StatusCode);

            Assert.Equal(applicationId, getCallStateResponse.Data.ApplicationId);
            Assert.Equal(to, getCallStateResponse.Data.To);
            Assert.Equal(from, getCallStateResponse.Data.From);
            Assert.Equal(callId, getCallStateResponse.Data.CallId);
        }
    }
}