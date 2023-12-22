# Bandwidth.Standard.Api.PhoneNumberLookupApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLookup**](PhoneNumberLookupApi.md#createlookup) | **POST** /accounts/{accountId}/tnlookup | Create Lookup |
| [**GetLookupStatus**](PhoneNumberLookupApi.md#getlookupstatus) | **GET** /accounts/{accountId}/tnlookup/{requestId} | Get Lookup Request Status |

<a id="createlookup"></a>
# **CreateLookup**
> CreateLookupResponse CreateLookup (string accountId, LookupRequest lookupRequest)

Create Lookup

Create a Phone Number Lookup Request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PhoneNumberLookupApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var lookupRequest = new LookupRequest(); // LookupRequest | Phone number lookup request.

            try
            {
                // Create Lookup
                CreateLookupResponse result = apiInstance.CreateLookup(accountId, lookupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberLookupApi.CreateLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Lookup
    ApiResponse<CreateLookupResponse> response = apiInstance.CreateLookupWithHttpInfo(accountId, lookupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberLookupApi.CreateLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **lookupRequest** | [**LookupRequest**](LookupRequest.md) | Phone number lookup request. |  |

### Return type

[**CreateLookupResponse**](CreateLookupResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlookupstatus"></a>
# **GetLookupStatus**
> LookupStatus GetLookupStatus (string accountId, string requestId)

Get Lookup Request Status

Get an existing Phone Number Lookup Request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetLookupStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PhoneNumberLookupApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var requestId = 004223a0-8b17-41b1-bf81-20732adf5590;  // string | The phone number lookup request ID from Bandwidth.

            try
            {
                // Get Lookup Request Status
                LookupStatus result = apiInstance.GetLookupStatus(accountId, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumberLookupApi.GetLookupStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLookupStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Lookup Request Status
    ApiResponse<LookupStatus> response = apiInstance.GetLookupStatusWithHttpInfo(accountId, requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PhoneNumberLookupApi.GetLookupStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **requestId** | **string** | The phone number lookup request ID from Bandwidth. |  |

### Return type

[**LookupStatus**](LookupStatus.md)

### Authorization

[Basic](../README.md#Basic)

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
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

