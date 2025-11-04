# Bandwidth.Standard.Api.PhoneNumberLookupApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAsyncBulkLookup**](PhoneNumberLookupApi.md#createasyncbulklookup) | **POST** /accounts/{accountId}/phoneNumberLookup/bulk | Create Asynchronous Bulk Number Lookup |
| [**CreateSyncLookup**](PhoneNumberLookupApi.md#createsynclookup) | **POST** /accounts/{accountId}/phoneNumberLookup | Create Synchronous Number Lookup |
| [**GetAsyncBulkLookup**](PhoneNumberLookupApi.md#getasyncbulklookup) | **GET** /accounts/{accountId}/phoneNumberLookup/bulk/{requestId} | Get Asynchronous Bulk Number Lookup |

<a id="createasyncbulklookup"></a>
# **CreateAsyncBulkLookup**
> CreateAsyncBulkLookupResponse CreateAsyncBulkLookup (string accountId, AsyncLookupRequest asyncLookupRequest)

Create Asynchronous Bulk Number Lookup

Creates an asynchronous bulk phone number lookup request. Maximum of 15,000 telephone numbers per request. Use the [Get Asynchronous Bulk Number Lookup](#tag/Phone-Number-Lookup/operation/getAsyncBulkLookup) endpoint to check the status of the request and view the results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateAsyncBulkLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PhoneNumberLookupApi(config);
            var accountId = 9900000;  // string | 
            var asyncLookupRequest = new AsyncLookupRequest(); // AsyncLookupRequest | Asynchronous bulk phone number lookup request.

            try
            {
                // Create Asynchronous Bulk Number Lookup
                CreateAsyncBulkLookupResponse result = apiInstance.CreateAsyncBulkLookup(accountId, asyncLookupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberLookupApi.CreateAsyncBulkLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAsyncBulkLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Asynchronous Bulk Number Lookup
    ApiResponse<CreateAsyncBulkLookupResponse> response = apiInstance.CreateAsyncBulkLookupWithHttpInfo(accountId, asyncLookupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberLookupApi.CreateAsyncBulkLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** |  |  |
| **asyncLookupRequest** | [**AsyncLookupRequest**](AsyncLookupRequest.md) | Asynchronous bulk phone number lookup request. |  |

### Return type

[**CreateAsyncBulkLookupResponse**](CreateAsyncBulkLookupResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **0** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsynclookup"></a>
# **CreateSyncLookup**
> CreateSyncLookupResponse CreateSyncLookup (string accountId, SyncLookupRequest syncLookupRequest)

Create Synchronous Number Lookup

Creates a synchronous phone number lookup request. Maximum of 100 telephone numbers per request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateSyncLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PhoneNumberLookupApi(config);
            var accountId = 9900000;  // string | 
            var syncLookupRequest = new SyncLookupRequest(); // SyncLookupRequest | Synchronous phone number lookup request.

            try
            {
                // Create Synchronous Number Lookup
                CreateSyncLookupResponse result = apiInstance.CreateSyncLookup(accountId, syncLookupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberLookupApi.CreateSyncLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSyncLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Synchronous Number Lookup
    ApiResponse<CreateSyncLookupResponse> response = apiInstance.CreateSyncLookupWithHttpInfo(accountId, syncLookupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberLookupApi.CreateSyncLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** |  |  |
| **syncLookupRequest** | [**SyncLookupRequest**](SyncLookupRequest.md) | Synchronous phone number lookup request. |  |

### Return type

[**CreateSyncLookupResponse**](CreateSyncLookupResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getasyncbulklookup"></a>
# **GetAsyncBulkLookup**
> GetAsyncBulkLookupResponse GetAsyncBulkLookup (string accountId, Guid requestId)

Get Asynchronous Bulk Number Lookup

Get an existing [Asynchronous Bulk Number Lookup](#tag/Phone-Number-Lookup/operation/createAsyncBulkLookup). Use this endpoint to check the status of the request and view the results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetAsyncBulkLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PhoneNumberLookupApi(config);
            var accountId = 9900000;  // string | 
            var requestId = 004223a0-8b17-41b1-bf81-20732adf5590;  // Guid | 

            try
            {
                // Get Asynchronous Bulk Number Lookup
                GetAsyncBulkLookupResponse result = apiInstance.GetAsyncBulkLookup(accountId, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberLookupApi.GetAsyncBulkLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAsyncBulkLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asynchronous Bulk Number Lookup
    ApiResponse<GetAsyncBulkLookupResponse> response = apiInstance.GetAsyncBulkLookupWithHttpInfo(accountId, requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberLookupApi.GetAsyncBulkLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** |  |  |
| **requestId** | **Guid** |  |  |

### Return type

[**GetAsyncBulkLookupResponse**](GetAsyncBulkLookupResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

