
# Electronic Wallet Field

1...N required [fields](#/rest/models/structures/key-value-pair-electronic-wallet-field-types-string) as determined by call to get requirements

## Structure

`ElectronicWalletField`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | [`ElectronicWalletFields`](../../doc/models/electronic-wallet-fields.md) | Required | Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields) |
| `MValue` | `string` | Required | - |

## Example (as JSON)

```json
{
  "key": "UNDEFINED",
  "value": "string"
}
```

