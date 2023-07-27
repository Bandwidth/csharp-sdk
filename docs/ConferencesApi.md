# Bandwidth.Standard.Api.ConferencesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadConferenceRecording**](ConferencesApi.md#downloadconferencerecording) | **GET** /accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId}/media | Download Conference Recording
[**GetConference**](ConferencesApi.md#getconference) | **GET** /accounts/{accountId}/conferences/{conferenceId} | Get Conference Information
[**GetConferenceMember**](ConferencesApi.md#getconferencemember) | **GET** /accounts/{accountId}/conferences/{conferenceId}/members/{memberId} | Get Conference Member
[**GetConferenceRecording**](ConferencesApi.md#getconferencerecording) | **GET** /accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId} | Get Conference Recording Information
[**ListConferenceRecordings**](ConferencesApi.md#listconferencerecordings) | **GET** /accounts/{accountId}/conferences/{conferenceId}/recordings | Get Conference Recordings
[**ListConferences**](ConferencesApi.md#listconferences) | **GET** /accounts/{accountId}/conferences | Get Conferences
[**UpdateConference**](ConferencesApi.md#updateconference) | **POST** /accounts/{accountId}/conferences/{conferenceId} | Update Conference
[**UpdateConferenceBxml**](ConferencesApi.md#updateconferencebxml) | **PUT** /accounts/{accountId}/conferences/{conferenceId}/bxml | Update Conference BXML
[**UpdateConferenceMember**](ConferencesApi.md#updateconferencemember) | **PUT** /accounts/{accountId}/conferences/{conferenceId}/members/{memberId} | Update Conference Member



## DownloadConferenceRecording

> System.IO.Stream DownloadConferenceRecording (string accountId, string conferenceId, string recordingId)

Download Conference Recording

Downloads the specified recording file.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DownloadConferenceRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Download Conference Recording
                System.IO.Stream result = apiInstance.DownloadConferenceRecording(accountId, conferenceId, recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.DownloadConferenceRecording: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 
 **recordingId** | **string**| Programmable Voice API Recording ID. | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConference

> Conference GetConference (string accountId, string conferenceId)

Get Conference Information

Returns information about the specified conference.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetConferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.

            try
            {
                // Get Conference Information
                Conference result = apiInstance.GetConference(accountId, conferenceId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.GetConference: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 

### Return type

[**Conference**](Conference.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conferences retrieved successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConferenceMember

> ConferenceMember GetConferenceMember (string accountId, string conferenceId, string memberId)

Get Conference Member

Returns information about the specified conference member.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetConferenceMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.
            var memberId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Conference Member ID.

            try
            {
                // Get Conference Member
                ConferenceMember result = apiInstance.GetConferenceMember(accountId, conferenceId, memberId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.GetConferenceMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 
 **memberId** | **string**| Programmable Voice API Conference Member ID. | 

### Return type

[**ConferenceMember**](ConferenceMember.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conference member found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetConferenceRecording

> ConferenceRecordingMetadata GetConferenceRecording (string accountId, string conferenceId, string recordingId)

Get Conference Recording Information

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
    public class GetConferenceRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.
            var recordingId = r-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Recording ID.

            try
            {
                // Get Conference Recording Information
                ConferenceRecordingMetadata result = apiInstance.GetConferenceRecording(accountId, conferenceId, recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.GetConferenceRecording: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 
 **recordingId** | **string**| Programmable Voice API Recording ID. | 

### Return type

[**ConferenceRecordingMetadata**](ConferenceRecordingMetadata.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conference recording found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListConferenceRecordings

> List&lt;ConferenceRecordingMetadata&gt; ListConferenceRecordings (string accountId, string conferenceId)

Get Conference Recordings

Returns a (potentially empty) list of metadata for the recordings that took place during the specified conference.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListConferenceRecordingsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.

            try
            {
                // Get Conference Recordings
                List<ConferenceRecordingMetadata> result = apiInstance.ListConferenceRecordings(accountId, conferenceId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.ListConferenceRecordings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 

### Return type

[**List&lt;ConferenceRecordingMetadata&gt;**](ConferenceRecordingMetadata.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conference recordings retrieved successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListConferences

> List&lt;Conference&gt; ListConferences (string accountId, string name = null, string minCreatedTime = null, string maxCreatedTime = null, int? pageSize = null, string pageToken = null)

Get Conferences

Returns a max of 1000 conferences, sorted by `createdTime` from oldest to newest.  **NOTE:** If the number of conferences in the account is bigger than `pageSize`, a `Link` header (with format `<{url}>; rel=\"next\"`) will be returned in the response. The url can be used to retrieve the next page of conference records.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListConferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var name = my-custom-name;  // string | Filter results by the `name` field. (optional) 
            var minCreatedTime = 2022-06-21T19:13:21Z;  // string | Filter results to conferences which have a `createdTime` after or at `minCreatedTime` (in ISO8601 format). (optional) 
            var maxCreatedTime = 2022-06-21T19:13:21Z;  // string | Filter results to conferences which have a `createdTime` before or at `maxCreatedTime` (in ISO8601 format). (optional) 
            var pageSize = 500;  // int? | Specifies the max number of conferences that will be returned. (optional)  (default to 1000)
            var pageToken = "pageToken_example";  // string | Not intended for explicit use. To use pagination, follow the links in the `Link` header of the response, as indicated in the endpoint description. (optional) 

            try
            {
                // Get Conferences
                List<Conference> result = apiInstance.ListConferences(accountId, name, minCreatedTime, maxCreatedTime, pageSize, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.ListConferences: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **name** | **string**| Filter results by the &#x60;name&#x60; field. | [optional] 
 **minCreatedTime** | **string**| Filter results to conferences which have a &#x60;createdTime&#x60; after or at &#x60;minCreatedTime&#x60; (in ISO8601 format). | [optional] 
 **maxCreatedTime** | **string**| Filter results to conferences which have a &#x60;createdTime&#x60; before or at &#x60;maxCreatedTime&#x60; (in ISO8601 format). | [optional] 
 **pageSize** | **int?**| Specifies the max number of conferences that will be returned. | [optional] [default to 1000]
 **pageToken** | **string**| Not intended for explicit use. To use pagination, follow the links in the &#x60;Link&#x60; header of the response, as indicated in the endpoint description. | [optional] 

### Return type

[**List&lt;Conference&gt;**](Conference.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conferences retrieved successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConference

> void UpdateConference (string accountId, string conferenceId, UpdateConference updateConference)

Update Conference

Update the conference state.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateConferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.
            var updateConference = new UpdateConference(); // UpdateConference | 

            try
            {
                // Update Conference
                apiInstance.UpdateConference(accountId, conferenceId, updateConference);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.UpdateConference: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 
 **updateConference** | [**UpdateConference**](UpdateConference.md)|  | 

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
| **204** | Conference was successfully modified. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConferenceBxml

> void UpdateConferenceBxml (string accountId, string conferenceId, string body)

Update Conference BXML

Update the conference BXML document.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateConferenceBxmlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.
            var body = <?xml version="1.0" encoding="UTF-8"?>
<Bxml>
    <StopRecording/>
</Bxml>;  // string | 

            try
            {
                // Update Conference BXML
                apiInstance.UpdateConferenceBxml(accountId, conferenceId, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.UpdateConferenceBxml: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 
 **body** | **string**|  | 

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
| **204** | Conference successfully modified. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateConferenceMember

> void UpdateConferenceMember (string accountId, string conferenceId, string memberId, UpdateConferenceMember updateConferenceMember)

Update Conference Member

Updates settings for a particular conference member.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateConferenceMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ConferencesApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var conferenceId = conf-fe23a767-a75a5b77-20c5-4cca-b581-cbbf0776eca9;  // string | Programmable Voice API Conference ID.
            var memberId = c-15ac29a2-1331029c-2cb0-4a07-b215-b22865662d85;  // string | Programmable Voice API Conference Member ID.
            var updateConferenceMember = new UpdateConferenceMember(); // UpdateConferenceMember | 

            try
            {
                // Update Conference Member
                apiInstance.UpdateConferenceMember(accountId, conferenceId, memberId, updateConferenceMember);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ConferencesApi.UpdateConferenceMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Your Bandwidth Account ID. | 
 **conferenceId** | **string**| Programmable Voice API Conference ID. | 
 **memberId** | **string**| Programmable Voice API Conference Member ID. | 
 **updateConferenceMember** | [**UpdateConferenceMember**](UpdateConferenceMember.md)|  | 

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
| **204** | Conference member was successfully modified. |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  * Retry-After - When you should try your request again. <br>  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

