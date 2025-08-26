# Bandwidth.Standard.Model.TfvSubmissionInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessAddress** | [**Address**](Address.md) |  | [optional] 
**BusinessContact** | [**Contact**](Contact.md) |  | [optional] 
**MessageVolume** | **int** | Estimated monthly volume of messages from the toll-free number. | [optional] 
**UseCase** | **string** | The category of the use case. | [optional] 
**UseCaseSummary** | **string** | A general idea of the use case and customer. | [optional] 
**ProductionMessageContent** | **string** | Example of message content. | [optional] 
**OptInWorkflow** | [**OptInWorkflow**](OptInWorkflow.md) |  | [optional] 
**AdditionalInformation** | **string** | Any additional information. | [optional] 
**IsvReseller** | **string** | ISV name. | [optional] 
**PrivacyPolicyUrl** | **string** | The Toll-Free Verification request privacy policy URL. | [optional] 
**TermsAndConditionsUrl** | **string** | The Toll-Free Verification request terms and conditions policy URL. | [optional] 
**BusinessDba** | **string** | The company &#39;Doing Business As&#39;. | [optional] 
**BusinessRegistrationNumber** | **string** | US Federal Tax ID Number (EIN) or Canada Business Number (CBN). Optional until early 2026. If a value is provided for this field, a value must be provided for &#x60;businessRegistrationType&#x60; and &#x60;businessEntityType&#x60;. Available starting October 1st, 2025. | [optional] 
**BusinessRegistrationType** | **BusinessRegistrationTypeEnum** |  | [optional] 
**BusinessEntityType** | **BusinessEntityTypeEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

