# Events

Event-related operations

```csharp
IEventsController eventsController = client.EventsController;
```

## Class Name

`EventsController`

## Methods

* [List Events](../../doc/controllers/events.md#list-events)
* [Retrieve Event](../../doc/controllers/events.md#retrieve-event)


# List Events

Retrieve a list of [user events](page:resources/user#list-user-events) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListEventsAsync(
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

[`Task<Models.EventListResult>`](../../doc/models/event-list-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
try
{
    EventListResult result = await eventsController.ListEventsAsync(userToken);
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
      "token": "evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292",
      "canBeCancelled": false,
      "eventRequirementCategoryType": "CATEGORY_UNDEFINED",
      "eventRequirementType": "TYPE_UNDEFINED",
      "eventStatus": "UNDEFINED",
      "eventType": "REQUIRED",
      "isComplete": false,
      "userAction": "NO_ACTION",
      "userImpact": "NO_IMPACT",
      "event": "WALLET_REGISTRATION",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292",
          "params": {
            "rel": "self"
          }
        }
      ]
    },
    {
      "token": "evnt-fe7c9063-0c86-400e-89e3-068c2f7e4f65",
      "canBeCancelled": false,
      "eventRequirementCategoryType": "CATEGORY_UNDEFINED",
      "eventRequirementType": "TYPE_UNDEFINED",
      "eventStatus": "UNDEFINED",
      "eventType": "REQUIRED",
      "isComplete": false,
      "userAction": "NO_ACTION",
      "userImpact": "NO_IMPACT",
      "event": "WALLET_REGISTRATION",
      "links": [
        {
          "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-fe7c9063-0c86-400e-89e3-068c2f7e4f65",
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
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events",
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


# Retrieve Event

Retrieve a single [user event](page:resources/user#get-user-event).

```csharp
RetrieveEventAsync(
    string userToken,
    string eventToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userToken` | `string` | Template, Required | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `eventToken` | `string` | Template, Required | Auto-generated unique identifier representing an event, prefixed with `evnt-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^evnt-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.UserEventResult>`](../../doc/models/user-event-result.md)

## Example Usage

```csharp
string userToken = "user-2bbfc967-d12e-4647-a887-d905172fb4bc";
string eventToken = "evnt-28491de2-5b22-4e30-028a-45901a10baa9";
try
{
    UserEventResult result = await eventsController.RetrieveEventAsync(
        userToken,
        eventToken
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
  "token": "evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292",
  "canBeCancelled": false,
  "eventRequirementCategoryType": "CATEGORY_UNDEFINED",
  "eventRequirementType": "TYPE_UNDEFINED",
  "eventStatus": "UNDEFINED",
  "eventType": "REQUIRED",
  "isComplete": false,
  "userAction": "NO_ACTION",
  "userImpact": "NO_IMPACT",
  "event": "WALLET_REGISTRATION",
  "links": [
    {
      "href": "https://api.sandbox.payquicker.io/api/v2/users/user-ae92315b-6190-4e56-bdf5-c0189ac420a1/events/evnt-4e2f6663-3e37-4bb8-b8f8-4ab1b02bd292",
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

