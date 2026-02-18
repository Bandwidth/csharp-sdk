# Bandwidth.Standard.Model.StatusCallback
Represents a status callback for an outbound MT SMS or MMS or RBM message.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **DateTime** |  | 
**EventTime** | **DateTime** | Represents the time at which the message was read, for &#x60;message-read&#x60; callbacks. | [optional] 
**Type** | **StatusCallbackTypeEnum** |  | 
**To** | **string** | The destination phone number the message was sent to. For status callbacks, this the the Bandwidth user&#39;s client phone number. | 
**Description** | **string** | A detailed description of the event described by the callback. | 
**Message** | [**StatusCallbackMessage**](StatusCallbackMessage.md) |  | 
**ErrorCode** | **int** | Optional error code, applicable only when type is &#x60;message-failed&#x60;. | [optional] 
**CarrierName** | **string** | The name of the Authorized Message Provider (AMP) that handled this message. In the US, this is the carrier that the message was sent to. This field is present only when this account feature has been enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

