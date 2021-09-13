
# Bandwidth Message Item

## Structure

`BandwidthMessageItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessageId` | `string` | Optional | The message id |
| `AccountId` | `string` | Optional | The account id of the message |
| `SourceTn` | `string` | Optional | The source phone number of the message |
| `DestinationTn` | `string` | Optional | The recipient phone number of the message |
| `MessageStatus` | `string` | Optional | The status of the message |
| `MessageDirection` | `string` | Optional | The direction of the message relative to Bandwidth. INBOUND or OUTBOUND |
| `MessageType` | `string` | Optional | The type of message. sms or mms |
| `SegmentCount` | `int?` | Optional | The number of segments the message was sent as |
| `ErrorCode` | `int?` | Optional | The numeric error code of the message |
| `ReceiveTime` | `string` | Optional | The ISO 8601 datetime of the message |
| `CarrierName` | `string` | Optional | The name of the carrier. Not currently supported for MMS, coming soon |
| `MessageSize` | `int?` | Optional | The size of the message including message content and headers |
| `MessageLength` | `int?` | Optional | The length of the message content |
| `AttachmentCount` | `int?` | Optional | The number of attachments the message has |
| `RecipientCount` | `int?` | Optional | The number of recipients the message has |
| `CampaignClass` | `string` | Optional | The campaign class of the message, if it has one |

## Example (as JSON)

```json
{
  "messageId": null,
  "accountId": null,
  "sourceTn": null,
  "destinationTn": null,
  "messageStatus": null,
  "messageDirection": null,
  "messageType": null,
  "segmentCount": null,
  "errorCode": null,
  "receiveTime": null,
  "carrierName": null,
  "messageSize": null,
  "messageLength": null,
  "attachmentCount": null,
  "recipientCount": null,
  "campaignClass": null
}
```

