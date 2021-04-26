using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Bandwidth.Standard;
using Bandwidth.Standard.Http.Client;
using Xunit;

namespace Bandwidth.StandardTests.Messaging
{
    public class MediaManagementTests
    {
        private BandwidthClient _client;

        public MediaManagementTests()
        {
            _client = new BandwidthClient.Builder()
                .Environment(Bandwidth.Standard.Environment.Production)
                .MessagingBasicAuthCredentials(TestConstants.Username, TestConstants.Password)
                .Build();
        }

        [Fact]
        public async Task UploadAndDownloadMedia()
        {
            var content = "Hello world";

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(content));
            FileStreamInfo fileStreamInfo = new FileStreamInfo(memoryStream);

            var mediaId = string.Concat(TestConstants.RunId, "text-media-id");
            var contentType = "text/plain";

            // Upload the media content.
            await _client.Messaging.APIController.UploadMediaAsync(TestConstants.AccountId, mediaId, fileStreamInfo.FileStream.Length, fileStreamInfo, contentType);
        
            // Get the media content which we've just uploaded.
            var response = await _client.Messaging.APIController.GetMediaAsync(TestConstants.AccountId, mediaId);

            Assert.Equal(200, response.StatusCode);

            Assert.Equal(contentType, response.Headers["Content-Type"]);

            // Validate that the media content is the correct.
            var streamReader = new StreamReader(response.Data);
            var actualContent = streamReader.ReadToEnd();

            Assert.Equal(content, actualContent);

            // Delete the media content.
            await _client.Messaging.APIController.DeleteMediaAsync(TestConstants.AccountId, mediaId);
        }
    }
}