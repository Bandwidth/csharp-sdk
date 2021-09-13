# API

```csharp
APIController aPIController = client.WebRtc.APIController;
```

## Class Name

`APIController`

## Methods

* [Create Participant](/doc/WebRtc/controllers/api.md#create-participant)
* [Get Participant](/doc/WebRtc/controllers/api.md#get-participant)
* [Delete Participant](/doc/WebRtc/controllers/api.md#delete-participant)
* [Create Session](/doc/WebRtc/controllers/api.md#create-session)
* [Get Session](/doc/WebRtc/controllers/api.md#get-session)
* [Delete Session](/doc/WebRtc/controllers/api.md#delete-session)
* [List Session Participants](/doc/WebRtc/controllers/api.md#list-session-participants)
* [Add Participant to Session](/doc/WebRtc/controllers/api.md#add-participant-to-session)
* [Remove Participant From Session](/doc/WebRtc/controllers/api.md#remove-participant-from-session)
* [Get Participant Subscriptions](/doc/WebRtc/controllers/api.md#get-participant-subscriptions)
* [Update Participant Subscriptions](/doc/WebRtc/controllers/api.md#update-participant-subscriptions)


# Create Participant

Create a new participant under this account.

Participants are idempotent, so relevant parameters must be set in this function if desired.

```csharp
CreateParticipantAsync(
    string accountId,
    Models.Participant body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `body` | [`Models.Participant`]($m/WebRtc/Participant) | Body, Optional | Participant parameters |

## Response Type

[`Task<ApiResponse<Models.AccountsParticipantsResponse>>`]($m/WebRtc/Accounts%20Participants%20Response)

## Example Usage

```csharp
string accountId = "accountId0";

try
{
    ApiResponse<AccountsParticipantsResponse> result = await aPIController.CreateParticipantAsync(accountId, null);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Get Participant

Get participant by ID.

```csharp
GetParticipantAsync(
    string accountId,
    string participantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `participantId` | `string` | Template, Required | Participant ID |

## Response Type

[`Task<ApiResponse<Models.Participant>>`]($m/WebRtc/Participant)

## Example Usage

```csharp
string accountId = "accountId0";
string participantId = "participantId0";

try
{
    ApiResponse<Participant> result = await aPIController.GetParticipantAsync(accountId, participantId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Delete Participant

Delete participant by ID.

```csharp
DeleteParticipantAsync(
    string accountId,
    string participantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `participantId` | `string` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string participantId = "participantId0";

try
{
    await aPIController.DeleteParticipantAsync(accountId, participantId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Create Session

Create a new session.

Sessions are idempotent, so relevant parameters must be set in this function if desired.

```csharp
CreateSessionAsync(
    string accountId,
    Models.Session body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `body` | [`Models.Session`]($m/WebRtc/Session) | Body, Optional | Session parameters |

## Response Type

[`Task<ApiResponse<Models.Session>>`]($m/WebRtc/Session)

## Example Usage

```csharp
string accountId = "accountId0";

try
{
    ApiResponse<Session> result = await aPIController.CreateSessionAsync(accountId, null);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Get Session

Get session by ID.

```csharp
GetSessionAsync(
    string accountId,
    string sessionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |

## Response Type

[`Task<ApiResponse<Models.Session>>`]($m/WebRtc/Session)

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";

try
{
    ApiResponse<Session> result = await aPIController.GetSessionAsync(accountId, sessionId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Delete Session

Delete session by ID.

```csharp
DeleteSessionAsync(
    string accountId,
    string sessionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";

try
{
    await aPIController.DeleteSessionAsync(accountId, sessionId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# List Session Participants

List participants in a session.

```csharp
ListSessionParticipantsAsync(
    string accountId,
    string sessionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |

## Response Type

[`Task<ApiResponse<List<Models.Participant>>>`]($m/WebRtc/Participant)

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";

try
{
    ApiResponse<List<Participant>> result = await aPIController.ListSessionParticipantsAsync(accountId, sessionId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Add Participant to Session

Add a participant to a session.

Subscriptions can optionally be provided as part of this call.

```csharp
AddParticipantToSessionAsync(
    string accountId,
    string sessionId,
    string participantId,
    Models.Subscriptions body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |
| `participantId` | `string` | Template, Required | Participant ID |
| `body` | [`Models.Subscriptions`]($m/WebRtc/Subscriptions) | Body, Optional | Subscriptions the participant should be created with |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";
string participantId = "participantId0";
var body = new Subscriptions();
body.SessionId = "d8886aad-b956-4e1b-b2f4-d7c9f8162772";

try
{
    await aPIController.AddParticipantToSessionAsync(accountId, sessionId, participantId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Remove Participant From Session

Remove a participant from a session.

This will automatically remove any subscriptions the participant has associated with this session.

```csharp
RemoveParticipantFromSessionAsync(
    string accountId,
    string sessionId,
    string participantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |
| `participantId` | `string` | Template, Required | Participant ID |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";
string participantId = "participantId0";

try
{
    await aPIController.RemoveParticipantFromSessionAsync(accountId, sessionId, participantId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Get Participant Subscriptions

Get a participant's subscriptions.

```csharp
GetParticipantSubscriptionsAsync(
    string accountId,
    string sessionId,
    string participantId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |
| `participantId` | `string` | Template, Required | Participant ID |

## Response Type

[`Task<ApiResponse<Models.Subscriptions>>`]($m/WebRtc/Subscriptions)

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";
string participantId = "participantId0";

try
{
    ApiResponse<Subscriptions> result = await aPIController.GetParticipantSubscriptionsAsync(accountId, sessionId, participantId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |


# Update Participant Subscriptions

Update a participant's subscriptions.

This is a full update that will replace the participant's subscriptions. First call `getParticipantSubscriptions` if you need the current subscriptions. Call this function with no `Subscriptions` object to remove all subscriptions.

```csharp
UpdateParticipantSubscriptionsAsync(
    string accountId,
    string sessionId,
    string participantId,
    Models.Subscriptions body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Account ID |
| `sessionId` | `string` | Template, Required | Session ID |
| `participantId` | `string` | Template, Required | Participant ID |
| `body` | [`Models.Subscriptions`]($m/WebRtc/Subscriptions) | Body, Optional | Initial state |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string sessionId = "sessionId8";
string participantId = "participantId0";
var body = new Subscriptions();
body.SessionId = "d8886aad-b956-4e1b-b2f4-d7c9f8162772";

try
{
    await aPIController.UpdateParticipantSubscriptionsAsync(accountId, sessionId, participantId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 401 | Unauthorized | `ApiException` |
| 403 | Access Denied | `ApiException` |
| 404 | Not Found | `ApiException` |
| Default | Unexpected Error | [`ErrorException`]($m/WebRtc/Error) |

