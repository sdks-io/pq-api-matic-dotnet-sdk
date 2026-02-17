
# Fee Distribution

## Structure

`FeeDistribution`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `double?` | Optional | Allocated money to be sent in the transaction.<br><br>**Default**: `1.02` |
| `Currency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `Description` | [`List<ReceiptDescriptions>`](../../doc/models/receipt-descriptions.md) | Optional | - |
| `FormattedAmount` | `string` | Optional | Combination of the amount and currency type<br><br>**Default**: `"$0.05 USD"` |
| `Percentage` | `double?` | Optional | Fee percentage that the responsible account pays |
| `Responsibility` | [`FeeResponsibilityParties?`](../../doc/models/fee-responsibility-parties.md) | Optional | Fee responsibility types |
| `ResponsibilitySource` | [`FeeResponsibilitySources?`](../../doc/models/fee-responsibility-sources.md) | Optional | Fee responsibility source types |
| `SourceToken` | `string` | Optional | Unique identifier representing the [source of funds](#/rest/models/structures/source-token)<br><br>**Default**: `"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860"`<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^(acct\|user\|dest)-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Example (as JSON)

```json
{
  "amount": 1.02,
  "currency": "USD",
  "description": [
    {
      "language": "en-US",
      "translation": "string"
    }
  ],
  "formattedAmount": "$0.05 USD",
  "percentage": 50.0,
  "responsibility": "COMPANY",
  "responsibilitySource": "CREDIT",
  "sourceToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860"
}
```

