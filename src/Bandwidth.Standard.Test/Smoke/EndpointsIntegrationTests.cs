using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Bandwidth.Standard;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Model;
using Bandwidth.Standard.Exceptions;

namespace Bandwidth.Standard.Test.Smoke
{
    public class EndpointsIntegrationTests : IAsyncLifetime
    {
        private readonly EndpointsApi _api;
        private readonly string _accountId;
        private readonly List<string> _endpointIds = new();
        private const int TestSleep = 2000;

        public EndpointsIntegrationTests()
        {
            // These should be set from environment variables or test config
            _accountId = Environment.GetEnvironmentVariable("BW_ACCOUNT_ID");
            var clientId = Environment.GetEnvironmentVariable("BW_CLIENT_ID");
            var clientSecret = Environment.GetEnvironmentVariable("BW_CLIENT_SECRET");
            var config = new Configuration(clientId, clientSecret);
            var client = new ApiClient(config);
            _api = new EndpointsApi(client);
        }

        public async Task InitializeAsync()
        {
            // No setup needed
            await Task.CompletedTask;
        }

        public async Task DisposeAsync()
        {
            // Cleanup endpoints created during tests
            foreach (var endpointId in _endpointIds)
            {
                try
                {
                    await _api.DeleteEndpointAsync(_accountId, endpointId);
                    await Task.Delay(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to cleanup endpoint {endpointId}: {e.Message}");
                }
            }
        }

        [Fact(DisplayName = "Create Endpoint (all params)")]
        public async Task TestCreateEndpoint_AllParams()
        {
            await Task.Delay(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                eventCallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/callback",
                eventFallbackUrl: Environment.GetEnvironmentVariable("BASE_CALLBACK_URL") + "/endpoint/fallback",
                tag: "csharp-sdk-test-endpoint"
            );
            var response = await _api.CreateEndpointWithHttpInfoAsync(_accountId, createRequest);
            Assert.Equal(201, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Data.Type);
            Assert.NotNull(response.Data.Data.Token);
            _endpointIds.Add(response.Data.Data.EndpointId);
        }

        [Fact(DisplayName = "Create Endpoint (minimal)")]
        public async Task TestCreateEndpoint_Minimal()
        {
            await Task.Delay(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.OUTBOUND
            );
            var response = await _api.CreateEndpointAsync(_accountId, createRequest);
            Assert.NotNull(response.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Type);
            Assert.NotNull(response.Data.Token);
            _endpointIds.Add(response.Data.EndpointId);
        }

        [Fact(DisplayName = "Get Endpoint")]
        public async Task TestGetEndpoint()
        {
            await Task.Delay(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.INBOUND,
                tag: "test-get-endpoint"
            );
            var createResponse = await _api.CreateEndpointAsync(_accountId, createRequest);
            var endpointId = createResponse.Data.EndpointId;
            _endpointIds.Add(endpointId);
            await Task.Delay(TestSleep);
            var response = await _api.GetEndpointWithHttpInfoAsync(_accountId, endpointId);
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.Equal(endpointId, response.Data.Data.EndpointId);
            Assert.Equal(EndpointTypeEnum.WEBRTC, response.Data.Data.Type);
            Assert.Equal("test-get-endpoint", response.Data.Data.Tag);
        }

        [Fact(DisplayName = "Get Endpoint Not Found")]
        public async Task TestGetEndpoint_NotFound()
        {
            await Task.Delay(TestSleep);
            var ex = await Assert.ThrowsAsync<ApiException>(async () =>
                await _api.GetEndpointAsync(_accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.Status);
        }

        [Fact(DisplayName = "List Endpoints")]
        public async Task TestListEndpoints()
        {
            await Task.Delay(TestSleep);
            for (int i = 0; i < 2; i++)
            {
                var createRequest = new CreateWebRtcConnectionRequest(
                    type: EndpointTypeEnum.WEBRTC,
                    direction: EndpointDirectionEnum.BIDIRECTIONAL,
                    tag: $"test-list-endpoint-{i}"
                );
                var createResponse = await _api.CreateEndpointAsync(_accountId, createRequest);
                _endpointIds.Add(createResponse.Data.EndpointId);
                await Task.Delay(1000);
            }
            await Task.Delay(TestSleep);
            var response = await _api.ListEndpointsWithHttpInfoAsync(_accountId, limit: 10);
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.IsType<ListEndpointsResponse>(response.Data);
            Assert.IsType<List<EndpointResponse>>(response.Data.Data);
        }

        [Fact(DisplayName = "List Endpoints With Filter")]
        public async Task TestListEndpoints_WithFilter()
        {
            await Task.Delay(TestSleep);
            var response = await _api.ListEndpointsAsync(_accountId, type: EndpointTypeEnum.WEBRTC, limit: 5);
            Assert.NotNull(response.Data);
            foreach (var endpoint in response.Data)
            {
                Assert.Equal(EndpointTypeEnum.WEBRTC, endpoint.Type);
            }
        }

        [Fact(DisplayName = "Delete Endpoint")]
        public async Task TestDeleteEndpoint()
        {
            await Task.Delay(TestSleep);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL,
                tag: "test-delete-endpoint"
            );
            var createResponse = await _api.CreateEndpointAsync(_accountId, createRequest);
            var endpointId = createResponse.Data.EndpointId;
            await Task.Delay(TestSleep);
            var response = await _api.DeleteEndpointWithHttpInfoAsync(_accountId, endpointId);
            Assert.Equal(204, response.StatusCode);
            await Task.Delay(TestSleep);
            var ex = await Assert.ThrowsAsync<ApiException>(async () =>
                await _api.GetEndpointAsync(_accountId, endpointId)
            );
            Assert.Equal(404, ex.Status);
        }

        [Fact(DisplayName = "Delete Endpoint Not Found")]
        public async Task TestDeleteEndpoint_NotFound()
        {
            await Task.Delay(TestSleep);
            var ex = await Assert.ThrowsAsync<ApiException>(async () =>
                await _api.DeleteEndpointAsync(_accountId, "non-existent-endpoint-id")
            );
            Assert.Equal(404, ex.Status);
        }

        [Fact(DisplayName = "Create Endpoint Unauthorized")]
        public async Task TestCreateEndpoint_Unauthorized()
        {
            await Task.Delay(TestSleep);
            var config = new Configuration(); // No credentials
            var client = new ApiClient(config);
            var unauthorizedApi = new EndpointsApi(client);
            var createRequest = new CreateWebRtcConnectionRequest(
                type: EndpointTypeEnum.WEBRTC,
                direction: EndpointDirectionEnum.BIDIRECTIONAL
            );
            var ex = await Assert.ThrowsAsync<ApiException>(async () =>
                await unauthorizedApi.CreateEndpointAsync(_accountId, createRequest)
            );
            Assert.Equal(401, ex.Status);
        }
    }
}
