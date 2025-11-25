# Bandwidth.Standard.Model.LookupResult
Carrier information results for the specified telephone number.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneNumber** | **string** | The telephone number in E.164 format. | [optional] 
**LineType** | **LineTypeEnum** |  | [optional] 
**MessagingProvider** | **string** | The messaging service provider of the telephone number. | [optional] 
**VoiceProvider** | **string** | The voice service provider of the telephone number. | [optional] 
**CountryCodeA3** | **string** | The country code of the telephone number in ISO 3166-1 alpha-3 format. | [optional] 
**DeactivationReporter** | **string** | [DNI-Only](#section/DNI-Only). The carrier that reported a deactivation event for this phone number.  | [optional] 
**DeactivationDate** | **string** | [DNI-Only](#section/DNI-Only). The datetime the carrier reported a deactivation event. | [optional] 
**DeactivationEvent** | **DeactivationEventEnum** |  | [optional] 
**LatestMessageDeliveryStatus** | **LatestMessageDeliveryStatusEnum** |  | [optional] 
**InitialMessageDeliveryStatusDate** | **DateTime** | [DNI-Only](#section/DNI-Only). The date the phone number entered the status described in &#x60;latestMessageDeliveryStatus&#x60;.  Think of this as the \&quot;start time\&quot; for that status. Value resets every time the &#x60;latestMessageDeliveryStatus&#x60; changes. | [optional] 
**LatestMessageDeliveryStatusDate** | **DateTime** | [DNI-Only](#section/DNI-Only). The date bandwidth last received delivery status information for this phone number.  Use this field to understand how up-to-date the &#x60;latestMessageDeliveryStatus&#x60; is. Value resets every time the &#x60;latestMessageDeliveryStatus&#x60; changes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

