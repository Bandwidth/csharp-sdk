
# Bandwidth.Standard.Model.Conference

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Bandwidth-generated conference ID. | [optional] 
**Name** | **string** | The name of the conference, as specified by your application. | [optional] 
**CreatedTime** | **DateTime** | The time the conference was initiated, in ISO 8601 format. | [optional] 
**CompletedTime** | **DateTime?** | The time the conference was terminated, in ISO 8601 format. | [optional] 
**ConferenceEventUrl** | **string** | The URL to send the conference-related events. | [optional] 
**ConferenceEventMethod** | **CallbackMethodEnum** |  | [optional] 
**Tag** | **string** | The custom string attached to the conference that will be sent with callbacks. | [optional] 
**ActiveMembers** | [**List&lt;ConferenceMember&gt;**](ConferenceMember.md) | A list of active members of the conference. Omitted if this is a response to the [Get Conferences endpoint](/apis/voice#tag/Conferences/operation/listConferences). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

