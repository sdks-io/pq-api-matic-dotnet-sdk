
# Bank Account Required Fields

Classifies the required [bank account field](#/rest/models/structures/bank-account-required-fields) objects

## Structure

`BankAccountRequiredFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Format` | [`BankAccountRequirementFormat`](../../doc/models/bank-account-requirement-format.md) | Optional | Classifies the [format](#/rest/models/structures/bank-account-requirement-format) of the required information for a bank account |
| `Requirement` | [`BankAccountFields?`](../../doc/models/bank-account-fields.md) | Optional | Classifies bank account [field types](#/rest/models/structures/bank-account-fields) |
| `Description` | [`List<Translation>`](../../doc/models/translation.md) | Optional | Localized requirement description for display purposes |
| `Validators` | [`List<BankAccountRequirementValidator>`](../../doc/models/bank-account-requirement-validator.md) | Optional | - |

## Example (as JSON)

```json
{
  "format": {
    "example": "string",
    "legend": [
      {
        "key": "string",
        "descriptions": [
          {
            "language": "en-US",
            "translation": "string"
          }
        ]
      }
    ]
  },
  "requirement": "BANK_ACH_ABA",
  "description": [
    {
      "language": "en-US",
      "translation": "string"
    }
  ],
  "validators": [
    {
      "validatorType": "LENGTH",
      "expression": "string"
    }
  ]
}
```

