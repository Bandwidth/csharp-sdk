# Bandwidth C# SDK

[![Test](https://github.com/Bandwidth/csharp-sdk/actions/workflows/test.yml/badge.svg)](https://github.com/Bandwidth/csharp-sdk/actions/workflows/test.yml)

| **OS** | **.NET** |
|:---:|:---:|
| Windows 2019 | Core 3.1, 6.0 |
| Windows 2022 | Core 3.1, 7.0 |
| Ubuntu 20.04 | Core 3.1, 6.0 |
| Ubuntu 22.04 | Core 3.1, 7.0 |

## Getting Started

### Installation

Add the package reference to your project file.

```sh
dotnet add package Bandwidth.Sdk
```

### Initialize

```csharp
using Bandwidth.Standard;

var client = new BandwidthClient.Builder()
    .Environment(Bandwidth.Standard.Environment.Production)
    .MessagingBasicAuthCredentials("username", "password")
    .VoiceBasicAuthCredentials("username", "password")
    .TwoFactorAuthBasicAuthCredentials("username", "password")
    .WebRtcBasicAuthCredentials("username", "password")
    .Build();
```

### Create A Phone Call

```csharp
using Bandwidth.Standard;
using Bandwidth.Standard.Voice.Models;

var request = new ApiCreateCallRequest()
{
    ApplicationId = "abc12345-6def-abc1-2345-6defabc12345",
    To = "+19999999999",
    From = "+18888888888",
    AnswerUrl = "https://test.com/callbacks/answer"
};

var createCallResponse = await client.Voice.APIController.CreateCallAsync("1111111", request);
```

### Send A Text Message

```csharp
using Bandwidth.Standard;
using Bandwidth.Standard.Messaging.Models;

var request = new MessageRequest()
{
    ApplicationId = "abc12345-6def-abc1-2345-6defabc12345",
    To = new List<string> { "+19999999999" },
    From = "+18888888888",
    Text = "Hello from Bandwidth!"
};

var response = await client.Messaging.APIController.CreateMessageAsync("1111111", request);
```

### Create BXML

```csharp
using Bandwidth.Standard.Voice.Bxml;

var speakSentence = new SpeakSentence();
speakSentence.Sentence = "Hello from Bandwidth!";
speakSentence.Voice = "susan";
speakSentence.Gender = "female";
speakSentence.Locale = "en_US";

var response = new Response();
response.Add(speakSentence);

// Returns XML allowing your application to handle call events.
response.ToBXML();

```

### Update an Existing Calls BXML

```csharp
using Bandwidth.Standard;
using Bandwidth.Standard.Voice.Bxml;

var speakSentence = new SpeakSentence();
speakSentence.Sentence = "This text is new!";
speakSentence.Voice = "susan";
speakSentence.Gender = "female";
speakSentence.Locale = "en_US";

var bxml = new BXML(speakSentence);

await client.Voice.APIController.ModifyCallBxml("1111111", callId, bxml.ToBXML());
```


### Create A MFA Request

```csharp
using Bandwidth.Standard;
using Bandwidth.Standard.TwoFactorAuth.Models;

var codeRequest = new TwoFactorCodeRequestSchema
{
    ApplicationId = "abc12345-6def-abc1-2345-6defabc12345",
    To = "+19999999999",
    From = "+18888888888",
    Scope = "sample",
    Digits = 6,
    Message = "Your temporary {NAME} {SCOPE} code is {CODE}."
};

// Create a code request to later be verified by the user.
var codeResponse = await client.TwoFactorAuth.MFAController.CreateMessagingTwoFactorAsync("1111111", codeRequest);

var verifyRequest = new TwoFactorVerifyRequestSchema
{
    ApplicationId = "abc12345-6def-abc1-2345-6defabc12345",
    To = "+19999999999",
    Scope = "sample",
    Code = "123345",
    ExpirationTimeInMinutes = 3
};

// The verification response contains a Data.Valid boolean indicating success or failure.
var verifyResponse = await _client.TwoFactorAuth.MFAController.CreateVerifyTwoFactorAsync("1111111", verifyRequest);
```

### WebRTC Participant & Session Management

```csharp
using Bandwidth.Standard;
using Bandwidth.Standard.WebRtc.Models;

var accountId = TestConstants.AccountId;

var session = new Session();
session.Tag = "new-session";

// Create a new session for participants to connect to.
var createSessionResponse = await _client.WebRtc.APIController.CreateSessionAsync("1111111", session);
var sessionId = createSessionResponse.Data.Id;

var participant = new Participant()
{
    PublishPermissions = new List<PublishPermissionEnum>() { PublishPermissionEnum.AUDIO, PublishPermissionEnum.VIDEO },
    CallbackUrl = "https://test.com/callbacks/participant"
};

// Create a new participant to join to the session.
var createParticipantResponse = await _client.WebRtc.APIController.CreateParticipantAsync("1111111", participant);
var participantId = createParticipantResponse.Data.Participant.Id;
var subscriptions = new Subscriptions()
{
    SessionId = sessionId
};

// Add the newly created participant to the session.
_client.WebRtc.APIController.AddParticipantToSessionAsync("1111111", sessionId, participantId, subscriptions);
```

## Supported .NET Versions

This package can be used with [.NET Standard 1.3](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Documentation

Documentation for this package can be found at https://dev.bandwidth.com/sdks/csharp.html

## Credentials

Information for credentials for this package can be found at https://dev.bandwidth.com/guides/accountCredentials.html
