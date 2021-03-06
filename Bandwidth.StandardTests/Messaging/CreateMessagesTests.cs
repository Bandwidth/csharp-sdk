using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Messaging.Exceptions;
using Bandwidth.Standard.Messaging.Models;
using Xunit;

namespace Bandwidth.StandardTests.Messaging
{
    public class CreateMessagesTests
    {
        private BandwidthClient _client;

        public CreateMessagesTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .MessagingBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task CreateMessageReturnsAccepted()
        {
            var text = "Hello from Bandwidth";

            var request = new MessageRequest()
            {
                ApplicationId = TestConstants.MessagingApplicationId,
                To = new List<string> { TestConstants.To },
                From = TestConstants.From,
                Text = text
            };
            
            var response = await _client.Messaging.APIController.CreateMessageAsync(TestConstants.AccountId, request);
            
            Assert.Equal(202, response.StatusCode);

            Assert.Equal(TestConstants.MessagingApplicationId, response.Data.ApplicationId);
            Assert.Single(response.Data.To);
            Assert.Equal(TestConstants.To, response.Data.To.First());
            Assert.Equal(TestConstants.From, response.Data.From);
            Assert.Equal(text, response.Data.Text);
        }

        [Fact]
        public async Task CreateMessageInvalidToPhoneNumberThrows()
        {
            var text = "Hello from Bandwidth";

            var request = new MessageRequest()
            {
                ApplicationId = TestConstants.MessagingApplicationId,
                To = new List<string> { "abc" },
                From = TestConstants.From,
                Text = text
            };
            
            var ex = await Assert.ThrowsAsync<MessagingException>(() => _client.Messaging.APIController.CreateMessageAsync(TestConstants.AccountId, request));
            
            Assert.Equal("400 Request is malformed or invalid", ex.Message);
        }

        [Fact]
        public async Task CreateMessageInvalidFromPhoneNumberThrows()
        {
            var accountId = TestConstants.AccountId;
            var applicationId = TestConstants.MessagingApplicationId;
            var to = new List<string> { TestConstants.To };
            var from = "invalid";
            var text = "Hello from Bandwidth";

            var request = new MessageRequest()
            {
                ApplicationId = applicationId,
                To = to,
                From = from,
                Text = text
            };
            
            var ex = await Assert.ThrowsAsync<MessagingException>(() => _client.Messaging.APIController.CreateMessageAsync(accountId, request));
            
            Assert.Equal("400 Request is malformed or invalid", ex.Message);
        }
    }
}
