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
        /// Test endpoint lifecycle: Create -> List -> Get -> Delete
        /// </summary>
        [Fact]
        public void EndpointLifecycleTest()
        {
            // Create
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/callback",
                eventFallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/fallback",
                tag: "csharp-sdk-test-endpoint"
            );
            ApiResponse<CreateEndpointResponse> createResponse = instance.CreateEndpointWithHttpInfo(accountId, new CreateEndpointRequest(webRtcRequest));
            Assert.Equal(HttpStatusCode.Created, createResponse.StatusCode);
            Assert.IsType<CreateEndpointResponse>(createResponse.Data);
            Assert.IsType<string>(createResponse.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, createResponse.Data.Data.Type);
            Assert.IsType<EndpointStatusEnum>(createResponse.Data.Data.Status);
            Assert.IsType<string>(createResponse.Data.Data.Token);
            Assert.Equal("csharp-sdk-test-endpoint", createResponse.Data.Data.Tag);
            var endpointId = createResponse.Data.Data.EndpointId;

            // List
            ApiResponse<ListEndpointsResponse> listResponse = instance.ListEndpointsWithHttpInfo(accountId, limit: 10);
            Assert.Equal(HttpStatusCode.OK, listResponse.StatusCode);
            Assert.IsType<ListEndpointsResponse>(listResponse.Data);
            Assert.IsType<List<Endpoints>>(listResponse.Data.Data);
            Assert.NotEmpty(listResponse.Data.Data);
            Assert.NotNull(listResponse.Data.Page);
            Assert.IsType<Page>(listResponse.Data.Page);

            // Get
            ApiResponse<EndpointResponse> getResponse = instance.GetEndpointWithHttpInfo(accountId, endpointId);
            Assert.Equal(HttpStatusCode.OK, getResponse.StatusCode);
            Assert.IsType<EndpointResponse>(getResponse.Data);
            Assert.Equal(endpointId, getResponse.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, getResponse.Data.Data.Type);
            Assert.IsType<EndpointStatusEnum>(getResponse.Data.Data.Status);
            Assert.Equal("csharp-sdk-test-endpoint", getResponse.Data.Data.Tag);

            // Delete
            ApiResponse<Object> deleteResponse = instance.DeleteEndpointWithHttpInfo(accountId, endpointId);
            Assert.Equal(HttpStatusCode.NoContent, deleteResponse.StatusCode);
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
