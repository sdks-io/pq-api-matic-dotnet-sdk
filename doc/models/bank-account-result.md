
# Bank Account Result

## Structure

`BankAccountResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Optional | Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)<br><br>**Default**: `"dest-631b200f-665d-4dbe-bd01-3063c9dec97d"`<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^(acct\|dest\|user)-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `BankAccountOwnershipType` | [`BankAccountOwnership?`](../../doc/models/bank-account-ownership.md) | Optional | Account [ownership types](#/rest/models/structures/bank-account-ownership) |
| `BankCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `BankCurrency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `Address` | [`BankAccountAddress`](../../doc/models/bank-account-address.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | Time object was [created](#/rest/models/structures/created-on) |
| `Description` | `string` | Optional | User-supplied description of the bank account for reference |
| `Fields` | [`List<BankAccountField>`](../../doc/models/bank-account-field.md) | Optional | - |
| `Status` | [`BankAccountStatuses?`](../../doc/models/bank-account-statuses.md) | Optional | Current verification status type of the [bank account](#/rest/models/structures/bank-account-status) |
| `Type` | [`BankAccountTypes?`](../../doc/models/bank-account-types.md) | Optional | Financial purpose of the [bank account](#/rest/models/structures/bank-account-type) |
| `TransferMethodType` | [`TransferMethodTypes?`](../../doc/models/transfer-method-types.md) | Optional | Optional transfer methods applicable only to bank and e-wallet transfers. |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |
| `Meta` | [`MetadataItems`](../../doc/models/metadata-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "token": "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
  "bankAccountOwnershipType": "BUSINESS",
  "bankcountry": "US",
  "bankCurrency": "USD",
  "address": {
    "address1": "string",
    "address2": "string",
    "address3": "string",
    "city": "string",
    "region": "string",
    "postalCode": "nzl",
    "country": "US"
  },
  "createdOn": "2026-02-07T22:23:09.9667010Z",
  "description": "string",
  "fields": [
    {
      "key": "BANK_ACH_ABA",
      "value": "string"
    }
  ],
  "status": "ACTIVE",
  "type": "CHECKING",
  "transferMethodType": "IACH",
  "links": [
    {
      "href": "string",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "20260207T231757Z-r1d65bb46d495mgjhC1BL1qvx400000004rg00000000c2uh"
  },
  "bankCountry": "RE"
}
```

