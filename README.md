# Bandwidth.Standard - the C# library for the Bandwidth

Bandwidth's Communication APIs

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://dev.bandwidth.com](https://dev.bandwidth.com)

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bandwidth.Standard.Api;
using Bandwidth.Standard.Client;
using Bandwidth.Standard.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CallsApi(config);
            var accountId = 9900000;  // string | Your Bandwidth Account ID.
            var createCall = new CreateCall(); // CreateCall | JSON object containing information to create an outbound call

            try
            {
                // Create Call
                CreateCallResponse result = apiInstance.CreateCall(accountId, createCall);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallsApi.CreateCall: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CallsApi* | [**CreateCall**](docs/CallsApi.md#createcall) | **POST** /accounts/{accountId}/calls | Create Call
*CallsApi* | [**GetCallState**](docs/CallsApi.md#getcallstate) | **GET** /accounts/{accountId}/calls/{callId} | Get Call State Information
*CallsApi* | [**UpdateCall**](docs/CallsApi.md#updatecall) | **POST** /accounts/{accountId}/calls/{callId} | Update Call
*CallsApi* | [**UpdateCallBxml**](docs/CallsApi.md#updatecallbxml) | **PUT** /accounts/{accountId}/calls/{callId}/bxml | Update Call BXML
*ConferencesApi* | [**DownloadConferenceRecording**](docs/ConferencesApi.md#downloadconferencerecording) | **GET** /accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId}/media | Download Conference Recording
*ConferencesApi* | [**GetConference**](docs/ConferencesApi.md#getconference) | **GET** /accounts/{accountId}/conferences/{conferenceId} | Get Conference Information
*ConferencesApi* | [**GetConferenceMember**](docs/ConferencesApi.md#getconferencemember) | **GET** /accounts/{accountId}/conferences/{conferenceId}/members/{memberId} | Get Conference Member
*ConferencesApi* | [**GetConferenceRecording**](docs/ConferencesApi.md#getconferencerecording) | **GET** /accounts/{accountId}/conferences/{conferenceId}/recordings/{recordingId} | Get Conference Recording Information
*ConferencesApi* | [**ListConferenceRecordings**](docs/ConferencesApi.md#listconferencerecordings) | **GET** /accounts/{accountId}/conferences/{conferenceId}/recordings | Get Conference Recordings
*ConferencesApi* | [**ListConferences**](docs/ConferencesApi.md#listconferences) | **GET** /accounts/{accountId}/conferences | Get Conferences
*ConferencesApi* | [**UpdateConference**](docs/ConferencesApi.md#updateconference) | **POST** /accounts/{accountId}/conferences/{conferenceId} | Update Conference
*ConferencesApi* | [**UpdateConferenceBxml**](docs/ConferencesApi.md#updateconferencebxml) | **PUT** /accounts/{accountId}/conferences/{conferenceId}/bxml | Update Conference BXML
*ConferencesApi* | [**UpdateConferenceMember**](docs/ConferencesApi.md#updateconferencemember) | **PUT** /accounts/{accountId}/conferences/{conferenceId}/members/{memberId} | Update Conference Member
*MFAApi* | [**GenerateMessagingCode**](docs/MFAApi.md#generatemessagingcode) | **POST** /accounts/{accountId}/code/messaging | Messaging Authentication Code
*MFAApi* | [**GenerateVoiceCode**](docs/MFAApi.md#generatevoicecode) | **POST** /accounts/{accountId}/code/voice | Voice Authentication Code
*MFAApi* | [**VerifyCode**](docs/MFAApi.md#verifycode) | **POST** /accounts/{accountId}/code/verify | Verify Authentication Code
*MediaApi* | [**DeleteMedia**](docs/MediaApi.md#deletemedia) | **DELETE** /users/{accountId}/media/{mediaId} | Delete Media
*MediaApi* | [**GetMedia**](docs/MediaApi.md#getmedia) | **GET** /users/{accountId}/media/{mediaId} | Get Media
*MediaApi* | [**ListMedia**](docs/MediaApi.md#listmedia) | **GET** /users/{accountId}/media | List Media
*MediaApi* | [**UploadMedia**](docs/MediaApi.md#uploadmedia) | **PUT** /users/{accountId}/media/{mediaId} | Upload Media
*MessagesApi* | [**CreateMessage**](docs/MessagesApi.md#createmessage) | **POST** /users/{accountId}/messages | Create Message
*MessagesApi* | [**ListMessages**](docs/MessagesApi.md#listmessages) | **GET** /users/{accountId}/messages | List Messages
*PhoneNumberLookupApi* | [**CreateLookup**](docs/PhoneNumberLookupApi.md#createlookup) | **POST** /accounts/{accountId}/tnlookup | Create Lookup
*PhoneNumberLookupApi* | [**GetLookupStatus**](docs/PhoneNumberLookupApi.md#getlookupstatus) | **GET** /accounts/{accountId}/tnlookup/{requestId} | Get Lookup Request Status
*RecordingsApi* | [**DeleteCallTranscription**](docs/RecordingsApi.md#deletecalltranscription) | **DELETE** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription | Delete Transcription
*RecordingsApi* | [**DeleteRecording**](docs/RecordingsApi.md#deleterecording) | **DELETE** /accounts/{accountId}/calls/{callId}/recordings/{recordingId} | Delete Recording
*RecordingsApi* | [**DeleteRecordingMedia**](docs/RecordingsApi.md#deleterecordingmedia) | **DELETE** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/media | Delete Recording Media
*RecordingsApi* | [**DownloadCallRecording**](docs/RecordingsApi.md#downloadcallrecording) | **GET** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/media | Download Recording
*RecordingsApi* | [**GetCallRecording**](docs/RecordingsApi.md#getcallrecording) | **GET** /accounts/{accountId}/calls/{callId}/recordings/{recordingId} | Get Call Recording
*RecordingsApi* | [**GetCallTranscription**](docs/RecordingsApi.md#getcalltranscription) | **GET** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription | Get Transcription
*RecordingsApi* | [**ListAccountCallRecordings**](docs/RecordingsApi.md#listaccountcallrecordings) | **GET** /accounts/{accountId}/recordings | Get Call Recordings
*RecordingsApi* | [**ListCallRecordings**](docs/RecordingsApi.md#listcallrecordings) | **GET** /accounts/{accountId}/calls/{callId}/recordings | List Call Recordings
*RecordingsApi* | [**TranscribeCallRecording**](docs/RecordingsApi.md#transcribecallrecording) | **POST** /accounts/{accountId}/calls/{callId}/recordings/{recordingId}/transcription | Create Transcription Request
*RecordingsApi* | [**UpdateCallRecordingState**](docs/RecordingsApi.md#updatecallrecordingstate) | **PUT** /accounts/{accountId}/calls/{callId}/recording | Update Recording
*StatisticsApi* | [**GetStatistics**](docs/StatisticsApi.md#getstatistics) | **GET** /accounts/{accountId}/statistics | Get Account Statistics


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountStatistics](docs/AccountStatistics.md)
 - [Model.AnswerCallback](docs/AnswerCallback.md)
 - [Model.BridgeCompleteCallback](docs/BridgeCompleteCallback.md)
 - [Model.BridgeTargetCompleteCallback](docs/BridgeTargetCompleteCallback.md)
 - [Model.CallDirectionEnum](docs/CallDirectionEnum.md)
 - [Model.CallRecordingMetadata](docs/CallRecordingMetadata.md)
 - [Model.CallState](docs/CallState.md)
 - [Model.CallStateEnum](docs/CallStateEnum.md)
 - [Model.CallbackMethodEnum](docs/CallbackMethodEnum.md)
 - [Model.CodeRequest](docs/CodeRequest.md)
 - [Model.Conference](docs/Conference.md)
 - [Model.ConferenceCompletedCallback](docs/ConferenceCompletedCallback.md)
 - [Model.ConferenceCreatedCallback](docs/ConferenceCreatedCallback.md)
 - [Model.ConferenceMember](docs/ConferenceMember.md)
 - [Model.ConferenceMemberExitCallback](docs/ConferenceMemberExitCallback.md)
 - [Model.ConferenceMemberJoinCallback](docs/ConferenceMemberJoinCallback.md)
 - [Model.ConferenceRecordingAvailableCallback](docs/ConferenceRecordingAvailableCallback.md)
 - [Model.ConferenceRecordingMetadata](docs/ConferenceRecordingMetadata.md)
 - [Model.ConferenceRedirectCallback](docs/ConferenceRedirectCallback.md)
 - [Model.ConferenceStateEnum](docs/ConferenceStateEnum.md)
 - [Model.CreateCall](docs/CreateCall.md)
 - [Model.CreateCallResponse](docs/CreateCallResponse.md)
 - [Model.CreateLookupResponse](docs/CreateLookupResponse.md)
 - [Model.CreateMessageRequestError](docs/CreateMessageRequestError.md)
 - [Model.DeferredResult](docs/DeferredResult.md)
 - [Model.DisconnectCallback](docs/DisconnectCallback.md)
 - [Model.Diversion](docs/Diversion.md)
 - [Model.DtmfCallback](docs/DtmfCallback.md)
 - [Model.FieldError](docs/FieldError.md)
 - [Model.FileFormatEnum](docs/FileFormatEnum.md)
 - [Model.GatherCallback](docs/GatherCallback.md)
 - [Model.InboundMessageCallback](docs/InboundMessageCallback.md)
 - [Model.InboundMessageCallbackMessage](docs/InboundMessageCallbackMessage.md)
 - [Model.InitiateCallback](docs/InitiateCallback.md)
 - [Model.ListMessageDirectionEnum](docs/ListMessageDirectionEnum.md)
 - [Model.ListMessageItem](docs/ListMessageItem.md)
 - [Model.LookupRequest](docs/LookupRequest.md)
 - [Model.LookupResult](docs/LookupResult.md)
 - [Model.LookupStatus](docs/LookupStatus.md)
 - [Model.LookupStatusEnum](docs/LookupStatusEnum.md)
 - [Model.MachineDetectionCompleteCallback](docs/MachineDetectionCompleteCallback.md)
 - [Model.MachineDetectionConfiguration](docs/MachineDetectionConfiguration.md)
 - [Model.MachineDetectionModeEnum](docs/MachineDetectionModeEnum.md)
 - [Model.MachineDetectionResult](docs/MachineDetectionResult.md)
 - [Model.Media](docs/Media.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageDeliveredCallback](docs/MessageDeliveredCallback.md)
 - [Model.MessageDeliveredCallbackMessage](docs/MessageDeliveredCallbackMessage.md)
 - [Model.MessageDirectionEnum](docs/MessageDirectionEnum.md)
 - [Model.MessageFailedCallback](docs/MessageFailedCallback.md)
 - [Model.MessageFailedCallbackMessage](docs/MessageFailedCallbackMessage.md)
 - [Model.MessageRequest](docs/MessageRequest.md)
 - [Model.MessageSendingCallback](docs/MessageSendingCallback.md)
 - [Model.MessageSendingCallbackMessage](docs/MessageSendingCallbackMessage.md)
 - [Model.MessageStatusEnum](docs/MessageStatusEnum.md)
 - [Model.MessageTypeEnum](docs/MessageTypeEnum.md)
 - [Model.MessagesList](docs/MessagesList.md)
 - [Model.MessagingCodeResponse](docs/MessagingCodeResponse.md)
 - [Model.MessagingRequestError](docs/MessagingRequestError.md)
 - [Model.MfaForbiddenRequestError](docs/MfaForbiddenRequestError.md)
 - [Model.MfaRequestError](docs/MfaRequestError.md)
 - [Model.MfaUnauthorizedRequestError](docs/MfaUnauthorizedRequestError.md)
 - [Model.PageInfo](docs/PageInfo.md)
 - [Model.PriorityEnum](docs/PriorityEnum.md)
 - [Model.RecordingAvailableCallback](docs/RecordingAvailableCallback.md)
 - [Model.RecordingCompleteCallback](docs/RecordingCompleteCallback.md)
 - [Model.RecordingStateEnum](docs/RecordingStateEnum.md)
 - [Model.RedirectCallback](docs/RedirectCallback.md)
 - [Model.RedirectMethodEnum](docs/RedirectMethodEnum.md)
 - [Model.StirShaken](docs/StirShaken.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.TnLookupRequestError](docs/TnLookupRequestError.md)
 - [Model.TranscribeRecording](docs/TranscribeRecording.md)
 - [Model.Transcription](docs/Transcription.md)
 - [Model.TranscriptionAvailableCallback](docs/TranscriptionAvailableCallback.md)
 - [Model.TranscriptionList](docs/TranscriptionList.md)
 - [Model.TranscriptionMetadata](docs/TranscriptionMetadata.md)
 - [Model.TransferAnswerCallback](docs/TransferAnswerCallback.md)
 - [Model.TransferCompleteCallback](docs/TransferCompleteCallback.md)
 - [Model.TransferDisconnectCallback](docs/TransferDisconnectCallback.md)
 - [Model.UpdateCall](docs/UpdateCall.md)
 - [Model.UpdateCallRecording](docs/UpdateCallRecording.md)
 - [Model.UpdateConference](docs/UpdateConference.md)
 - [Model.UpdateConferenceMember](docs/UpdateConferenceMember.md)
 - [Model.VerifyCodeRequest](docs/VerifyCodeRequest.md)
 - [Model.VerifyCodeResponse](docs/VerifyCodeResponse.md)
 - [Model.VoiceApiError](docs/VoiceApiError.md)
 - [Model.VoiceCodeResponse](docs/VoiceCodeResponse.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Basic"></a>
### Basic

- **Type**: HTTP basic authentication

