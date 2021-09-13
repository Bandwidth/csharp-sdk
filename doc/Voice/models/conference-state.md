
# Conference State

## Structure

`ConferenceState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `CreatedTime` | `DateTime?` | Optional | - |
| `CompletedTime` | `DateTime?` | Optional | - |
| `ConferenceEventUrl` | `string` | Optional | - |
| `ConferenceEventMethod` | [`Models.ConferenceEventMethodEnum?`](/doc/Voice/models/conference-event-method-enum.md) | Optional | - |
| `Tag` | `string` | Optional | - |
| `ActiveMembers` | [`List<Models.ConferenceMemberState>`](/doc/Voice/models/conference-member-state.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": null,
  "name": null,
  "createdTime": null,
  "completedTime": null,
  "conferenceEventUrl": null,
  "conferenceEventMethod": null,
  "tag": null,
  "activeMembers": null
}
```

