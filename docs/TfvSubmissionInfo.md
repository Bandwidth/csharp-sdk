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
**BusinessRegistrationNumber** | **string** | Government-issued business identifying number.  **Note:** If this field is provided, it is strongly recommended to also provide &#x60;businessRegistrationType&#x60; and &#x60;businessRegistrationIssuingCountry&#x60;. Submissions missing these fields have a high likelihood of rejection.  | [optional] 
**BusinessRegistrationType** | **BusinessRegistrationTypeEnum** |  | [optional] 
**BusinessRegistrationIssuingCountry** | **BusinessRegistrationIssuingCountryEnum** |  | [optional] 
**BusinessEntityType** | **BusinessEntityTypeEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

