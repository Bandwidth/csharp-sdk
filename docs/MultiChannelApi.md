# Bandwidth.Standard.Api.MultiChannelApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMultiChannelMessage**](MultiChannelApi.md#createmultichannelmessage) | **POST** /users/{accountId}/messages/multiChannel | Create Multi-Channel Message |

<a id="createmultichannelmessage"></a>
# **CreateMultiChannelMessage**
> CreateMultiChannelMessageResponse CreateMultiChannelMessage (string accountId, MultiChannelMessageRequest multiChannelMessageRequest)

Create Multi-Channel Message

Endpoint for sending Multi-Channel messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateMultiChannelMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MultiChannelApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var multiChannelMessageRequest = new MultiChannelMessageRequest(); // MultiChannelMessageRequest | 

            try
            {
                // Create Multi-Channel Message
                CreateMultiChannelMessageResponse result = apiInstance.CreateMultiChannelMessage(accountId, multiChannelMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultiChannelApi.CreateMultiChannelMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMultiChannelMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Multi-Channel Message
    ApiResponse<CreateMultiChannelMessageResponse> response = apiInstance.CreateMultiChannelMessageWithHttpInfo(accountId, multiChannelMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MultiChannelApi.CreateMultiChannelMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **multiChannelMessageRequest** | [**MultiChannelMessageRequest**](MultiChannelMessageRequest.md) |  |  |

### Return type

[**CreateMultiChannelMessageResponse**](CreateMultiChannelMessageResponse.md)

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
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

