# Bandwidth.Standard.Api.EndpointsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEndpoint**](EndpointsApi.md#createendpoint) | **POST** /accounts/{accountId}/endpoints | Create Endpoint |
| [**DeleteEndpoint**](EndpointsApi.md#deleteendpoint) | **DELETE** /accounts/{accountId}/endpoints/{endpointId} | Delete Endpoint |
| [**GetEndpoint**](EndpointsApi.md#getendpoint) | **GET** /accounts/{accountId}/endpoints/{endpointId} | Get Endpoint |
| [**ListEndpoints**](EndpointsApi.md#listendpoints) | **GET** /accounts/{accountId}/endpoints | List Endpoints |
| [**UpdateEndpointBxml**](EndpointsApi.md#updateendpointbxml) | **PUT** /accounts/{accountId}/endpoints/{endpointId}/bxml | Update Endpoint BXML |

<a id="createendpoint"></a>
# **CreateEndpoint**
> CreateEndpointResponse CreateEndpoint (string accountId, CreateEndpointRequest createEndpointRequest)

Create Endpoint

Creates a new Endpoint for the specified account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var createEndpointRequest = new CreateEndpointRequest(); // CreateEndpointRequest | 

            try
            {
                // Create Endpoint
                CreateEndpointResponse result = apiInstance.CreateEndpoint(accountId, createEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.CreateEndpoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEndpointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Endpoint
    ApiResponse<CreateEndpointResponse> response = apiInstance.CreateEndpointWithHttpInfo(accountId, createEndpointRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsApi.CreateEndpointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **createEndpointRequest** | [**CreateEndpointRequest**](CreateEndpointRequest.md) |  |  |

### Return type

[**CreateEndpointResponse**](CreateEndpointResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteendpoint"></a>
# **DeleteEndpoint**
> void DeleteEndpoint (string accountId, string endpointId)

Delete Endpoint

Deletes the specified endpoint. If the endpoint is actively streaming media, the media stream will be terminated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var endpointId = e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | BRTC Endpoint ID.

            try
            {
                // Delete Endpoint
                apiInstance.DeleteEndpoint(accountId, endpointId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.DeleteEndpoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEndpointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Endpoint
    apiInstance.DeleteEndpointWithHttpInfo(accountId, endpointId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsApi.DeleteEndpointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **endpointId** | **string** | BRTC Endpoint ID. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getendpoint"></a>
# **GetEndpoint**
> EndpointResponse GetEndpoint (string accountId, string endpointId)

Get Endpoint

Returns information about the specified endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var endpointId = e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | BRTC Endpoint ID.

            try
            {
                // Get Endpoint
                EndpointResponse result = apiInstance.GetEndpoint(accountId, endpointId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetEndpoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEndpointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Endpoint
    ApiResponse<EndpointResponse> response = apiInstance.GetEndpointWithHttpInfo(accountId, endpointId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsApi.GetEndpointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **endpointId** | **string** | BRTC Endpoint ID. |  |

### Return type

[**EndpointResponse**](EndpointResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listendpoints"></a>
# **ListEndpoints**
> ListEndpointsResponse ListEndpoints (string accountId, EndpointTypeEnum? type = null, EndpointStatusEnum? status = null, string afterCursor = null, int? limit = null)

List Endpoints

Returns a list of endpoints associated with the specified account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListEndpointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var type = (EndpointTypeEnum) "WEBRTC";  // EndpointTypeEnum? | The type of endpoint. (optional) 
            var status = (EndpointStatusEnum) "CONNECTED";  // EndpointStatusEnum? | The status of the endpoint. (optional) 
            var afterCursor = TWF5IHRoZSBmb3JjZSBiZSB3aXRoIHlvdQ==;  // string | The cursor to use for pagination. This is the value of the `next` link in the previous response. (optional) 
            var limit = 2;  // int? | The maximum number of endpoints to return in the response. (optional)  (default to 100)

            try
            {
                // List Endpoints
                ListEndpointsResponse result = apiInstance.ListEndpoints(accountId, type, status, afterCursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.ListEndpoints: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEndpointsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Endpoints
    ApiResponse<ListEndpointsResponse> response = apiInstance.ListEndpointsWithHttpInfo(accountId, type, status, afterCursor, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsApi.ListEndpointsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **type** | **EndpointTypeEnum?** | The type of endpoint. | [optional]  |
| **status** | **EndpointStatusEnum?** | The status of the endpoint. | [optional]  |
| **afterCursor** | **string** | The cursor to use for pagination. This is the value of the &#x60;next&#x60; link in the previous response. | [optional]  |
| **limit** | **int?** | The maximum number of endpoints to return in the response. | [optional] [default to 100] |

### Return type

[**ListEndpointsResponse**](ListEndpointsResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateendpointbxml"></a>
# **UpdateEndpointBxml**
> void UpdateEndpointBxml (string accountId, string endpointId, string body)

Update Endpoint BXML

Updates the BXML for the specified endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateEndpointBxmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EndpointsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var endpointId = e-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | BRTC Endpoint ID.
            var body = "body_example";  // string | 

            try
            {
                // Update Endpoint BXML
                apiInstance.UpdateEndpointBxml(accountId, endpointId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.UpdateEndpointBxml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEndpointBxmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Endpoint BXML
    apiInstance.UpdateEndpointBxmlWithHttpInfo(accountId, endpointId, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EndpointsApi.UpdateEndpointBxmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **endpointId** | **string** | BRTC Endpoint ID. |  |
| **body** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

