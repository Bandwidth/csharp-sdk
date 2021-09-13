# API

```csharp
APIController aPIController = client.Messaging.APIController;
```

## Class Name

`APIController`

## Methods

* [List Media](/doc/Messaging/controllers/api.md#list-media)
* [Get Media](/doc/Messaging/controllers/api.md#get-media)
* [Upload Media](/doc/Messaging/controllers/api.md#upload-media)
* [Delete Media](/doc/Messaging/controllers/api.md#delete-media)
* [Get Messages](/doc/Messaging/controllers/api.md#get-messages)
* [Create Message](/doc/Messaging/controllers/api.md#create-message)


# List Media

Gets a list of your media files. No query parameters are supported.

```csharp
ListMediaAsync(
    string accountId,
    string continuationToken = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | User's account ID |
| `continuationToken` | `string` | Header, Optional | Continuation token used to retrieve subsequent media. |

## Response Type

[`Task<ApiResponse<List<Models.Media>>>`]($m/Messaging/Media)

## Example Usage

```csharp
string accountId = "900000";
string continuationToken = "12345";

try
{
    ApiResponse<List<Media>> result = await aPIController.ListMediaAsync(accountId, continuationToken);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Request is malformed or invalid | [`MessagingException`]($m/Messaging/MessagingException) |
| 401 | 401 The specified user does not have access to the account | [`MessagingException`]($m/Messaging/MessagingException) |
| 403 | 403 The user does not have access to this API | [`MessagingException`]($m/Messaging/MessagingException) |
| 404 | 404 Path not found | [`MessagingException`]($m/Messaging/MessagingException) |
| 415 | 415 The content-type of the request is incorrect | [`MessagingException`]($m/Messaging/MessagingException) |
| 429 | 429 The rate limit has been reached | [`MessagingException`]($m/Messaging/MessagingException) |


# Get Media

Downloads a media file you previously uploaded.

```csharp
GetMediaAsync(
    string accountId,
    string mediaId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | User's account ID |
| `mediaId` | `string` | Template, Required | Media ID to retrieve<br>**Constraints**: *Pattern*: `.+` |

## Response Type

`Task<ApiResponse<Stream>>`

## Example Usage

```csharp
string accountId = "900000";
string mediaId = "0a610655-ba58";

try
{
    ApiResponse<Stream> result = await aPIController.GetMediaAsync(accountId, mediaId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Request is malformed or invalid | [`MessagingException`]($m/Messaging/MessagingException) |
| 401 | 401 The specified user does not have access to the account | [`MessagingException`]($m/Messaging/MessagingException) |
| 403 | 403 The user does not have access to this API | [`MessagingException`]($m/Messaging/MessagingException) |
| 404 | 404 Path not found | [`MessagingException`]($m/Messaging/MessagingException) |
| 415 | 415 The content-type of the request is incorrect | [`MessagingException`]($m/Messaging/MessagingException) |
| 429 | 429 The rate limit has been reached | [`MessagingException`]($m/Messaging/MessagingException) |


# Upload Media

Uploads a file the normal HTTP way. You may add headers to the request in order to provide some control to your media-file.

```csharp
UploadMediaAsync(
    string accountId,
    string mediaId,
    FileStreamInfo body,
    string contentType = "application/octet-stream",
    string cacheControl = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | User's account ID |
| `mediaId` | `string` | Template, Required | The user supplied custom media ID<br>**Constraints**: *Pattern*: `.+` |
| `body` | `FileStreamInfo` | Body, Required | - |
| `contentType` | `string` | Header, Optional | The media type of the entity-body<br>**Default**: `"application/octet-stream"` |
| `cacheControl` | `string` | Header, Optional | General-header field is used to specify directives that MUST be obeyed by all caching mechanisms along the request/response chain. |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "900000";
string mediaId = "my-media-id";
FileStreamInfo body = new FileStreamInfo(new FileStream("dummy_file",FileMode.Open));
string contentType = "audio/wav";
string cacheControl = "no-cache";

try
{
    await aPIController.UploadMediaAsync(accountId, mediaId, body, contentType, cacheControl);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Request is malformed or invalid | [`MessagingException`]($m/Messaging/MessagingException) |
| 401 | 401 The specified user does not have access to the account | [`MessagingException`]($m/Messaging/MessagingException) |
| 403 | 403 The user does not have access to this API | [`MessagingException`]($m/Messaging/MessagingException) |
| 404 | 404 Path not found | [`MessagingException`]($m/Messaging/MessagingException) |
| 415 | 415 The content-type of the request is incorrect | [`MessagingException`]($m/Messaging/MessagingException) |
| 429 | 429 The rate limit has been reached | [`MessagingException`]($m/Messaging/MessagingException) |


# Delete Media

Deletes a media file from Bandwidth API server. Make sure you don't have any application scripts still using the media before you delete. If you accidentally delete a media file, you can immediately upload a new file with the same name.

```csharp
DeleteMediaAsync(
    string accountId,
    string mediaId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | User's account ID |
| `mediaId` | `string` | Template, Required | The media ID to delete<br>**Constraints**: *Pattern*: `.+` |

## Response Type

`Task`

## Example Usage

```csharp
string accountId = "900000";
string mediaId = "tjdla-4562ld";

try
{
    await aPIController.DeleteMediaAsync(accountId, mediaId);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Request is malformed or invalid | [`MessagingException`]($m/Messaging/MessagingException) |
| 401 | 401 The specified user does not have access to the account | [`MessagingException`]($m/Messaging/MessagingException) |
| 403 | 403 The user does not have access to this API | [`MessagingException`]($m/Messaging/MessagingException) |
| 404 | 404 Path not found | [`MessagingException`]($m/Messaging/MessagingException) |
| 415 | 415 The content-type of the request is incorrect | [`MessagingException`]($m/Messaging/MessagingException) |
| 429 | 429 The rate limit has been reached | [`MessagingException`]($m/Messaging/MessagingException) |


# Get Messages

Gets a list of messages based on query parameters.

```csharp
GetMessagesAsync(
    string accountId,
    string messageId = null,
    string sourceTn = null,
    string destinationTn = null,
    string messageStatus = null,
    int? errorCode = null,
    string fromDateTime = null,
    string toDateTime = null,
    string pageToken = null,
    int? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | User's account ID |
| `messageId` | `string` | Query, Optional | The ID of the message to search for. Special characters need to be encoded using URL encoding |
| `sourceTn` | `string` | Query, Optional | The phone number that sent the message |
| `destinationTn` | `string` | Query, Optional | The phone number that received the message |
| `messageStatus` | `string` | Query, Optional | The status of the message. One of RECEIVED, QUEUED, SENDING, SENT, FAILED, DELIVERED, ACCEPTED, UNDELIVERED |
| `errorCode` | `int?` | Query, Optional | The error code of the message |
| `fromDateTime` | `string` | Query, Optional | The start of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days. |
| `toDateTime` | `string` | Query, Optional | The end of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days. |
| `pageToken` | `string` | Query, Optional | A base64 encoded value used for pagination of results |
| `limit` | `int?` | Query, Optional | The maximum records requested in search result. Default 100. The sum of limit and after cannot be more than 10000 |

## Response Type

[`Task<ApiResponse<Models.BandwidthMessagesList>>`]($m/Messaging/BandwidthMessagesList)

## Example Usage

```csharp
string accountId = "900000";
string messageId = "9e0df4ca-b18d-40d7-a59f-82fcdf5ae8e6";
string sourceTn = "%2B15554443333";
string destinationTn = "%2B15554443333";
string messageStatus = "RECEIVED";
int? errorCode = 9902;
string fromDateTime = "2016-09-14T18:20:16.000Z";
string toDateTime = "2016-09-14T18:20:16.000Z";
string pageToken = "gdEewhcJLQRB5";
int? limit = 50;

try
{
    ApiResponse<BandwidthMessagesList> result = await aPIController.GetMessagesAsync(accountId, messageId, sourceTn, destinationTn, messageStatus, errorCode, fromDateTime, toDateTime, pageToken, limit);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Request is malformed or invalid | [`MessagingException`]($m/Messaging/MessagingException) |
| 401 | 401 The specified user does not have access to the account | [`MessagingException`]($m/Messaging/MessagingException) |
| 403 | 403 The user does not have access to this API | [`MessagingException`]($m/Messaging/MessagingException) |
| 404 | 404 Path not found | [`MessagingException`]($m/Messaging/MessagingException) |
| 415 | 415 The content-type of the request is incorrect | [`MessagingException`]($m/Messaging/MessagingException) |
| 429 | 429 The rate limit has been reached | [`MessagingException`]($m/Messaging/MessagingException) |


# Create Message

Endpoint for sending text messages and picture messages using V2 messaging.

```csharp
CreateMessageAsync(
    string accountId,
    Models.MessageRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | User's account ID |
| `body` | [`Models.MessageRequest`]($m/Messaging/MessageRequest) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.BandwidthMessage>>`]($m/Messaging/BandwidthMessage)

## Example Usage

```csharp
string accountId = "900000";
var body = new MessageRequest();
body.ApplicationId = "93de2206-9669-4e07-948d-329f4b722ee2";
body.To = new List<string>();
body.To.Add("+15554443333");
body.To.Add("+15552223333");
body.From = "+15551113333";

try
{
    ApiResponse<BandwidthMessage> result = await aPIController.CreateMessageAsync(accountId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | 400 Request is malformed or invalid | [`MessagingException`]($m/Messaging/MessagingException) |
| 401 | 401 The specified user does not have access to the account | [`MessagingException`]($m/Messaging/MessagingException) |
| 403 | 403 The user does not have access to this API | [`MessagingException`]($m/Messaging/MessagingException) |
| 404 | 404 Path not found | [`MessagingException`]($m/Messaging/MessagingException) |
| 415 | 415 The content-type of the request is incorrect | [`MessagingException`]($m/Messaging/MessagingException) |
| 429 | 429 The rate limit has been reached | [`MessagingException`]($m/Messaging/MessagingException) |

