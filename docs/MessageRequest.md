# Bandwidth.Standard.Model.MessageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **string** | The ID of the Application your from number is associated with in the Bandwidth Phone Number Dashboard. | 
**To** | **List&lt;string&gt;** | The phone number(s) the message should be sent to in E164 format. | 
**From** | **string** | One of your telephone numbers the message should come from in E164 format. | 
**Text** | **string** | The contents of the text message. Must be 2048 characters or less. | [optional] 
**Media** | **List&lt;string&gt;** | A list of URLs to include as media attachments as part of the message. | [optional] 
**Tag** | **string** | A custom string that will be included in callback events of the message. Max 1024 characters. | [optional] 
**Priority** | **PriorityEnum** |  | [optional] 
**Expiration** | **string** | A string with the date/time value that the message will automatically expire by. This must be a valid RFC-3339 value, e.g., 2021-03-14T01:59:26Z or 2021-03-13T20:59:26-05:00. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

