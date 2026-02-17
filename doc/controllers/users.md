# Users

# Users

---


The *Users* resource represents an individual or a business that can receive payments, such as employees, survey participants, contractors, or distributors.

Users can withdraw funds using any of PayQuicker supported payout options, including bank accounts, debit cards, prepaid cards, or paper checks. All payout options for a user are attached to their resource.

With this resource, you can perform the following calls:

* `POST`: Create a new user
* `GET`: Retrieve a user or list of users
* `PUT`: Update a user

For more information, see [Users](page:resources/user).

```csharp
IUsersController usersController = client.UsersController;
```

## Class Name

`UsersController`

## Methods

* [Create User](../../doc/controllers/users.md#create-user)
* [List Users](../../doc/controllers/users.md#list-users)
* [Retrieve User](../../doc/controllers/users.md#retrieve-user)
* [Update User](../../doc/controllers/users.md#update-user)


# Create User

Create a new [user](page:resources/user).

```csharp
CreateUserAsync(
    Models.CreateOrUpdateUser body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateOrUpdateUser`](../../doc/models/create-or-update-user.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.UserResult>`](../../doc/models/user-result.md)

## Example Usage

```csharp
CreateOrUpdateUser body = new CreateOrUpdateUser
{
};

try
{
    UserResult result = await usersController.CreateUserAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "user-91acd009-36d5-40d9-b8b1-39a3704b577e",
  "addressLine1": "4179 BUFFALO ROAD",
  "businessAddressLine1": "99 Office Park",
  "businessAddressLine2": "Suite 293",
  "businessAddressType": "BUSINESS",
  "businessCity": "Modesto",
  "businessContactRole": "OTHER",
  "businessCountry": "US",
  "businessName": "Api V2 Company LLC",
  "businessPostalCode": "99700",
  "businessRegion": "CA",
  "city": "NORTH CHILI",
  "country": "US",
  "countryOfBirth": "US",
  "countryOfNationality": "US",
  "createdOn": "2022-04-08T19:44:16Z",
  "currency": "USD",
  "dateOfBirth": "1991-04-13T00:00:00Z",
  "email": "PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM",
  "employerId": "1",
  "firstName": "Timothy",
  "gender": "MALE",
  "governmentId": "111111111",
  "governmentIdType": "SSN",
  "language": "en-US",
  "lastName": "Mueller",
  "mailingAddressLine1": "128 Maple Lane",
  "mailingCity": "Rochester",
  "mailingCountry": "US",
  "mailingPostalCode": "14625",
  "mailingRegion": "NY",
  "mobileNumber": "+15859876543",
  "mobileNumberCountry": "US",
  "occupationTitle": "TESTER",
  "occupationType": "GOVERNMENT",
  "phoneNumber": "+15859876543",
  "phoneNumberCountry": "US",
  "postalCode": "14514",
  "programUserId": "Kaylee.Howe8",
  "region": "NY",
  "taxResidentStatus": "YES",
  "userType": "INDIVIDUAL",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# List Users

Retrieve a list of [users](page:resources/user) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListUsersAsync(
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.UserListResult>`](../../doc/models/user-list-result.md)

## Example Usage

```csharp
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    UserListResult result = await usersController.ListUsersAsync(
        page,
        pageSize,
        filter,
        sort,
        language
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "payload": [
    {
      "token": "user-19c60cc6-71c3-4db0-9092-4d422410c87e",
      "addressLine1": "400 Linden Oaks",
      "addressLine2": "Rochester, NY 14625-2818",
      "city": "Rochester",
      "country": "US",
      "countryOfBirth": "US",
      "countryOfNationality": "US",
      "createdOn": "2021-06-07T21:23:41Z",
      "dateOfBirth": "1991-04-13T00:00:00Z",
      "email": "PQTESTEMAIL+Caden_Aufderhar@GMAIL.COM",
      "firstName": "Susie",
      "gender": "MALE",
      "language": "en-US",
      "lastName": "Fadel",
      "mobileNumber": "+1 585-987-6543",
      "mobileNumberCountry": "US",
      "phoneNumber": "+1 585-987-6543",
      "phoneNumberCountry": "US",
      "postalCode": "14625",
      "premiseNumber": "400",
      "programUserId": "Haley_Ryan",
      "region": "NY",
      "status": "ACTIVE",
      "userType": "INDIVIDUAL",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-19c60cc6-71c3-4db0-9092-4d422410c87e",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "user-2d926d31-a609-40e1-b28a-a32e0aeb6a79",
      "addressLine1": "400 Linden Oaks",
      "addressLine2": "Rochester, NY 14625-2818",
      "city": "Rochester",
      "country": "US",
      "countryOfBirth": "US",
      "countryOfNationality": "US",
      "createdOn": "2021-06-08T16:04:54Z",
      "dateOfBirth": "1991-04-13T00:00:00Z",
      "email": "PQTESTEMAIL+Milton_Cronin9@GMAIL.COM",
      "firstName": "Alycia",
      "gender": "MALE",
      "language": "en-US",
      "lastName": "McLaughlin",
      "mobileNumber": "+1 585-987-6543",
      "mobileNumberCountry": "US",
      "phoneNumber": "+1 585-987-6543",
      "phoneNumberCountry": "US",
      "postalCode": "14625",
      "premiseNumber": "400",
      "programUserId": "Elliot.Sawayn",
      "region": "NY",
      "status": "ACTIVE",
      "userType": "INDIVIDUAL",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-2d926d31-a609-40e1-b28a-a32e0aeb6a79",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "user-80df50a2-3cc8-462d-87c8-cf3e266994c8",
      "addressLine1": "400 Linden Oaks",
      "addressLine2": "Rochester, NY 14625-2818",
      "city": "Rochester",
      "country": "US",
      "countryOfBirth": "US",
      "countryOfNationality": "US",
      "createdOn": "2021-06-08T16:13:53Z",
      "dateOfBirth": "1991-04-13T00:00:00Z",
      "email": "PQTESTEMAIL+Meta50@GMAIL.COM",
      "firstName": "Trisha",
      "gender": "MALE",
      "governmentId": "000000000",
      "language": "en-US",
      "lastName": "Leffler",
      "mobileNumber": "+1 585-987-6543",
      "mobileNumberCountry": "US",
      "phoneNumber": "+1 585-987-6543",
      "phoneNumberCountry": "US",
      "postalCode": "14625",
      "premiseNumber": "400",
      "programUserId": "Nona49",
      "region": "NY",
      "status": "ACTIVE",
      "userType": "INDIVIDUAL",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-80df50a2-3cc8-462d-87c8-cf3e266994c8",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "user-b26db8d1-ebb1-4367-aad4-3ffb6f0f17cf",
      "addressLine1": "400 Linden Oaks",
      "addressLine2": "Rochester, NY 14625-2818",
      "city": "Rochester",
      "country": "US",
      "countryOfBirth": "US",
      "countryOfNationality": "US",
      "createdOn": "2021-06-08T16:21:54Z",
      "dateOfBirth": "1991-04-13T00:00:00Z",
      "email": "PQTESTEMAIL+Frankie_Stoltenberg@GMAIL.COM",
      "firstName": "Kevon",
      "gender": "MALE",
      "governmentId": "000000000",
      "language": "en-US",
      "lastName": "Waelchi",
      "mobileNumber": "+1 585-987-6543",
      "mobileNumberCountry": "US",
      "phoneNumber": "+1 585-987-6543",
      "phoneNumberCountry": "US",
      "postalCode": "14625",
      "premiseNumber": "400",
      "programUserId": "Lydia_Jacobi13",
      "region": "NY",
      "status": "ACTIVE",
      "userType": "INDIVIDUAL",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-b26db8d1-ebb1-4367-aad4-3ffb6f0f17cf",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "user-61b12c1f-7cff-42e3-9c56-09ba2b08d2ed",
      "addressLine1": "4179 BUFFALO ROAD",
      "businessAddressLine1": "400 Linden Oaks",
      "businessAddressType": "BUSINESS",
      "businessCity": "Rochester",
      "businessCountry": "US",
      "businessName": "Api V2 Company LLC",
      "businessOperatingName": "Api V2 Company LLC",
      "businessPostalCode": "14625",
      "businessRegion": "NY",
      "businessRegistrationCountry": "US",
      "businessRegistrationRegion": "NY",
      "city": "NORTH CHILI",
      "country": "US",
      "countryOfBirth": "US",
      "countryOfNationality": "US",
      "createdOn": "2021-06-08T16:36:05Z",
      "dateOfBirth": "1991-04-13T00:00:00Z",
      "email": "PQTESTEMAIL+Helena.Skiles24@GMAIL.COM",
      "firstName": "Westley",
      "gender": "MALE",
      "governmentId": "000000000",
      "language": "en-US",
      "lastName": "Westley",
      "mobileNumber": "+1 585-987-6543",
      "mobileNumberCountry": "US",
      "phoneNumber": "+1 585-987-6543",
      "phoneNumberCountry": "US",
      "postalCode": "14514",
      "premiseNumber": "400",
      "programUserId": "Nicholas94",
      "region": "NY",
      "status": "ACTIVE",
      "userType": "BUSINESS",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-61b12c1f-7cff-42e3-9c56-09ba2b08d2ed",
          "params": {
            "rel": "self"
          }
        }
      ]
    }
  ],
  "meta": {
    "pageNo": "1",
    "pageSize": "5",
    "pageCount": "124",
    "recordCount": "618",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users?pageSize=5&page=1",
      "params": {
        "rel": "self"
      }
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# Retrieve User

Retrieve a single [user](page:resources/user) record by user token.

```csharp
RetrieveUserAsync(
    string userToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.UserResult>`](../../doc/models/user-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
try
{
    UserResult result = await usersController.RetrieveUserAsync(userToken);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "user-91acd009-36d5-40d9-b8b1-39a3704b577e",
  "addressLine1": "4179 BUFFALO ROAD",
  "businessAddressLine1": "99 Office Park",
  "businessAddressLine2": "Suite 293",
  "businessAddressType": "BUSINESS",
  "businessCity": "Modesto",
  "businessContactRole": "OTHER",
  "businessCountry": "US",
  "businessName": "Api V2 Company LLC",
  "businessPostalCode": "99700",
  "businessRegion": "CA",
  "city": "NORTH CHILI",
  "country": "US",
  "countryOfBirth": "US",
  "countryOfNationality": "US",
  "createdOn": "2022-04-08T19:44:16Z",
  "currency": "USD",
  "dateOfBirth": "1991-04-13T00:00:00Z",
  "email": "PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM",
  "employerId": "1",
  "firstName": "Timothy",
  "gender": "MALE",
  "governmentId": "111111111",
  "governmentIdType": "SSN",
  "language": "en-US",
  "lastName": "Mueller",
  "mailingAddressLine1": "128 Maple Lane",
  "mailingCity": "Rochester",
  "mailingCountry": "US",
  "mailingPostalCode": "14625",
  "mailingRegion": "NY",
  "mobileNumber": "+15859876543",
  "mobileNumberCountry": "US",
  "occupationTitle": "TESTER",
  "occupationType": "GOVERNMENT",
  "phoneNumber": "+15859876543",
  "phoneNumberCountry": "US",
  "postalCode": "14514",
  "programUserId": "Kaylee.Howe8",
  "region": "NY",
  "taxResidentStatus": "YES",
  "userType": "INDIVIDUAL",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# Update User

Update a [user](page:resources/user) object (change [email](#/rest/models/structures/email-address)], [address](#/rest/models/structures/address) change, etc.) using a user token.'

```csharp
UpdateUserAsync(
    string userToken,
    Models.CreateOrUpdateUser body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `body` | [`CreateOrUpdateUser`](../../doc/models/create-or-update-user.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.UserResult>`](../../doc/models/user-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
CreateOrUpdateUser body = new CreateOrUpdateUser
{
};

try
{
    UserResult result = await usersController.UpdateUserAsync(
        userToken,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorResultException)
    {
       // TODO: Handle ApiErrorResultException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "token": "user-91acd009-36d5-40d9-b8b1-39a3704b577e",
  "addressLine1": "4179 BUFFALO ROAD",
  "businessAddressLine1": "99 Office Park",
  "businessAddressLine2": "Suite 293",
  "businessAddressType": "BUSINESS",
  "businessCity": "Modesto",
  "businessContactRole": "OTHER",
  "businessCountry": "US",
  "businessName": "Api V2 Company LLC",
  "businessPostalCode": "99700",
  "businessRegion": "CA",
  "city": "NORTH CHILI",
  "country": "US",
  "countryOfBirth": "US",
  "countryOfNationality": "US",
  "createdOn": "2022-04-08T19:44:16Z",
  "currency": "USD",
  "dateOfBirth": "1991-04-13T00:00:00Z",
  "email": "PQTESTEMAIL+Emanuel_Carroll@GMAIL.COM",
  "employerId": "1",
  "firstName": "Timothy",
  "gender": "MALE",
  "governmentId": "111111111",
  "governmentIdType": "SSN",
  "language": "en-US",
  "lastName": "Mueller",
  "mailingAddressLine1": "128 Maple Lane",
  "mailingCity": "Rochester",
  "mailingCountry": "US",
  "mailingPostalCode": "14625",
  "mailingRegion": "NY",
  "mobileNumber": "+15859876543",
  "mobileNumberCountry": "US",
  "occupationTitle": "TESTER",
  "occupationType": "GOVERNMENT",
  "phoneNumber": "+15859876543",
  "phoneNumberCountry": "US",
  "postalCode": "14514",
  "programUserId": "Kaylee.Howe8",
  "region": "NY",
  "taxResidentStatus": "YES",
  "userType": "INDIVIDUAL",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-91acd009-36d5-40d9-b8b1-39a3704b577e",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |

