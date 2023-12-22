using System;
using System.Collections.Generic;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using System.Net;

namespace Bandwidth.Standard.Test.Integration
{
    /// <summary>
    ///  Class for testing MessagesApi
    /// </summary>
    public class MessagesIntegrationTests : IDisposable
    {
        private string accountId;
        private Configuration fakeConfiguration;
        private MessagesApi forbiddenInstance;
        private MessagesApi instance;
        private MessageRequest messageRequest;
        private MessagesApi unauthorizedInstance;

        public MessagesIntegrationTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

            // Authorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://messaging.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            instance = new MessagesApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://messaging.bandwidth.com/api/v2";
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new MessagesApi(fakeConfiguration);

            // Forbidden API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://messaging.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");
            forbiddenInstance = new MessagesApi(fakeConfiguration);

            // Message Request
            messageRequest = new MessageRequest(
                applicationId: Environment.GetEnvironmentVariable("BW_MESSAGING_APPLICATION_ID"),
                to: new List<string> {Environment.GetEnvironmentVariable("USER_NUMBER") },
                from: Environment.GetEnvironmentVariable("BW_NUMBER"),
                text: "c# integration test",
                media: new List<string> { "https://cdn2.thecatapi.com/images/MTY3ODIyMQ.jpg" },
                tag: "c# integration test",
                priority: PriorityEnum.Default
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessagesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<MessagesApi>(instance);
        }

        /// <summary>
        /// Test CreateMessage
        /// </summary>
        [Fact]
        public void CreateMessageTest()
        {
            var response = instance.CreateMessageWithHttpInfo(accountId, messageRequest);
            Assert.Equal(HttpStatusCode.Accepted, response.StatusCode);
            Assert.NotNull(response.Data.ApplicationId);
            Assert.NotNull(response.Data.To);
            Assert.NotNull(response.Data.From);
            Assert.NotNull(response.Data.Owner);
            Assert.NotNull(response.Data.Text);
            Assert.NotNull(response.Data.Media);
            Assert.NotNull(response.Data.Tag);
            Assert.IsType<PriorityEnum>(response.Data.Priority);
            Assert.NotNull(response.Data.Priority);
            Assert.Equal(1, response.Data.SegmentCount);
            Assert.IsType<DateTime>(response.Data.Time);
        }

        /// <summary>
        /// Test CreateMessage with an invalid message request
        /// </summary>
        [Fact]
        public void CreateMessageBadRequest()
        {
            messageRequest.ApplicationId = null; 
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateMessage(accountId, messageRequest));
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test CreateMessage with invalid media
        /// </summary>
        [Fact]
        public void CreateMessageInvalidMedia()
        {
            messageRequest.Media = new List<string> { "not media" }; 
            ApiException Exception = Assert.Throws<ApiException>(() => instance.CreateMessageWithHttpInfo(accountId, messageRequest));
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test CreateMessage with an unauthorized client
        /// </summary>
        [Fact]
        public void CreateMessageUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.CreateMessage(accountId, messageRequest));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test create message with a forbidden client
        /// API does not throw an error
        /// </summary>
        [Fact (Skip = "API does not throw an error")]
        public void CreateMessageForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.CreateMessage(accountId, messageRequest));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test a successful ListMessages request
        /// </summary>
        [Fact]
        public void ListMessagesTest()
        {
            var response = instance.ListMessagesWithHttpInfo(
                accountId: accountId,
                messageDirection: ListMessageDirectionEnum.OUTBOUND,
                messageStatus: MessageStatusEnum.DELIVERED,
                messageType: MessageTypeEnum.Sms
            );
            Assert.IsType<ApiResponse<MessagesList>>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotEqual(0, response.Data.TotalCount);
            Assert.IsType<List<ListMessageItem>>(response.Data.Messages);
            Assert.IsType<ListMessageItem>(response.Data.Messages[0]);

            var message = response.Data.Messages[0];
            Assert.Equal(accountId, message.AccountId);
            Assert.Matches("^\\+[1-9]\\d{1,14}$", message.DestinationTn);
            Assert.Equal(ListMessageDirectionEnum.OUTBOUND, message.MessageDirection);
            Assert.Matches("^.+$", message.MessageId);
            Assert.IsType<MessageStatusEnum>(message.MessageStatus);
            Assert.IsType<MessageTypeEnum>(message.MessageType);
            Assert.NotEqual(0, message.SegmentCount);
            Assert.Matches("^\\+[1-9]\\d{1,14}$", message.SourceTn);
            Assert.IsType<DateTime>(message.ReceiveTime);
        }

        /// <summary>
        /// Test ListMessages without any messages
        /// </summary>
        [Fact]
        public void ListMessagesBadRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => instance.ListMessages(accountId));
            Assert.Equal(400, Exception.ErrorCode);
        }

        /// <summary>
        /// Test ListMessages with an unauthorized client
        /// </summary>
        [Fact]
        public void ListMessagesUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListMessages(accountId));
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test ListMessages with a forbidden client
        /// API throws a 400 rather than a 401
        /// </summary>
        [Fact (Skip = "API throws a 400 rather than a 401")]
        public void ListMessagesForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() => forbiddenInstance.ListMessages(accountId));
            Assert.Equal(401, Exception.ErrorCode);
        }
    }
}
