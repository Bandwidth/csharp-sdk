# Bandwidth.Standard.Api.StatisticsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStatistics**](StatisticsApi.md#getstatistics) | **GET** /accounts/{accountId}/statistics | Get Account Statistics



## GetStatistics

> AccountStatistics GetStatistics (string accountId)

Get Account Statistics

Returns details about the current state of the account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetStatisticsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StatisticsApi(Configuration.Default);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.

            try
            {
                // Get Account Statistics
                AccountStatistics result = apiInstance.GetStatistics(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatistics: " + e.Message );
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

### Return type

[**AccountStatistics**](AccountStatistics.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics Found |  -  |
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

