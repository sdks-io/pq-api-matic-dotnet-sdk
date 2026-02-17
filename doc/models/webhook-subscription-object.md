
# Webhook Subscription Object

Webhook subscription object

## Structure

`WebhookSubscriptionObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `Created` | `DateTime?` | Optional | Time object was [created](#/rest/models/structures/created-on) |
| `LastUpdated` | `DateTime?` | Optional | Date and time that the object was last updated |
| `Url` | `string` | Optional | Full path of the URI used for this object |
| `Namespace` | [`WebhookNamespaces?`](../../doc/models/webhook-namespaces.md) | Optional | Namespace used to identify and refer to the object |
| `Status` | [`WebhookSubscriptionStatuses?`](../../doc/models/webhook-subscription-statuses.md) | Optional | - |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |

## Example (as JSON)

```json
{
  "token": "string",
  "created": "02/07/2026 22:23:09",
  "lastUpdated": "02/07/2026 22:23:10",
  "url": "string",
  "namespace": "BANKACCOUNTS.CREATED",
  "status": "AVAILABLE",
  "links": [
    {
      "href": "string",
      "params": {
        "rel": "self"
      }
    }
  ]
}
```

