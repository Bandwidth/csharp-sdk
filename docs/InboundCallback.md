# Bandwidth.Standard.Model.InboundCallback
Represents an inbound callback.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **DateTime** |  | 
**Type** | **InboundCallbackTypeEnum** |  | 
**To** | **string** | The destination phone number the message was sent to. For inbound callbacks, this is the Bandwidth number or alphanumeric identifier that received the message.  | 
**Description** | **string** | A detailed description of the event described by the callback. | 
**Message** | [**InboundCallbackMessage**](InboundCallbackMessage.md) |  | 
**CarrierName** | **string** | The name of the Authorized Message Provider (AMP) that handled this message. In the US, this is the carrier that the message was sent to. This field is present only when this account feature has been enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

