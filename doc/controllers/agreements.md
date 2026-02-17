# Agreements

# Agreements

---


The *Agreements* resource is a document that the user agrees to as part of opening an account with PayQuicker.

Users need to agree to the terms of the account, which includes fees, privacy policy, esign, and consent.

If the user does not agree to these terms, an account will not be opened.

With this resource, you can perform the following requests:

* `POST`: Accept a single agreement
* `GET`: Retrieve an agreement or list of agreements

For more information, see [Agreements](page:resources/agreements).

```csharp
IAgreementsController agreementsController = client.AgreementsController;
```

## Class Name

`AgreementsController`

## Methods

* [Accept Agreement](../../doc/controllers/agreements.md#accept-agreement)
* [List Agreements](../../doc/controllers/agreements.md#list-agreements)
* [Retrieve Program Agreement](../../doc/controllers/agreements.md#retrieve-program-agreement)


# Accept Agreement

Accept a single program [agreement](page:resources/agreements).

```csharp
AcceptAgreementAsync(
    string userToken,
    string agreementToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `agreementToken` | `string` | Template, Required | Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^agmt-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

`Task`

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string agreementToken = "agmt-b33d420f-6c1b-4a93-9455-d6585552b97d";
try
{
    await agreementsController.AcceptAgreementAsync(
        userToken,
        agreementToken
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# List Agreements

Retrieve a list of program [agreements](page:resources/agreements) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListAgreementsAsync(
    string programToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programToken` | `string` | Template, Required | Auto-generated unique identifier representing a program, prefixed with `prog-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^prog-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.AgreementListResultJson>`](../../doc/models/agreement-list-result-json.md)

## Example Usage

```csharp
string programToken = "prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    AgreementListResultJson result = await agreementsController.ListAgreementsAsync(
        programToken,
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
      "token": "agmt-b33d420f-6c1b-4a93-9455-d6585552b97d",
      "contentBase64": "DQogIGZvciB5b3VyIHBsYXN0aW...KPC9ib2R5Pg0KDQo8L2h0bWw+DQo=",
      "url": "https://cdn.payquicker.io/content/Agreements/Cardholder/v1/Languages_EN_US/CardholderAgreement-Consumer-ACH-20k-MCB-USD.pdf",
      "type": "CARD_HOLDER_AGREEMENT",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb/agreements/agmt-b33d420f-6c1b-4a93-9455-d6585552b97d",
          "params": {
            "rel": "self"
          }
        }
      ]
    }
  ],
  "meta": {
    "pageNo": "1",
    "pageSize": "100",
    "pageCount": "0",
    "recordCount": "0",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb/agreements",
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


# Retrieve Program Agreement

Retrieve a single program [agreement](page:resources/agreements).

```csharp
RetrieveProgramAgreementAsync(
    string programToken,
    string agreementToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programToken` | `string` | Template, Required | Auto-generated unique identifier representing a program, prefixed with `prog-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^prog-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `agreementToken` | `string` | Template, Required | Auto-generated unique identifier representing a program agreement, prefixed with `agmt-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^agmt-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.AgreementResult>`](../../doc/models/agreement-result.md)

## Example Usage

```csharp
string programToken = "prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb";
string agreementToken = "agmt-b33d420f-6c1b-4a93-9455-d6585552b97d";
try
{
    AgreementResult result = await agreementsController.RetrieveProgramAgreementAsync(
        programToken,
        agreementToken
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
  "token": "agmt-b33d420f-6c1b-4a93-9455-d6585552b97d",
  "contentBase64": "DQogIGZvciB5b3VyIHBsYXN0aW...KPC9ib2R5Pg0KDQo8L2h0bWw+DQo=",
  "url": "https://cdn.payquicker.io/content/Agreements/Cardholder/v1/Languages_EN_US/CardholderAgreement-Consumer-ACH-20k-MCB-USD.pdf",
  "type": "CARD_HOLDER_AGREEMENT",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/programs/prog-6a272eca-9487-d83a-c9e4-8df8c9a7f6eb/agreements/agmt-b33d420f-6c1b-4a93-9455-d6585552b97d",
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

