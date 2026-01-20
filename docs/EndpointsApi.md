# Bandwidth.Standard.Api.EndpointsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEndpoint**](EndpointsApi.md#createendpoint) | **POST** /accounts/{accountId}/endpoints | Create Endpoint |
| [**DeleteEndpoint**](EndpointsApi.md#deleteendpoint) | **DELETE** /accounts/{accountId}/endpoints/{endpointId} | Delete Endpoint |
| [**GetEndpoint**](EndpointsApi.md#getendpoint) | **GET** /accounts/{accountId}/endpoints/{endpointId} | Get Endpoint |
| [**ListEndpoints**](EndpointsApi.md#listendpoints) | **GET** /accounts/{accountId}/endpoints | List Endpoints |
| [**UpdateEndpointBxml**](EndpointsApi.md#updateendpointbxml) | **PUT** /accounts/{accountId}/endpoints/{endpointId}/bxml | Update Endpoint BXML |

<a id="createendpoint"></a>
# **CreateEndpoint**
> CreateEndpointResponse CreateEndpoint (string accountId, CreateWebRtcConnectionRequest body)

Create Endpoint

Creates a new Endpoint for the specified account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **body** | **CreateWebRtcConnectionRequest** |  |  |

### Return type

[**CreateEndpointResponse**](CreateEndpointResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteendpoint"></a>
# **DeleteEndpoint**
> void DeleteEndpoint (string accountId, string endpointId)

Delete Endpoint

Deletes the specified endpoint. If the endpoint is actively streaming media, the media stream will be terminated.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **endpointId** | **string** | BRTC Endpoint ID. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getendpoint"></a>
# **GetEndpoint**
> EndpointResponse GetEndpoint (string accountId, string endpointId)

Get Endpoint

Returns information about the specified endpoint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **endpointId** | **string** | BRTC Endpoint ID. |  |

### Return type

[**EndpointResponse**](EndpointResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listendpoints"></a>
# **ListEndpoints**
> ListEndpointsResponse ListEndpoints (string accountId, EndpointTypeEnum type = null, EndpointStatusEnum status = null, string afterCursor = null, int limit = null)

List Endpoints

Returns a list of endpoints associated with the specified account.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **type** | **EndpointTypeEnum** | The type of endpoint. | [optional]  |
| **status** | **EndpointStatusEnum** | The status of the endpoint. | [optional]  |
| **afterCursor** | **string** | The cursor to use for pagination. This is the value of the &#x60;next&#x60; link in the previous response. | [optional]  |
| **limit** | **int** | The maximum number of endpoints to return in the response. | [optional] [default to 100] |

### Return type

[**ListEndpointsResponse**](ListEndpointsResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateendpointbxml"></a>
# **UpdateEndpointBxml**
> void UpdateEndpointBxml (string accountId, string endpointId, string body)

Update Endpoint BXML

Updates the BXML for the specified endpoint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **endpointId** | **string** | BRTC Endpoint ID. |  |
| **body** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

