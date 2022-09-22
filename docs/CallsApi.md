# Bandwidth.Standard.Api.CallsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCall**](CallsApi.md#createcall) | **POST** /accounts/{accountId}/calls | Create Call |
| [**GetCallState**](CallsApi.md#getcallstate) | **GET** /accounts/{accountId}/calls/{callId} | Get Call State Information |
| [**UpdateCall**](CallsApi.md#updatecall) | **POST** /accounts/{accountId}/calls/{callId} | Update Call |
| [**UpdateCallBxml**](CallsApi.md#updatecallbxml) | **PUT** /accounts/{accountId}/calls/{callId}/bxml | Update Call BXML |

<a name="createcall"></a>
# **CreateCall**
> CreateCallResponse CreateCall (string accountId, CreateCall createCall)

Create Call

Creates an outbound phone call.  All calls are initially queued. Your outbound calls will initiated at a specific dequeueing rate, enabling your application to \"fire and forget\" when creating calls. Queued calls may not be modified until they are dequeued and placed, but may be removed from your queue on demand.  <b>Please note:</b> Calls submitted to your queue will be placed approximately in order, but exact ordering is not guaranteed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CallsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID
            var createCall = new CreateCall(); // CreateCall | JSON object containing information to create an outbound call

            try
            {
                // Create Call
                CreateCallResponse result = apiInstance.CreateCall(accountId, createCall);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallsApi.CreateCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Call
    ApiResponse<CreateCallResponse> response = apiInstance.CreateCallWithHttpInfo(accountId, createCall);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallsApi.CreateCallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID |  |
| **createCall** | [**CreateCall**](CreateCall.md) | JSON object containing information to create an outbound call |  |

### Return type

[**CreateCallResponse**](CreateCallResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Call Successfully Created |  * Location - The URL for further interactions with this call <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcallstate"></a>
# **GetCallState**
> CallState GetCallState (string accountId, string callId)

Get Call State Information

Retrieve the current state of a specific call. This information is near-realtime, so it may take a few minutes for your call to be accessible using this endpoint.  **Note**: Call information is kept for 7 days after the calls are hung up. If you attempt to retrieve information for a call that is older than 7 days, you will get an HTTP 404 response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetCallStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CallsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID

            try
            {
                // Get Call State Information
                CallState result = apiInstance.GetCallState(accountId, callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallsApi.GetCallState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCallStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call State Information
    ApiResponse<CallState> response = apiInstance.GetCallStateWithHttpInfo(accountId, callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallsApi.GetCallStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID |  |
| **callId** | **string** | Programmable Voice API Call ID |  |

### Return type

[**CallState**](CallState.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecall"></a>
# **UpdateCall**
> void UpdateCall (string accountId, string callId, UpdateCall updateCall)

Update Call

Interrupts and redirects a call to a different URL that should return a BXML document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CallsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID
            var updateCall = new UpdateCall(); // UpdateCall | JSON object containing information to redirect an existing call to a new BXML document

            try
            {
                // Update Call
                apiInstance.UpdateCall(accountId, callId, updateCall);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallsApi.UpdateCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Call
    apiInstance.UpdateCallWithHttpInfo(accountId, callId, updateCall);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallsApi.UpdateCallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID |  |
| **callId** | **string** | Programmable Voice API Call ID |  |
| **updateCall** | [**UpdateCall**](UpdateCall.md) | JSON object containing information to redirect an existing call to a new BXML document |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call Successfully Modified |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **409** | Conflict |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecallbxml"></a>
# **UpdateCallBxml**
> void UpdateCallBxml (string accountId, string callId, string body)

Update Call BXML

Interrupts and replaces an active call's BXML document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateCallBxmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CallsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID
            var body = <?xml version=\"1.0\" encoding=\"UTF-8\"?>
<Bxml>
  <SpeakSentence>This is a test sentence.</SpeakSentence>
</Bxml>;  // string | 

            try
            {
                // Update Call BXML
                apiInstance.UpdateCallBxml(accountId, callId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CallsApi.UpdateCallBxml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCallBxmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Call BXML
    apiInstance.UpdateCallBxmlWithHttpInfo(accountId, callId, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CallsApi.UpdateCallBxmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID |  |
| **callId** | **string** | Programmable Voice API Call ID |  |
| **body** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Call BXML Successfully Replaced |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **409** | Conflict |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

