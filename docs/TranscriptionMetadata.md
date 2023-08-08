
# Bandwidth.Standard.Model.TranscriptionMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique transcription ID | [optional] 
**Status** | **string** | The current status of the process. For recording, current possible values are &#39;processing&#39;, &#39;partial&#39;, &#39;complete&#39;, &#39;deleted&#39;, and &#39;error&#39;. For transcriptions, current possible values are &#39;none&#39;, &#39;processing&#39;, &#39;available&#39;, &#39;error&#39;, &#39;timeout&#39;, &#39;file-size-too-big&#39;, and &#39;file-size-too-small&#39;. Additional states may be added in the future, so your application must be tolerant of unknown values. | [optional] 
**CompletedTime** | **string** | The time that the transcription was completed | [optional] 
**Url** | **string** | The URL of the [transcription](#operation/getCallTranscription) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

