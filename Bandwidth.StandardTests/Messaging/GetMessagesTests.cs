using System.Collections.Generic;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Messaging.Models;
using Xunit;

namespace Bandwidth.StandardTests.Messaging
{
    public class GetMessagesTests
    {
        private BandwidthClient _client;

        public GetMessagesTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .MessagingBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task GetMessageReturnsOK()
        {
            var text = "Hello from Bandwidth";

            var request = new MessageRequest()
            {
                ApplicationId = TestConstants.MessagingApplicationId,
                To = new List<string> { TestConstants.To },
                From = TestConstants.From,
                Text = text
            };
            
            var createMessageResponse = await _client.Messaging.APIController.CreateMessageAsync(TestConstants.AccountId, request);
            
            var getMessagesResponse = await _client.Messaging.APIController.GetMessagesAsync(TestConstants.AccountId, createMessageResponse.Data.Id);

            Assert.Equal(200, getMessagesResponse.StatusCode);
        }
    }
}
