# Bandwidth.Standard.Api.MediaApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMedia**](MediaApi.md#deletemedia) | **DELETE** /users/{accountId}/media/{mediaId} | Delete Media
[**GetMedia**](MediaApi.md#getmedia) | **GET** /users/{accountId}/media/{mediaId} | Get Media
[**ListMedia**](MediaApi.md#listmedia) | **GET** /users/{accountId}/media | List Media
[**UploadMedia**](MediaApi.md#uploadmedia) | **PUT** /users/{accountId}/media/{mediaId} | Upload Media



## DeleteMedia

> void DeleteMedia (string accountId, string mediaId)

Delete Media

Deletes a media file from Bandwidth API server. Make sure you don't have any application scripts still using the media before you delete.  If you accidentally delete a media file you can immediately upload a new file with the same name.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MediaApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var mediaId = 14762070468292kw2fuqty55yp2b2/0/bw.png;  // string | Media ID to retrieve.

            try
            {
                // Delete Media
                apiInstance.DeleteMedia(accountId, mediaId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaApi.DeleteMedia: " + e.Message );
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
 **mediaId** | **string**| Media ID to retrieve. | 

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMedia

> System.IO.Stream GetMedia (string accountId, string mediaId)

Get Media

Downloads a media file you previously uploaded.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MediaApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var mediaId = 14762070468292kw2fuqty55yp2b2/0/bw.png;  // string | Media ID to retrieve.

            try
            {
                // Get Media
                System.IO.Stream result = apiInstance.GetMedia(accountId, mediaId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaApi.GetMedia: " + e.Message );
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
 **mediaId** | **string**| Media ID to retrieve. | 

### Return type

**System.IO.Stream**

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListMedia

> List&lt;Media&gt; ListMedia (string accountId, string continuationToken = null)

List Media

Gets a list of your media files. No query parameters are supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MediaApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var continuationToken = 1XEi2tsFtLo1JbtLwETnM1ZJ+PqAa8w6ENvC5QKvwyrCDYII663Gy5M4s40owR1tjkuWUif6qbWvFtQJR5/ipqbUnfAqL254LKNlPy6tATCzioKSuHuOqgzloDkSwRtX0LtcL2otHS69hK343m+SjdL+vlj71tT39;  // string | Continuation token used to retrieve subsequent media. (optional) 

            try
            {
                // List Media
                List<Media> result = apiInstance.ListMedia(accountId, continuationToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaApi.ListMedia: " + e.Message );
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
 **continuationToken** | **string**| Continuation token used to retrieve subsequent media. | [optional] 

### Return type

[**List&lt;Media&gt;**](Media.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * Continuation-Token - Continuation token used to retrieve subsequent media. <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UploadMedia

> void UploadMedia (string accountId, string mediaId, System.IO.Stream body, string contentType = null, string cacheControl = null)

Upload Media

Upload a file. You may add headers to the request in order to provide some control to your media file.  If a file is uploaded with the same name as a file that already exists under this account, the previous file will be overwritten.  A list of supported media types can be found [here](https://support.bandwidth.com/hc/en-us/articles/360014128994-What-MMS-file-types-are-supported-).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UploadMediaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MediaApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var mediaId = 14762070468292kw2fuqty55yp2b2/0/bw.png;  // string | Media ID to retrieve.
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var contentType = audio/wav;  // string | The media type of the entity-body. (optional) 
            var cacheControl = no-cache;  // string | General-header field is used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain. (optional) 

            try
            {
                // Upload Media
                apiInstance.UploadMedia(accountId, mediaId, body, contentType, cacheControl);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MediaApi.UploadMedia: " + e.Message );
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
 **mediaId** | **string**| Media ID to retrieve. | 
 **body** | **System.IO.Stream**|  | 
 **contentType** | **string**| The media type of the entity-body. | [optional] 
 **cacheControl** | **string**| General-header field is used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain. | [optional] 

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: application/json, application/ogg, application/pdf, application/rtf, application/zip, application/x-tar, application/xml, application/gzip, application/x-bzip2, application/x-gzip, application/smil, application/javascript, audio/mp4, audio/mpeg, audio/ogg, audio/flac, audio/webm, audio/wav, audio/amr, audio/3gpp, image/bmp, image/gif, image/jpeg, image/pjpeg, image/png, image/svg+xml, image/tiff, image/webp, image/x-icon, text/css, text/csv, text/calendar, text/plain, text/javascript, text/vcard, text/vnd.wap.wml, text/xml, video/avi, video/mp4, video/mpeg, video/ogg, video/quicktime, video/webm, video/x-ms-wmv
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

