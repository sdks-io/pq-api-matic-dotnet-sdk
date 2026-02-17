
# Electronic Wallet Requirement Validator

[Validator type](#/rest/models/structures/electronic-wallet-requirement-validator) that for the required electronic wallet information.

## Structure

`ElectronicWalletRequirementValidator`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ValidatorType` | [`ValidatorTypes?`](../../doc/models/validator-types.md) | Optional | [Validator types](#/rest/models/structures/bank-account-requirement-validator) for the required bank account information. |
| `Expression` | `string` | Required | Validation regular expression |

## Example (as JSON)

```json
{
  "validatorType": "LENGTH",
  "expression": "string"
}
```

