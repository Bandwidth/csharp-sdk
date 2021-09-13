# MFA

```csharp
MFAController mFAController = client.MultiFactorAuth.MFAController;
```

## Class Name

`MFAController`

## Methods

* [Create Voice Two Factor](/doc/MultiFactorAuth/controllers/mfa.md#create-voice-two-factor)
* [Create Messaging Two Factor](/doc/MultiFactorAuth/controllers/mfa.md#create-messaging-two-factor)
* [Create Verify Two Factor](/doc/MultiFactorAuth/controllers/mfa.md#create-verify-two-factor)


# Create Voice Two Factor

Multi-Factor authentication with Bandwidth Voice services. Allows for a user to send an MFA code via a phone call.

```csharp
CreateVoiceTwoFactorAsync(
    string accountId,
    Models.TwoFactorCodeRequestSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Bandwidth Account ID with Voice service enabled |
| `body` | [`Models.TwoFactorCodeRequestSchema`]($m/MultiFactorAuth/TwoFactorCodeRequestSchema) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.TwoFactorVoiceResponse>>`]($m/MultiFactorAuth/TwoFactorVoiceResponse)

## Example Usage

```csharp
string accountId = "accountId0";
var body = new TwoFactorCodeRequestSchema();
body.To = "to0";
body.From = "from6";
body.ApplicationId = "applicationId6";
body.Message = "message6";
body.Digits = 45.32;

try
{
    ApiResponse<TwoFactorVoiceResponse> result = await mFAController.CreateVoiceTwoFactorAsync(accountId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | If there is any issue with values passed in by the user | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |
| 401 | Authentication is either incorrect or not present | [`UnauthorizedRequestException`]($m/MultiFactorAuth/UnauthorizedRequest) |
| 403 | The user is not authorized to access this resource | [`ForbiddenRequestException`]($m/MultiFactorAuth/ForbiddenRequest) |
| 500 | An internal server error occurred | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |


# Create Messaging Two Factor

Multi-Factor authentication with Bandwidth Messaging services. Allows a user to send an MFA code via a text message (SMS).

```csharp
CreateMessagingTwoFactorAsync(
    string accountId,
    Models.TwoFactorCodeRequestSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Bandwidth Account ID with Messaging service enabled |
| `body` | [`Models.TwoFactorCodeRequestSchema`]($m/MultiFactorAuth/TwoFactorCodeRequestSchema) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.TwoFactorMessagingResponse>>`]($m/MultiFactorAuth/TwoFactorMessagingResponse)

## Example Usage

```csharp
string accountId = "accountId0";
var body = new TwoFactorCodeRequestSchema();
body.To = "to0";
body.From = "from6";
body.ApplicationId = "applicationId6";
body.Message = "message6";
body.Digits = 45.32;

try
{
    ApiResponse<TwoFactorMessagingResponse> result = await mFAController.CreateMessagingTwoFactorAsync(accountId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | If there is any issue with values passed in by the user | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |
| 401 | Authentication is either incorrect or not present | [`UnauthorizedRequestException`]($m/MultiFactorAuth/UnauthorizedRequest) |
| 403 | The user is not authorized to access this resource | [`ForbiddenRequestException`]($m/MultiFactorAuth/ForbiddenRequest) |
| 500 | An internal server error occurred | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |


# Create Verify Two Factor

Allows a user to verify an MFA code.

```csharp
CreateVerifyTwoFactorAsync(
    string accountId,
    Models.TwoFactorVerifyRequestSchema body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | Bandwidth Account ID with Two-Factor enabled |
| `body` | [`Models.TwoFactorVerifyRequestSchema`]($m/MultiFactorAuth/TwoFactorVerifyRequestSchema) | Body, Required | - |

## Response Type

[`Task<ApiResponse<Models.TwoFactorVerifyCodeResponse>>`]($m/MultiFactorAuth/TwoFactorVerifyCodeResponse)

## Example Usage

```csharp
string accountId = "accountId0";
var body = new TwoFactorVerifyRequestSchema();
body.To = "to0";
body.ApplicationId = "applicationId6";
body.ExpirationTimeInMinutes = 166.8;
body.Code = "code4";

try
{
    ApiResponse<TwoFactorVerifyCodeResponse> result = await mFAController.CreateVerifyTwoFactorAsync(accountId, body);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | If there is any issue with values passed in by the user | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |
| 401 | Authentication is either incorrect or not present | [`UnauthorizedRequestException`]($m/MultiFactorAuth/UnauthorizedRequest) |
| 403 | The user is not authorized to access this resource | [`ForbiddenRequestException`]($m/MultiFactorAuth/ForbiddenRequest) |
| 429 | The user has made too many bad requests and is temporarily locked out | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |
| 500 | An internal server error occurred | [`ErrorWithRequestException`]($m/MultiFactorAuth/ErrorWithRequest) |

