
# User Result

## Structure

`UserResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `AddressLine1` | `string` | Optional | Address Line 1<br><br>**Constraints**: *Maximum Length*: `255` |
| `AddressLine2` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `AddressLine3` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `BusinessAddressLine1` | `string` | Optional | Business address line 1<br><br>**Constraints**: *Maximum Length*: `255` |
| `BusinessAddressLine2` | `string` | Optional | Business address line 2<br><br>**Constraints**: *Maximum Length*: `255` |
| `BusinessAddressLine3` | `string` | Optional | Business address line 3<br><br>**Constraints**: *Maximum Length*: `255` |
| `BusinessAddressType` | [`Addresses?`](../../doc/models/addresses.md) | Optional | Classifies the [address](#/rest/models/structures/address) type (*Residential*, *Business*, *Billing*, *Shipping*) |
| `BusinessCity` | `string` | Optional | Business city<br><br>**Constraints**: *Maximum Length*: `50` |
| `BusinessContactRole` | [`BusinessContactRoles?`](../../doc/models/business-contact-roles.md) | Optional | Business contact role<br><br>**Constraints**: *Maximum Length*: `20` |
| `BusinessCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `BusinessName` | `string` | Optional | Business name |
| `BusinessPostalCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `50` |
| `BusinessRegion` | `string` | Optional | Region that the business is based out of |
| `City` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `Country` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `CountryOfBirth` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `CountryOfNationality` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `CreatedOn` | `DateTime?` | Optional | Time object was [created](#/rest/models/structures/created-on) |
| `Currency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `DateOfBirth` | `DateTime?` | Optional | - |
| `Email` | `string` | Optional | Contact [email address](#/rest/models/structures/email-address) for the user account for the user account<br><br>**Constraints**: *Minimum Length*: `8`, *Maximum Length*: `100`, *Pattern*: `^.+@.+\..+` |
| `EmployerId` | `string` | Optional | Employer id |
| `FirstName` | `string` | Optional | First name<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `Gender` | [`Genders?`](../../doc/models/genders.md) | Optional | [Gender](#/rest/models/structures/gender) as a user identifies |
| `GovernmentId` | `string` | Optional | **Constraints**: *Maximum Length*: `20` |
| `GovernmentIdType` | [`GovernmentIds?`](../../doc/models/government-ids.md) | Optional | Indicates the type of ID submitted for user verification purposes. |
| `Language` | [`Languages?`](../../doc/models/languages.md) | Optional | The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format |
| `LastName` | `string` | Optional | Last name<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `MailingAddressLine1` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `MailingAddressLine2` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `MailingAddressLine3` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `MailingCity` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `MailingCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `MailingPostalCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3` |
| `MailingRegion` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `MobileNumber` | `string` | Optional | - |
| `MobileNumberCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `OccupationTitle` | `string` | Optional | **Constraints**: *Maximum Length*: `20` |
| `OccupationType` | [`Occupations?`](../../doc/models/occupations.md) | Optional | [Type of occupation](#/rest/models/structures/occupation) for the user |
| `PhoneNumber` | `string` | Optional | - |
| `PhoneNumberCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `PostalCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `50` |
| `ProgramUserId` | `string` | Optional | [Program identifier](#/rest/models/structures/program-user-id) for the user<br><br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `100` |
| `Region` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `Status` | [`UserStatuses?`](../../doc/models/user-statuses.md) | Optional | Status of the user [User status type](#/rest/models/structures/user-status) |
| `TaxResidentStatus` | [`TaxResidentStatuses?`](../../doc/models/tax-resident-statuses.md) | Optional | Tax [resident status type](#/rest/models/structures/tax-resident-status) |
| `UserType` | [`UserTypes?`](../../doc/models/user-types.md) | Optional | Account holder's profile [type](#/rest/models/structures/user-type) |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |
| `Meta` | [`MetadataItems`](../../doc/models/metadata-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "token": "string",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "businessAddressLine1": "string",
  "businessAddressLine2": "string",
  "businessAddressLine3": "string",
  "businessAddressType": "BUSINESS",
  "businessCity": "string",
  "businessContactRole": "MANAGER",
  "businesscountry": "US",
  "businessName": "string",
  "businessPostalCode": "uuk",
  "businessRegion": "string",
  "city": "string",
  "country": "US",
  "countryOfBirth": "US",
  "countryOfNationality": "US",
  "createdOn": "2026-02-07T22:23:09.9667010Z",
  "currency": "USD",
  "dateOfBirth": "2026-02-07T22:23:10.0141433Z",
  "email": "john.doe@email.com",
  "employerId": "string",
  "firstName": "John",
  "gender": "FEMALE",
  "governmentId": "string",
  "governmentIdType": "CURP",
  "language": "en-US",
  "lastName": "Doe",
  "mailingAddressLine1": "string",
  "mailingAddressLine2": "string",
  "mailingAddressLine3": "string",
  "mailingCity": "string",
  "mailingcountry": "US",
  "mailingPostalCode": "jgl",
  "mailingRegion": "string",
  "mobileNumber": "+12345678901",
  "mobileNumberCountry": "US",
  "occupationTitle": "string",
  "occupationType": "ARTS",
  "phoneNumber": "+12345678901",
  "phoneNumberCountry": "US",
  "postalCode": "uuk",
  "programUserId": "pdekt",
  "region": "string",
  "status": "ACTIVE",
  "taxResidentStatus": "NO",
  "userType": "BUSINESS",
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
  }
}
```

