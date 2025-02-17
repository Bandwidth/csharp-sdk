# Bandwidth.Standard.Model.WebhookSubscriptionRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BasicAuthentication** | [**TfvBasicAuthentication**](TfvBasicAuthentication.md) |  | [optional] 
**CallbackUrl** | **string** | Callback URL to receive status updates from Bandwidth. When a webhook subscription is registered with Bandwidth under a given account ID, it will be used to send status updates for all requests submitted under that account ID. | 
**SharedSecretKey** | **string** | An ASCII string submitted by the user as a shared secret key for generating an HMAC header for callbacks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

