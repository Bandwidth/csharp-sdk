# Bandwidth.Standard.Model.VerificationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessAddress** | [**Address**](Address.md) |  | 
**BusinessContact** | [**Contact**](Contact.md) |  | 
**MessageVolume** | **int** | Estimated monthly volume of messages from the toll-free number. | 
**PhoneNumbers** | **List&lt;string&gt;** |  | 
**UseCase** | **string** | The category of the use case. | 
**UseCaseSummary** | **string** | A general idea of the use case and customer. | 
**ProductionMessageContent** | **string** | Example of message content. | 
**OptInWorkflow** | [**OptInWorkflow**](OptInWorkflow.md) |  | 
**AdditionalInformation** | **string** | Any additional information. | [optional] 
**IsvReseller** | **string** | ISV name. | [optional] 
**PrivacyPolicyUrl** | **string** | The Toll-Free Verification request privacy policy URL. | [optional] 
**TermsAndConditionsUrl** | **string** | The Toll-Free Verification request terms and conditions policy URL. | [optional] 
**BusinessDba** | **string** | The company &#39;Doing Business As&#39;. | [optional] 
**BusinessRegistrationNumber** | **string** | US Federal Tax ID Number (EIN) or Canada Business Number (CBN). Optional until early 2026. If a value is provided for this field, a value must be provided for &#x60;businessRegistrationType&#x60; and &#x60;businessEntityType&#x60;. Available starting October 1st, 2025. | [optional] 
**BusinessRegistrationType** | **BusinessRegistrationTypeEnum** |  | [optional] 
**BusinessEntityType** | **BusinessEntityTypeEnum** |  | [optional] 
**HelpMessageResponse** | **string** | A message that gets sent to users requesting help. | [optional] 
**AgeGatedContent** | **bool** | Indicates whether the content is age-gated. | [optional] 
**CvToken** | **string** | The token provided by Campaign Verify to validate your political use case. Only required for 527 political organizations. If you are not a 527 political organization, this field should be omitted. If you pass an empty string, it will be passed along and potentially rejected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

