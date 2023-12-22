# Bandwidth.Standard.Api.ParticipantsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateParticipant**](ParticipantsApi.md#createparticipant) | **POST** /accounts/{accountId}/participants | Create Participant |
| [**DeleteParticipant**](ParticipantsApi.md#deleteparticipant) | **DELETE** /accounts/{accountId}/participants/{participantId} | Delete Participant |
| [**GetParticipant**](ParticipantsApi.md#getparticipant) | **GET** /accounts/{accountId}/participants/{participantId} | Get Participant |

<a name="createparticipant"></a>
# **CreateParticipant**
> CreateParticipantResponse CreateParticipant (string accountId, CreateParticipantRequest createParticipantRequest = null)

Create Participant

Create a new participant under this account. Participants are idempotent, so relevant parameters must be set in this function if desired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ParticipantsApi(config);
            var accountId = 9900000;  // string | Account ID
            var createParticipantRequest = new CreateParticipantRequest(); // CreateParticipantRequest | Create participant request body. (optional) 

            try
            {
                // Create Participant
                CreateParticipantResponse result = apiInstance.CreateParticipant(accountId, createParticipantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipantsApi.CreateParticipant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateParticipantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Participant
    ApiResponse<CreateParticipantResponse> response = apiInstance.CreateParticipantWithHttpInfo(accountId, createParticipantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParticipantsApi.CreateParticipantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **createParticipantRequest** | [**CreateParticipantRequest**](CreateParticipantRequest.md) | Create participant request body. | [optional]  |

### Return type

[**CreateParticipantResponse**](CreateParticipantResponse.md)

### Authorization

[Basic](../README.md#Basic)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparticipant"></a>
# **DeleteParticipant**
> void DeleteParticipant (string accountId, string participantId)

Delete Participant

Delete participant by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ParticipantsApi(config);
            var accountId = 9900000;  // string | Account ID
            var participantId = 62e0ecb9-0b1b-5115-aae4-4f36123d6bb1;  // string | Participant ID

            try
            {
                // Delete Participant
                apiInstance.DeleteParticipant(accountId, participantId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipantsApi.DeleteParticipant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteParticipantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Participant
    apiInstance.DeleteParticipantWithHttpInfo(accountId, participantId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParticipantsApi.DeleteParticipantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **participantId** | **string** | Participant ID |  |

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparticipant"></a>
# **GetParticipant**
> Participant GetParticipant (string accountId, string participantId)

Get Participant

Get participant by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ParticipantsApi(config);
            var accountId = 9900000;  // string | Account ID
            var participantId = 62e0ecb9-0b1b-5115-aae4-4f36123d6bb1;  // string | Participant ID

            try
            {
                // Get Participant
                Participant result = apiInstance.GetParticipant(accountId, participantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipantsApi.GetParticipant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetParticipantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Participant
    ApiResponse<Participant> response = apiInstance.GetParticipantWithHttpInfo(accountId, participantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParticipantsApi.GetParticipantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **participantId** | **string** | Participant ID |  |

### Return type

[**Participant**](Participant.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

