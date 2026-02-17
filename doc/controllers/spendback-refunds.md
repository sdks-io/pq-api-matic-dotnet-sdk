# Spendback Refunds

```csharp
ISpendbackRefundsController spendbackRefundsController = client.SpendbackRefundsController;
```

## Class Name

`SpendbackRefundsController`

## Methods

* [Accept Spendback Refund Quote](../../doc/controllers/spendback-refunds.md#accept-spendback-refund-quote)
* [Cancel Spendback Refund Quote](../../doc/controllers/spendback-refunds.md#cancel-spendback-refund-quote)
* [Create Spendback Refund Quote](../../doc/controllers/spendback-refunds.md#create-spendback-refund-quote)
* [List Spendback Refunds](../../doc/controllers/spendback-refunds.md#list-spendback-refunds)
* [Retrieve Spendback Refund](../../doc/controllers/spendback-refunds.md#retrieve-spendback-refund)


# Accept Spendback Refund Quote

Accept a spendback return quote.

```csharp
AcceptSpendbackRefundQuoteAsync(
    string spendbackToken,
    string refundToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `spendbackToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`.<br><br>**Constraints**: *Pattern*: `^spnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `refundToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`.<br><br>**Constraints**: *Pattern*: `^rfnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.SpendbackRefundResult>`](../../doc/models/spendback-refund-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
string refundToken = "rfnd-c39437e1-dc80-4293-8211-c14b5a32f762";
try
{
    SpendbackRefundResult result = await spendbackRefundsController.AcceptSpendbackRefundQuoteAsync(
        spendbackToken,
        refundToken
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


# Cancel Spendback Refund Quote

Cancel an spendback refund quote.

```csharp
CancelSpendbackRefundQuoteAsync(
    string spendbackToken,
    string refundToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `spendbackToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`.<br><br>**Constraints**: *Pattern*: `^spnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `refundToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`.<br><br>**Constraints**: *Pattern*: `^rfnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.SpendbackRefundResult>`](../../doc/models/spendback-refund-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
string refundToken = "rfnd-c39437e1-dc80-4293-8211-c14b5a32f762";
try
{
    SpendbackRefundResult result = await spendbackRefundsController.CancelSpendbackRefundQuoteAsync(
        spendbackToken,
        refundToken
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


# Create Spendback Refund Quote

Perform a [spendback](page:resources/spendbacks) refund for a partial amount.

```csharp
CreateSpendbackRefundQuoteAsync(
    string spendbackToken,
    Models.CreateSpendbackRefundQuote body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `spendbackToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back transaction and quote, prefixed with `spnd-`.<br><br>**Constraints**: *Pattern*: `^spnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `body` | [`CreateSpendbackRefundQuote`](../../doc/models/create-spendback-refund-quote.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.SpendbackRefundResult>`](../../doc/models/spendback-refund-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
CreateSpendbackRefundQuote body = new CreateSpendbackRefundQuote
{
    Amount = 1.13,
};

try
{
    SpendbackRefundResult result = await spendbackRefundsController.CreateSpendbackRefundQuoteAsync(
        spendbackToken,
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# List Spendback Refunds

Retrieve a list of [spendbacks](page:resources/spendbacks) refunds that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListSpendbackRefundsAsync(
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

[`Task<Models.SpendbackRefundListResult>`](../../doc/models/spendback-refund-list-result.md)

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
    SpendbackRefundListResult result = await spendbackRefundsController.ListSpendbackRefundsAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |


# Retrieve Spendback Refund

Retrieve a single spendback refund using the rfnd token

```csharp
RetrieveSpendbackRefundAsync(
    string spendbackToken,
    string refundToken,
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
| `refundToken` | `string` | Template, Required | Auto-generated unique identifier representing an individual spend back refund transaction and quote, prefixed with `rfnd-`.<br><br>**Constraints**: *Pattern*: `^rfnd-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `page` | `int` | Query, Required | Page number of specific page to return<br><br>**Constraints**: `>= 1` |
| `pageSize` | `int` | Query, Required | Number of items to be displayed per page<br><br>**Constraints**: `>= 1`, `<= 50` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `sort` | `string` | Query, Optional | Sort request results by specific attribute. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.SpendbackRefundResult>`](../../doc/models/spendback-refund-result.md)

## Example Usage

```csharp
string spendbackToken = "spnd-c39437e1-dc80-4293-8211-c14b5a32f762";
string refundToken = "rfnd-c39437e1-dc80-4293-8211-c14b5a32f762";
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    SpendbackRefundResult result = await spendbackRefundsController.RetrieveSpendbackRefundAsync(
        spendbackToken,
        refundToken,
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| 500 | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |
| Default | - | [`ApiErrorResultException`](../../doc/models/api-error-result-exception.md) |

