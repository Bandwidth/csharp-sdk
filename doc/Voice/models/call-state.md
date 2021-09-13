
# Call State

## Structure

`CallState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CallId` | `string` | Optional | - |
| `ParentCallId` | `string` | Optional | - |
| `ApplicationId` | `string` | Optional | - |
| `AccountId` | `string` | Optional | - |
| `To` | `string` | Optional | - |
| `From` | `string` | Optional | - |
| `Direction` | `string` | Optional | - |
| `State` | `string` | Optional | The current state of the call. Current possible values are 'initiated', 'answered' and 'disconnected'. Additional states may be added in the future, so your application must be tolerant of unknown values. |
| `Identity` | `string` | Optional | - |
| `StirShaken` | `Dictionary<string, string>` | Optional | - |
| `StartTime` | `DateTime?` | Optional | - |
| `AnswerTime` | `DateTime?` | Optional | - |
| `EndTime` | `DateTime?` | Optional | - |
| `DisconnectCause` | `string` | Optional | The reason the call was disconnected, or null if the call is still active. Current values are 'cancel', 'timeout', 'busy', 'rejected', 'hangup', 'invalid-bxml', 'callback-error', 'application-error', 'error', 'account-limit', 'node-capacity-exceeded' and 'unknown'. Additional causes may be added in the future, so your application must be tolerant of unknown values. |
| `ErrorMessage` | `string` | Optional | - |
| `ErrorId` | `string` | Optional | - |
| `LastUpdate` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "callId": null,
  "parentCallId": null,
  "applicationId": null,
  "accountId": null,
  "to": null,
  "from": null,
  "direction": null,
  "state": null,
  "identity": null,
  "stirShaken": null,
  "startTime": null,
  "answerTime": null,
  "endTime": null,
  "disconnectCause": null,
  "errorMessage": null,
  "errorId": null,
  "lastUpdate": null
}
```

