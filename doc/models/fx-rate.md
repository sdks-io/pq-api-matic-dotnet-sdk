
# Fx Rate

Exchange rate

## Structure

`FxRate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DestinationAmount` | `double?` | Optional | Allocated money to be sent in the transaction. |
| `DestinationCurrency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `DestinationFormattedAmount` | `string` | Optional | Combination of the amount and currency type<br><br>**Default**: `"$0.05 USD"` |
| `Rate` | `double?` | Optional | Exchange [rate](#/rest/models/structures/rate)<br><br>**Constraints**: `>= 0`, `<= 1` |
| `SourceAmount` | `double?` | Optional | Allocated money to be sent in the transaction.<br><br>**Default**: `1.02` |
| `SourceCurrency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `SourceFormattedAmount` | `string` | Optional | Combination of the amount and currency type<br><br>**Default**: `"$0.05 USD"` |

## Example (as JSON)

```json
{
  "destinationAmount": 50.0,
  "destinationCurrency": "USD",
  "destinationFormattedAmount": "$0.05 USD",
  "rate": 0.85,
  "sourceAmount": 1.02,
  "sourceCurrency": "USD",
  "sourceFormattedAmount": "$0.05 USD"
}
```

