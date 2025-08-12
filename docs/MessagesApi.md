# Bandwidth.Standard.Api.MessagesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMessage**](MessagesApi.md#createmessage) | **POST** /users/{accountId}/messages | Create Message |
| [**ListMessages**](MessagesApi.md#listmessages) | **GET** /users/{accountId}/messages | List Messages |

<a id="createmessage"></a>
# **CreateMessage**
> Message CreateMessage (string accountId, MessageRequest messageRequest)

Create Message

Endpoint for sending text messages and picture messages using V2 messaging.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class CreateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagesApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var messageRequest = new MessageRequest(); // MessageRequest | 

            try
            {
                // Create Message
                Message result = apiInstance.CreateMessage(accountId, messageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.CreateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Message
    ApiResponse<Message> response = apiInstance.CreateMessageWithHttpInfo(accountId, messageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.CreateMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **messageRequest** | [**MessageRequest**](MessageRequest.md) |  |  |

### Return type

[**Message**](Message.md)

### Authorization

[Basic](../README.md#Basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmessages"></a>
# **ListMessages**
> MessagesList ListMessages (string accountId, string messageId = null, string sourceTn = null, string destinationTn = null, MessageStatusEnum? messageStatus = null, ListMessageDirectionEnum? messageDirection = null, string carrierName = null, MessageTypeEnum? messageType = null, int? errorCode = null, string fromDateTime = null, string toDateTime = null, string campaignId = null, int? fromBwLatency = null, bool? bwQueued = null, ProductTypeEnum? product = null, string location = null, string callingNumberCountryA3 = null, string calledNumberCountryA3 = null, int? fromSegmentCount = null, int? toSegmentCount = null, int? fromMessageSize = null, int? toMessageSize = null, string sort = null, string pageToken = null, int? limit = null, bool? limitTotalCount = null)

List Messages

Returns a list of messages based on query parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class ListMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagesApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var messageId = 9e0df4ca-b18d-40d7-a59f-82fcdf5ae8e6;  // string | The ID of the message to search for. Special characters need to be encoded using URL encoding. Message IDs could come in different formats, e.g., 9e0df4ca-b18d-40d7-a59f-82fcdf5ae8e6 and 1589228074636lm4k2je7j7jklbn2 are valid message ID formats. Note that you must include at least one query parameter. (optional) 
            var sourceTn = %2B15554443333;  // string | The phone number that sent the message. Accepted values are: a single full phone number a comma separated list of full phone numbers (maximum of 10) or a single partial phone number (minimum of 5 characters e.g. '%2B1919'). (optional) 
            var destinationTn = %2B15554443333;  // string | The phone number that received the message. Accepted values are: a single full phone number a comma separated list of full phone numbers (maximum of 10) or a single partial phone number (minimum of 5 characters e.g. '%2B1919'). (optional) 
            var messageStatus = (MessageStatusEnum) "RECEIVED";  // MessageStatusEnum? | The status of the message. One of RECEIVED QUEUED SENDING SENT FAILED DELIVERED ACCEPTED UNDELIVERED. (optional) 
            var messageDirection = (ListMessageDirectionEnum) "INBOUND";  // ListMessageDirectionEnum? | The direction of the message. One of INBOUND OUTBOUND. (optional) 
            var carrierName = Verizon;  // string | The name of the carrier used for this message. Possible values include but are not limited to Verizon and TMobile. Special characters need to be encoded using URL encoding (i.e. AT&T should be passed as AT%26T). (optional) 
            var messageType = (MessageTypeEnum) "sms";  // MessageTypeEnum? | The type of message. Either sms or mms. (optional) 
            var errorCode = 9902;  // int? | The error code of the message. (optional) 
            var fromDateTime = 2022-09-14T18:20:16.000Z;  // string | The start of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days. (optional) 
            var toDateTime = 2022-09-14T18:20:16.000Z;  // string | The end of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days. (optional) 
            var campaignId = CJEUMDK;  // string | The campaign ID of the message. (optional) 
            var fromBwLatency = 5;  // int? | The minimum Bandwidth latency of the message in seconds. Only available for accounts with the Advanced Quality Metrics feature enabled. (optional) 
            var bwQueued = true;  // bool? | A boolean value indicating whether the message is queued in the Bandwidth network. (optional) 
            var product = P2P;  // ProductTypeEnum? | Messaging product associated with the message. (optional) 
            var location = 123ABC;  // string | Location Id associated with the message. (optional) 
            var callingNumberCountryA3 = USA;  // string | Calling number country in A3 format. (optional) 
            var calledNumberCountryA3 = USA;  // string | Called number country in A3 format. (optional) 
            var fromSegmentCount = 1;  // int? | Segment count (start range). (optional) 
            var toSegmentCount = 3;  // int? | Segment count (end range). (optional) 
            var fromMessageSize = 100;  // int? | Message size (start range). (optional) 
            var toMessageSize = 120;  // int? | Message size (end range). (optional) 
            var sort = sourceTn:desc;  // string | The field and direction to sort by combined with a colon. Direction is either asc or desc. (optional) 
            var pageToken = gdEewhcJLQRB5;  // string | A base64 encoded value used for pagination of results. (optional) 
            var limit = 50;  // int? | The maximum records requested in search result. Default 100. The sum of limit and after cannot be more than 10000. (optional) 
            var limitTotalCount = true;  // bool? | When set to true, the response's totalCount field will have a maximum value of 10,000. When set to false, or excluded, this will give an accurate totalCount of all messages that match the provided filters. If you are experiencing latency, try using this parameter to limit your results. (optional) 

            try
            {
                // List Messages
                MessagesList result = apiInstance.ListMessages(accountId, messageId, sourceTn, destinationTn, messageStatus, messageDirection, carrierName, messageType, errorCode, fromDateTime, toDateTime, campaignId, fromBwLatency, bwQueued, product, location, callingNumberCountryA3, calledNumberCountryA3, fromSegmentCount, toSegmentCount, fromMessageSize, toMessageSize, sort, pageToken, limit, limitTotalCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ListMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Messages
    ApiResponse<MessagesList> response = apiInstance.ListMessagesWithHttpInfo(accountId, messageId, sourceTn, destinationTn, messageStatus, messageDirection, carrierName, messageType, errorCode, fromDateTime, toDateTime, campaignId, fromBwLatency, bwQueued, product, location, callingNumberCountryA3, calledNumberCountryA3, fromSegmentCount, toSegmentCount, fromMessageSize, toMessageSize, sort, pageToken, limit, limitTotalCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ListMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **messageId** | **string** | The ID of the message to search for. Special characters need to be encoded using URL encoding. Message IDs could come in different formats, e.g., 9e0df4ca-b18d-40d7-a59f-82fcdf5ae8e6 and 1589228074636lm4k2je7j7jklbn2 are valid message ID formats. Note that you must include at least one query parameter. | [optional]  |
| **sourceTn** | **string** | The phone number that sent the message. Accepted values are: a single full phone number a comma separated list of full phone numbers (maximum of 10) or a single partial phone number (minimum of 5 characters e.g. &#39;%2B1919&#39;). | [optional]  |
| **destinationTn** | **string** | The phone number that received the message. Accepted values are: a single full phone number a comma separated list of full phone numbers (maximum of 10) or a single partial phone number (minimum of 5 characters e.g. &#39;%2B1919&#39;). | [optional]  |
| **messageStatus** | **MessageStatusEnum?** | The status of the message. One of RECEIVED QUEUED SENDING SENT FAILED DELIVERED ACCEPTED UNDELIVERED. | [optional]  |
| **messageDirection** | **ListMessageDirectionEnum?** | The direction of the message. One of INBOUND OUTBOUND. | [optional]  |
| **carrierName** | **string** | The name of the carrier used for this message. Possible values include but are not limited to Verizon and TMobile. Special characters need to be encoded using URL encoding (i.e. AT&amp;T should be passed as AT%26T). | [optional]  |
| **messageType** | **MessageTypeEnum?** | The type of message. Either sms or mms. | [optional]  |
| **errorCode** | **int?** | The error code of the message. | [optional]  |
| **fromDateTime** | **string** | The start of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days. | [optional]  |
| **toDateTime** | **string** | The end of the date range to search in ISO 8601 format. Uses the message receive time. The date range to search in is currently 14 days. | [optional]  |
| **campaignId** | **string** | The campaign ID of the message. | [optional]  |
| **fromBwLatency** | **int?** | The minimum Bandwidth latency of the message in seconds. Only available for accounts with the Advanced Quality Metrics feature enabled. | [optional]  |
| **bwQueued** | **bool?** | A boolean value indicating whether the message is queued in the Bandwidth network. | [optional]  |
| **product** | **ProductTypeEnum?** | Messaging product associated with the message. | [optional]  |
| **location** | **string** | Location Id associated with the message. | [optional]  |
| **callingNumberCountryA3** | **string** | Calling number country in A3 format. | [optional]  |
| **calledNumberCountryA3** | **string** | Called number country in A3 format. | [optional]  |
| **fromSegmentCount** | **int?** | Segment count (start range). | [optional]  |
| **toSegmentCount** | **int?** | Segment count (end range). | [optional]  |
| **fromMessageSize** | **int?** | Message size (start range). | [optional]  |
| **toMessageSize** | **int?** | Message size (end range). | [optional]  |
| **sort** | **string** | The field and direction to sort by combined with a colon. Direction is either asc or desc. | [optional]  |
| **pageToken** | **string** | A base64 encoded value used for pagination of results. | [optional]  |
| **limit** | **int?** | The maximum records requested in search result. Default 100. The sum of limit and after cannot be more than 10000. | [optional]  |
| **limitTotalCount** | **bool?** | When set to true, the response&#39;s totalCount field will have a maximum value of 10,000. When set to false, or excluded, this will give an accurate totalCount of all messages that match the provided filters. If you are experiencing latency, try using this parameter to limit your results. | [optional]  |

### Return type

[**MessagesList**](MessagesList.md)

### Authorization

[Basic](../README.md#Basic)

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
| **415** | Unsupported Media Type |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

