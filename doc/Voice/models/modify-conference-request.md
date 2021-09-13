
# Modify Conference Request

## Structure

`ModifyConferenceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | [`Models.StatusEnum?`](/doc/Voice/models/status-enum.md) | Optional | - |
| `RedirectUrl` | `string` | Optional | - |
| `RedirectFallbackUrl` | `string` | Optional | - |
| `RedirectMethod` | [`Models.RedirectMethodEnum?`](/doc/Voice/models/redirect-method-enum.md) | Optional | - |
| `RedirectFallbackMethod` | [`Models.RedirectFallbackMethodEnum?`](/doc/Voice/models/redirect-fallback-method-enum.md) | Optional | - |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `FallbackUsername` | `string` | Optional | - |
| `FallbackPassword` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "status": null,
  "redirectUrl": null,
  "redirectFallbackUrl": null,
  "redirectMethod": null,
  "redirectFallbackMethod": null,
  "username": null,
  "password": null,
  "fallbackUsername": null,
  "fallbackPassword": null
}
```

