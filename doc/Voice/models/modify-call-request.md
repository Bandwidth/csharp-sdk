
# Modify Call Request

## Structure

`ModifyCallRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | [`Models.StateEnum?`](/doc/Voice/models/state-enum.md) | Optional | **Default**: `StateEnum.active`<br>*Default: `StateEnum.active`* |
| `RedirectUrl` | `string` | Optional | Required if state is 'active' |
| `RedirectFallbackUrl` | `string` | Optional | - |
| `RedirectMethod` | [`Models.RedirectMethodEnum?`](/doc/Voice/models/redirect-method-enum.md) | Optional | - |
| `RedirectFallbackMethod` | [`Models.RedirectFallbackMethodEnum?`](/doc/Voice/models/redirect-fallback-method-enum.md) | Optional | - |
| `Username` | `string` | Optional | - |
| `Password` | `string` | Optional | - |
| `FallbackUsername` | `string` | Optional | - |
| `FallbackPassword` | `string` | Optional | - |
| `Tag` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "state": null,
  "redirectUrl": null,
  "redirectFallbackUrl": null,
  "redirectMethod": null,
  "redirectFallbackMethod": null,
  "username": null,
  "password": null,
  "fallbackUsername": null,
  "fallbackPassword": null,
  "tag": null
}
```

