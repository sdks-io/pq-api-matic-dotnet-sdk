
# Authorization Object

## Structure

`AuthorizationObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`PrepaidCardAuthorizations?`](../../doc/models/prepaid-card-authorizations.md) | Optional | Financial types for the [prepaid card](page:resources/prepaid-cards) authorization. |
| `CreatedOn` | `DateTime?` | Optional | Time object was [created](#/rest/models/structures/created-on) |
| `Sign` | [`Signs?`](../../doc/models/signs.md) | Optional | Receipt sign types |
| `SourceToken` | `string` | Optional | Unique identifier representing the [source of funds](#/rest/models/structures/source-token)<br><br>**Default**: `"acct-3908ab5a-6ce1-474d-8b80-a63a7b147860"`<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^(acct\|user\|dest)-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `Amount` | `double?` | Optional | Allocated money to be sent in the transaction.<br><br>**Default**: `1.02` |
| `Currency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `Status` | [`ReceiptStatuses?`](../../doc/models/receipt-statuses.md) | Optional | Receipt status types |
| `Descriptions` | [`List<Translation>`](../../doc/models/translation.md) | Optional | - |
| `AuthDate` | `DateTime?` | Optional | Date that the auth was created |
| `Reference` | `string` | Optional | [Provider reference](#/rest/models/structures/identity-verification-provider-reference) used for performing identity checks for the provider |

## Example (as JSON)

```json
{
  "type": "UNDEFINED",
  "createdOn": "2026-02-07T22:23:09.9667010Z",
  "sign": "CREDIT",
  "sourceToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
  "amount": 1.02,
  "currency": "USD",
  "status": "UNDEFINED",
  "descriptions": [
    {
      "language": "en-US",
      "translation": "string"
    }
  ],
  "authDate": "2026-02-07T22:23:09.3746937Z",
  "reference": "string"
}
```

