using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Smoke
{
    public class EndpointsSmokeTests : IDisposable
    {
        private readonly EndpointsApi _api;
        private readonly Configuration _configuration;
        private readonly Configuration _unauthorizedConfiguration;
        private readonly string _accountId;
        private readonly List<string> _endpointIds = new();
        private const int TestSleep = 2000;

        public EndpointsSmokeTests()
        {
            _accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            var clientId = Environment.GetEnvironmentVariable("BW_CLIENT_ID");
            var clientSecret = Environment.GetEnvironmentVariable("BW_CLIENT_SECRET");

            // Authorized API Client
            _configuration = new Configuration();
            _configuration.OAuthClientId = clientId;
            _configuration.OAuthClientSecret = clientSecret;
            _api = new EndpointsApi(_configuration);

            // Unauthorized API Client
            _unauthorizedConfiguration = new Configuration();
            _unauthorizedConfiguration.Username = "badUsername";
            _unauthorizedConfiguration.Password = "badPassword";
        }

        public void Dispose()
        {
            // Cleanup endpoints created during tests
            foreach (var endpointId in _endpointIds)
            {
                try
                {
                    _api.DeleteEndpoint(_accountId, endpointId);
                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to cleanup endpoint {endpointId}: {e.Message}");
                }
            }
        }

        [Fact(DisplayName = "Create Endpoint (all params)")]
        public void TestCreateEndpoint_AllParams()
        {
            System.Threading.Thread.Sleep(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/callback",
                eventFallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/fallback",
                tag: "csharp-sdk-test-endpoint"
            );
            var response = _api.CreateEndpointWithHttpInfo(_accountId, createRequest);
            Assert.Equal(201, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Data.Type);
            Assert.NotNull(response.Data.Data.Token);
            _endpointIds.Add(response.Data.Data.EndpointId);
        }

        [Fact(DisplayName = "Create Endpoint (minimal)")]
        public void TestCreateEndpoint_Minimal()
        {
            System.Threading.Thread.Sleep(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.OUTBOUND
            );
            var response = _api.CreateEndpoint(_accountId, createRequest);
            Assert.NotNull(response.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Type);
            Assert.NotNull(response.Data.Token);
            _endpointIds.Add(response.Data.EndpointId);
        }

        [Fact(DisplayName = "Get Endpoint")]
        public void TestGetEndpoint()
        {
            System.Threading.Thread.Sleep(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.INBOUND,
                tag: "test-get-endpoint"
            );
            var createResponse = _api.CreateEndpoint(_accountId, createRequest);
            var endpointId = createResponse.Data.EndpointId;
            _endpointIds.Add(endpointId);
            System.Threading.Thread.Sleep(TestSleep);
            var response = _api.GetEndpointWithHttpInfo(_accountId, endpointId);
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.Equal(endpointId, response.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Data.Type);
            Assert.Equal("test-get-endpoint", response.Data.Data.Tag);
        }

        [Fact(DisplayName = "Get Endpoint Not Found")]
        public void TestGetEndpoint_NotFound()
        {
            System.Threading.Thread.Sleep(TestSleep);
            ApiException ex = Assert.Throws<ApiException>(() =>
                _api.GetEndpoint(_accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.ErrorCode);
        }

        [Fact(DisplayName = "List Endpoints")]
        public void TestListEndpoints()
        {
            System.Threading.Thread.Sleep(TestSleep);
            for (int i = 0; i < 2; i++)
            {
                var createRequest = new CreateWebRtcConnectionRequest(
                    type: EndpointTypeEnum.WEBRTC,
                    direction: EndpointDirectionEnum.BIDIRECTIONAL,
                    tag: $"test-list-endpoint-{i}"
                );
                var createResponse = _api.CreateEndpoint(_accountId, createRequest);
                _endpointIds.Add(createResponse.Data.EndpointId);
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(TestSleep);
            var response = _api.ListEndpointsWithHttpInfo(_accountId, limit: 10);
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.IsType<ListEndpointsResponse>(response.Data);
            Assert.IsType<List<EndpointResponse>>(response.Data.Data);
        }

        [Fact(DisplayName = "List Endpoints With Filter")]
        public void TestListEndpoints_WithFilter()
        {
            System.Threading.Thread.Sleep(TestSleep);
            var response = _api.ListEndpoints(_accountId, type: EndpointTypeEnum.WEBRTC, limit: 5);
            Assert.NotNull(response.Data);
            foreach (var endpoint in response.Data)
            {
                Assert.Equal(EndpointTypeEnum.WEBRTC, endpoint.Type);
            }
        }

        [Fact(DisplayName = "Delete Endpoint")]
        public void TestDeleteEndpoint()
        {
            System.Threading.Thread.Sleep(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                tag: "test-delete-endpoint"
            );
            var createResponse = _api.CreateEndpoint(_accountId, createRequest);
            var endpointId = createResponse.Data.EndpointId;
            System.Threading.Thread.Sleep(TestSleep);
            var response = _api.DeleteEndpointWithHttpInfo(_accountId, endpointId);
            Assert.Equal(204, response.StatusCode);
            System.Threading.Thread.Sleep(TestSleep);
            ApiException ex = Assert.Throws<ApiException>(() =>
                _api.GetEndpoint(_accountId, endpointId)
            );
            Assert.Equal(404, ex.ErrorCode);
        }

        [Fact(DisplayName = "Delete Endpoint Not Found")]
        public void TestDeleteEndpoint_NotFound()
        {
            System.Threading.Thread.Sleep(TestSleep);
            ApiException ex = Assert.Throws<ApiException>(() =>
                _api.DeleteEndpoint(_accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.ErrorCode);
        }

        [Fact(DisplayName = "Create Endpoint Unauthorized")]
        public void TestCreateEndpoint_Unauthorized()
        {
            System.Threading.Thread.Sleep(TestSleep);
            var unauthorizedApi = new EndpointsApi(_unauthorizedConfiguration);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL
            );
            ApiException ex = Assert.Throws<ApiException>(() =>
                unauthorizedApi.CreateEndpoint(_accountId, createRequest)
            );
            Assert.Equal(401, ex.ErrorCode);
        }
    }
}
