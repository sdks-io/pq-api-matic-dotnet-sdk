# Bank Accounts

```csharp
IBankAccountsController bankAccountsController = client.BankAccountsController;
```

## Class Name

`BankAccountsController`

## Methods

* [Create Bank Account](../../doc/controllers/bank-accounts.md#create-bank-account)
* [Create Company Bank Account](../../doc/controllers/bank-accounts.md#create-company-bank-account)
* [Delete Bank Account](../../doc/controllers/bank-accounts.md#delete-bank-account)
* [Delete Company Bank Account](../../doc/controllers/bank-accounts.md#delete-company-bank-account)
* [List Bank Accounts](../../doc/controllers/bank-accounts.md#list-bank-accounts)
* [List Company Bank Accounts](../../doc/controllers/bank-accounts.md#list-company-bank-accounts)
* [Retrieve Bank Account](../../doc/controllers/bank-accounts.md#retrieve-bank-account)
* [Retrieve Bank Account Creation Requirements for a Prepaid Card](../../doc/controllers/bank-accounts.md#retrieve-bank-account-creation-requirements-for-a-prepaid-card)
* [Retrieve Company Bank Account](../../doc/controllers/bank-accounts.md#retrieve-company-bank-account)
* [Retrieve Company Bank Account Creation Requirements](../../doc/controllers/bank-accounts.md#retrieve-company-bank-account-creation-requirements)
* [Retrieve Creation Requirements](../../doc/controllers/bank-accounts.md#retrieve-creation-requirements)
* [Update Bank Account](../../doc/controllers/bank-accounts.md#update-bank-account)
* [Update Company Bank Account](../../doc/controllers/bank-accounts.md#update-company-bank-account)


# Create Bank Account

Create a [bank account](page:resources/bank-accounts) using a user token.

```csharp
CreateBankAccountAsync(
    string userToken,
    Models.CreateOrUpdateBankAccount body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `body` | [`CreateOrUpdateBankAccount`](../../doc/models/create-or-update-bank-account.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.BankAccountResult>`](../../doc/models/bank-account-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
CreateOrUpdateBankAccount body = new CreateOrUpdateBankAccount
{
    BankAccountOwnershipType = BankAccountOwnership.Business,
    BankCountry = Countries.Us,
    BankCurrency = Currencies.Usd,
    Description = "Official USD Testing Bank Account 1",
    Fields = new List<BankAccountField>
    {
        new BankAccountField
        {
            Key = BankAccountFields.BankBban,
            MValue = "01234567890",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankAchAba,
            MValue = "012345678",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankName,
            MValue = "API V2 USD BANK 1",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BeneficiaryName,
            MValue = "Hazel Mosciski",
        },
    },
    Type = BankAccountTypes.Savings,
};

try
{
    BankAccountResult result = await bankAccountsController.CreateBankAccountAsync(
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
  "token": "dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
  "bankAccountOwnershipType": "BUSINESS",
  "bankCountry": "US",
  "bankCurrency": "USD",
  "createdOn": "2022-05-20T15:48:54Z",
  "description": "Official USD Testing Bank Account 1",
  "fields": [
    {
      "key": "BANK_BBAN",
      "value": "****7890"
    },
    {
      "key": "BANK_ACH_ABA",
      "value": "****5678"
    },
    {
      "key": "BENEFICIARY_NAME",
      "value": "Dennis Bruen"
    },
    {
      "key": "BANK_NAME",
      "value": "API V2 USD BANK 1"
    }
  ],
  "status": "VERIFIED",
  "type": "SAVINGS",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
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


# Create Company Bank Account

Create a company [bank account](page:resources/bank-accounts) using an account token.

```csharp
CreateCompanyBankAccountAsync(
    string accountToken,
    Models.CreateOrUpdateBankAccount body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountToken` | `string` | Template, Required | Auto-generated unique identifier representing a company account, prefixed with `acct-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^acct-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `body` | [`CreateOrUpdateBankAccount`](../../doc/models/create-or-update-bank-account.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.BankAccountResult>`](../../doc/models/bank-account-result.md)

## Example Usage

```csharp
string accountToken = "acct-b3f0570a-6586-4e00-8d6e-8a2bf93cfae4";
CreateOrUpdateBankAccount body = new CreateOrUpdateBankAccount
{
    BankAccountOwnershipType = BankAccountOwnership.Business,
    BankCountry = Countries.Us,
    BankCurrency = Currencies.Usd,
    Description = "Official USD Testing Bank Account 1",
    Fields = new List<BankAccountField>
    {
        new BankAccountField
        {
            Key = BankAccountFields.BankBban,
            MValue = "01234567890",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankAchAba,
            MValue = "012345678",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankName,
            MValue = "API V2 USD BANK 1",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BeneficiaryName,
            MValue = "Hazel Mosciski",
        },
    },
    Type = BankAccountTypes.Savings,
};

try
{
    BankAccountResult result = await bankAccountsController.CreateCompanyBankAccountAsync(
        accountToken,
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
  "token": "dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
  "bankAccountOwnershipType": "BUSINESS",
  "bankCountry": "US",
  "bankCurrency": "USD",
  "createdOn": "2022-05-20T15:48:54Z",
  "description": "Official USD Testing Bank Account 1",
  "fields": [
    {
      "key": "BANK_BBAN",
      "value": "****7890"
    },
    {
      "key": "BANK_ACH_ABA",
      "value": "****5678"
    },
    {
      "key": "BENEFICIARY_NAME",
      "value": "Dennis Bruen"
    },
    {
      "key": "BANK_NAME",
      "value": "API V2 USD BANK 1"
    }
  ],
  "status": "VERIFIED",
  "type": "SAVINGS",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
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


# Delete Bank Account

Delete a user [bank account](page:resources/bank-accounts).

```csharp
DeleteBankAccountAsync(
    string userToken,
    string destinationToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.OperationResult>`](../../doc/models/operation-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
try
{
    OperationResult result = await bankAccountsController.DeleteBankAccountAsync(
        userToken,
        destinationToken
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
  "result": true,
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


# Delete Company Bank Account

Delete a company [bank account](page:resources/bank-accounts).

```csharp
DeleteCompanyBankAccountAsync(
    string accountToken,
    string destinationToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountToken` | `string` | Template, Required | Auto-generated unique identifier representing a company account, prefixed with `acct-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^acct-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.OperationResult>`](../../doc/models/operation-result.md)

## Example Usage

```csharp
string accountToken = "acct-b3f0570a-6586-4e00-8d6e-8a2bf93cfae4";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
try
{
    OperationResult result = await bankAccountsController.DeleteCompanyBankAccountAsync(
        accountToken,
        destinationToken
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
  "result": true,
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


# List Bank Accounts

Retrieve a list of [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListBankAccountsAsync(
    string userToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountListResult>`](../../doc/models/bank-account-list-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    BankAccountListResult result = await bankAccountsController.ListBankAccountsAsync(
        userToken,
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
      "token": "dest-969daa60-c743-4e4f-8609-559874f26d6c",
      "bankAccountOwnershipType": "BUSINESS",
      "bankCountry": "US",
      "bankCurrency": "USD",
      "createdOn": "2022-05-20T16:26:25Z",
      "description": "Official USD Testing Bank Account 2",
      "fields": [
        {
          "key": "BANK_BBAN",
          "value": "****7899"
        },
        {
          "key": "BANK_ACH_ABA",
          "value": "****5688"
        },
        {
          "key": "BENEFICIARY_NAME",
          "value": "Harry Grady"
        },
        {
          "key": "BANK_NAME",
          "value": "API V2 USD BANK 2"
        }
      ],
      "status": "VERIFIED",
      "type": "SAVINGS",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-969daa60-c743-4e4f-8609-559874f26d6c",
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
    "pageCount": "1",
    "recordCount": "1",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts?page=1&pageSize=5&language=en-US",
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


# List Company Bank Accounts

Retrieve a list of company [bank accounts](page:resources/bank-accounts) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListCompanyBankAccountsAsync(
    string accountToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountToken` | `string` | Template, Required | Auto-generated unique identifier representing a company account, prefixed with `acct-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^acct-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountListResult>`](../../doc/models/bank-account-list-result.md)

## Example Usage

```csharp
string accountToken = "acct-b3f0570a-6586-4e00-8d6e-8a2bf93cfae4";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    BankAccountListResult result = await bankAccountsController.ListCompanyBankAccountsAsync(
        accountToken,
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
      "token": "dest-969daa60-c743-4e4f-8609-559874f26d6c",
      "bankAccountOwnershipType": "BUSINESS",
      "bankCountry": "US",
      "bankCurrency": "USD",
      "createdOn": "2022-05-20T16:26:25Z",
      "description": "Official USD Testing Bank Account 2",
      "fields": [
        {
          "key": "BANK_BBAN",
          "value": "****7899"
        },
        {
          "key": "BANK_ACH_ABA",
          "value": "****5688"
        },
        {
          "key": "BENEFICIARY_NAME",
          "value": "Harry Grady"
        },
        {
          "key": "BANK_NAME",
          "value": "API V2 USD BANK 2"
        }
      ],
      "status": "VERIFIED",
      "type": "SAVINGS",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-969daa60-c743-4e4f-8609-559874f26d6c",
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
    "pageCount": "1",
    "recordCount": "1",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts?page=1&pageSize=5&language=en-US",
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


# Retrieve Bank Account

Retrieve a single [bank account](page:resources/bank-accounts) using a destination token.

```csharp
RetrieveBankAccountAsync(
    string userToken,
    string destinationToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountResult>`](../../doc/models/bank-account-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    BankAccountResult result = await bankAccountsController.RetrieveBankAccountAsync(
        userToken,
        destinationToken,
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
  "token": "dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
  "bankAccountOwnershipType": "BUSINESS",
  "bankCountry": "US",
  "bankCurrency": "USD",
  "createdOn": "2022-05-20T15:48:54Z",
  "description": "Official USD Testing Bank Account 1",
  "fields": [
    {
      "key": "BANK_BBAN",
      "value": "****7890"
    },
    {
      "key": "BANK_ACH_ABA",
      "value": "****5678"
    },
    {
      "key": "BENEFICIARY_NAME",
      "value": "Dennis Bruen"
    },
    {
      "key": "BANK_NAME",
      "value": "API V2 USD BANK 1"
    }
  ],
  "status": "VERIFIED",
  "type": "SAVINGS",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
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


# Retrieve Bank Account Creation Requirements for a Prepaid Card

Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the pre-paid card as the destination.

```csharp
RetrieveBankAccountCreationRequirementsForAPrepaidCardAsync(
    string userToken,
    string destinationToken,
    Models.Countries? country = null,
    Models.Currencies? currency = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `country` | [`Countries?`](../../doc/models/countries.md) | Query, Optional | Filter results by country. |
| `currency` | [`Currencies?`](../../doc/models/currencies.md) | Query, Optional | Filter results by currency. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountRequirementListResult>`](../../doc/models/bank-account-requirement-list-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
Countries? country = Countries.Us;
Currencies? currency = Currencies.Usd;
try
{
    BankAccountRequirementListResult result = await bankAccountsController.RetrieveBankAccountCreationRequirementsForAPrepaidCardAsync(
        userToken,
        destinationToken,
        country,
        currency
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
      "bankCountry": "IT",
      "bankCurrency": "EUR",
      "requirements": [
        {
          "requirement": "BANK_IBAN",
          "format": {
            "example": "IT43K0310412701000000820420",
            "legend": [
              {
                "key": "IT43K0310412701000000820420",
                "descriptions": [
                  {
                    "language": "en-US",
                    "translation": "Example IBAN"
                  },
                  {
                    "language": "it-IT",
                    "translation": "Esempio IBAN"
                  }
                ]
              }
            ]
          },
          "description": [
            {
              "language": "en-US",
              "translation": "IBAN"
            },
            {
              "language": "it-IT",
              "translation": "IBAN"
            }
          ],
          "validators": [
            {
              "validatorType": "REGEX",
              "expression": "^IT\\\\d{2}[A-Z]\\\\d{10}[0-9A-Z]{12}$"
            }
          ]
        },
        {
          "requirement": "BANK_SWIFT_BIC",
          "format": {
            "example": "01234567890",
            "legend": [
              {
                "key": "01234567890",
                "descriptions": [
                  {
                    "language": "en-US",
                    "translation": "Example Swift/BIC"
                  },
                  {
                    "language": "it-IT",
                    "translation": "Esempio Swift/BIC"
                  }
                ]
              }
            ]
          },
          "description": [
            {
              "language": "en-US",
              "translation": "Swift/BIC"
            },
            {
              "language": "it-IT",
              "translation": "Swift/BIC"
            }
          ],
          "validators": [
            {
              "validatorType": "REGEX",
              "expression": "^[a-z0-9A-Z]{8,11}$"
            }
          ]
        }
      ],
      "quote": {
        "formattedAmount": "$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)",
        "amount": 4.32,
        "currency": "USD"
      },
      "links": [
        {
          "params": {
            "rel": "self"
          },
          "href": "string"
        }
      ]
    }
  ],
  "links": [
    {
      "params": {
        "rel": "self"
      },
      "href": "string"
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


# Retrieve Company Bank Account

Retrieve a single company [bank account](page:resources/bank-accounts) using a destination token.

```csharp
RetrieveCompanyBankAccountAsync(
    string accountToken,
    string destinationToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountToken` | `string` | Template, Required | Auto-generated unique identifier representing a company account, prefixed with `acct-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^acct-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountResult>`](../../doc/models/bank-account-result.md)

## Example Usage

```csharp
string accountToken = "acct-b3f0570a-6586-4e00-8d6e-8a2bf93cfae4";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    BankAccountResult result = await bankAccountsController.RetrieveCompanyBankAccountAsync(
        accountToken,
        destinationToken,
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
  "token": "dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
  "bankAccountOwnershipType": "BUSINESS",
  "bankCountry": "US",
  "bankCurrency": "USD",
  "createdOn": "2022-05-20T15:48:54Z",
  "description": "Official USD Testing Bank Account 1",
  "fields": [
    {
      "key": "BANK_BBAN",
      "value": "****7890"
    },
    {
      "key": "BANK_ACH_ABA",
      "value": "****5678"
    },
    {
      "key": "BENEFICIARY_NAME",
      "value": "Dennis Bruen"
    },
    {
      "key": "BANK_NAME",
      "value": "API V2 USD BANK 1"
    }
  ],
  "status": "VERIFIED",
  "type": "SAVINGS",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
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


# Retrieve Company Bank Account Creation Requirements

Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.

```csharp
RetrieveCompanyBankAccountCreationRequirementsAsync(
    string accountToken,
    Models.Countries? country = null,
    Models.Currencies? currency = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountToken` | `string` | Template, Required | Auto-generated unique identifier representing a company account, prefixed with `acct-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^acct-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `country` | [`Countries?`](../../doc/models/countries.md) | Query, Optional | Filter results by country. |
| `currency` | [`Currencies?`](../../doc/models/currencies.md) | Query, Optional | Filter results by currency. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountRequirementListResult>`](../../doc/models/bank-account-requirement-list-result.md)

## Example Usage

```csharp
string accountToken = "acct-b3f0570a-6586-4e00-8d6e-8a2bf93cfae4";
Countries? country = Countries.Us;
Currencies? currency = Currencies.Usd;
try
{
    BankAccountRequirementListResult result = await bankAccountsController.RetrieveCompanyBankAccountCreationRequirementsAsync(
        accountToken,
        country,
        currency
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
      "bankCountry": "IT",
      "bankCurrency": "EUR",
      "requirements": [
        {
          "requirement": "BANK_IBAN",
          "format": {
            "example": "IT43K0310412701000000820420",
            "legend": [
              {
                "key": "IT43K0310412701000000820420",
                "descriptions": [
                  {
                    "language": "en-US",
                    "translation": "Example IBAN"
                  },
                  {
                    "language": "it-IT",
                    "translation": "Esempio IBAN"
                  }
                ]
              }
            ]
          },
          "description": [
            {
              "language": "en-US",
              "translation": "IBAN"
            },
            {
              "language": "it-IT",
              "translation": "IBAN"
            }
          ],
          "validators": [
            {
              "validatorType": "REGEX",
              "expression": "^IT\\\\d{2}[A-Z]\\\\d{10}[0-9A-Z]{12}$"
            }
          ]
        },
        {
          "requirement": "BANK_SWIFT_BIC",
          "format": {
            "example": "01234567890",
            "legend": [
              {
                "key": "01234567890",
                "descriptions": [
                  {
                    "language": "en-US",
                    "translation": "Example Swift/BIC"
                  },
                  {
                    "language": "it-IT",
                    "translation": "Esempio Swift/BIC"
                  }
                ]
              }
            ]
          },
          "description": [
            {
              "language": "en-US",
              "translation": "Swift/BIC"
            },
            {
              "language": "it-IT",
              "translation": "Swift/BIC"
            }
          ],
          "validators": [
            {
              "validatorType": "REGEX",
              "expression": "^[a-z0-9A-Z]{8,11}$"
            }
          ]
        }
      ],
      "quote": {
        "formattedAmount": "$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)",
        "amount": 4.32,
        "currency": "USD"
      },
      "links": [
        {
          "params": {
            "rel": "self"
          },
          "href": "string"
        }
      ]
    }
  ],
  "links": [
    {
      "params": {
        "rel": "self"
      },
      "href": "string"
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


# Retrieve Creation Requirements

Retrieve requirements for adding a [bank account](page:resources/bank-accounts) using the parameters provided.

```csharp
RetrieveCreationRequirementsAsync(
    string userToken,
    Models.Countries? country = null,
    Models.Currencies? currency = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `country` | [`Countries?`](../../doc/models/countries.md) | Query, Optional | Filter results by country. |
| `currency` | [`Currencies?`](../../doc/models/currencies.md) | Query, Optional | Filter results by currency. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.BankAccountRequirementListResult>`](../../doc/models/bank-account-requirement-list-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
Countries? country = Countries.Us;
Currencies? currency = Currencies.Usd;
try
{
    BankAccountRequirementListResult result = await bankAccountsController.RetrieveCreationRequirementsAsync(
        userToken,
        country,
        currency
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
      "bankCountry": "IT",
      "bankCurrency": "EUR",
      "requirements": [
        {
          "requirement": "BANK_IBAN",
          "format": {
            "example": "IT43K0310412701000000820420",
            "legend": [
              {
                "key": "IT43K0310412701000000820420",
                "descriptions": [
                  {
                    "language": "en-US",
                    "translation": "Example IBAN"
                  },
                  {
                    "language": "it-IT",
                    "translation": "Esempio IBAN"
                  }
                ]
              }
            ]
          },
          "description": [
            {
              "language": "en-US",
              "translation": "IBAN"
            },
            {
              "language": "it-IT",
              "translation": "IBAN"
            }
          ],
          "validators": [
            {
              "validatorType": "REGEX",
              "expression": "^IT\\\\d{2}[A-Z]\\\\d{10}[0-9A-Z]{12}$"
            }
          ]
        },
        {
          "requirement": "BANK_SWIFT_BIC",
          "format": {
            "example": "01234567890",
            "legend": [
              {
                "key": "01234567890",
                "descriptions": [
                  {
                    "language": "en-US",
                    "translation": "Example Swift/BIC"
                  },
                  {
                    "language": "it-IT",
                    "translation": "Esempio Swift/BIC"
                  }
                ]
              }
            ]
          },
          "description": [
            {
              "language": "en-US",
              "translation": "Swift/BIC"
            },
            {
              "language": "it-IT",
              "translation": "Swift/BIC"
            }
          ],
          "validators": [
            {
              "validatorType": "REGEX",
              "expression": "^[a-z0-9A-Z]{8,11}$"
            }
          ]
        }
      ],
      "quote": {
        "formattedAmount": "$4.32 USD (USD, en-US), 0,00 â‚¬ EUR (EUR, fr-FR)",
        "amount": 4.32,
        "currency": "USD"
      },
      "links": [
        {
          "params": {
            "rel": "self"
          },
          "href": "string"
        }
      ]
    }
  ],
  "links": [
    {
      "params": {
        "rel": "self"
      },
      "href": "string"
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


# Update Bank Account

Update a [bank account](page:resources/bank-accounts).

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateBankAccountAsync(
    string userToken,
    string destinationToken,
    Models.CreateOrUpdateBankAccount body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `body` | [`CreateOrUpdateBankAccount`](../../doc/models/create-or-update-bank-account.md) | Body, Optional | - |

## Response Type

[`Task<Models.BankAccountResult>`](../../doc/models/bank-account-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
CreateOrUpdateBankAccount body = new CreateOrUpdateBankAccount
{
    BankAccountOwnershipType = BankAccountOwnership.Business,
    BankCountry = Countries.Us,
    BankCurrency = Currencies.Usd,
    Description = "Official USD Testing Bank Account 1",
    Fields = new List<BankAccountField>
    {
        new BankAccountField
        {
            Key = BankAccountFields.BankBban,
            MValue = "01234567890",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankAchAba,
            MValue = "012345678",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankName,
            MValue = "API V2 USD BANK 1",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BeneficiaryName,
            MValue = "Hazel Mosciski",
        },
    },
    Type = BankAccountTypes.Savings,
};

try
{
    BankAccountResult result = await bankAccountsController.UpdateBankAccountAsync(
        userToken,
        destinationToken,
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
  "token": "dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
  "bankAccountOwnershipType": "BUSINESS",
  "bankCountry": "US",
  "bankCurrency": "USD",
  "createdOn": "2022-05-20T15:48:54Z",
  "description": "Official USD Testing Bank Account 1",
  "fields": [
    {
      "key": "BANK_BBAN",
      "value": "****7890"
    },
    {
      "key": "BANK_ACH_ABA",
      "value": "****5678"
    },
    {
      "key": "BENEFICIARY_NAME",
      "value": "Dennis Bruen"
    },
    {
      "key": "BANK_NAME",
      "value": "API V2 USD BANK 1"
    }
  ],
  "status": "VERIFIED",
  "type": "SAVINGS",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
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


# Update Company Bank Account

Update a company [bank account](page:resources/bank-accounts).

```csharp
UpdateCompanyBankAccountAsync(
    string accountToken,
    string destinationToken,
    Models.CreateOrUpdateBankAccount body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountToken` | `string` | Template, Required | Auto-generated unique identifier representing a company account, prefixed with `acct-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^acct-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `destinationToken` | `string` | Template, Required | Auto-generated unique identifier representing a transfer destination, including prepaid cards, bank accounts, paper checks, and other users, prefixed with `dest-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^dest-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `body` | [`CreateOrUpdateBankAccount`](../../doc/models/create-or-update-bank-account.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.BankAccountResult>`](../../doc/models/bank-account-result.md)

## Example Usage

```csharp
string accountToken = "acct-b3f0570a-6586-4e00-8d6e-8a2bf93cfae4";
string destinationToken = "dest-4aed86e2-4929-45bf-814d-9030aef21e79";
CreateOrUpdateBankAccount body = new CreateOrUpdateBankAccount
{
    BankAccountOwnershipType = BankAccountOwnership.Business,
    BankCountry = Countries.Us,
    BankCurrency = Currencies.Usd,
    Description = "Official USD Testing Bank Account 1",
    Fields = new List<BankAccountField>
    {
        new BankAccountField
        {
            Key = BankAccountFields.BankBban,
            MValue = "01234567890",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankAchAba,
            MValue = "012345678",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BankName,
            MValue = "API V2 USD BANK 1",
        },
        new BankAccountField
        {
            Key = BankAccountFields.BeneficiaryName,
            MValue = "Hazel Mosciski",
        },
    },
    Type = BankAccountTypes.Savings,
};

try
{
    BankAccountResult result = await bankAccountsController.UpdateCompanyBankAccountAsync(
        accountToken,
        destinationToken,
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
  "token": "dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
  "bankAccountOwnershipType": "BUSINESS",
  "bankCountry": "US",
  "bankCurrency": "USD",
  "createdOn": "2022-05-20T15:48:54Z",
  "description": "Official USD Testing Bank Account 1",
  "fields": [
    {
      "key": "BANK_BBAN",
      "value": "****7890"
    },
    {
      "key": "BANK_ACH_ABA",
      "value": "****5678"
    },
    {
      "key": "BENEFICIARY_NAME",
      "value": "Dennis Bruen"
    },
    {
      "key": "BANK_NAME",
      "value": "API V2 USD BANK 1"
    }
  ],
  "status": "VERIFIED",
  "type": "SAVINGS",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/bank-accounts/dest-41579f58-35dd-4f7b-9252-aa3e337a2eb4",
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

