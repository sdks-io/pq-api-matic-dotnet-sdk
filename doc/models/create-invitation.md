
# Create Invitation

## Structure

`CreateInvitation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | [`Currencies?`](../../doc/models/currencies.md) | Optional | [Currency code type](#/rest/models/structures/country) for the object<br><br>**Default**: `Currencies.USD` |
| `ProgramUserId` | `string` | Optional | [Program identifier](#/rest/models/structures/program-user-id) for the user<br><br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `100` |
| `Email` | `string` | Optional | Contact [email address](#/rest/models/structures/email-address) for the user account for the user account<br><br>**Constraints**: *Minimum Length*: `8`, *Maximum Length*: `100`, *Pattern*: `^.+@.+\..+` |
| `FirstName` | `string` | Optional | First name<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `LastName` | `string` | Optional | Last name<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `DateOfBirth` | `DateTime?` | Optional | - |
| `TaxResidentStatus` | [`TaxResidentStatuses?`](../../doc/models/tax-resident-statuses.md) | Optional | Tax [resident status type](#/rest/models/structures/tax-resident-status) |
| `PhoneNumber` | `string` | Optional | - |
| `MobileNumber` | `string` | Optional | - |
| `PhoneNumberCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `MobileNumberCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `AddressLine1` | `string` | Optional | Address Line 1<br><br>**Constraints**: *Maximum Length*: `255` |
| `AddressLine2` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `AddressLine3` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `City` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `Region` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `Country` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `PostalCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `50` |
| `Gender` | [`Genders?`](../../doc/models/genders.md) | Optional | [Gender](#/rest/models/structures/gender) as a user identifies |
| `UserType` | [`UserTypes?`](../../doc/models/user-types.md) | Optional | Account holder's profile [type](#/rest/models/structures/user-type) |
| `Language` | [`Languages?`](../../doc/models/languages.md) | Optional | The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format |
| `CountryOfBirth` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `CountryOfNationality` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `BusinessContactRole` | [`BusinessContactRoles?`](../../doc/models/business-contact-roles.md) | Optional | Business contact role<br><br>**Constraints**: *Maximum Length*: `20` |
| `GovernmentIdType` | [`GovernmentIds?`](../../doc/models/government-ids.md) | Optional | Indicates the type of ID submitted for user verification purposes. |
| `GovernmentId` | `string` | Optional | **Constraints**: *Maximum Length*: `20` |
| `OccupationTitle` | `string` | Optional | **Constraints**: *Maximum Length*: `20` |
| `OccupationType` | [`Occupations?`](../../doc/models/occupations.md) | Optional | [Type of occupation](#/rest/models/structures/occupation) for the user |
| `MailingAddressLine1` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `MailingAddressLine2` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `MailingAddressLine3` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `MailingCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `MailingCity` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `MailingRegion` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `MailingPostalCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3` |
| `BusinessAddressLine1` | `string` | Optional | Business address line 1<br><br>**Constraints**: *Maximum Length*: `255` |
| `BusinessAddressLine2` | `string` | Optional | Business address line 2<br><br>**Constraints**: *Maximum Length*: `255` |
| `BusinessAddressLine3` | `string` | Optional | Business address line 3<br><br>**Constraints**: *Maximum Length*: `255` |
| `BusinessCountry` | [`Countries?`](../../doc/models/countries.md) | Optional | Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.<br><br>The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience. |
| `BusinessCity` | `string` | Optional | Business city<br><br>**Constraints**: *Maximum Length*: `50` |
| `BusinessRegion` | `string` | Optional | Region that the business is based out of |
| `BusinessPostalCode` | `string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `50` |
| `PremiseNumber` | `string` | Optional | **Constraints**: *Maximum Length*: `50` |
| `ProgramToken` | `string` | Optional | Auto-generated unique identifier representing a program, prefixed with prog-<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^prog-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `PrimaryUserToken` | `string` | Optional | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Example (as JSON)

```json
{
  "currency": "USD",
  "programUserId": "pdekt",
  "email": "john.doe@email.com",
  "firstName": "John",
  "lastName": "Doe",
  "dateOfBirth": "2026-02-07T22:23:10.0141433Z",
  "taxResidentStatus": "NO",
  "phoneNumber": "+12345678901",
  "mobileNumber": "+12345678901",
  "phoneNumberCountry": "US",
  "mobileNumberCountry": "US",
  "addressLine1": "string",
  "addressLine2": "string",
  "addressLine3": "string",
  "city": "string",
  "region": "string",
  "country": "US",
  "postalCode": "uuk",
  "gender": "FEMALE",
  "userType": "BUSINESS",
  "language": "en-US",
  "countryOfBirth": "US",
  "countryOfNationality": "US",
  "businessContactRole": "MANAGER",
  "governmentIdType": "CURP",
  "governmentId": "string",
  "occupationTitle": "string",
  "occupationType": "ARTS",
  "mailingAddressLine1": "string",
  "mailingAddressLine2": "string",
  "mailingAddressLine3": "string",
  "mailingcountry": "US",
  "mailingCity": "string",
  "mailingRegion": "string",
  "mailingPostalCode": "jgl",
  "businessAddressLine1": "string",
  "businessAddressLine2": "string",
  "businessAddressLine3": "string",
  "businesscountry": "US",
  "businessCity": "string",
  "businessRegion": "string",
  "businessPostalCode": "uuk",
  "premiseNumber": "string",
  "programToken": "prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb",
  "primaryUserToken": "user-2bbfc967-d12e-4647-a887-d905172fb4bc"
}
```

