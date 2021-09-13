
# Call Recording Metadata

## Structure

`CallRecordingMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplicationId` | `string` | Optional | - |
| `AccountId` | `string` | Optional | - |
| `CallId` | `string` | Optional | - |
| `ParentCallId` | `string` | Optional | - |
| `RecordingId` | `string` | Optional | - |
| `To` | `string` | Optional | - |
| `From` | `string` | Optional | - |
| `TransferCallerId` | `string` | Optional | - |
| `TransferTo` | `string` | Optional | - |
| `Duration` | `string` | Optional | Format is ISO-8601 |
| `Direction` | [`Models.DirectionEnum?`](/doc/Voice/models/direction-enum.md) | Optional | - |
| `Channels` | `int?` | Optional | - |
| `StartTime` | `DateTime?` | Optional | - |
| `EndTime` | `DateTime?` | Optional | - |
| `FileFormat` | [`Models.FileFormatEnum?`](/doc/Voice/models/file-format-enum.md) | Optional | - |
| `Status` | `string` | Optional | The current status of the recording. Current values are 'processing', 'partial', 'complete', 'deleted' and 'error'. Additional states may be added in the future, so your application must be tolerant of unknown values. |
| `MediaUrl` | `string` | Optional | - |
| `Transcription` | [`Models.TranscriptionMetadata`](/doc/Voice/models/transcription-metadata.md) | Optional | - |

## Example (as JSON)

```json
{
  "applicationId": null,
  "accountId": null,
  "callId": null,
  "parentCallId": null,
  "recordingId": null,
  "to": null,
  "from": null,
  "transferCallerId": null,
  "transferTo": null,
  "duration": null,
  "direction": null,
  "channels": null,
  "startTime": null,
  "endTime": null,
  "fileFormat": null,
  "status": null,
  "mediaUrl": null,
  "transcription": null
}
```

