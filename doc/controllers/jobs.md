# Jobs

# Jobs

---


The *Jobs* resource allows you to list, create, retrieve, and cancel jobs.

```csharp
IJobsController jobsController = client.JobsController;
```

## Class Name

`JobsController`

## Methods

* [Cancel Payment Job](../../doc/controllers/jobs.md#cancel-payment-job)
* [Create Payment Job](../../doc/controllers/jobs.md#create-payment-job)
* [List Payment Jobs](../../doc/controllers/jobs.md#list-payment-jobs)
* [Retrieve Payment Job](../../doc/controllers/jobs.md#retrieve-payment-job)


# Cancel Payment Job

Cancel an submitted payment [job](page:resources/jobs).

```csharp
CancelPaymentJobAsync(
    string jobToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `jobToken` | `string` | Template, Required | Auto-generated unique identifier representing a job, prefixed with `jobs-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^jobs-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.PaymentJobResult>`](../../doc/models/payment-job-result.md)

## Example Usage

```csharp
string jobToken = "jobs-2bbfc967-d12e-4647-a887-d905172fb4bc";
try
{
    PaymentJobResult result = await jobsController.CancelPaymentJobAsync(jobToken);
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


# Create Payment Job

Create a [payment](page:resources/jobs).

```csharp
CreatePaymentJobAsync(
    PaymentJob body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`PaymentJob`](../../doc/models/containers/payment-job.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.PaymentJobResult>`](../../doc/models/payment-job-result.md)

## Example Usage

```csharp
PaymentJob body = PaymentJob.FromGatewayPaymentJob(
    new GatewayPaymentJob
    {
        NotBefore = DateTime.ParseExact("2022-04-26T15:16:18Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        NotAfter = DateTime.ParseExact("2019-08-24T14:15:22Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Items = new List<GatewayPaymentJobQuote>
        {
            new GatewayPaymentJobQuote
            {
                Amount = 1.02,
                Currency = Currencies.Usd,
                SourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
                DestinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
                Note = "string",
                Memo = "string",
                Purpose = PaymentPurposes.Bonus,
                ClientPaymentId = "d4b6f130-1d1c-4ce2-903a-0c1ad128f55e",
            },
        },
    }
);

try
{
    PaymentJobResult result = await jobsController.CreatePaymentJobAsync(body);
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


# List Payment Jobs

Retrieve a list of [jobs](page:resources/jobs) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListPaymentJobsAsync(
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

[`Task<Models.PaymentJobListResult>`](../../doc/models/payment-job-list-result.md)

## Example Usage

```csharp
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    PaymentJobListResult result = await jobsController.ListPaymentJobsAsync(
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


# Retrieve Payment Job

Retrieve a single payment [job](page:resources/jobs).

```csharp
RetrievePaymentJobAsync(
    string jobToken,
    string filter = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `jobToken` | `string` | Template, Required | Auto-generated unique identifier representing a job, prefixed with `jobs-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^jobs-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.PaymentJobResult>`](../../doc/models/payment-job-result.md)

## Example Usage

```csharp
string jobToken = "jobs-2bbfc967-d12e-4647-a887-d905172fb4bc";
string filter = "string";
Languages? language = Languages.EnUs;
try
{
    PaymentJobResult result = await jobsController.RetrievePaymentJobAsync(
        jobToken,
        filter,
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

