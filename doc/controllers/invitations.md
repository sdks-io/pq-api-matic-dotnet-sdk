# Invitations

# Invitations

---


The *Invitations* resource allows you to list, create, retrieve, and modify invitations.

```csharp
IInvitationsController invitationsController = client.InvitationsController;
```

## Class Name

`InvitationsController`

## Methods

* [Cancel Invitation](../../doc/controllers/invitations.md#cancel-invitation)
* [Create Invitation](../../doc/controllers/invitations.md#create-invitation)
* [List Invitations](../../doc/controllers/invitations.md#list-invitations)
* [Retrieve Invitation](../../doc/controllers/invitations.md#retrieve-invitation)
* [Update Invitation](../../doc/controllers/invitations.md#update-invitation)


# Cancel Invitation

Cancel an open [invitation](page:resources/invitations) quote.

```csharp
CancelInvitationAsync(
    string invitationToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invitationToken` | `string` | Template, Required | Auto-generated unique identifier representing an invite, prefixed with `invt-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^invt-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.InvitationResult>`](../../doc/models/invitation-result.md)

## Example Usage

```csharp
string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";
try
{
    InvitationResult result = await invitationsController.CancelInvitationAsync(invitationToken);
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


# Create Invitation

Create a [invitation](page:resources/invitations) quote.

```csharp
CreateInvitationAsync(
    Models.CreateInvitation body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateInvitation`](../../doc/models/create-invitation.md) | Body, Optional | - |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.InvitationResult>`](../../doc/models/invitation-result.md)

## Example Usage

```csharp
CreateInvitation body = new CreateInvitation
{
    Currency = Currencies.Usd,
};

try
{
    InvitationResult result = await invitationsController.CreateInvitationAsync(body);
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


# List Invitations

Retrieve a list of [invitations](page:resources/invitations) that supports filtering, sorting, and pagination through existing mechanisms.

```csharp
ListInvitationsAsync(
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

[`Task<Models.InvitationListResult>`](../../doc/models/invitation-list-result.md)

## Example Usage

```csharp
int page = 1;
int pageSize = 20;
string filter = "string";
string sort = "string";
Languages? language = Languages.EnUs;
try
{
    InvitationListResult result = await invitationsController.ListInvitationsAsync(
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


# Retrieve Invitation

Retrieve a single [invitation](page:resources/invitations).

```csharp
RetrieveInvitationAsync(
    string invitationToken,
    string filter = null,
    Models.Languages? language = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invitationToken` | `string` | Template, Required | Auto-generated unique identifier representing an invite, prefixed with `invt-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^invt-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `filter` | `string` | Query, Optional | Filter request results by specific criteria. |
| `language` | [`Languages?`](../../doc/models/languages.md) | Query, Optional | Filter results by language type. |

## Requires scope

### server

`readonly`

## Response Type

[`Task<Models.InvitationResult>`](../../doc/models/invitation-result.md)

## Example Usage

```csharp
string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";
string filter = "string";
Languages? language = Languages.EnUs;
try
{
    InvitationResult result = await invitationsController.RetrieveInvitationAsync(
        invitationToken,
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


# Update Invitation

Accept an open [invitation](page:resources/invitations) quote.

```csharp
UpdateInvitationAsync(
    string invitationToken)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invitationToken` | `string` | Template, Required | Auto-generated unique identifier representing an invite, prefixed with `invt-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^invt-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |

## Requires scope

### server

`modify`

## Response Type

[`Task<Models.InvitationResult>`](../../doc/models/invitation-result.md)

## Example Usage

```csharp
string invitationToken = "invt-2bbfc967-d12e-4647-a887-d905172fb4bc";
try
{
    InvitationResult result = await invitationsController.UpdateInvitationAsync(invitationToken);
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

