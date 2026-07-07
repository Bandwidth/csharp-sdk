# Bandwidth.Standard.Model.Bxml.Verbs.Refer

The `<Refer>` verb is used to hand off a call to a SIP endpoint via a SIP REFER. The call is transferred to the specified SIP URI, and an optional callback is sent when the transfer completes.

For more details, see the [Bandwidth BXML Refer documentation](https://dev.bandwidth.com/docs/voice/bxml/refer.html).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferCompleteUrl** | **string** | URL to receive the `referComplete` callback when the REFER is finished. | [optional]
**ReferCompleteMethod** | **string** | HTTP method to use for the `referComplete` callback. Must be `GET` or `POST`. | [optional] [default to `POST`]
**Tag** | **string** | Optional custom string to include in callbacks. Max 256 characters. | [optional]
**SipUriElement** | [**SipUri**](SipUri.md) | The SIP URI destination for the REFER. Must start with `sip:`. This is the same `SipUri` type used by [`<Transfer>`](Transfer.md) - see [Shared SipUri type](#shared-sipuri-type) below for which attributes are valid in each context. | 

## Shared SipUri type

`<Refer>` and `<Transfer>` both use the same `SipUri` type (`Bandwidth.Standard.Model.Bxml.Verbs.SipUri`) for their SIP URI child element, rather than separate types per verb. Only a subset of `SipUri`'s attributes are valid depending on which verb it's attached to:

Attribute | Valid for `<Transfer>` | Valid for `<Refer>`
------------ | :---: | :---:
`Uri` | Yes | Yes
`Uui` | Yes | No
`TransferAnswerUrl` | Yes | No
`TransferAnswerMethod` | Yes | No
`TransferAnswerFallbackUrl` | Yes | No
`TransferAnswerFallbackMethod` | Yes | No
`TransferDisconnectUrl` | Yes | No
`TransferDisconnectMethod` | Yes | No
`Username` | Yes | No
`Password` | Yes | No
`FallbackUsername` | Yes | No
`FallbackPassword` | Yes | No
`Tag` | Yes | No

Assigning a `SipUri` with any of the Transfer-only attributes set to `Refer` (via `WithSipUri(SipUri)` or by setting `SipUriElement` directly) throws an `ArgumentException` naming the offending attribute(s). This check runs at the point of assignment - mutating the `SipUri` instance's attributes *after* attaching it to `Refer` is not re-validated before serialization.

## Methods

Name | Description
------------ | -------------
`WithSipUri(string sipUri)` | Sets the SIP URI destination from a string. Returns the `Refer` instance for chaining.
`WithSipUri(SipUri sipUri)` | Sets the SIP URI destination from a `SipUri` object. Throws if any Transfer-only attribute is set. Returns the `Refer` instance for chaining.
`WithReferCompleteUrl(string referCompleteUrl)` | Sets the `referCompleteUrl` attribute. Returns the `Refer` instance for chaining.
`WithReferCompleteMethod(string referCompleteMethod)` | Sets the `referCompleteMethod` attribute (`GET` or `POST`). Returns the `Refer` instance for chaining.
`WithTag(string tag)` | Sets the `tag` attribute. Returns the `Refer` instance for chaining.

## Validation

- `SipUri.Uri` must start with `sip:` (case-insensitive). An `ArgumentException` is thrown if the value does not match.
- `SipUri` attached to `Refer` must not have any Transfer-only attribute set (see table above). An `ArgumentException` naming the offending attribute(s) is thrown otherwise.
- `ReferCompleteMethod` must be either `GET` or `POST`. An `ArgumentException` is thrown for any other value.

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

