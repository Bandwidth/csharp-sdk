using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xunit;

using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Smoke
{
    /// <summary>
    ///  Class for testing EndpointsApi
    /// </summary>
    public class EndpointsSmokeTests : IDisposable
    {
        private string accountId;
        private Configuration configuration;
        private Configuration unauthorizedConfiguration;
        private Configuration forbiddenConfiguration;
        private EndpointsApi instance;
        private EndpointsApi unauthorizedInstance;
        private EndpointsApi forbiddenInstance;

        public EndpointsSmokeTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

            // Authorized API Client
            configuration = new Configuration();
            configuration.BasePath = "https://api.bandwidth.com/v2";
            configuration.OAuthClientId = Environment.GetEnvironmentVariable("BW_CLIENT_ID");
            configuration.OAuthClientSecret = Environment.GetEnvironmentVariable("BW_CLIENT_SECRET");
            instance = new EndpointsApi(configuration);

            // Unauthorized API Client
            unauthorizedConfiguration = new Configuration();
            unauthorizedConfiguration.Username = "badUsername";
            unauthorizedConfiguration.Password = "badPassword";
            unauthorizedInstance = new EndpointsApi(unauthorizedConfiguration);

            // Forbidden API Client
            forbiddenConfiguration = new Configuration();
            forbiddenConfiguration.Username = Environment.GetEnvironmentVariable("BW_USERNAME_FORBIDDEN");
            forbiddenConfiguration.Password = Environment.GetEnvironmentVariable("BW_PASSWORD_FORBIDDEN");
            forbiddenInstance = new EndpointsApi(forbiddenConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test successful CreateEndpoint request
        /// </summary>
        [Fact]
        public void CreateEndpointTest()
        {
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/callback",
                eventFallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/fallback",
                tag: "csharp-sdk-test-endpoint"
            );
            ApiResponse<CreateEndpointResponse> response = instance.CreateEndpointWithHttpInfo(accountId, new CreateEndpointRequest(webRtcRequest));
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            Assert.IsType<CreateEndpointResponse>(response.Data);
            Assert.IsType<string>(response.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Data.Type);
            Assert.IsType<EndpointStatusEnum>(response.Data.Data.Status);
            Assert.IsType<string>(response.Data.Data.Token);
            Assert.Equal("csharp-sdk-test-endpoint", response.Data.Data.Tag);

            // Cleanup
            instance.DeleteEndpoint(accountId, response.Data.Data.EndpointId);
        }

        /// <summary>
        /// Test CreateEndpoint with an unauthorized client
        /// </summary>
        [Fact]
        public void CreateEndpointUnauthorizedRequest()
        {
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL
            );
            ApiException Exception = Assert.Throws<ApiException>(() =>
                unauthorizedInstance.CreateEndpoint(accountId, new CreateEndpointRequest(webRtcRequest))
            );
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test CreateEndpoint with a forbidden client
        /// </summary>
        [Fact]
        public void CreateEndpointForbiddenRequest()
        {
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL
            );
            ApiException Exception = Assert.Throws<ApiException>(() =>
                forbiddenInstance.CreateEndpoint(accountId, new CreateEndpointRequest(webRtcRequest))
            );
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test successful GetEndpoint request
        /// </summary>
        [Fact]
        public void GetEndpointTest()
        {
            // Create an endpoint to get
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                tag: "csharp-sdk-get-test"
            );
            CreateEndpointResponse createResponse = instance.CreateEndpoint(accountId, new CreateEndpointRequest(webRtcRequest));
            var endpointId = createResponse.Data.EndpointId;

            ApiResponse<EndpointResponse> response = instance.GetEndpointWithHttpInfo(accountId, endpointId);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.IsType<EndpointResponse>(response.Data);
            Assert.Equal(endpointId, response.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Data.Type);
            Assert.IsType<EndpointStatusEnum>(response.Data.Data.Status);
            Assert.Equal("csharp-sdk-get-test", response.Data.Data.Tag);

            // Cleanup
            instance.DeleteEndpoint(accountId, endpointId);
        }

        /// <summary>
        /// Test GetEndpoint with an unauthorized client
        /// </summary>
        [Fact]
        public void GetEndpointUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                unauthorizedInstance.GetEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test GetEndpoint with a forbidden client
        /// </summary>
        [Fact]
        public void GetEndpointForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                forbiddenInstance.GetEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test GetEndpoint with a fake endpoint-id
        /// </summary>
        [Fact]
        public void GetEndpointNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                instance.GetEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, Exception.ErrorCode);
        }

        /// <summary>
        /// Test successful ListEndpoints request
        /// </summary>
        [Fact]
        public void ListEndpointsTest()
        {
            ApiResponse<ListEndpointsResponse> response = instance.ListEndpointsWithHttpInfo(accountId);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.IsType<ListEndpointsResponse>(response.Data);
            Assert.IsType<List<Endpoints>>(response.Data.Data);
            Assert.NotNull(response.Data.Page);
            Assert.IsType<Page>(response.Data.Page);
        }

        /// <summary>
        /// Test ListEndpoints with an unauthorized client
        /// </summary>
        [Fact]
        public void ListEndpointsUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                unauthorizedInstance.ListEndpoints(accountId)
            );
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test ListEndpoints with a forbidden client
        /// </summary>
        [Fact]
        public void ListEndpointsForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                forbiddenInstance.ListEndpoints(accountId)
            );
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test successful DeleteEndpoint request
        /// </summary>
        [Fact]
        public void DeleteEndpointTest()
        {
            // Create an endpoint to delete
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                tag: "csharp-sdk-delete-test"
            );
            CreateEndpointResponse createResponse = instance.CreateEndpoint(accountId, new CreateEndpointRequest(webRtcRequest));
            var endpointId = createResponse.Data.EndpointId;

            ApiResponse<Object> response = instance.DeleteEndpointWithHttpInfo(accountId, endpointId);
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        /// <summary>
        /// Test DeleteEndpoint with an unauthorized client
        /// </summary>
        [Fact]
        public void DeleteEndpointUnauthorizedRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                unauthorizedInstance.DeleteEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(401, Exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteEndpoint with a forbidden client
        /// </summary>
        [Fact]
        public void DeleteEndpointForbiddenRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                forbiddenInstance.DeleteEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(403, Exception.ErrorCode);
        }

        /// <summary>
        /// Test DeleteEndpoint with a fake endpoint-id
        /// </summary>
        [Fact]
        public void DeleteEndpointNotFoundRequest()
        {
            ApiException Exception = Assert.Throws<ApiException>(() =>
                instance.DeleteEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, Exception.ErrorCode);
        }
    }
}
