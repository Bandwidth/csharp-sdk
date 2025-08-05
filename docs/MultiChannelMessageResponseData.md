# Bandwidth.Standard.Model.MultiChannelMessageResponseData
The data returned in a multichannel message response.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | The ID of the message. | 
**Time** | **DateTime** | The time the message was received by the Bandwidth API. | 
**Direction** | **MessageDirectionEnum** |  | 
**To** | **List&lt;string&gt;** | The destination phone number(s) of the message, in E164 format. | 
**ChannelList** | [**List&lt;MultiChannelMessageResponseDataChannelListInner&gt;**](MultiChannelMessageResponseDataChannelListInner.md) | A list of message bodies. The messages will be attempted in the order they are listed. Once a message sends successfully, the others will be ignored. | 
**Tag** | **string** | A custom string that will be included in callback events of the message. Max 1024 characters. | [optional] 
**Priority** | **PriorityEnum** |  | [optional] 
**Expiration** | **DateTime** | A string with the date/time value that the message will automatically expire by. This must be a valid RFC-3339 value, e.g., 2021-03-14T01:59:26Z or 2021-03-13T20:59:26-05:00. Must be a date-time in the future. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

