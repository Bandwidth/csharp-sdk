# Bandwidth.Standard.Model.ListMessageItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | The message id | [optional] 
**AccountId** | **string** | The account id associated with this message. | [optional] 
**SourceTn** | **string** | The source phone number of the message. | [optional] 
**DestinationTn** | **string** | The recipient phone number of the message. | [optional] 
**MessageStatus** | **MessageStatusEnum** |  | [optional] 
**MessageDirection** | **ListMessageDirectionEnum** |  | [optional] 
**MessageType** | **MessageTypeEnum** |  | [optional] 
**SegmentCount** | **int** | The number of segments the user&#39;s message is broken into before sending over carrier networks. | [optional] 
**ErrorCode** | **int** | The numeric error code of the message. | [optional] 
**ReceiveTime** | **DateTime** | The ISO 8601 datetime of the message. | [optional] 
**CarrierName** | **string** | The name of the carrier. Not currently supported for MMS coming soon. | [optional] 
**MessageSize** | **int?** | The size of the message including message content and headers. | [optional] 
**MessageLength** | **int** | The length of the message content. | [optional] 
**AttachmentCount** | **int?** | The number of attachments the message has. | [optional] 
**RecipientCount** | **int?** | The number of recipients the message has. | [optional] 
**CampaignClass** | **string** | The campaign class of the message if it has one. | [optional] 
**CampaignId** | **string** | The campaign ID of the message if it has one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

