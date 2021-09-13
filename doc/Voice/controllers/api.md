# API

```csharp
APIController aPIController = client.Voice.APIController;
```

## Class Name

`APIController`

## Methods

* [Create Call](/doc/Voice/controllers/api.md#create-call)
* [Get Call](/doc/Voice/controllers/api.md#get-call)
* [Modify Call](/doc/Voice/controllers/api.md#modify-call)
* [Modify Call Recording State](/doc/Voice/controllers/api.md#modify-call-recording-state)
* [Get Call Recordings](/doc/Voice/controllers/api.md#get-call-recordings)
* [Get Call Recording](/doc/Voice/controllers/api.md#get-call-recording)
* [Delete Recording](/doc/Voice/controllers/api.md#delete-recording)
* [Get Download Call Recording](/doc/Voice/controllers/api.md#get-download-call-recording)
* [Delete Recording Media](/doc/Voice/controllers/api.md#delete-recording-media)
* [Get Call Transcription](/doc/Voice/controllers/api.md#get-call-transcription)
* [Create Transcribe Call Recording](/doc/Voice/controllers/api.md#create-transcribe-call-recording)
* [Delete Call Transcription](/doc/Voice/controllers/api.md#delete-call-transcription)
* [Get Conferences](/doc/Voice/controllers/api.md#get-conferences)
* [Get Conference](/doc/Voice/controllers/api.md#get-conference)
* [Modify Conference](/doc/Voice/controllers/api.md#modify-conference)
* [Modify Conference Member](/doc/Voice/controllers/api.md#modify-conference-member)
* [Get Conference Member](/doc/Voice/controllers/api.md#get-conference-member)
* [Get Conference Recordings](/doc/Voice/controllers/api.md#get-conference-recordings)
* [Get Conference Recording](/doc/Voice/controllers/api.md#get-conference-recording)
* [Get Download Conference Recording](/doc/Voice/controllers/api.md#get-download-conference-recording)
* [Get Query Call Recordings](/doc/Voice/controllers/api.md#get-query-call-recordings)


# Create Call

Creates an outbound phone call.

```csharp
CreateCallAsync(
    string accountId,
    Models.CreateCallRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `body` | [`Models.CreateCallRequest`]($m/Voice/CreateCallRequest) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.CreateCallResponse>>`]($m/Voice/CreateCallResponse)

## Example Usage

```csharp
string accountId = "accountId0";
var body = new CreateCallRequest();
body.From = "+15555555555";
body.To = "+15555555555, sip:john@doe.com";
body.AnswerUrl = "answerUrl4";
body.ApplicationId = "applicationId6";

try
{
    ApiResponse<CreateCallResponse> result = await aPIController.CreateCallAsync(accountId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Call

Returns near-realtime metadata about the specified call.

```csharp
GetCallAsync(
    string accountId,
    string callId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.CallState>>`]($m/Voice/CallState)

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";

try
{
    ApiResponse<CallState> result = await aPIController.GetCallAsync(accountId, callId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Modify Call

Interrupts and replaces an active call's BXML document.

```csharp
ModifyCallAsync(
    string accountId,
    string callId,
    Models.ModifyCallRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `body` | [`Models.ModifyCallRequest`]($m/Voice/ModifyCallRequest) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
var body = new ModifyCallRequest();

try
{
    await aPIController.ModifyCallAsync(accountId, callId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Modify Call Recording State

Pauses or resumes a recording.

```csharp
ModifyCallRecordingStateAsync(
    string accountId,
    string callId,
    Models.ModifyCallRecordingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `body` | [`Models.ModifyCallRecordingRequest`]($m/Voice/ModifyCallRecordingRequest) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
var body = new ModifyCallRecordingRequest();
body.State = State1Enum.PAUSED;

try
{
    await aPIController.ModifyCallRecordingStateAsync(accountId, callId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Call Recordings

Returns a (potentially empty) list of metadata for the recordings that took place during the specified call.

```csharp
GetCallRecordingsAsync(
    string accountId,
    string callId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<List<Models.CallRecordingMetadata>>>`]($m/Voice/CallRecordingMetadata)

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";

try
{
    ApiResponse<List<CallRecordingMetadata>> result = await aPIController.GetCallRecordingsAsync(accountId, callId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Call Recording

Returns metadata for the specified recording.

```csharp
GetCallRecordingAsync(
    string accountId,
    string callId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.CallRecordingMetadata>>`]($m/Voice/CallRecordingMetadata)

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";

try
{
    ApiResponse<CallRecordingMetadata> result = await aPIController.GetCallRecordingAsync(accountId, callId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Delete Recording

Deletes the specified recording.

```csharp
DeleteRecordingAsync(
    string accountId,
    string callId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";

try
{
    await aPIController.DeleteRecordingAsync(accountId, callId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Download Call Recording

Downloads the specified recording.

```csharp
GetDownloadCallRecordingAsync(
    string accountId,
    string callId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

`Task<ApiResponse<dynamic>>`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";

try
{
    ApiResponse<dynamic> result = await aPIController.GetDownloadCallRecordingAsync(accountId, callId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Delete Recording Media

Deletes the specified recording's media.

```csharp
DeleteRecordingMediaAsync(
    string accountId,
    string callId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";

try
{
    await aPIController.DeleteRecordingMediaAsync(accountId, callId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Call Transcription

Downloads the specified transcription.

```csharp
GetCallTranscriptionAsync(
    string accountId,
    string callId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.TranscriptionResponse>>`]($m/Voice/TranscriptionResponse)

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";

try
{
    ApiResponse<TranscriptionResponse> result = await aPIController.GetCallTranscriptionAsync(accountId, callId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Create Transcribe Call Recording

Requests that the specified recording be transcribed.

```csharp
CreateTranscribeCallRecordingAsync(
    string accountId,
    string callId,
    string recordingId,
    Models.TranscribeRecordingRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |
| `body` | [`Models.TranscribeRecordingRequest`]($m/Voice/TranscribeRecordingRequest) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";
var body = new TranscribeRecordingRequest();

try
{
    await aPIController.CreateTranscribeCallRecordingAsync(accountId, callId, recordingId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 410 | The media for this recording has been deleted, so we can't transcribe it | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Delete Call Transcription

Deletes the specified recording's transcription.

```csharp
DeleteCallTranscriptionAsync(
    string accountId,
    string callId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string callId = "callId0";
string recordingId = "recordingId2";

try
{
    await aPIController.DeleteCallTranscriptionAsync(accountId, callId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Conferences

Returns information about the conferences in the account.

```csharp
GetConferencesAsync(
    string accountId,
    string name = null,
    string minCreatedTime = null,
    string maxCreatedTime = null,
    int? pageSize = 1000,
    string pageToken = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `name` | `string` | Query, Optional | - |
| `minCreatedTime` | `string` | Query, Optional | - |
| `maxCreatedTime` | `string` | Query, Optional | - |
| `pageSize` | `int?` | Query, Optional | **Default**: `1000` |
| `pageToken` | `string` | Query, Optional | - |

## Response Type

[`Task<ApiResponse<List<Models.ConferenceState>>>`]($m/Voice/ConferenceState)

## Example Usage

```csharp
string accountId = "accountId0";
int? pageSize = 1000;

try
{
    ApiResponse<List<ConferenceState>> result = await aPIController.GetConferencesAsync(accountId, null, null, null, pageSize, null);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Conference

Returns information about the specified conference.

```csharp
GetConferenceAsync(
    string accountId,
    string conferenceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.ConferenceState>>`]($m/Voice/ConferenceState)

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";

try
{
    ApiResponse<ConferenceState> result = await aPIController.GetConferenceAsync(accountId, conferenceId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Modify Conference

Modify the conference state.

```csharp
ModifyConferenceAsync(
    string accountId,
    string conferenceId,
    Models.ModifyConferenceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |
| `body` | [`Models.ModifyConferenceRequest`]($m/Voice/ModifyConferenceRequest) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";
var body = new ModifyConferenceRequest();

try
{
    await aPIController.ModifyConferenceAsync(accountId, conferenceId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Modify Conference Member

Updates settings for a particular conference member.

```csharp
ModifyConferenceMemberAsync(
    string accountId,
    string conferenceId,
    string callId,
    Models.ConferenceMemberState body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |
| `callId` | `string` | Template, Required | - |
| `body` | [`Models.ConferenceMemberState`]($m/Voice/ConferenceMemberState) | Body, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";
string callId = "callId0";
var body = new ConferenceMemberState();

try
{
    await aPIController.ModifyConferenceMemberAsync(accountId, conferenceId, callId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Conference Member

Returns information about the specified conference member.

```csharp
GetConferenceMemberAsync(
    string accountId,
    string conferenceId,
    string memberId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |
| `memberId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.ConferenceMemberState>>`]($m/Voice/ConferenceMemberState)

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";
string memberId = "memberId0";

try
{
    ApiResponse<ConferenceMemberState> result = await aPIController.GetConferenceMemberAsync(accountId, conferenceId, memberId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Conference Recordings

Returns a (potentially empty) list of metadata for the recordings that took place during the specified conference

```csharp
GetConferenceRecordingsAsync(
    string accountId,
    string conferenceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<List<Models.ConferenceRecordingMetadata>>>`]($m/Voice/ConferenceRecordingMetadata)

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";

try
{
    ApiResponse<List<ConferenceRecordingMetadata>> result = await aPIController.GetConferenceRecordingsAsync(accountId, conferenceId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Conference Recording

Returns metadata for the specified recording.

```csharp
GetConferenceRecordingAsync(
    string accountId,
    string conferenceId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

[`Task<ApiResponse<Models.CallRecordingMetadata>>`]($m/Voice/CallRecordingMetadata)

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";
string recordingId = "recordingId2";

try
{
    ApiResponse<CallRecordingMetadata> result = await aPIController.GetConferenceRecordingAsync(accountId, conferenceId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Download Conference Recording

Downloads the specified recording.

```csharp
GetDownloadConferenceRecordingAsync(
    string accountId,
    string conferenceId,
    string recordingId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `conferenceId` | `string` | Template, Required | - |
| `recordingId` | `string` | Template, Required | - |

## Response Type

`Task<ApiResponse<dynamic>>`

## Example Usage

```csharp
string accountId = "accountId0";
string conferenceId = "conferenceId0";
string recordingId = "recordingId2";

try
{
    ApiResponse<dynamic> result = await aPIController.GetDownloadConferenceRecordingAsync(accountId, conferenceId, recordingId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |


# Get Query Call Recordings

Returns a list of metadata for the recordings associated with the specified account. The list can be filtered by the optional from, to, minStartTime, and maxStartTime arguments. The list is capped at 1000 entries and may be empty if no recordings match the specified criteria.

```csharp
GetQueryCallRecordingsAsync(
    string accountId,
    string from = null,
    string to = null,
    string minStartTime = null,
    string maxStartTime = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | - |
| `from` | `string` | Query, Optional | - |
| `to` | `string` | Query, Optional | - |
| `minStartTime` | `string` | Query, Optional | - |
| `maxStartTime` | `string` | Query, Optional | - |

## Response Type

[`Task<ApiResponse<List<Models.CallRecordingMetadata>>>`]($m/Voice/CallRecordingMetadata)

## Example Usage

```csharp
string accountId = "accountId0";

try
{
    ApiResponse<List<CallRecordingMetadata>> result = await aPIController.GetQueryCallRecordingsAsync(accountId, null, null, null, null);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Something's not quite right... Your request is invalid. Please fix it before trying again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 401 | Your credentials are invalid. Please use your Bandwidth dashboard credentials to authenticate to the API. | `ApiException` |
| 403 | User unauthorized to perform this action. | [`ApiErrorException`]($m/Voice/ApiError) |
| 404 | The resource specified cannot be found or does not belong to you. | [`ApiErrorException`]($m/Voice/ApiError) |
| 415 | We don't support that media type. If a request body is required, please send it to us as `application/json`. | [`ApiErrorException`]($m/Voice/ApiError) |
| 429 | You're sending requests to this endpoint too frequently. Please slow your request rate down and try again. | [`ApiErrorException`]($m/Voice/ApiError) |
| 500 | Something unexpected happened. Please try again. | [`ApiErrorException`]($m/Voice/ApiError) |

