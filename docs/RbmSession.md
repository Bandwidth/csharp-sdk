# Bandwidth.Standard.Model.RbmSession
RCS interactive session information for the message. An interactive session is a 24-hour window covering all Rich and Rich Media messages exchanged between an RCS agent and a specific end user mobile number. It is triggered when at least 4 messages are exchanged within 24 hours, at least 2 of them mobile-originated and at least 1 mobile-terminated. Only present on `message-delivered`, `message-received` and `session-started` callbacks for RBM messages of US agents with the Conversational billing category. Omitted for all other messages.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanInitiate** | **bool** | Whether the message can start an interactive session. &#x60;false&#x60; if the message is already part of an active session, or if the agent is not eligible for interactive session billing. | 
**Id** | **string** | The unique identifier of the interactive session the message is part of. This is not a message ID. Omitted if the message is not part of a session. | [optional] 
**Type** | **string** | The type of the interactive session. Only present on &#x60;session-started&#x60; callbacks. | [optional] 
**StartTime** | **DateTime?** | The time the 24-hour session window opened. Only present on &#x60;session-started&#x60; callbacks. | [optional] 
**EndTime** | **DateTime?** | The time the 24-hour session window closes. Only present on &#x60;session-started&#x60; callbacks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

