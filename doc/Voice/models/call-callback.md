
# Call Callback

This object represents all possible fields that may be included in callbacks related to call events, including events that come from BXML verbs

## Structure

`CallCallback`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EventType` | `string` | Optional | - |
| `EventTime` | `string` | Optional | - |
| `AccountId` | `string` | Optional | - |
| `ApplicationId` | `string` | Optional | - |
| `From` | `string` | Optional | - |
| `To` | `string` | Optional | - |
| `Direction` | `string` | Optional | - |
| `CallId` | `string` | Optional | - |
| `CallUrl` | `string` | Optional | - |
| `StartTime` | `string` | Optional | - |
| `AnswerTime` | `string` | Optional | - |
| `TransferCallerId` | `string` | Optional | - |
| `TransferTo` | `string` | Optional | - |
| `Cause` | `string` | Optional | - |
| `ErrorMessage` | `string` | Optional | - |
| `ErrorId` | `string` | Optional | - |
| `EndTime` | `string` | Optional | - |
| `Digit` | `string` | Optional | - |
| `ParentCallId` | `string` | Optional | - |
| `RecordingId` | `string` | Optional | - |
| `Duration` | `string` | Optional | - |
| `FileFormat` | `string` | Optional | - |
| `MediaUrl` | `string` | Optional | - |
| `Tag` | `string` | Optional | - |
| `Channels` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `Digits` | `string` | Optional | - |
| `TerminatingDigit` | `string` | Optional | - |
| `Transcription` | [`Models.Transcription`](/doc/Voice/models/transcription.md) | Optional | - |
| `Diversion` | [`Models.Diversion`](/doc/Voice/models/diversion.md) | Optional | - |

## Example (as JSON)

```json
{
  "eventType": null,
  "eventTime": null,
  "accountId": null,
  "applicationId": null,
  "from": null,
  "to": null,
  "direction": null,
  "callId": null,
  "callUrl": null,
  "startTime": null,
  "answerTime": null,
  "transferCallerId": null,
  "transferTo": null,
  "cause": null,
  "errorMessage": null,
  "errorId": null,
  "endTime": null,
  "digit": null,
  "parentCallId": null,
  "recordingId": null,
  "duration": null,
  "fileFormat": null,
  "mediaUrl": null,
  "tag": null,
  "channels": null,
  "status": null,
  "digits": null,
  "terminatingDigit": null,
  "transcription": null,
  "diversion": null
}
```

