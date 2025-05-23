# Bandwidth.Standard.Model.MultiChannelChannelListObjectContent
The content of the message.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The contents of the text message. Must be 2048 characters or less. | 
**Suggestions** | [**List&lt;MultiChannelAction&gt;**](MultiChannelAction.md) | An array of suggested actions for the recipient. | [optional] 
**Media** | **List&lt;string&gt;** | A list of URLs to include as media attachments as part of the message. Each URL can be at most 4096 characters. | 
**Orientation** | **StandaloneCardOrientationEnum** |  | 
**ThumbnailImageAlignment** | **ThumbnailAlignmentEnum** |  | 
**CardContent** | [**RbmCardContent**](RbmCardContent.md) |  | 
**CardWidth** | **CardWidthEnum** |  | 
**CardContents** | [**List&lt;RbmCardContent&gt;**](RbmCardContent.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

