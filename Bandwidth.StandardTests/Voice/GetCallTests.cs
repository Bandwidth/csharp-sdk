using System;
using System.Threading;
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

            var retries = 5;
            do
            {
                try
                {
                    // Attempt to get the call's state after it has been created.
                    var getCallStateResponse = await _client.Voice.APIController.GetCallAsync(accountId, callId);

                    // No need to retry if we've made it this far.
                    retries = 0;

                    Assert.Equal(200, getCallStateResponse.StatusCode);

                    Assert.Equal(callId, getCallStateResponse.Data.CallId);
                    Assert.Null(getCallStateResponse.Data.ParentCallId);
                    Assert.Equal(applicationId, getCallStateResponse.Data.ApplicationId);
                    Assert.Equal(accountId, getCallStateResponse.Data.AccountId);
                    Assert.Equal(to, getCallStateResponse.Data.To);
                    Assert.Equal(from, getCallStateResponse.Data.From);
                    Assert.Equal("outbound", getCallStateResponse.Data.Direction);
                    Assert.Equal("initiated", getCallStateResponse.Data.State);
                    Assert.Null(getCallStateResponse.Data.Identity);
                    Assert.Empty(getCallStateResponse.Data.StirShaken);
                    Assert.IsType(typeof(DateTime), getCallStateResponse.Data.StartTime);
                    Assert.Null(getCallStateResponse.Data.AnswerTime);
                    Assert.Null(getCallStateResponse.Data.EndTime);
                    Assert.Null(getCallStateResponse.Data.DisconnectCause);
                    Assert.Null(getCallStateResponse.Data.ErrorMessage);
                    Assert.Null(getCallStateResponse.Data.ErrorId);
                    Assert.IsType(typeof(DateTime), getCallStateResponse.Data.LastUpdate);
                }
                catch (ApiErrorException ex)
                {
                    // There are times when the created call resource is not yet available after creating it.
                    retries = ex.ResponseCode == 404 ? retries - 1 : 0;
                    // Pause to give time to contemplate life.
                    Thread.Sleep(TestConstants.Timeout);
                }
            }
            while (retries > 0);
        }
    }
}