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
**BusinessRegistrationNumber** | **string** | Government-issued business identifying number.  **Note: As of October 19th, 2026 this field will be required when &#x60;businessEntityType&#x60; is _not_ &#x60;SOLE_PROPRIETOR&#x60;. If this field is provided, &#x60;businessRegistrationType&#x60; and &#x60;businessRegistrationIssuingCountry&#x60; are also required.**  | [optional] 
**BusinessRegistrationType** | **BusinessRegistrationTypeEnum** |  | [optional] 
**BusinessRegistrationIssuingCountry** | **string** | The country issuing the business registration in ISO-3166-1 alpha-3 format. Alpha-2 format is accepted by the API, but alpha-3 is highly encouraged.  **Note: As of October 19th, 2026 this field will be required when &#x60;businessRegistrationNumber&#x60; is provided.**  | Registration Type     | Supported Countries                | |- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | EIN                  | USA                                | | CBN                  | CAN                                | | NEQ                  | CAN                                | | PROVINCIAL_NUMBER    | CAN                                | | CRN                  | GBR, HKG                           | | VAT                  | GBR, IRL, BRA, NLD                 | | ACN                  | AUS                                | | ABN                  | AUS                                | | BRN                  | HKG                                | | SIREN                | FRA                                | | SIRET                | FRA                                | | NZBN                 | NZL                                | | UST_IDNR             | DEU                                | | CIF                  | ESP                                | | NIF                  | ESP                                | | CNPJ                 | BRA                                | | UID                  | CHE                                | | OTHER                | Must Provide Country Code          | | [optional] 
**BusinessEntityType** | **BusinessEntityTypeEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

