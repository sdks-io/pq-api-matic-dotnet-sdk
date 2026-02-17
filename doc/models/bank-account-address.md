
# Bank Account Address

## Structure

`BankAccountAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address1` | `string` | Required | Address Line 1<br><br>**Constraints**: *Maximum Length*: `255` |
| `Address2` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `Address3` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `City` | `string` | Required | **Constraints**: *Maximum Length*: `50` |
| `Region` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `PostalCode` | `string` | Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `50` |
| `Country` | [`Countries`](../../doc/models/countries.md) | Required | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |

## Example (as JSON)

```json
{
  "address1": "string",
  "address2": "string",
  "address3": "string",
  "city": "string",
  "region": "string",
  "postalCode": "nzl",
  "country": "US"
}
```

