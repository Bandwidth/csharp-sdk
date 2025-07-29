# Bandwidth.Standard.Model.StatusCallbackMessage
Message payload schema within a callback

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier of the message. | 
**Owner** | **string** | The Bandwidth phone number or alphanumeric identifier associated with the message. | 
**ApplicationId** | **string** | The ID of the Application your from number or senderId is associated with in the Bandwidth Phone Number Dashboard. | 
**Time** | **DateTime** |  | 
**SegmentCount** | **int** | The number of segments the user&#39;s message is broken into before sending over carrier networks. | 
**Direction** | **MessageDirectionEnum** |  | 
**To** | **List&lt;string&gt;** | The phone number recipients of the message. | 
**From** | **string** | The Bandwidth phone number or alphanumeric identifier the message was sent from. | 
**Text** | **string** |  | [optional] 
**Tag** | **string** | A custom string that will be included in callback events of the message. Max 1024 characters. | [optional] 
**Media** | **List&lt;string&gt;** | Optional media, not applicable for sms | [optional] 
**Priority** | **PriorityEnum** |  | [optional] 
**Channel** | **MultiChannelMessageChannelEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

