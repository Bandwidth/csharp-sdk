
# Bandwidth.Standard.Model.TranscribeRecording

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | The URL to send the [TranscriptionAvailable](/docs/voice/webhooks/transcriptionAvailable) event to. You should not include sensitive or personally-identifiable information in the callbackUrl field! Always use the proper username and password fields for authorization. | [optional] 
**CallbackMethod** | **CallbackMethodEnum** |  | [optional] 
**Username** | **string** | Basic auth username. | [optional] 
**Password** | **string** | Basic auth password. | [optional] 
**Tag** | **string** | (optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present. | [optional] 
**CallbackTimeout** | **double?** | This is the timeout (in seconds) to use when delivering the webhook to &#x60;callbackUrl&#x60;. Can be any numeric value (including decimals) between 1 and 25. | [optional] [default to 15D]
**DetectLanguage** | **bool?** | A boolean value to indicate that the recording may not be in English, and the transcription service will need to detect the dominant language the recording is in and transcribe accordingly. Current supported languages are English, French, and Spanish. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

