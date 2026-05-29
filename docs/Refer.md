# Bandwidth.Standard.Model.Bxml.Verbs.Refer

The `<Refer>` verb is used to hand off a call to a SIP endpoint via a SIP REFER. The call is transferred to the specified SIP URI, and an optional callback is sent when the transfer completes.

For more details, see the [Bandwidth BXML Refer documentation](https://dev.bandwidth.com/docs/voice/bxml/refer.html).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferCompleteUrl** | **string** | URL to receive the `referComplete` callback when the REFER is finished. | [optional]
**ReferCompleteMethod** | **string** | HTTP method to use for the `referComplete` callback. Must be `GET` or `POST`. | [optional] [default to `POST`]
**Tag** | **string** | Optional custom string to include in callbacks. Max 4096 characters. | [optional]
**SipUriElement** | [**Refer.SipUri**](#sipuri-nested-class) | The SIP URI destination for the REFER. Must start with `sip:`. | 

## SipUri Nested Class

The `<SipUri>` element specifies the destination SIP URI for the REFER.

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The SIP URI to refer the call to. Must start with `sip:`. | 

## Methods

Name | Description
------------ | -------------
`WithSipUri(string sipUri)` | Sets the SIP URI destination from a string. Returns the `Refer` instance for chaining.
`WithSipUri(SipUri sipUri)` | Sets the SIP URI destination from a `SipUri` object. Returns the `Refer` instance for chaining.
`WithReferCompleteUrl(string referCompleteUrl)` | Sets the `referCompleteUrl` attribute. Returns the `Refer` instance for chaining.
`WithReferCompleteMethod(string referCompleteMethod)` | Sets the `referCompleteMethod` attribute (`GET` or `POST`). Returns the `Refer` instance for chaining.
`WithTag(string tag)` | Sets the `tag` attribute. Returns the `Refer` instance for chaining.

## Example Usage

```csharp
using Bandwidth.Standard.Model.Bxml;
using Bandwidth.Standard.Model.Bxml.Verbs;

var refer = new Refer()
    .WithSipUri("sip:alice@atlanta.example.com")
    .WithReferCompleteUrl("https://example.com/handleRefer")
    .WithReferCompleteMethod("POST")
    .WithTag("refer-tag");

var response = new Response(refer);
Console.WriteLine(response.ToBXML());
```

### Output BXML

```xml
<?xml version="1.0" encoding="utf-8"?>
<Response>
  <Refer referCompleteUrl="https://example.com/handleRefer" referCompleteMethod="POST" tag="refer-tag">
    <SipUri>sip:alice@atlanta.example.com</SipUri>
  </Refer>
</Response>
```

## Validation

- `SipUri.Uri` must start with `sip:` (case-insensitive). An `ArgumentException` is thrown if the value does not match.
- `ReferCompleteMethod` must be either `GET` or `POST`. An `ArgumentException` is thrown for any other value.

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

