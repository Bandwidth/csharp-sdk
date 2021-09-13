
# Accounts Participants Response

## Structure

`AccountsParticipantsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Participant` | [`Models.Participant`](/doc/WebRtc/models/participant.md) | Optional | A participant object |
| `Token` | `string` | Optional | Auth token for the returned participant<br><br>This should be passed to the participant so that they can connect to the platform |

## Example (as JSON)

```json
{
  "participant": null,
  "token": null
}
```

