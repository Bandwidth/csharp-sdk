# Bandwidth.Standard.Model.EndpointEvent
An event that occurred on an endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndpointId** | **string** | The unique ID of the endpoint. | 
**Type** | **EndpointTypeEnum** |  | 
**Status** | **EndpointStatusEnum** |  | 
**CreationTimestamp** | **DateTime** | The time the endpoint was created. In ISO-8601 format. | 
**ExpirationTimestamp** | **DateTime** | The time the endpoint token will expire. In ISO-8601 format. Tokens last 24 hours. | 
**Tag** | **string** | A tag for the endpoint. | [optional] 
**EventTime** | **DateTime** | The time the event occurred. In ISO-8601 format. | 
**EventType** | **EndpointEventTypeEnum** |  | 
**Device** | [**Device**](Device.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

