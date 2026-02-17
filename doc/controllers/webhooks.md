# Webhooks

# Webhooks

---


The *Webhooks* resource allows you to list, create, receive, and delete webhook subscriptions. It refers to a combination of elements that collectively create a notification and reaction for a change in data. Webhooks are subscriptions to events and send a notification when an event occurs.  When you use our API, you may want to receive webhooks (inbound HTTP(s)) requests from the server.

With this resource, you can perform the following requests:

* `POST`: Create a webhook subscription
* `GET`: Retrieve a webhook subscription
* `PATCH`: Update a webhook subscription
* `DELETE`: Cancel a webhook subscription

For more information, see [Webhooks](page:resources/webhooks).

```csharp
IWebhooksController webhooksController = client.WebhooksController;
```

## Class Name

`WebhooksController`

## Methods

* [Create Subscription](../../doc/controllers/webhooks.md#create-subscription)
* [Delete Subscription](../../doc/controllers/webhooks.md#delete-subscription)
* [List Subscriptions](../../doc/controllers/webhooks.md#list-subscriptions)
* [Retrieve Subscription](../../doc/controllers/webhooks.md#retrieve-subscription)
* [Update Subscription](../../doc/controllers/webhooks.md#update-subscription)


# Create Subscription

Create a [webhook subscription](page:resources/webhooks).

```csharp
CreateSubscriptionAsync(
    Models.CreateWebhookRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateWebhookRequest`](../../doc/models/create-webhook-request.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.WebhookSubscriptionResult>`](../../doc/models/webhook-subscription-result.md)

## Example Usage

```csharp
CreateWebhookRequest body = new CreateWebhookRequest
{
    MNamespace = WebhookNamespaces.PaymentquotesAccepted,
    Url = "https://fawebhookreceiver.azurewebsites.net/api/receive",
};

try
{
    WebhookSubscriptionResult result = await webhooksController.CreateSubscriptionAsync(body);
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
  "token": "webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
  "created": "2020-07-24T14:53:08Z",
  "lastUpdated": "2022-04-13T05:53:48Z",
  "url": "https://fawebhookreceiver.azurewebsites.net/api/receive",
  "namespace": "PAYMENTQUOTES.ACCEPTED",
  "status": "SUBSCRIBED",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
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


# Delete Subscription

Delete a [webhook subscription](page:resources/webhooks).

```csharp
DeleteSubscriptionAsync(
    string webhookToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `webhookToken` | `string` | Template, Required | Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`.<br><br>**Constraints**: *Pattern*: `^webh-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.WebhookSubscriptionResult>`](../../doc/models/webhook-subscription-result.md)

## Example Usage

```csharp
string webhookToken = "webh-6260c132-5cb1-4e30-8b08-9ce559893acb";
try
{
    WebhookSubscriptionResult result = await webhooksController.DeleteSubscriptionAsync(webhookToken);
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
  "token": "webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
  "created": "2020-07-24T14:53:08Z",
  "lastUpdated": "2022-04-13T05:53:48Z",
  "url": "https://fawebhookreceiver.azurewebsites.net/api/receive",
  "namespace": "PAYMENTQUOTES.ACCEPTED",
  "status": "SUBSCRIBED",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
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


# List Subscriptions

Retrieve a list of all [webhook subscriptions](page:resources/webhooks) that supports filtering, sorting, and pagination through existing mechanisms

```csharp
ListSubscriptionsAsync(
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

[`Task<Models.WebhookSubscriptionListResult>`](../../doc/models/webhook-subscription-list-result.md)

## Example Usage

```csharp
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    WebhookSubscriptionListResult result = await webhooksController.ListSubscriptionsAsync(
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
      "token": "webh-4cdcb012-8b3f-453f-af4f-c29e6091db92",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2021-08-09T18:31:55Z",
      "url": "https://api.sandbox.payquicker.io/integrations/internal/twohundred",
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.CLOSEDSTOLEN",
      "status": "SUBSCRIBED",
      "links": [
        {
          "href": "https://platform.mypayquicker.dev/api/v2/webhooks/webh-4cdcb012-8b3f-453f-af4f-c29e6091db92",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2021-08-09T18:31:55Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive",
      "namespace": "PAPERCHECKS.UPDATED.STATUS.REDEEMED",
      "status": "SUBSCRIBED",
      "links": [
        {
          "href": "https://platform.mypayquicker.dev/api/v2/webhooks/webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "namespace": "USERS.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USERS.UPDATED.STATUS.REGISTRATIONINPROGRESS",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USERS.UPDATED.STATUS.REGISTRATIONCOMPLETE",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USERS.UPDATED.KYC.REQUIRED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USERS.UPDATED.KYC.PROVIDED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USERS.UPDATED.KYC.REJECTED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USERS.UPDATED.KYC.APPROVED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.ACTIVE",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.CLOSED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.CLOSEDLOST",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.PENDINGACTIVATION",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.PENDINGORDER",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.SUSPENDED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "BANKACCOUNTS.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "BANKACCOUNTS.UPDATED.STATUS.APPROVED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "BANKACCOUNTS.UPDATED.STATUS.DELETED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "BANKACCOUNTS.UPDATED.STATUS.COMPLIANCEHOLD",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "BANKACCOUNTS.UPDATED.DETAILS.MODIFIED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAPERCHECKS.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAPERCHECKS.UPDATED.STATUS.INPROGRESS",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAPERCHECKS.UPDATED.STATUS.CANCELLED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAPERCHECKS.UPDATED.DETAILS.MODIFIED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "TRANSFERQUOTES.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "TRANSFERQUOTES.ACCEPTED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "TRANSFERQUOTES.VOIDED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "TRANSFERQUOTES.CANCELLED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAYMENTQUOTES.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAYMENTQUOTES.ACCEPTED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAYMENTQUOTES.VOIDED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PAYMENTQUOTES.CANCELLED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "SPENDBACKQUOTES.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "SPENDBACKQUOTES.ACCEPTED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "SPENDBACKQUOTES.VOIDED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "SPENDBACKQUOTES.CANCELLED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.CREATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.COMPLETED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.CANCELLED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.REFUNDED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.FAILED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.PENDING",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.SCHEDULED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.PROCESSING",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.REVERSED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.DETAILS.MODIFIED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USEREVENTS.STARTED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USEREVENTS.UPDATED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "USEREVENTS.COMPLETED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "RECEIPTS.UPDATED.STATUS.RETURNED",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
    },
    {
      "namespace": "PREPAIDCARDS.UPDATED.STATUS.PENDINGRELEASE",
      "status": "AVAILABLE",
      "token": "webh-4de2d5d8-f04a-4fe1-bff0-8d343295f24e",
      "created": "2020-07-24T14:53:08Z",
      "lastUpdated": "2020-07-24T14:53:08Z",
      "url": "https://fawebhookreceiver.azurewebsites.net/api/receive"
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
      "href": "https://platform.mypayquicker.dev/api/v2/webhooks",
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


# Retrieve Subscription

Retrieve a single [webhook subscription](page:resources/webhooks) using the webhook token.

```csharp
RetrieveSubscriptionAsync(
    string webhookToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `webhookToken` | `string` | Template, Required | Auto-generated unique identifier representing a webhook subscription, prefixed with `webh-`.<br><br>**Constraints**: *Pattern*: `^webh-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.WebhookSubscriptionResult>`](../../doc/models/webhook-subscription-result.md)

## Example Usage

```csharp
string webhookToken = "webh-6260c132-5cb1-4e30-8b08-9ce559893acb";
try
{
    WebhookSubscriptionResult result = await webhooksController.RetrieveSubscriptionAsync(webhookToken);
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
  "token": "webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
  "created": "2020-07-24T14:53:08Z",
  "lastUpdated": "2022-04-13T05:53:48Z",
  "url": "https://fawebhookreceiver.azurewebsites.net/api/receive",
  "namespace": "PAYMENTQUOTES.ACCEPTED",
  "status": "SUBSCRIBED",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
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


# Update Subscription

Update a [webhook subscription](page:resources/webhooks).

```csharp
UpdateSubscriptionAsync(
    Models.CreateWebhookRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateWebhookRequest`](../../doc/models/create-webhook-request.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.WebhookSubscriptionResult>`](../../doc/models/webhook-subscription-result.md)

## Example Usage

```csharp
CreateWebhookRequest body = new CreateWebhookRequest
{
    MNamespace = WebhookNamespaces.PaymentquotesAccepted,
    Url = "https://fawebhookreceiver.azurewebsites.net/api/receive",
};

try
{
    WebhookSubscriptionResult result = await webhooksController.UpdateSubscriptionAsync(body);
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
  "token": "webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
  "created": "2020-07-24T14:53:08Z",
  "lastUpdated": "2022-04-13T05:53:48Z",
  "url": "https://fawebhookreceiver.azurewebsites.net/api/receive",
  "namespace": "PAYMENTQUOTES.ACCEPTED",
  "status": "SUBSCRIBED",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/webhooks/webh-c33c81ab-9fd7-4835-8cf9-1b23473e1163",
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

