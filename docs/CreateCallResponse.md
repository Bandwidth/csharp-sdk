# Bandwidth.Standard.Model.CreateCallResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationId** | **string** | The id of the application associated with the &#x60;from&#x60; number. | 
**AccountId** | **string** | The bandwidth account ID associated with the call. | 
**CallId** | **string** | Programmable Voice API Call ID. | 
**To** | **string** | Recipient of the outgoing call. | 
**From** | **string** | Phone number that created the outbound call. | 
**EnqueuedTime** | **DateTime?** | The time at which the call was accepted into the queue. | [optional] 
**CallUrl** | **string** | The URL to update this call&#39;s state. | 
**CallTimeout** | **double** | The timeout (in seconds) for the callee to answer the call after it starts ringing. | [optional] 
**CallbackTimeout** | **double** | This is the timeout (in seconds) to use when delivering webhooks for the call. | [optional] 
**Tag** | **string** | Custom tag value. | [optional] 
**AnswerMethod** | **CallbackMethodEnum** |  | 
**AnswerUrl** | **string** | URL to deliver the &#x60;answer&#x60; event webhook. | 
**AnswerFallbackMethod** | **CallbackMethodEnum** |  | [optional] 
**AnswerFallbackUrl** | **string** | Fallback URL to deliver the &#x60;answer&#x60; event webhook. | [optional] 
**DisconnectMethod** | **CallbackMethodEnum** |  | 
**DisconnectUrl** | **string** | URL to deliver the &#x60;disconnect&#x60; event webhook. | [optional] 
**Username** | **string** | Basic auth username. | [optional] 
**Password** | **string** | Basic auth password. | [optional] 
**FallbackUsername** | **string** | Basic auth username. | [optional] 
**FallbackPassword** | **string** | Basic auth password. | [optional] 
**Priority** | **int?** | The priority of this call over other calls from your account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

