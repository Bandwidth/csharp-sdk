# Bandwidth.Standard.Model.Message

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the message. | [optional] 
**Owner** | **string** | The Bandwidth phone number associated with the message. | [optional] 
**ApplicationId** | **string** | The application ID associated with the message. | [optional] 
**Time** | **DateTime** | The datetime stamp of the message in ISO 8601 | [optional] 
**SegmentCount** | **int** | The number of segments the original message from the user is broken into before sending over to carrier networks.  | [optional] 
**Direction** | **MessageDirectionEnum** |  | [optional] 
**To** | **List&lt;string&gt;** | The phone number recipients of the message. | [optional] 
**From** | **string** | The phone number the message was sent from. | [optional] 
**Media** | **List&lt;string&gt;** | The list of media URLs sent in the message. Including a &#x60;filename&#x60; field in the &#x60;Content-Disposition&#x60; header of the media linked with a URL will set the displayed file name. This is a best practice to ensure that your media has a readable file name.  | [optional] 
**Text** | **string** | The contents of the message. | [optional] 
**Tag** | **string** | The custom string set by the user. | [optional] 
**Priority** | **PriorityEnum** |  | [optional] 
**Expiration** | **DateTime** | The expiration date-time set by the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

