# Bandwidth.Standard.Api.RecordingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteRecording**](RecordingsApi.md#deleterecording) | **DELETE** /accounts/{accountId}/calls/{callId}/recordings/{recordingId} | Delete Recording |
| [**DeleteRecordingMedia**](RecordingsApi.md#deleterecordingmedia) | **DELETE** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/media | Delete Recording Media |
| [**DeleteRecordingTranscription**](RecordingsApi.md#deleterecordingtranscription) | **DELETE** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription | Delete Transcription |
| [**DownloadCallRecording**](RecordingsApi.md#downloadcallrecording) | **GET** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/media | Download Recording |
| [**GetCallRecording**](RecordingsApi.md#getcallrecording) | **GET** /accounts/{accountId}/calls/{callId}/recordings/{recordingId} | Get Call Recording |
| [**GetRecordingTranscription**](RecordingsApi.md#getrecordingtranscription) | **GET** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription | Get Transcription |
| [**ListAccountCallRecordings**](RecordingsApi.md#listaccountcallrecordings) | **GET** /accounts/{accountId}/recordings | Get Call Recordings |
| [**ListCallRecordings**](RecordingsApi.md#listcallrecordings) | **GET** /accounts/{accountId}/calls/{callId}/recordings | List Call Recordings |
| [**TranscribeCallRecording**](RecordingsApi.md#transcribecallrecording) | **POST** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription | Create Transcription Request |
| [**UpdateCallRecordingState**](RecordingsApi.md#updatecallrecordingstate) | **PUT** /accounts/{accountId}/calls/{callId}/recording | Update Recording |

<a id="deleterecording"></a>
# **DeleteRecording**
> void DeleteRecording (string accountId, string callId, string recordingId)

Delete Recording

Delete the recording information, media and transcription.  Note: After the deletion is requested and a `204` is returned, neither the recording metadata nor the actual media nor its transcription will be accessible anymore. However, the media of the specified recording is not deleted immediately. This deletion process, while transparent and irreversible, can take an additional 24 to 48 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteRecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Delete Recording
                apiInstance.DeleteRecording(accountId, callId, recordingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.DeleteRecording: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRecordingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Recording
    apiInstance.DeleteRecordingWithHttpInfo(accountId, callId, recordingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.DeleteRecordingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |

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
| **204** | Recording was deleted. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterecordingmedia"></a>
# **DeleteRecordingMedia**
> void DeleteRecordingMedia (string accountId, string callId, string recordingId)

Delete Recording Media

Deletes the specified recording's media.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteRecordingMediaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Delete Recording Media
                apiInstance.DeleteRecordingMedia(accountId, callId, recordingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.DeleteRecordingMedia: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRecordingMediaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Recording Media
    apiInstance.DeleteRecordingMediaWithHttpInfo(accountId, callId, recordingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.DeleteRecordingMediaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |

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
| **204** | The recording media was successfully deleted. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterecordingtranscription"></a>
# **DeleteRecordingTranscription**
> void DeleteRecordingTranscription (string accountId, string callId, string recordingId)

Delete Transcription

Deletes the specified recording's transcription.  Note: After the deletion is requested and a `204` is returned, the transcription will not be accessible anymore. However, it is not deleted immediately. This deletion process, while transparent and irreversible, can take an additional 24 to 48 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteRecordingTranscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Delete Transcription
                apiInstance.DeleteRecordingTranscription(accountId, callId, recordingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.DeleteRecordingTranscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRecordingTranscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Transcription
    apiInstance.DeleteRecordingTranscriptionWithHttpInfo(accountId, callId, recordingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.DeleteRecordingTranscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |

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
| **204** | The transcription was successfully deleted. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadcallrecording"></a>
# **DownloadCallRecording**
> System.IO.Stream DownloadCallRecording (string accountId, string callId, string recordingId)

Download Recording

Downloads the specified recording.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DownloadCallRecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Download Recording
                System.IO.Stream result = apiInstance.DownloadCallRecording(accountId, callId, recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.DownloadCallRecording: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadCallRecordingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download Recording
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadCallRecordingWithHttpInfo(accountId, callId, recordingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.DownloadCallRecordingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |

### Return type

**System.IO.Stream**

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: audio/vnd.wave, audio/mpeg, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Media found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcallrecording"></a>
# **GetCallRecording**
> CallRecordingMetadata GetCallRecording (string accountId, string callId, string recordingId)

Get Call Recording

Returns metadata for the specified recording.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetCallRecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Get Call Recording
                CallRecordingMetadata result = apiInstance.GetCallRecording(accountId, callId, recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.GetCallRecording: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCallRecordingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Recording
    ApiResponse<CallRecordingMetadata> response = apiInstance.GetCallRecordingWithHttpInfo(accountId, callId, recordingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.GetCallRecordingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |

### Return type

[**CallRecordingMetadata**](CallRecordingMetadata.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Recording found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecordingtranscription"></a>
# **GetRecordingTranscription**
> RecordingTranscriptions GetRecordingTranscription (string accountId, string callId, string recordingId)

Get Transcription

Downloads the specified transcription. If the recording was multi-channel, then there will be 2 transcripts. The caller/called party transcript will be the first item while [`<PlayAudio>`](/docs/voice/bxml/playAudio) and [`<SpeakSentence>`](/docs/voice/bxml/speakSentence) transcript will be the second item. During a [`<Transfer>`](/docs/voice/bxml/transfer) the A-leg transcript will be the first item while the B-leg transcript will be the second item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetRecordingTranscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Get Transcription
                RecordingTranscriptions result = apiInstance.GetRecordingTranscription(accountId, callId, recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.GetRecordingTranscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecordingTranscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transcription
    ApiResponse<RecordingTranscriptions> response = apiInstance.GetRecordingTranscriptionWithHttpInfo(accountId, callId, recordingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.GetRecordingTranscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |

### Return type

[**RecordingTranscriptions**](RecordingTranscriptions.md)

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

<a id="listaccountcallrecordings"></a>
# **ListAccountCallRecordings**
> List&lt;CallRecordingMetadata&gt; ListAccountCallRecordings (string accountId, string to = null, string from = null, string minStartTime = null, string maxStartTime = null)

Get Call Recordings

Returns a list of metadata for the recordings associated with the specified account. The list can be filtered by the optional from, to, minStartTime, and maxStartTime arguments. The list is capped at 1000 entries and may be empty if no recordings match the specified criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListAccountCallRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var to = %2b19195551234;  // string | Filter results by the `to` field. (optional) 
            var from = %2b19195554321;  // string | Filter results by the `from` field. (optional) 
            var minStartTime = 2022-06-21T19:13:21Z;  // string | Filter results to recordings which have a `startTime` after or including `minStartTime` (in ISO8601 format). (optional) 
            var maxStartTime = 2022-06-21T19:13:21Z;  // string | Filter results to recordings which have a `startTime` before `maxStartTime` (in ISO8601 format). (optional) 

            try
            {
                // Get Call Recordings
                List<CallRecordingMetadata> result = apiInstance.ListAccountCallRecordings(accountId, to, from, minStartTime, maxStartTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.ListAccountCallRecordings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccountCallRecordingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Call Recordings
    ApiResponse<List<CallRecordingMetadata>> response = apiInstance.ListAccountCallRecordingsWithHttpInfo(accountId, to, from, minStartTime, maxStartTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.ListAccountCallRecordingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **to** | **string** | Filter results by the &#x60;to&#x60; field. | [optional]  |
| **from** | **string** | Filter results by the &#x60;from&#x60; field. | [optional]  |
| **minStartTime** | **string** | Filter results to recordings which have a &#x60;startTime&#x60; after or including &#x60;minStartTime&#x60; (in ISO8601 format). | [optional]  |
| **maxStartTime** | **string** | Filter results to recordings which have a &#x60;startTime&#x60; before &#x60;maxStartTime&#x60; (in ISO8601 format). | [optional]  |

### Return type

[**List&lt;CallRecordingMetadata&gt;**](CallRecordingMetadata.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Recordings retrieved successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcallrecordings"></a>
# **ListCallRecordings**
> List&lt;CallRecordingMetadata&gt; ListCallRecordings (string accountId, string callId)

List Call Recordings

Returns a (potentially empty) list of metadata for the recordings that took place during the specified call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListCallRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.

            try
            {
                // List Call Recordings
                List<CallRecordingMetadata> result = apiInstance.ListCallRecordings(accountId, callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.ListCallRecordings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCallRecordingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Call Recordings
    ApiResponse<List<CallRecordingMetadata>> response = apiInstance.ListCallRecordingsWithHttpInfo(accountId, callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.ListCallRecordingsWithHttpInfo: " + e.Message);
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

[**List&lt;CallRecordingMetadata&gt;**](CallRecordingMetadata.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Recordings retrieved successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="transcribecallrecording"></a>
# **TranscribeCallRecording**
> void TranscribeCallRecording (string accountId, string callId, string recordingId, TranscribeRecording transcribeRecording)

Create Transcription Request

Generate the transcription for a specific recording. Transcription can succeed only for recordings of length greater than 500 milliseconds and less than 4 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class TranscribeCallRecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.
            var transcribeRecording = new TranscribeRecording(); // TranscribeRecording | 

            try
            {
                // Create Transcription Request
                apiInstance.TranscribeCallRecording(accountId, callId, recordingId, transcribeRecording);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.TranscribeCallRecording: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranscribeCallRecordingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Transcription Request
    apiInstance.TranscribeCallRecordingWithHttpInfo(accountId, callId, recordingId, transcribeRecording);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.TranscribeCallRecordingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **recordingId** | **string** | Programmable Voice API Recording ID. |  |
| **transcribeRecording** | [**TranscribeRecording**](TranscribeRecording.md) |  |  |

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
| **204** | Transcription was successfully requested. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecallrecordingstate"></a>
# **UpdateCallRecordingState**
> void UpdateCallRecordingState (string accountId, string callId, UpdateCallRecording updateCallRecording)

Update Recording

Pause or resume a recording on an active phone call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateCallRecordingStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RecordingsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var callId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Call ID.
            var updateCallRecording = new UpdateCallRecording(); // UpdateCallRecording | 

            try
            {
                // Update Recording
                apiInstance.UpdateCallRecordingState(accountId, callId, updateCallRecording);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordingsApi.UpdateCallRecordingState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCallRecordingStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Recording
    apiInstance.UpdateCallRecordingStateWithHttpInfo(accountId, callId, updateCallRecording);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordingsApi.UpdateCallRecordingStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **callId** | **string** | Programmable Voice API Call ID. |  |
| **updateCallRecording** | [**UpdateCallRecording**](UpdateCallRecording.md) |  |  |

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
| **200** | Recording state was successfully modified. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

