
# Bandwidth Message

## Structure

`BandwidthMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The id of the message |
| `Owner` | `string` | Optional | The Bandwidth phone number associated with the message |
| `ApplicationId` | `string` | Optional | The application ID associated with the message |
| `Time` | `string` | Optional | The datetime stamp of the message in ISO 8601 |
| `SegmentCount` | `int?` | Optional | The number of segments the original message from the user is broken into before sending over to carrier networks |
| `Direction` | `string` | Optional | The direction of the message relative to Bandwidth. Can be in or out |
| `To` | `List<string>` | Optional | The phone number recipients of the message<br>**Constraints**: *Unique Items Required* |
| `From` | `string` | Optional | The phone number the message was sent from |
| `Media` | `List<string>` | Optional | The list of media URLs sent in the message. Including a `filename` field in the `Content-Disposition` header of the media linked with a URL will set the displayed file name. This is a best practice to ensure that your media has a readable file name.<br>**Constraints**: *Unique Items Required* |
| `Text` | `string` | Optional | The contents of the message |
| `Tag` | `string` | Optional | The custom string set by the user |
| `Priority` | `string` | Optional | The priority specified by the user |

## Example (as JSON)

```json
{
  "id": null,
  "owner": null,
  "applicationId": null,
  "time": null,
  "segmentCount": null,
  "direction": null,
  "to": null,
  "from": null,
  "media": null,
  "text": null,
  "tag": null,
  "priority": null
}
```

