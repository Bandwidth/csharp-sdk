
# Conference Recording Metadata

## Structure

`ConferenceRecordingMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `string` | Optional | - |
| `ConferenceId` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `RecordingId` | `string` | Optional | - |
| `Duration` | `string` | Optional | Format is ISO-8601 |
| `Channels` | `int?` | Optional | - |
| `StartTime` | `DateTime?` | Optional | - |
| `EndTime` | `DateTime?` | Optional | - |
| `FileFormat` | [`Models.FileFormatEnum?`](/doc/Voice/models/file-format-enum.md) | Optional | - |
| `Status` | `string` | Optional | The current status of the recording. Current possible values are 'processing', 'partial', 'complete', 'deleted', and 'error'. Additional states may be added in the future, so your application must be tolerant of unknown values. |
| `MediaUrl` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "accountId": null,
  "conferenceId": null,
  "name": null,
  "recordingId": null,
  "duration": null,
  "channels": null,
  "startTime": null,
  "endTime": null,
  "fileFormat": null,
  "status": null,
  "mediaUrl": null
}
```

