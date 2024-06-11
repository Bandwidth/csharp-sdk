# Bandwidth.Standard.Api.TranscriptionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteRealTimeTranscription**](TranscriptionsApi.md#deleterealtimetranscription) | **DELETE** /accounts/{accountId}/calls/{callId}/transcriptions/{transcriptionId} | Delete a specific transcription |
| [**GetRealTimeTranscription**](TranscriptionsApi.md#getrealtimetranscription) | **GET** /accounts/{accountId}/calls/{callId}/transcriptions/{transcriptionId} | Retrieve a specific transcription |
| [**ListRealTimeTranscriptions**](TranscriptionsApi.md#listrealtimetranscriptions) | **GET** /accounts/{accountId}/calls/{callId}/transcriptions | Enumerate transcriptions made with StartTranscription |

<a id="deleterealtimetranscription"></a>
# **DeleteRealTimeTranscription**
> void DeleteRealTimeTranscription (string accountId, string callId, string transcriptionId)

Delete a specific transcription

Delete the specified transcription that was created on this call via [startTranscription](/docs/voice/bxml/startTranscription).  Note: After the deletion is requested and a `204` is returned, the transcription will not be accessible anymore. However, it is not deleted immediately. This deletion process, while transparent and irreversible, can take an additional 24 to 48 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteRealTimeTranscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var transcriptionId = t-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Transcription ID.

            try
            {
                // Delete a specific transcription
                apiInstance.DeleteRealTimeTranscription(accountId, callId, transcriptionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionsApi.DeleteRealTimeTranscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRealTimeTranscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific transcription
    apiInstance.DeleteRealTimeTranscriptionWithHttpInfo(accountId, callId, transcriptionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranscriptionsApi.DeleteRealTimeTranscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **transcriptionId** | **string** | Programmable Voice API Transcription ID. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Transcription data was deleted. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrealtimetranscription"></a>
# **GetRealTimeTranscription**
> CallTranscriptionResponse GetRealTimeTranscription (string accountId, string callId, string transcriptionId)

Retrieve a specific transcription

Retrieve the specified transcription that was created on this call via [startTranscription](/docs/voice/bxml/startTranscription).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetRealTimeTranscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var transcriptionId = t-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Transcription ID.

            try
            {
                // Retrieve a specific transcription
                CallTranscriptionResponse result = apiInstance.GetRealTimeTranscription(accountId, callId, transcriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionsApi.GetRealTimeTranscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRealTimeTranscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a specific transcription
    ApiResponse<CallTranscriptionResponse> response = apiInstance.GetRealTimeTranscriptionWithHttpInfo(accountId, callId, transcriptionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranscriptionsApi.GetRealTimeTranscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **transcriptionId** | **string** | Programmable Voice API Transcription ID. |  |

### Return type

[**CallTranscriptionResponse**](CallTranscriptionResponse.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transcription found. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrealtimetranscriptions"></a>
# **ListRealTimeTranscriptions**
> List&lt;CallTranscriptionMetadata&gt; ListRealTimeTranscriptions (string accountId, string callId)

Enumerate transcriptions made with StartTranscription

Enumerates the transcriptions created on this call via [startTranscription](/docs/voice/bxml/startTranscription).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListRealTimeTranscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TranscriptionsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.

            try
            {
                // Enumerate transcriptions made with StartTranscription
                List<CallTranscriptionMetadata> result = apiInstance.ListRealTimeTranscriptions(accountId, callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranscriptionsApi.ListRealTimeTranscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRealTimeTranscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enumerate transcriptions made with StartTranscription
    ApiResponse<List<CallTranscriptionMetadata>> response = apiInstance.ListRealTimeTranscriptionsWithHttpInfo(accountId, callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranscriptionsApi.ListRealTimeTranscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |

### Return type

[**List&lt;CallTranscriptionMetadata&gt;**](CallTranscriptionMetadata.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transcription found. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

