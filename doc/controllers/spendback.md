# Spendback

# Spendback

---


The *Spendback* resource represents a closed-loop and pull-based payment method that will allow users to make a payment from a prepaid card or wallet.

With this resource, you can perform the following requests:

* `POST`: Quote a spendback
* `GET`: Retrieve a spendback quote or list of spendback quotes
* `PATCH`: Update a spendback quote
* `DELETE`: Delete a spendback quote

For more information, see [Spendback](page:resources/spendbacks).

```csharp
ISpendbackController spendbackController = client.SpendbackController;
```

## Class Name

`SpendbackController`

## Methods

* [Accept Spendback Quote](../../doc/controllers/spendback.md#accept-spendback-quote)
* [Cancel Spendback Quote](../../doc/controllers/spendback.md#cancel-spendback-quote)
* [Create Spendback Quote](../../doc/controllers/spendback.md#create-spendback-quote)
* [List Spendbacks](../../doc/controllers/spendback.md#list-spendbacks)
* [Retrieve Spendback](../../doc/controllers/spendback.md#retrieve-spendback)


# Accept Spendback Quote

Accept an open [spendback](page:resources/spendbacks) quote.

```csharp
AcceptSpendbackQuoteAsync(
    string spendbackToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `spendbackToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`.<br><br>**Constraints**: *Pattern*: `^spnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.SpendbackResult>`](../../doc/models/spendback-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
try
{
    SpendbackResult result = await spendbackController.AcceptSpendbackQuoteAsync(spendbackToken);
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
  "token": "spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
  "amount": 300,
  "autoAcceptQuote": false,
  "clientSpendbackId": "08c6d59d-a04d-4603-8104-10c9d4c61f0d",
  "created": "2022-05-02T16:45:09Z",
  "currency": "USD",
  "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
  "memo": "Spendback 1 Memo",
  "note": "Spendback 1 Note",
  "purpose": "EXPENSE",
  "sourceToken": "user-2bbfc967-d12e-4647-a887-d905172fb4bc",
  "status": "PENDING_ACCEPTANCE",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
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


# Cancel Spendback Quote

Cancel an open [spendback](page:resources/spendbacks) quote.

```csharp
CancelSpendbackQuoteAsync(
    string spendbackToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `spendbackToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`.<br><br>**Constraints**: *Pattern*: `^spnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.SpendbackResult>`](../../doc/models/spendback-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
try
{
    SpendbackResult result = await spendbackController.CancelSpendbackQuoteAsync(spendbackToken);
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
  "token": "spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
  "amount": 300,
  "autoAcceptQuote": false,
  "clientSpendbackId": "08c6d59d-a04d-4603-8104-10c9d4c61f0d",
  "created": "2022-05-02T16:45:09Z",
  "currency": "USD",
  "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
  "memo": "Spendback 1 Memo",
  "note": "Spendback 1 Note",
  "purpose": "EXPENSE",
  "sourceToken": "user-2bbfc967-d12e-4647-a887-d905172fb4bc",
  "status": "PENDING_ACCEPTANCE",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
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


# Create Spendback Quote

Create a [spendback](page:resources/spendbacks) quote.

```csharp
CreateSpendbackQuoteAsync(
    SpendbackQuote body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SpendbackQuote`](../../doc/models/containers/spendback-quote.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.SpendbackResult>`](../../doc/models/spendback-result.md)

## Example Usage

```csharp
SpendbackQuote body = SpendbackQuote.FromGatewaySpendbackQuote(
    new GatewaySpendbackQuote
    {
        Amount = 1.02,
        Currency = Currencies.Usd,
        SourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
        DestinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
        Memo = "string",
        Note = "string",
        ClientSpendbackId = "spnd-b7fda294-8d3a-48e8-9a11-ef7be07a732c",
        AutoAcceptQuote = true,
    }
);

try
{
    SpendbackResult result = await spendbackController.CreateSpendbackQuoteAsync(body);
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
  "token": "spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
  "amount": 300,
  "autoAcceptQuote": false,
  "clientSpendbackId": "08c6d59d-a04d-4603-8104-10c9d4c61f0d",
  "created": "2022-05-02T16:45:09Z",
  "currency": "USD",
  "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
  "memo": "Spendback 1 Memo",
  "note": "Spendback 1 Note",
  "purpose": "EXPENSE",
  "sourceToken": "user-2bbfc967-d12e-4647-a887-d905172fb4bc",
  "status": "PENDING_ACCEPTANCE",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
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


# List Spendbacks

Retrieve a list of [spendbacks](page:resources/spendbacks) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListSpendbacksAsync(
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

[`Task<Models.SpendbackListResult>`](../../doc/models/spendback-list-result.md)

## Example Usage

```csharp
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    SpendbackListResult result = await spendbackController.ListSpendbacksAsync(
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
      "token": "spnd-c62fd949-78ef-4f32-aef7-5de8d0c6f4a7",
      "amount": 300,
      "autoAcceptQuote": false,
      "clientSpendbackId": "8c3b61d7-1f5a-4bb9-8ffc-ac756c27a3e1",
      "created": "2021-06-08T19:30:03Z",
      "currency": "USD",
      "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
      "memo": "Spendback 1 Memo",
      "note": "Spendback 1 Note",
      "purpose": "EXPENSE",
      "sourceToken": "user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2",
      "status": "ACCEPTED",
      "receiptToken": "rcpt-4aaa0738-24d9-40bd-a548-18932a6c7f5c",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-c62fd949-78ef-4f32-aef7-5de8d0c6f4a7",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "spnd-9d769a60-4d59-4905-bb46-8f6856121f2a",
      "amount": 35,
      "autoAcceptQuote": false,
      "clientSpendbackId": "37ebee96-eb48-4689-8079-b650e2a4e753",
      "created": "2021-06-08T19:31:56Z",
      "currency": "USD",
      "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
      "memo": "Spendback 1 Memo",
      "note": "Spendback 1 Note",
      "purpose": "EXPENSE",
      "sourceToken": "user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2",
      "status": "CANCELLED",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-9d769a60-4d59-4905-bb46-8f6856121f2a",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "spnd-bc16fb78-e391-4796-8a82-4fe7d7473c1a",
      "amount": 100,
      "autoAcceptQuote": true,
      "clientSpendbackId": "35bc04d0-e98f-4ca9-817b-d62c3b320d6f",
      "created": "2021-06-08T19:33:18Z",
      "currency": "USD",
      "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
      "memo": "Spendback 1 Memo",
      "note": "Spendback 1 Note",
      "purpose": "EXPENSE",
      "sourceToken": "user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2",
      "status": "ACCEPTED",
      "receiptToken": "rcpt-6dbd9a70-75c9-49b7-aff6-34708ed491df",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-bc16fb78-e391-4796-8a82-4fe7d7473c1a",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "spnd-4d14117c-3e8b-4275-9863-f85762ac32fb",
      "amount": 100,
      "autoAcceptQuote": true,
      "clientSpendbackId": "SPENDBACKRETURN-79f6126943bd451f99bb38649da1ea10",
      "created": "2021-06-08T19:34:33Z",
      "currency": "USD",
      "destinationToken": "acct-70739320-c917-425c-a77a-d647c65fd175",
      "sourceToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
      "status": "FAILED",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4d14117c-3e8b-4275-9863-f85762ac32fb",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "spnd-25b877b2-fb00-4c9a-a464-f91a6597e752",
      "amount": 20,
      "autoAcceptQuote": true,
      "clientSpendbackId": "9b97af1c-53b6-42a0-b19c-eaffdc48a854",
      "created": "2021-06-08T19:35:00Z",
      "currency": "USD",
      "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
      "memo": "Spendback 1 Memo",
      "note": "Spendback 1 Note",
      "purpose": "EXPENSE",
      "sourceToken": "user-b41dee0e-f1ca-4e1b-9e1e-e95d13ad8fa2",
      "status": "ACCEPTED",
      "receiptToken": "rcpt-e69b9edb-23c3-4a47-900c-60b7addbbae2",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-25b877b2-fb00-4c9a-a464-f91a6597e752",
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
    "pageCount": "13",
    "recordCount": "64",
    "timezone": "GMT",
    "requestRef": "request-reference-value"
  },
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/spend-back?page=1&pageSize=5&language=en-US",
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


# Retrieve Spendback

Retrieve a single [spendbacks](page:resources/spendbacks) quote using the spendback token.

```csharp
RetrieveSpendbackAsync(
    string spendbackToken,
    int page,
    int pageSize,
    string filter = null,
    string sort = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `spendbackToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`.<br><br>**Constraints**: *Pattern*: `^spnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.SpendbackResult>`](../../doc/models/spendback-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    SpendbackResult result = await spendbackController.RetrieveSpendbackAsync(
        spendbackToken,
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
  "token": "spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
  "amount": 300,
  "autoAcceptQuote": false,
  "clientSpendbackId": "08c6d59d-a04d-4603-8104-10c9d4c61f0d",
  "created": "2022-05-02T16:45:09Z",
  "currency": "USD",
  "destinationToken": "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
  "memo": "Spendback 1 Memo",
  "note": "Spendback 1 Note",
  "purpose": "EXPENSE",
  "sourceToken": "user-2bbfc967-d12e-4647-a887-d905172fb4bc",
  "status": "PENDING_ACCEPTANCE",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/spend-back/spnd-4c414196-d3dd-4233-a729-6fc2da0810eb",
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

