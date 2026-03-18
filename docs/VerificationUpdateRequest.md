# Bandwidth.Standard.Model.VerificationUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessAddress** | [**Address**](Address.md) |  | 
**BusinessContact** | [**Contact**](Contact.md) |  | 
**MessageVolume** | **int** | Estimated monthly volume of messages from the toll-free number. | 
**UseCase** | **string** | The category of the use case. | 
**UseCaseSummary** | **string** | A general idea of the use case and customer. | 
**ProductionMessageContent** | **string** | Example of message content. | 
**OptInWorkflow** | [**OptInWorkflow**](OptInWorkflow.md) |  | 
**AdditionalInformation** | **string** | Any additional information. | [optional] 
**IsvReseller** | **string** | ISV name. | [optional] 
**PrivacyPolicyUrl** | **string** | The Toll-Free Verification request privacy policy URL. | [optional] 
**TermsAndConditionsUrl** | **string** | The Toll-Free Verification request terms and conditions policy URL. | [optional] 
**BusinessDba** | **string** | The company &#39;Doing Business As&#39;. | [optional] 
**BusinessRegistrationNumber** | **string** | Government-issued business identifying number.  **Note:** If this field is provided, it is strongly recommended to also provide &#x60;businessRegistrationType&#x60; and &#x60;businessRegistrationIssuingCountry&#x60;. Submissions missing these fields have a high likelihood of rejection.  | [optional] 
**BusinessRegistrationType** | **BusinessRegistrationTypeEnum** |  | [optional] 
**BusinessEntityType** | **BusinessEntityTypeEnum** |  | [optional] 
**BusinessRegistrationIssuingCountry** | **BusinessRegistrationIssuingCountryEnum** |  | [optional] 
**HelpMessageResponse** | **string** | A message that gets sent to users requesting help. | [optional] 
**AgeGatedContent** | **bool** | Indicates whether the content is age-gated. | [optional] 
**CvToken** | **string** | The token provided by Campaign Verify to validate your political use case. Only required for 527 political organizations. If you are not a 527 political organization, this field should be omitted. Supplying an empty string will likely result in rejection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

