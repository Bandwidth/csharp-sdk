using System.Collections.Generic;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.WebRtc.Models;
using Xunit;

namespace Bandwidth.StandardTests.WebRtc
{
    public class SessionTests
    {
        private BandwidthClient _client;

        public SessionTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .WebRtcBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task CreateSessionAndAddParticipant()
        {
            var accountId = TestConstants.AccountId;

            var session = new Session();
            session.Tag = "new-session";
            
            var createSessionResponse = await _client.WebRtc.APIController.CreateSessionAsync(accountId, session);

            Assert.NotEmpty(createSessionResponse.Data.Id);
            Assert.Equal("new-session", createSessionResponse.Data.Tag);

            var sessionId = createSessionResponse.Data.Id;

            var publishPermissions = new List<PublishPermissionEnum>() { PublishPermissionEnum.AUDIO, PublishPermissionEnum.VIDEO };
            var callbackUrl = string.Concat(TestConstants.BaseCallbackUrl, "/callbacks/participant");

            var participant = new Participant()
            {
                PublishPermissions = publishPermissions,
                CallbackUrl = callbackUrl
            };

            var createParticipantResponse = await _client.WebRtc.APIController.CreateParticipantAsync(accountId, participant);
            
            Assert.NotEmpty(createParticipantResponse.Data.Token);
            Assert.NotNull(createParticipantResponse.Data.Participant);
            Assert.NotEmpty(createParticipantResponse.Data.Participant.Id);
            
            Assert.True(createParticipantResponse.Data.Participant.PublishPermissions.Count == 2);
            Assert.Contains(PublishPermissionEnum.AUDIO, createParticipantResponse.Data.Participant.PublishPermissions);
            Assert.Contains(PublishPermissionEnum.VIDEO, createParticipantResponse.Data.Participant.PublishPermissions);

            var participantId = createParticipantResponse.Data.Participant.Id;

            await _client.WebRtc.APIController.AddParticipantToSessionAsync(accountId, sessionId, participantId);
            await _client.WebRtc.APIController.RemoveParticipantFromSessionAsync(accountId, participantId, sessionId);

            await _client.WebRtc.APIController.DeleteParticipantAsync(accountId, participantId);
            await _client.WebRtc.APIController.DeleteSessionAsync(accountId, sessionId);
        }
    }
}
