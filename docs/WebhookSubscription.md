# Bandwidth.Standard.Model.WebhookSubscription
Information about a webhook that Bandwidth should send upon the completion of event customer has subscribed to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**AccountId** | **string** |  | [optional] 
**CallbackUrl** | **string** | Callback URL to receive status updates from Bandwidth. When a webhook subscription is registered with Bandwidth under a given account ID, it will be used to send status updates for all requests submitted under that account ID. | 
**Type** | **WebhookSubscriptionTypeEnum** |  | [optional] 
**BasicAuthentication** | [**WebhookSubscriptionBasicAuthentication**](WebhookSubscriptionBasicAuthentication.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | [optional] 
**ModifiedDate** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

