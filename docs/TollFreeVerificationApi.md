# Bandwidth.Standard.Api.TollFreeVerificationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhookSubscription**](TollFreeVerificationApi.md#createwebhooksubscription) | **POST** /accounts/{accountId}/tollFreeVerification/webhooks/subscriptions | Create Webhook Subscription |
| [**DeleteVerificationRequest**](TollFreeVerificationApi.md#deleteverificationrequest) | **DELETE** /accounts/{accountId}/phoneNumbers/{phoneNumber}/tollFreeVerification | Delete a Toll-Free Verification Submission |
| [**DeleteWebhookSubscription**](TollFreeVerificationApi.md#deletewebhooksubscription) | **DELETE** /accounts/{accountId}/tollFreeVerification/webhooks/subscriptions/{id} | Delete Webhook Subscription |
| [**GetTollFreeVerificationStatus**](TollFreeVerificationApi.md#gettollfreeverificationstatus) | **GET** /accounts/{accountId}/phoneNumbers/{phoneNumber}/tollFreeVerification | Get Toll-Free Verification Status |
| [**ListTollFreeUseCases**](TollFreeVerificationApi.md#listtollfreeusecases) | **GET** /tollFreeVerification/useCases | List Toll-Free Use Cases |
| [**ListWebhookSubscriptions**](TollFreeVerificationApi.md#listwebhooksubscriptions) | **GET** /accounts/{accountId}/tollFreeVerification/webhooks/subscriptions | List Webhook Subscriptions |
| [**RequestTollFreeVerification**](TollFreeVerificationApi.md#requesttollfreeverification) | **POST** /accounts/{accountId}/tollFreeVerification | Request Toll-Free Verification |
| [**UpdateTollFreeVerificationRequest**](TollFreeVerificationApi.md#updatetollfreeverificationrequest) | **PUT** /accounts/{accountId}/phoneNumbers/{phoneNumber}/tollFreeVerification | Update Toll-Free Verification Request |
| [**UpdateWebhookSubscription**](TollFreeVerificationApi.md#updatewebhooksubscription) | **PUT** /accounts/{accountId}/tollFreeVerification/webhooks/subscriptions/{id} | Update Webhook Subscription |

<a id="createwebhooksubscription"></a>
# **CreateWebhookSubscription**
> WebhookSubscription CreateWebhookSubscription (string accountId, WebhookSubscriptionRequestSchema webhookSubscriptionRequestSchema)

Create Webhook Subscription

Create a new webhook subscription (this webhook will be called for every update on every submission). In addition to a `callbackUrl`, this subscription can provide optional HTTP basic authentication credentials (a username and a password). The returned subscription object will contain an ID that can be used to modify or delete the subscription at a later time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateWebhookSubscriptionExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var webhookSubscriptionRequestSchema = new WebhookSubscriptionRequestSchema(); // WebhookSubscriptionRequestSchema | Information about a webhook that Bandwidth should send upon the completion of event customer is trying to subscribe to.

            try
            {
                // Create Webhook Subscription
                WebhookSubscription result = apiInstance.CreateWebhookSubscription(accountId, webhookSubscriptionRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.CreateWebhookSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhookSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Webhook Subscription
    ApiResponse<WebhookSubscription> response = apiInstance.CreateWebhookSubscriptionWithHttpInfo(accountId, webhookSubscriptionRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.CreateWebhookSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **webhookSubscriptionRequestSchema** | [**WebhookSubscriptionRequestSchema**](WebhookSubscriptionRequestSchema.md) | Information about a webhook that Bandwidth should send upon the completion of event customer is trying to subscribe to. |  |

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

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
| **404** | Cannot find the requested resource. |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteverificationrequest"></a>
# **DeleteVerificationRequest**
> void DeleteVerificationRequest (string accountId, string phoneNumber)

Delete a Toll-Free Verification Submission

Delete a toll-free verification submission for a toll-free number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteVerificationRequestExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var phoneNumber = +18885555555;  // string | Valid Toll-Free telephone number in E.164 format.

            try
            {
                // Delete a Toll-Free Verification Submission
                apiInstance.DeleteVerificationRequest(accountId, phoneNumber);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.DeleteVerificationRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVerificationRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Toll-Free Verification Submission
    apiInstance.DeleteVerificationRequestWithHttpInfo(accountId, phoneNumber);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.DeleteVerificationRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **phoneNumber** | **string** | Valid Toll-Free telephone number in E.164 format. |  |

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
| **404** | Cannot find the requested resource. |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewebhooksubscription"></a>
# **DeleteWebhookSubscription**
> void DeleteWebhookSubscription (string accountId, string id)

Delete Webhook Subscription

Delete a webhook subscription by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteWebhookSubscriptionExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var id = 7bt57JcsVYJrN9K1OcV1Nu;  // string | Webhook subscription ID

            try
            {
                // Delete Webhook Subscription
                apiInstance.DeleteWebhookSubscription(accountId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.DeleteWebhookSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebhookSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Webhook Subscription
    apiInstance.DeleteWebhookSubscriptionWithHttpInfo(accountId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.DeleteWebhookSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **id** | **string** | Webhook subscription ID |  |

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
| **404** | Cannot find the requested resource. |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettollfreeverificationstatus"></a>
# **GetTollFreeVerificationStatus**
> TfvStatus GetTollFreeVerificationStatus (string accountId, string phoneNumber)

Get Toll-Free Verification Status

Gets the verification status for a phone number that is provisioned to your account. Submission information will be appended to the response if it is available.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetTollFreeVerificationStatusExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var phoneNumber = +18885555555;  // string | Valid Toll-Free telephone number in E.164 format.

            try
            {
                // Get Toll-Free Verification Status
                TfvStatus result = apiInstance.GetTollFreeVerificationStatus(accountId, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.GetTollFreeVerificationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTollFreeVerificationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Toll-Free Verification Status
    ApiResponse<TfvStatus> response = apiInstance.GetTollFreeVerificationStatusWithHttpInfo(accountId, phoneNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.GetTollFreeVerificationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **phoneNumber** | **string** | Valid Toll-Free telephone number in E.164 format. |  |

### Return type

[**TfvStatus**](TfvStatus.md)

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
| **404** | Cannot find the requested resource. |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtollfreeusecases"></a>
# **ListTollFreeUseCases**
> List&lt;string&gt; ListTollFreeUseCases ()

List Toll-Free Use Cases

Lists valid toll-free use cases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListTollFreeUseCasesExample
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

            var apiInstance = new TollFreeVerificationApi(config);

            try
            {
                // List Toll-Free Use Cases
                List<string> result = apiInstance.ListTollFreeUseCases();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.ListTollFreeUseCases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTollFreeUseCasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Toll-Free Use Cases
    ApiResponse<List<string>> response = apiInstance.ListTollFreeUseCasesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.ListTollFreeUseCasesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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
| **404** | Cannot find the requested resource. |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listwebhooksubscriptions"></a>
# **ListWebhookSubscriptions**
> WebhookSubscriptionsListBody ListWebhookSubscriptions (string accountId)

List Webhook Subscriptions

Lists all webhook subscriptions that are registered to receive status updates for the toll-free verification requests submitted under this account (password will not be returned through this API If `basicAuthentication` is defined, the `password` property of that object will be null).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListWebhookSubscriptionsExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.

            try
            {
                // List Webhook Subscriptions
                WebhookSubscriptionsListBody result = apiInstance.ListWebhookSubscriptions(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.ListWebhookSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWebhookSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Webhook Subscriptions
    ApiResponse<WebhookSubscriptionsListBody> response = apiInstance.ListWebhookSubscriptionsWithHttpInfo(accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.ListWebhookSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |

### Return type

[**WebhookSubscriptionsListBody**](WebhookSubscriptionsListBody.md)

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
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requesttollfreeverification"></a>
# **RequestTollFreeVerification**
> void RequestTollFreeVerification (string accountId, VerificationRequest verificationRequest)

Request Toll-Free Verification

Submit a request for verification of a toll-free phone number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class RequestTollFreeVerificationExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var verificationRequest = new VerificationRequest(); // VerificationRequest | Request for verification of a toll-free phone number.

            try
            {
                // Request Toll-Free Verification
                apiInstance.RequestTollFreeVerification(accountId, verificationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.RequestTollFreeVerification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestTollFreeVerificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request Toll-Free Verification
    apiInstance.RequestTollFreeVerificationWithHttpInfo(accountId, verificationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.RequestTollFreeVerificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **verificationRequest** | [**VerificationRequest**](VerificationRequest.md) | Request for verification of a toll-free phone number. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

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
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetollfreeverificationrequest"></a>
# **UpdateTollFreeVerificationRequest**
> void UpdateTollFreeVerificationRequest (string accountId, string phoneNumber, TfvSubmissionWrapper tfvSubmissionWrapper)

Update Toll-Free Verification Request

Updates a toll-free verification request. Submissions are only eligible for resubmission for 7 days within being processed and if resubmission is allowed (resubmitAllowed field is true).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateTollFreeVerificationRequestExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var phoneNumber = +18885555555;  // string | Valid Toll-Free telephone number in E.164 format.
            var tfvSubmissionWrapper = new TfvSubmissionWrapper(); // TfvSubmissionWrapper | Update a request for verification of a toll-free phone number.

            try
            {
                // Update Toll-Free Verification Request
                apiInstance.UpdateTollFreeVerificationRequest(accountId, phoneNumber, tfvSubmissionWrapper);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.UpdateTollFreeVerificationRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTollFreeVerificationRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Toll-Free Verification Request
    apiInstance.UpdateTollFreeVerificationRequestWithHttpInfo(accountId, phoneNumber, tfvSubmissionWrapper);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.UpdateTollFreeVerificationRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **phoneNumber** | **string** | Valid Toll-Free telephone number in E.164 format. |  |
| **tfvSubmissionWrapper** | [**TfvSubmissionWrapper**](TfvSubmissionWrapper.md) | Update a request for verification of a toll-free phone number. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

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
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebhooksubscription"></a>
# **UpdateWebhookSubscription**
> WebhookSubscription UpdateWebhookSubscription (string accountId, string id, WebhookSubscriptionRequestSchema webhookSubscriptionRequestSchema)

Update Webhook Subscription

Update an existing webhook subscription (`callbackUrl` and `basicAuthentication` can be updated).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateWebhookSubscriptionExample
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

            var apiInstance = new TollFreeVerificationApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var id = 7bt57JcsVYJrN9K1OcV1Nu;  // string | Webhook subscription ID
            var webhookSubscriptionRequestSchema = new WebhookSubscriptionRequestSchema(); // WebhookSubscriptionRequestSchema | Information about a webhook that Bandwidth should send upon the completion of event customer is trying to subscribe to.

            try
            {
                // Update Webhook Subscription
                WebhookSubscription result = apiInstance.UpdateWebhookSubscription(accountId, id, webhookSubscriptionRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TollFreeVerificationApi.UpdateWebhookSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebhookSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Webhook Subscription
    ApiResponse<WebhookSubscription> response = apiInstance.UpdateWebhookSubscriptionWithHttpInfo(accountId, id, webhookSubscriptionRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TollFreeVerificationApi.UpdateWebhookSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **id** | **string** | Webhook subscription ID |  |
| **webhookSubscriptionRequestSchema** | [**WebhookSubscriptionRequestSchema**](WebhookSubscriptionRequestSchema.md) | Information about a webhook that Bandwidth should send upon the completion of event customer is trying to subscribe to. |  |

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Cannot find the requested resource. |  -  |
| **405** | Method Not Allowed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

