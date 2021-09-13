
# Order Status

If requestId exists, the result for that request is returned. See the Examples for details on the various responses that you can receive.  Generally, if you see a Response Code of 0 in a result for a TN, information will be available for it.  Any other Response Code will indicate no information was available for the TN.

## Structure

`OrderStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | The requestId. |
| `Status` | `string` | Optional | The status of the request (IN_PROGRESS, COMPLETE, PARTIAL_COMPLETE, or FAILED). |
| `FailedTelephoneNumbers` | `List<string>` | Optional | The telephone numbers whose lookup failed |
| `Result` | [`List<Models.Result>`](/doc/PhoneNumberLookup/models/result.md) | Optional | The carrier information results for the specified telephone number. |

## Example (as JSON)

```json
{
  "requestId": null,
  "status": null,
  "failedTelephoneNumbers": null,
  "result": null
}
```

