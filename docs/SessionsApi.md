# Bandwidth.Standard.Api.SessionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddParticipantToSession**](SessionsApi.md#addparticipanttosession) | **PUT** /accounts/{accountId}/sessions/{sessionId}/participants/{participantId} | Add Participant to Session |
| [**CreateSession**](SessionsApi.md#createsession) | **POST** /accounts/{accountId}/sessions | Create Session |
| [**DeleteSession**](SessionsApi.md#deletesession) | **DELETE** /accounts/{accountId}/sessions/{sessionId} | Delete Session |
| [**GetParticipantSubscriptions**](SessionsApi.md#getparticipantsubscriptions) | **GET** /accounts/{accountId}/sessions/{sessionId}/participants/{participantId}/subscriptions | Get Participant Subscriptions |
| [**GetSession**](SessionsApi.md#getsession) | **GET** /accounts/{accountId}/sessions/{sessionId} | Get Session |
| [**ListSessionParticipants**](SessionsApi.md#listsessionparticipants) | **GET** /accounts/{accountId}/sessions/{sessionId}/participants | List Participants in Session |
| [**RemoveParticipantFromSession**](SessionsApi.md#removeparticipantfromsession) | **DELETE** /accounts/{accountId}/sessions/{sessionId}/participants/{participantId} | Remove Participant from Session |
| [**UpdateParticipantSubscriptions**](SessionsApi.md#updateparticipantsubscriptions) | **PUT** /accounts/{accountId}/sessions/{sessionId}/participants/{participantId}/subscriptions | Update Participant Subscriptions |

<a name="addparticipanttosession"></a>
# **AddParticipantToSession**
> void AddParticipantToSession (string accountId, string sessionId, string participantId, Subscriptions subscriptions = null)

Add Participant to Session

Add a participant to a session.  Subscriptions can optionally be provided as part of this call. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class AddParticipantToSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID
            var participantId = 62e0ecb9-0b1b-5115-aae4-4f36123d6bb1;  // string | Participant ID
            var subscriptions = new Subscriptions(); // Subscriptions | The Body describes an optional set of subscriptions to apply to the participant.  Calling this endpoint with no/empty body will only add the participant to the session, and will not subscribe the Participant to any media.  The request body for this endpoint is OPTIONAL and provided as a convenience to avoid additional calls to the Update Participant Subscriptions endpoint. - -- If a body is provided it will result in direct control over what Participants are subscribed to.    - if the participants Array is provided and not empty, that list of Participants will be subscribed To   - if the participants Array is missing or empty, and the sessionId is provided, the participant will be subscribed to the session, including all subsequent changes to the membership of the session   - if the sessionId and the participant Array are both missing or empty, no subscriptions will be created (optional) 

            try
            {
                // Add Participant to Session
                apiInstance.AddParticipantToSession(accountId, sessionId, participantId, subscriptions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.AddParticipantToSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddParticipantToSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Participant to Session
    apiInstance.AddParticipantToSessionWithHttpInfo(accountId, sessionId, participantId, subscriptions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.AddParticipantToSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |
| **participantId** | **string** | Participant ID |  |
| **subscriptions** | [**Subscriptions**](Subscriptions.md) | The Body describes an optional set of subscriptions to apply to the participant.  Calling this endpoint with no/empty body will only add the participant to the session, and will not subscribe the Participant to any media.  The request body for this endpoint is OPTIONAL and provided as a convenience to avoid additional calls to the Update Participant Subscriptions endpoint. - -- If a body is provided it will result in direct control over what Participants are subscribed to.    - if the participants Array is provided and not empty, that list of Participants will be subscribed To   - if the participants Array is missing or empty, and the sessionId is provided, the participant will be subscribed to the session, including all subsequent changes to the membership of the session   - if the sessionId and the participant Array are both missing or empty, no subscriptions will be created | [optional]  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsession"></a>
# **CreateSession**
> Session CreateSession (string accountId, Session session = null)

Create Session

Create a new session. Sessions are idempotent, so relevant parameters must be set in this function if desired.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var session = new Session(); // Session | Create session request body. (optional) 

            try
            {
                // Create Session
                Session result = apiInstance.CreateSession(accountId, session);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.CreateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Session
    ApiResponse<Session> response = apiInstance.CreateSessionWithHttpInfo(accountId, session);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.CreateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **session** | [**Session**](Session.md) | Create session request body. | [optional]  |

### Return type

[**Session**](Session.md)

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

<a name="deletesession"></a>
# **DeleteSession**
> void DeleteSession (string accountId, string sessionId)

Delete Session

Delete session by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID

            try
            {
                // Delete Session
                apiInstance.DeleteSession(accountId, sessionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.DeleteSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Session
    apiInstance.DeleteSessionWithHttpInfo(accountId, sessionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.DeleteSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |

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

<a name="getparticipantsubscriptions"></a>
# **GetParticipantSubscriptions**
> Subscriptions GetParticipantSubscriptions (string accountId, string sessionId, string participantId)

Get Participant Subscriptions

Get a participant's subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetParticipantSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID
            var participantId = 62e0ecb9-0b1b-5115-aae4-4f36123d6bb1;  // string | Participant ID

            try
            {
                // Get Participant Subscriptions
                Subscriptions result = apiInstance.GetParticipantSubscriptions(accountId, sessionId, participantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.GetParticipantSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetParticipantSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Participant Subscriptions
    ApiResponse<Subscriptions> response = apiInstance.GetParticipantSubscriptionsWithHttpInfo(accountId, sessionId, participantId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.GetParticipantSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |
| **participantId** | **string** | Participant ID |  |

### Return type

[**Subscriptions**](Subscriptions.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsession"></a>
# **GetSession**
> Session GetSession (string accountId, string sessionId)

Get Session

Get session by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GetSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID

            try
            {
                // Get Session
                Session result = apiInstance.GetSession(accountId, sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.GetSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Session
    ApiResponse<Session> response = apiInstance.GetSessionWithHttpInfo(accountId, sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.GetSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |

### Return type

[**Session**](Session.md)

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

<a name="listsessionparticipants"></a>
# **ListSessionParticipants**
> List&lt;Participant&gt; ListSessionParticipants (string accountId, string sessionId)

List Participants in Session

List participants in a session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListSessionParticipantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID

            try
            {
                // List Participants in Session
                List<Participant> result = apiInstance.ListSessionParticipants(accountId, sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.ListSessionParticipants: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSessionParticipantsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Participants in Session
    ApiResponse<List<Participant>> response = apiInstance.ListSessionParticipantsWithHttpInfo(accountId, sessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.ListSessionParticipantsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |

### Return type

[**List&lt;Participant&gt;**](Participant.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeparticipantfromsession"></a>
# **RemoveParticipantFromSession**
> void RemoveParticipantFromSession (string accountId, string sessionId, string participantId)

Remove Participant from Session

Remove a participant from a session. This will automatically remove any subscriptions the participant has associated with this session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class RemoveParticipantFromSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID
            var participantId = 62e0ecb9-0b1b-5115-aae4-4f36123d6bb1;  // string | Participant ID

            try
            {
                // Remove Participant from Session
                apiInstance.RemoveParticipantFromSession(accountId, sessionId, participantId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.RemoveParticipantFromSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveParticipantFromSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Participant from Session
    apiInstance.RemoveParticipantFromSessionWithHttpInfo(accountId, sessionId, participantId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.RemoveParticipantFromSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |
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

<a name="updateparticipantsubscriptions"></a>
# **UpdateParticipantSubscriptions**
> void UpdateParticipantSubscriptions (string accountId, string sessionId, string participantId, Subscriptions subscriptions = null)

Update Participant Subscriptions

Update a participant's subscriptions. This is a full update that will replace the participant's subscriptions. It allows subscription to the entire Session, a subset list of Participants in that Session, or specific media streams on any of the listed Participants. First call `getParticipantSubscriptions` if you need the current subscriptions. Calling this API with no `Subscriptions` object to remove all subscriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class UpdateParticipantSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SessionsApi(config);
            var accountId = 9900000;  // string | Account ID
            var sessionId = cb5054ee-a69b-41ac-9ab2-04d6370826b4;  // string | Session ID
            var participantId = 62e0ecb9-0b1b-5115-aae4-4f36123d6bb1;  // string | Participant ID
            var subscriptions = new Subscriptions(); // Subscriptions | The body describes the desired subscriptions for the Participant. - -- If a body is provided it will result in direct control over what Participants are subscribed to.    - if the participants Array is provided and not empty, that list of Participants will be subscribed To   - if the participants Array is missing or empty, and the sessionId is provided, the participant will be subscribed to the session, including all subsequent changes to the membership of the session   - if the sessionId and the participant Array are both missing or empty, no subscriptions will be created (optional) 

            try
            {
                // Update Participant Subscriptions
                apiInstance.UpdateParticipantSubscriptions(accountId, sessionId, participantId, subscriptions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.UpdateParticipantSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateParticipantSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Participant Subscriptions
    apiInstance.UpdateParticipantSubscriptionsWithHttpInfo(accountId, sessionId, participantId, subscriptions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.UpdateParticipantSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Account ID |  |
| **sessionId** | **string** | Session ID |  |
| **participantId** | **string** | Participant ID |  |
| **subscriptions** | [**Subscriptions**](Subscriptions.md) | The body describes the desired subscriptions for the Participant. - -- If a body is provided it will result in direct control over what Participants are subscribed to.    - if the participants Array is provided and not empty, that list of Participants will be subscribed To   - if the participants Array is missing or empty, and the sessionId is provided, the participant will be subscribed to the session, including all subsequent changes to the membership of the session   - if the sessionId and the participant Array are both missing or empty, no subscriptions will be created | [optional]  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

