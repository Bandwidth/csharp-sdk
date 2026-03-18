using System;
using System.Collections.Generic;
using System.Net;
using Xunit;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Smoke
{
    public class EndpointsSmokeTests
    {
        private readonly EndpointsApi _api;
        private readonly Configuration _unauthorizedConfiguration;
        private readonly string _accountId;

        public EndpointsSmokeTests()
        {
            _accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            var clientId = Environment.GetEnvironmentVariable("BW_CLIENT_ID");
            var clientSecret = Environment.GetEnvironmentVariable("BW_CLIENT_SECRET");

            // Authorized API Client
            _api = new EndpointsApi(new Configuration
            {
                OAuthClientId = clientId,
                OAuthClientSecret = clientSecret
            });

            // Unauthorized API Client
            _unauthorizedConfiguration = new Configuration
            {
                Username = "badUsername",
                Password = "badPassword"
            };
        }

        [Fact(DisplayName = "Endpoint Lifecycle: Create → List → Get → Delete")]
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
            var createResponse = _api.CreateEndpointWithHttpInfo(_accountId, new CreateEndpointRequest(webRtcRequest));
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
            var listResponse = _api.ListEndpointsWithHttpInfo(_accountId, limit: 10);
            Assert.Equal(HttpStatusCode.OK, listResponse.StatusCode);
            Assert.IsType<ListEndpointsResponse>(listResponse.Data);
            Assert.IsType<List<Link>>(listResponse.Data.Links);
            Assert.IsType<List<Error>>(listResponse.Data.Errors);
            Assert.IsType<List<Endpoints>>(listResponse.Data.Data);

            // List with filter
            var filteredResponse = _api.ListEndpoints(_accountId, type: EndpointTypeEnum.WEBRTC, limit: 5);
            Assert.IsType<List<Endpoints>>(filteredResponse.Data);
            foreach (var endpoint in filteredResponse.Data)
            {
                Assert.Equal(EndpointTypeEnum.WEBRTC, endpoint.Type);
            }

            // Get
            var getResponse = _api.GetEndpointWithHttpInfo(_accountId, endpointId);
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
            var deleteResponse = _api.DeleteEndpointWithHttpInfo(_accountId, endpointId);
            Assert.Equal(HttpStatusCode.NoContent, deleteResponse.StatusCode);
        }

        [Fact(DisplayName = "Create Endpoint Unauthorized")]
        public void TestCreateEndpoint_Unauthorized()
        {
            var unauthorizedApi = new EndpointsApi(_unauthorizedConfiguration);
            var webRtcRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL
            );
            ApiException ex = Assert.Throws<ApiException>(() =>
                unauthorizedApi.CreateEndpoint(_accountId, new CreateEndpointRequest(webRtcRequest))
            );
            Assert.Equal(401, ex.ErrorCode);
        }

        [Fact(DisplayName = "Get Endpoint Not Found")]
        public void TestGetEndpoint_NotFound()
        {
            ApiException ex = Assert.Throws<ApiException>(() =>
                _api.GetEndpoint(_accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.ErrorCode);
        }

        [Fact(DisplayName = "Delete Endpoint Not Found")]
        public void TestDeleteEndpoint_NotFound()
        {
            ApiException ex = Assert.Throws<ApiException>(() =>
                _api.DeleteEndpoint(_accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.ErrorCode);
        }
    }
}
