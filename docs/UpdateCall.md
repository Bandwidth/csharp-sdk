# Bandwidth.Standard.Model.UpdateCall

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **CallStateEnum** |  | [optional] 
**RedirectUrl** | **string** | The URL to send the [Redirect](/docs/voice/bxml/redirect) event to which will provide new BXML.  Required if &#x60;state&#x60; is &#x60;active&#x60;.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;. | [optional] 
**RedirectMethod** | **RedirectMethodEnum** |  | [optional] 
**Username** | **string** | Basic auth username. | [optional] 
**Password** | **string** | Basic auth password. | [optional] 
**RedirectFallbackUrl** | **string** | A fallback url which, if provided, will be used to retry the redirect callback delivery in case &#x60;redirectUrl&#x60; fails to respond. | [optional] 
**RedirectFallbackMethod** | **RedirectMethodEnum** |  | [optional] 
**FallbackUsername** | **string** | Basic auth username. | [optional] 
**FallbackPassword** | **string** | Basic auth password. | [optional] 
**Tag** | **string** | A custom string that will be sent with this and all future callbacks unless overwritten by a future &#x60;tag&#x60; attribute or [&#x60;&lt;Tag&gt;&#x60;](/docs/voice/bxml/tag) verb, or cleared.  May be cleared by setting &#x60;tag&#x3D;\&quot;\&quot;&#x60;.  Max length 256 characters.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

