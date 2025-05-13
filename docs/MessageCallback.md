# Bandwidth.Standard.Model.MessageCallback
Message Callback Schema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **DateTime** |  | 
**Type** | **CallbackTypeEnum** |  | 
**To** | **string** |  | 
**Description** | **string** | A detailed description of the event described by the callback. | 
**Message** | [**MessageCallbackMessage**](MessageCallbackMessage.md) |  | 
**ErrorCode** | **int?** | Optional error code, applicable only when type is &#x60;message-failed&#x60;. | [optional] 
**CarrierName** | **string** | The name of the Authorized Message Provider (AMP) that handled this message. In the US, this is the carrier that the message was sent to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

