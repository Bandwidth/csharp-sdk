# Bandwidth.Standard.Api.MFAApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateMessagingCode**](MFAApi.md#generatemessagingcode) | **POST** /accounts/{accountId}/code/messaging | Messaging Authentication Code |
| [**GenerateVoiceCode**](MFAApi.md#generatevoicecode) | **POST** /accounts/{accountId}/code/voice | Voice Authentication Code |
| [**VerifyCode**](MFAApi.md#verifycode) | **POST** /accounts/{accountId}/code/verify | Verify Authentication Code |

<a id="generatemessagingcode"></a>
# **GenerateMessagingCode**
> MessagingCodeResponse GenerateMessagingCode (string accountId, CodeRequest codeRequest)

Messaging Authentication Code

Send an MFA code via text message (SMS).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GenerateMessagingCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MFAApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var codeRequest = new CodeRequest(); // CodeRequest | MFA code request body.

            try
            {
                // Messaging Authentication Code
                MessagingCodeResponse result = apiInstance.GenerateMessagingCode(accountId, codeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MFAApi.GenerateMessagingCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateMessagingCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Messaging Authentication Code
    ApiResponse<MessagingCodeResponse> response = apiInstance.GenerateMessagingCodeWithHttpInfo(accountId, codeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MFAApi.GenerateMessagingCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **codeRequest** | [**CodeRequest**](CodeRequest.md) | MFA code request body. |  |

### Return type

[**MessagingCodeResponse**](MessagingCodeResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatevoicecode"></a>
# **GenerateVoiceCode**
> VoiceCodeResponse GenerateVoiceCode (string accountId, CodeRequest codeRequest)

Voice Authentication Code

Send an MFA Code via a phone call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class GenerateVoiceCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MFAApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var codeRequest = new CodeRequest(); // CodeRequest | MFA code request body.

            try
            {
                // Voice Authentication Code
                VoiceCodeResponse result = apiInstance.GenerateVoiceCode(accountId, codeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MFAApi.GenerateVoiceCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateVoiceCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Voice Authentication Code
    ApiResponse<VoiceCodeResponse> response = apiInstance.GenerateVoiceCodeWithHttpInfo(accountId, codeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MFAApi.GenerateVoiceCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **codeRequest** | [**CodeRequest**](CodeRequest.md) | MFA code request body. |  |

### Return type

[**VoiceCodeResponse**](VoiceCodeResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="verifycode"></a>
# **VerifyCode**
> VerifyCodeResponse VerifyCode (string accountId, VerifyCodeRequest verifyCodeRequest)

Verify Authentication Code

Verify a previously sent MFA code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class VerifyCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MFAApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var verifyCodeRequest = new VerifyCodeRequest(); // VerifyCodeRequest | MFA code verify request body.

            try
            {
                // Verify Authentication Code
                VerifyCodeResponse result = apiInstance.VerifyCode(accountId, verifyCodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MFAApi.VerifyCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify Authentication Code
    ApiResponse<VerifyCodeResponse> response = apiInstance.VerifyCodeWithHttpInfo(accountId, verifyCodeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MFAApi.VerifyCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Your Bandwidth Account ID. |  |
| **verifyCodeRequest** | [**VerifyCodeRequest**](VerifyCodeRequest.md) | MFA code verify request body. |  |

### Return type

[**VerifyCodeResponse**](VerifyCodeResponse.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

