# Bandwidth.Standard.Model.RecordingCompleteCallback
The Record Complete event is sent after a <Record> verb has executed if the call is still active. The BXML returned by this callback is executed next. When the recording is available for download, a Recording Available event will be sent.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The event type, value can be one of the following: answer, bridgeComplete, bridgeTargetComplete, conferenceCreated, conferenceRedirect, conferenceMemberJoin, conferenceMemberExit, conferenceCompleted, conferenceRecordingAvailable, disconnect, dtmf, gather, initiate, machineDetectionComplete, recordingComplete, recordingAvailable, redirect, transcriptionAvailable, transferAnswer, transferComplete, transferDisconnect. | [optional] 
**EventTime** | **DateTime** | The approximate UTC date and time when the event was generated by the Bandwidth server, in ISO 8601 format. This may not be exactly the time of event execution. | [optional] 
**AccountId** | **string** | The user account associated with the call. | [optional] 
**ApplicationId** | **string** | The id of the application associated with the call. | [optional] 
**From** | **string** | The provided identifier of the caller. Must be a phone number in E.164 format (e.g. +15555555555). | [optional] 
**To** | **string** | The phone number that received the call, in E.164 format (e.g. +15555555555). | [optional] 
**Direction** | **CallDirectionEnum** |  | [optional] 
**CallId** | **string** | The call id associated with the event. | [optional] 
**CallUrl** | **string** | The URL of the call associated with the event. | [optional] 
**ParentCallId** | **string** | (optional) If the event is related to the B leg of a &lt;Transfer&gt;, the call id of the original call leg that executed the &lt;Transfer&gt;. Otherwise, this field will not be present. | [optional] 
**RecordingId** | **string** | The unique ID of this recording | [optional] 
**MediaUrl** | **string** | The URL that can be used to download the recording. Only present if the recording is finished and may be downloaded. | [optional] 
**EnqueuedTime** | **DateTime?** | (optional) If call queueing is enabled and this is an outbound call, time the call was queued, in ISO 8601 format. | [optional] 
**StartTime** | **DateTime** | Time the call was started, in ISO 8601 format. | [optional] 
**AnswerTime** | **DateTime?** | Time the call was answered, in ISO 8601 format. | [optional] 
**EndTime** | **DateTime** | The time that the recording ended in ISO-8601 format | [optional] 
**Duration** | **string** | The duration of the recording in ISO-8601 format | [optional] 
**FileFormat** | **FileFormatEnum** |  | [optional] 
**Channels** | **int** | Always &#x60;1&#x60; for conference recordings; multi-channel recordings are not supported on conferences. | [optional] 
**Tag** | **string** | (optional) The tag specified on call creation. If no tag was specified or it was previously cleared, this field will not be present. | [optional] 
**TransferCallerId** | **string** | The phone number used as the from field of the B-leg call, in E.164 format (e.g. +15555555555). | [optional] 
**TransferTo** | **string** | The phone number used as the to field of the B-leg call, in E.164 format (e.g. +15555555555). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

