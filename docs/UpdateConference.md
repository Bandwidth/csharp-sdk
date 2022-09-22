# Bandwidth.Standard.Model.UpdateConference

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **ConferenceStateEnum** |  | [optional] 
**RedirectUrl** | **string** | The URL to send the [conferenceRedirect](/docs/voice/webhooks/conferenceRedirect) event which will provide new BXML. Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;, but required if &#x60;state&#x60; is &#x60;active&#x60; | [optional] 
**RedirectMethod** | **RedirectMethodEnum** |  | [optional] 
**Username** | **string** | Basic auth username. | [optional] 
**Password** | **string** | Basic auth password. | [optional] 
**RedirectFallbackUrl** | **string** | A fallback url which, if provided, will be used to retry the &#x60;conferenceRedirect&#x60; webhook delivery in case &#x60;redirectUrl&#x60; fails to respond.  Not allowed if &#x60;state&#x60; is &#x60;completed&#x60;. | [optional] 
**RedirectFallbackMethod** | **RedirectMethodEnum** |  | [optional] 
**FallbackUsername** | **string** | Basic auth username. | [optional] 
**FallbackPassword** | **string** | Basic auth password. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

