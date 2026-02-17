
# Bank Account Field

1...N required [fields](#/rest/models/structures/key-value-pair-bank-field-types-string) as determined by call to get requirements

## Structure

`BankAccountField`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | [`BankAccountFields`](../../doc/models/bank-account-fields.md) | Required | Classifies bank account [field types](#/rest/models/structures/bank-account-fields) |
| `MValue` | `string` | Required | - |

## Example (as JSON)

```json
{
  "key": "BANK_ACH_ABA",
  "value": "string"
}
```

