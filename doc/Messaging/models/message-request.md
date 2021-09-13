
# Message Request

## Structure

`MessageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplicationId` | `string` | Required | The ID of the Application your from number is associated with in the Bandwidth Phone Number Dashboard. |
| `To` | `List<string>` | Required | The phone number(s) the message should be sent to in E164 format<br>**Constraints**: *Unique Items Required* |
| `From` | `string` | Required | One of your telephone numbers the message should come from in E164 format |
| `Text` | `string` | Optional | The contents of the text message. Must be 2048 characters or less. |
| `Media` | `List<string>` | Optional | A list of URLs to include as media attachments as part of the message. |
| `Tag` | `string` | Optional | A custom string that will be included in callback events of the message. Max 1024 characters |
| `Priority` | [`Models.PriorityEnum?`](/doc/Messaging/models/priority-enum.md) | Optional | The message's priority, currently for toll-free or short code SMS only. Messages with a priority value of `"high"` are given preference over your other traffic. |

## Example (as JSON)

```json
{
  "applicationId": "93de2206-9669-4e07-948d-329f4b722ee2",
  "to": [
    "+15554443333",
    "+15552223333"
  ],
  "from": "+15551113333"
}
```

