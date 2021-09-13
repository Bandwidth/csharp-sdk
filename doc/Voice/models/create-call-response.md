
# Create Call Response

## Structure

`CreateCallResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Required | - |
| `CallId` | `string` | Required | - |
| `ApplicationId` | `string` | Required | - |
| `To` | `string` | Required | - |
| `From` | `string` | Required | - |
| `StartTime` | `DateTime?` | Optional | - |
| `CallUrl` | `string` | Required | - |
| `CallTimeout` | `double?` | Optional | - |
| `CallbackTimeout` | `double?` | Optional | - |
| `AnswerUrl` | `string` | Required | - |
| `AnswerMethod` | [`Models.AnswerMethodEnum`](/doc/Voice/models/answer-method-enum.md) | Required | - |
| `AnswerFallbackUrl` | `string` | Optional | - |
| `AnswerFallbackMethod` | [`Models.AnswerFallbackMethodEnum?`](/doc/Voice/models/answer-fallback-method-enum.md) | Optional | - |
| `DisconnectUrl` | `string` | Optional | - |
| `DisconnectMethod` | [`Models.DisconnectMethodEnum?`](/doc/Voice/models/disconnect-method-enum.md) | Required | - |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `FallbackUsername` | `string` | Optional | - |
| `FallbackPassword` | `string` | Optional | - |
| `Tag` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "accountId": "accountId0",
  "callId": "callId0",
  "applicationId": "applicationId0",
  "to": "to6",
  "from": "from2",
  "startTime": null,
  "callUrl": "callUrl2",
  "callTimeout": null,
  "callbackTimeout": null,
  "answerUrl": "answerUrl8",
  "answerMethod": "POST",
  "answerFallbackUrl": null,
  "answerFallbackMethod": null,
  "disconnectUrl": null,
  "disconnectMethod": "POST",
  "username": null,
  "password": null,
  "fallbackUsername": null,
  "fallbackPassword": null,
  "tag": null
}
```

