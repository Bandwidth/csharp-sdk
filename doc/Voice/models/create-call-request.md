
# Create Call Request

## Structure

`CreateCallRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `From` | `string` | Required | Format is E164 |
| `To` | `string` | Required | Format is E164 or SIP URI |
| `Uui` | `string` | Optional | A comma-separated list of 'User-To-User' headers to be sent in the INVITE when calling a SIP URI. Each value must end with an 'encoding' parameter as described in https://tools.ietf.org/html/rfc7433. Only 'jwt' and 'base64' encodings are allowed. The entire value cannot exceed 350 characters, including parameters and separators. |
| `CallTimeout` | `double?` | Optional | - |
| `CallbackTimeout` | `double?` | Optional | - |
| `AnswerUrl` | `string` | Required | - |
| `AnswerFallbackUrl` | `string` | Optional | - |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `FallbackUsername` | `string` | Optional | - |
| `FallbackPassword` | `string` | Optional | - |
| `AnswerMethod` | [`Models.AnswerMethodEnum?`](/doc/Voice/models/answer-method-enum.md) | Optional | - |
| `AnswerFallbackMethod` | [`Models.AnswerFallbackMethodEnum?`](/doc/Voice/models/answer-fallback-method-enum.md) | Optional | - |
| `DisconnectUrl` | `string` | Optional | - |
| `DisconnectMethod` | [`Models.DisconnectMethodEnum?`](/doc/Voice/models/disconnect-method-enum.md) | Optional | - |
| `Tag` | `string` | Optional | - |
| `ApplicationId` | `string` | Required | - |
| `MachineDetection` | [`Models.MachineDetectionRequest`](/doc/Voice/models/machine-detection-request.md) | Optional | - |

## Example (as JSON)

```json
{
  "from": "+15555555555",
  "to": "+15555555555, sip:john@doe.com",
  "answerUrl": null,
  "applicationId": null
}
```

