
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `BaseUrl` | `string` | *Default*: `"https://www.example.com"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `MessagingBasicAuthUserName` | `string` | The username to use with basic authentication |
| `MessagingBasicAuthPassword` | `string` | The password to use with basic authentication |
| `MultiFactorAuthBasicAuthUserName` | `string` | The username to use with basic authentication |
| `MultiFactorAuthBasicAuthPassword` | `string` | The password to use with basic authentication |
| `PhoneNumberLookupBasicAuthUserName` | `string` | The username to use with basic authentication |
| `PhoneNumberLookupBasicAuthPassword` | `string` | The password to use with basic authentication |
| `VoiceBasicAuthUserName` | `string` | The username to use with basic authentication |
| `VoiceBasicAuthPassword` | `string` | The password to use with basic authentication |
| `WebRtcBasicAuthUserName` | `string` | The username to use with basic authentication |
| `WebRtcBasicAuthPassword` | `string` | The password to use with basic authentication |

The API client can be initialized as follows:

```csharp
Bandwidth.Standard.BandwidthClient client = new Bandwidth.Standard.BandwidthClient.Builder()
    .MessagingBasicAuthCredentials("MessagingBasicAuthUserName", "MessagingBasicAuthPassword")
    .MultiFactorAuthBasicAuthCredentials("MultiFactorAuthBasicAuthUserName", "MultiFactorAuthBasicAuthPassword")
    .PhoneNumberLookupBasicAuthCredentials("PhoneNumberLookupBasicAuthUserName", "PhoneNumberLookupBasicAuthPassword")
    .VoiceBasicAuthCredentials("VoiceBasicAuthUserName", "VoiceBasicAuthPassword")
    .WebRtcBasicAuthCredentials("WebRtcBasicAuthUserName", "WebRtcBasicAuthPassword")
    .Environment(Bandwidth.Standard.Environment.Production)
    .BaseUrl("https://www.example.com")
    .HttpClientConfig(config => config.NumberOfRetries(0))
    .Build();
```

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## bandwidthClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| Messaging | Gets MessagingClient controller. |
| MultiFactorAuth | Gets MultiFactorAuthClient controller. |
| PhoneNumberLookup | Gets PhoneNumberLookupClient controller. |
| Voice | Gets VoiceClient controller. |
| WebRtc | Gets WebRtcClient controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | `IHttpClientConfiguration` |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BaseUrl | BaseUrl value. | `string` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the bandwidthClient using the values provided for the builder. | `Builder` |

## bandwidthClient Builder Class

Class to build instances of bandwidthClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BaseUrl(string baseUrl)` | BaseUrl value. | `Builder` |
| `AdditionalHeaders(IDictionary<string, List<string>> additionalHeaders)` | Gets the additional headers. | `Builder` |
| `SdkVersion(string sdkVersion)` | Gets the additional headers. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `SquareVersion(string squareVersion)` | Square Connect API versions | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `CustomUrl(string customUrl)` | Sets the base URL requests are made to. Defaults to `https://connect.squareup.com` | `Builder` |
| `AdditionalHeaders(IDictionary<string, List<string>> additionalHeaders)` | Gets the additional headers. | `Builder` |
| `SdkVersion(string sdkVersion)` | Gets the additional headers. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `SquareVersion(string squareVersion)` | Square Connect API versions | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `CustomUrl(string customUrl)` | Sets the base URL requests are made to. Defaults to `https://connect.squareup.com` | `Builder` |
| `AdditionalHeaders(IDictionary<string, List<string>> additionalHeaders)` | Gets the additional headers. | `Builder` |
| `SdkVersion(string sdkVersion)` | Gets the additional headers. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `SquareVersion(string squareVersion)` | Square Connect API versions | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `CustomUrl(string customUrl)` | Sets the base URL requests are made to. Defaults to `https://connect.squareup.com` | `Builder` |
| `AdditionalHeaders(IDictionary<string, List<string>> additionalHeaders)` | Gets the additional headers. | `Builder` |
| `SdkVersion(string sdkVersion)` | Gets the additional headers. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `SquareVersion(string squareVersion)` | Square Connect API versions | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `CustomUrl(string customUrl)` | Sets the base URL requests are made to. Defaults to `https://connect.squareup.com` | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BaseUrl(string baseUrl)` | BaseUrl value. | `Builder` |

