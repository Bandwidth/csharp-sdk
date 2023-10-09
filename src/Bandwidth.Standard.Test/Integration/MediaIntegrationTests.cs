using System;
using System.IO;
using System.Collections.Generic;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using System.Net;

namespace Bandwidth.Standard.Test.Integration
{
    /// <summary>
    ///  Class for testing MediaApi
    /// </summary>
    public class MediaIntegrationTests : IDisposable
    {
        private string accountId;
        private Configuration fakeConfiguration;
        private MediaApi instance;
        private string testMediaId;
        private string testContentType;
        private string filePath;
        private MediaApi unauthorizedInstance;


        public MediaIntegrationTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            testContentType = "image/jpeg";
            testMediaId = $"test-media-id-{Guid.NewGuid()}";
            // Authorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://voice.bandwidth.com/api/v2";
            fakeConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME");
            fakeConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD");
            instance = new MediaApi(fakeConfiguration);

            // Unauthorized API Client
            fakeConfiguration = new Configuration();
            fakeConfiguration.BasePath = "https://messaging.bandwidth.com/api/v2";
            fakeConfiguration.Username = "badUsername";
            fakeConfiguration.Password = "badPassword";
            unauthorizedInstance = new MediaApi(fakeConfiguration);

            // Create a media file to use for testing
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = "../../../Fixtures/csharp_cat.jpeg";
            filePath = Path.Combine(baseDirectory, relativePath);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MediaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<MediaApi>(instance);
        }

        /// <summary>
        /// Test successful UploadMedia Request
        /// </summary>
        [Fact]
        public void UploadMediaTest()
        {
            var testMediaBody = new System.IO.FileStream(filePath, FileMode.Open);
            var responseWithHttpInfo = instance.UploadMediaWithHttpInfo(accountId, testMediaId, testMediaBody, testContentType);
            Assert.IsType<ApiResponse<Object>>(responseWithHttpInfo);
            Assert.Equal(HttpStatusCode.NoContent, responseWithHttpInfo.StatusCode);
            testMediaBody.Close();
        }

        /// <summary>
        /// Test UploadMedia with an unauthorized client
        /// /// </summary>
        [Fact]
        public void UploadMediaUnauthorized()
        {
            var testMediaBody = new System.IO.FileStream(filePath, FileMode.Open);
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.UploadMediaWithHttpInfo(accountId, testMediaId, testMediaBody, testContentType));
            Assert.Equal(401, exception.ErrorCode);
            testMediaBody.Close();
        }

        /// <summary>
        /// Test UploadMedia with a forbidden client
        /// </summary>
        [Fact]
        public void UploadMediaForbidden()
        {
            var testMediaBody = new System.IO.FileStream(filePath, FileMode.Open);
            ApiException exception = Assert.Throws<ApiException>(() => instance.UploadMediaWithHttpInfo("not-an-account-id", testMediaId, testMediaBody, testContentType));
            Assert.Equal(403, exception.ErrorCode);
            testMediaBody.Close();
        }

        /// <summary>
        /// Test successful ListMedia Request
        /// </summary>
        [Fact]
        public void ListMediaTest()
        {
            var responseWithHttpInfo = instance.ListMediaWithHttpInfo(accountId);
            Assert.Equal(HttpStatusCode.OK, responseWithHttpInfo.StatusCode);

            var response = instance.ListMedia(accountId);
            Assert.IsType<List<Media>>(response);
            Assert.IsType<Media>(response[0]);
        }

        /// <summary>
        /// Test ListMedia with an unauthorized client
        /// </summary>
        [Fact]
        public void ListMediaUnauthorized()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.ListMediaWithHttpInfo(accountId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test ListMedia with a forbidden client 
        /// </summary>
        [Fact]
        public void ListMediaForbidden()
        {
            ApiException exception = Assert.Throws<ApiException>(() => instance.ListMediaWithHttpInfo("not-an-account-id"));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test successful GetMedia Request
        /// </summary>
        [Fact]
        public void GetMediaTest()
        {  
            var testMediaBody = new System.IO.FileStream(filePath, FileMode.Open);
            var uploadResponse = instance.UploadMediaWithHttpInfo(accountId, testMediaId, testMediaBody, testContentType);

            var responseWithHttpInfo = instance.GetMediaWithHttpInfo(accountId, testMediaId);
            Assert.Equal(HttpStatusCode.OK, responseWithHttpInfo.StatusCode);

            var response = instance.GetMedia(accountId, testMediaId);
            Assert.IsAssignableFrom<System.IO.Stream>(response);
            testMediaBody.Close();
        }

        /// <summary>
        /// Test GetMedia with an unauthorized client
        /// </summary>
        [Fact]
        public void GetMediaUnauthorized()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.GetMediaWithHttpInfo(accountId, testMediaId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetMedia with a forbidden client
        /// </summary>
        [Fact]
        public void GetMediaForbidden()
        {
            ApiException exception = Assert.Throws<ApiException>(() => instance.GetMediaWithHttpInfo("not-an-account-id", testMediaId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test GetMedia with a fake media id
        /// </summary>
        [Fact]
        public void GetMediaNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => instance.GetMediaWithHttpInfo(accountId, "not-a-media-id.jpg"));
            Assert.Equal(404, exception.ErrorCode);
        }

        /// <summary>
        /// Test successful DeleteMedia Request
        /// </summary>
        [Fact]
        public void DeleteMediaTest()
        {
            var testMediaBody = new System.IO.FileStream(filePath, FileMode.Open);
            var uploadResponse = instance.UploadMediaWithHttpInfo(accountId, testMediaId, testMediaBody, testContentType);

            var responseWithHttpInfo = instance.DeleteMediaWithHttpInfo(accountId, testMediaId);
            Assert.Equal(HttpStatusCode.NoContent, responseWithHttpInfo.StatusCode);
            testMediaBody.Close();
        }

        /// <summary>
        /// Test DeleteMedia with an unauthorized client
        /// </summary>
        [Fact]
        public void DeleteMediaUnauthorized()
        {
            ApiException exception = Assert.Throws<ApiException>(() => unauthorizedInstance.DeleteMediaWithHttpInfo(accountId, testMediaId));
            Assert.Equal(401, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteMedia with a forbidden client
        /// </summary>
        [Fact]
        public void DeleteMediaForbidden()
        {
            ApiException exception = Assert.Throws<ApiException>(() => instance.DeleteMediaWithHttpInfo("not-an-account-id", testMediaId));
            Assert.Equal(403, exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteMedia with a fake media id
        /// API does not throw an exception
        /// </summary>
        [Fact (Skip = "API does not throw an exception")]
        public void DeleteMediaNotFound()
        {
            ApiException exception = Assert.Throws<ApiException>(() => instance.DeleteMediaWithHttpInfo(accountId, "not-a-media-id.jpg"));
            Assert.Equal(404, exception.ErrorCode);
        }
    }
}
