using System.Collections.Generic;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.WebRtc.Models;
using Xunit;

namespace Bandwidth.StandardTests.WebRtc
{
    public class ParticipantTests
    {
        private BandwidthClient _client;

        public ParticipantTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .WebRtcBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task CreateParticipantWithPermissionsAsync()
        {
            var accountId = TestConstants.AccountId;

            var participant = new Participant()
            {
                PublishPermissions = new List<PublishPermissionEnum>() { PublishPermissionEnum.AUDIO, PublishPermissionEnum.VIDEO }
            };

            var response = await _client.WebRtc.APIController.CreateParticipantAsync(accountId, participant);

            Assert.Equal(200, response.StatusCode);

            Assert.NotEmpty(response.Data.Participant.Id);
            Assert.Null(response.Data.Participant.CallbackUrl);
            
            Assert.Equal(2, response.Data.Participant.PublishPermissions.Count);
            Assert.Contains(PublishPermissionEnum.AUDIO, response.Data.Participant.PublishPermissions);
            Assert.Contains(PublishPermissionEnum.VIDEO, response.Data.Participant.PublishPermissions);

            Assert.Empty(response.Data.Participant.Sessions);

            Assert.Null(response.Data.Participant.Subscriptions.SessionId);
            Assert.Null(response.Data.Participant.Subscriptions.Participants);
            
            Assert.NotEmpty(response.Data.Participant.Tag);
            Assert.Equal(DeviceApiVersionEnum.V3, response.Data.Participant.DeviceApiVersion);

            Assert.NotEmpty(response.Data.Token);

            await _client.WebRtc.APIController.DeleteParticipantAsync(accountId, response.Data.Participant.Id);
        }
    }
}