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
    public class EndpointsSmokeTests : IDisposable
    {
        private string accountId;
        private Configuration configuration;
        private Configuration unauthorizedConfiguration;
        private EndpointsApi instance;
        private EndpointsApi unauthorizedInstance;

        public EndpointsSmokeTests()
        {
            accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");

            // Authorized API Client
            configuration = new Configuration();
            configuration.BasePath = "https://api.bandwidth.com/api/v2";
            configuration.OAuthClientId = Environment.GetEnvironmentVariable("BW_CLIENT_ID");
            configuration.OAuthClientSecret = Environment.GetEnvironmentVariable("BW_CLIENT_SECRET");
            instance = new EndpointsApi(configuration);

            // Unauthorized API Client
            unauthorizedConfiguration = new Configuration();
            unauthorizedConfiguration.Username = "badUsername";
            unauthorizedConfiguration.Password = "badPassword";
            unauthorizedInstance = new EndpointsApi(unauthorizedConfiguration);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        [Fact(DisplayName = "Endpoint Lifecycle: Create -> List -> Get -> Delete")]
        public void TestEndpointLifecycle()
        {
            // Create
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/callback",
                eventFallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/fallback",
                tag: "csharp-sdk-test-endpoint"
            );
            var createResponse = instance.CreateEndpointWithHttpInfo(accountId, new CreateEndpointRequest(webRtcRequest));
            Assert.Equal(HttpStatusCode.Created, createResponse.StatusCode);
            Assert.IsType<CreateEndpointResponse>(createResponse.Data);
            Assert.IsType<List<Link>>(createResponse.Data.Links);
            Assert.IsType<List<Error>>(createResponse.Data.Errors);
            Assert.IsType<CreateEndpointResponseData>(createResponse.Data.Data);
            Assert.IsType<string>(createResponse.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, createResponse.Data.Data.Type);
            Assert.IsType<EndpointStatusEnum>(createResponse.Data.Data.Status);
            Assert.IsType<string>(createResponse.Data.Data.Token);
            Assert.IsType<DateTime>(createResponse.Data.Data.CreationTimestamp);
            Assert.IsType<DateTime>(createResponse.Data.Data.ExpirationTimestamp);
            Assert.Equal("csharp-sdk-test-endpoint", createResponse.Data.Data.Tag);
            Assert.IsType<List<Device>>(createResponse.Data.Data.Devices);
            var endpointId = createResponse.Data.Data.EndpointId;

            // List
            var listResponse = instance.ListEndpointsWithHttpInfo(accountId, limit: 10);
            Assert.Equal(HttpStatusCode.OK, listResponse.StatusCode);
            Assert.IsType<ListEndpointsResponse>(listResponse.Data);
            Assert.IsType<List<Link>>(listResponse.Data.Links);
            Assert.IsType<List<Error>>(listResponse.Data.Errors);
            Assert.IsType<List<Endpoints>>(listResponse.Data.Data);
            Assert.NotEmpty(listResponse.Data.Data);
            Assert.NotNull(listResponse.Data.Page);
            Assert.IsType<Page>(listResponse.Data.Page);
            Assert.True(listResponse.Data.Page.PageSize > 0);
            Assert.True(listResponse.Data.Page.TotalElements > 0);
            Assert.True(listResponse.Data.Page.TotalPages > 0);

            var listItem = listResponse.Data.Data.First(e => e.EndpointId == endpointId);
            Assert.IsType<string>(listItem.EndpointId);
            Assert.IsType<EndpointTypeEnum>(listItem.Type);
            Assert.IsType<EndpointStatusEnum>(listItem.Status);
            Assert.IsType<DateTime>(listItem.CreationTimestamp);
            Assert.IsType<DateTime>(listItem.ExpirationTimestamp);

            // Get
            var getResponse = instance.GetEndpointWithHttpInfo(accountId, endpointId);
            Assert.Equal(HttpStatusCode.OK, getResponse.StatusCode);
            Assert.IsType<EndpointResponse>(getResponse.Data);
            Assert.IsType<List<Link>>(getResponse.Data.Links);
            Assert.IsType<List<Error>>(getResponse.Data.Errors);
            Assert.IsType<Endpoint>(getResponse.Data.Data);
            Assert.Equal(endpointId, getResponse.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, getResponse.Data.Data.Type);
            Assert.IsType<EndpointStatusEnum>(getResponse.Data.Data.Status);
            Assert.IsType<DateTime>(getResponse.Data.Data.CreationTimestamp);
            Assert.IsType<DateTime>(getResponse.Data.Data.ExpirationTimestamp);
            Assert.Equal("csharp-sdk-test-endpoint", getResponse.Data.Data.Tag);
            Assert.IsType<List<Device>>(getResponse.Data.Data.Devices);

            // Delete
            var deleteResponse = instance.DeleteEndpointWithHttpInfo(accountId, endpointId);
            Assert.Equal(HttpStatusCode.NoContent, deleteResponse.StatusCode);
        }

        [Fact(DisplayName = "Create Endpoint Unauthorized")]
        public void TestCreateEndpoint_Unauthorized()
        {
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL
            );
            ApiException ex = Assert.Throws<ApiException>(() =>
                unauthorizedInstance.CreateEndpoint(accountId, new CreateEndpointRequest(webRtcRequest))
            );
            Assert.Equal(401, ex.ErrorCode);
        }

        [Fact(DisplayName = "Get Endpoint Not Found")]
        public void TestGetEndpoint_NotFound()
        {
            ApiException ex = Assert.Throws<ApiException>(() =>
                instance.GetEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.ErrorCode);
        }

        [Fact(DisplayName = "Delete Endpoint Not Found")]
        public void TestDeleteEndpoint_NotFound()
        {
            ApiException ex = Assert.Throws<ApiException>(() =>
                instance.DeleteEndpoint(accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.ErrorCode);
        }
    }
}
