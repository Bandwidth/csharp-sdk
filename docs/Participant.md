# Bandwidth.Standard.Model.Participant
Participant object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique id of the participant. | [optional] [readonly] 
**CallbackUrl** | **string** | Full callback url to use for notifications about this participant. | [optional] 
**PublishPermissions** | [**List&lt;PublishPermissionsEnum&gt;**](PublishPermissionsEnum.md) | Defines if this participant can publish audio or video. | [optional] 
**Sessions** | **List&lt;string&gt;** | List of session ids this participant is associated with  Capped to one  Upon creation of a Participant, returns as an empty array. | [optional] [readonly] 
**Subscriptions** | [**Subscriptions**](Subscriptions.md) |  | [optional] 
**Tag** | **string** | User defined tag to associate with the participant. | [optional] 
**DeviceApiVersion** | **DeviceApiVersionEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

