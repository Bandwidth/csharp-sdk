
# Participant

A participant object

## Structure

`Participant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique id of the participant |
| `CallbackUrl` | `string` | Optional | Full callback url to use for notifications about this participant |
| `PublishPermissions` | [`List<Models.PublishPermissionEnum>`](/doc/WebRtc/models/publish-permission-enum.md) | Optional | Defines if this participant can publish audio or video<br>**Constraints**: *Unique Items Required* |
| `Sessions` | `List<string>` | Optional | List of session ids this participant is associated with<br><br>Capped to one |
| `Subscriptions` | [`Models.Subscriptions`](/doc/WebRtc/models/subscriptions.md) | Optional | - |
| `Tag` | `string` | Optional | User defined tag to associate with the participant |
| `DeviceApiVersion` | [`Models.DeviceApiVersionEnum?`](/doc/WebRtc/models/device-api-version-enum.md) | Optional | Optional field to define the device api version of this participant<br>**Default**: `DeviceApiVersionEnum.V2`<br>*Default: `DeviceApiVersionEnum.V2`* |

## Example (as JSON)

```json
{
  "id": null,
  "callbackUrl": null,
  "publishPermissions": null,
  "sessions": null,
  "subscriptions": null,
  "tag": null,
  "deviceApiVersion": null
}
```

