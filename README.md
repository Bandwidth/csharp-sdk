# Getting Started with bandwidth

Bandwidth's set of APIs

## Install the Package

The SDK is available as a NuGet that you can search for and install using the NuGet GUI. You can also use the following command on the Package Manager Console:

```csharp
Install-Package Bandwidth.Sdk -Version 1.1.0
```

You can also view the NuGet at:
https://www.nuget.org/packages/Bandwidth.Sdk/1.1.0

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package Bandwidth.Sdk --version 1.1.0
```

## Initialize the API Client

The following parameters are configurable for the API Client.

| Parameter | Type | Description |
|  --- | --- | --- |
| `MessagingBasicAuthUserName` | `string` | The username to use with basic authentication |
| `MessagingBasicAuthPassword` | `string` | The password to use with basic authentication |
| `VoiceBasicAuthUserName` | `string` | The username to use with basic authentication |
| `VoiceBasicAuthPassword` | `string` | The password to use with basic authentication |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |

The API client can be initialized as following.

```csharp
Bandwidth.Standard.BandwidthClient client = new Bandwidth.Standard.BandwidthClient.Builder()
    .MessagingBasicAuthUserName("MessagingBasicAuthUserName")
    .MessagingBasicAuthPassword("MessagingBasicAuthPassword")
    .VoiceBasicAuthUserName("VoiceBasicAuthUserName")
    .VoiceBasicAuthPassword("VoiceBasicAuthPassword")
    .Environment(Environment.Production)
    .Build();
```

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## Authorization

This API does not require authentication.

## API Reference

### List of APIs

*

