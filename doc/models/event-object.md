
# Event Object

## Structure

`EventObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `CanBeCancelled` | `bool?` | Optional | - |
| `EventRequirementCategoryType` | [`EventRequirementCategories?`](../../doc/models/event-requirement-categories.md) | Optional | - |
| `EventRequirementType` | [`EventRequirements?`](../../doc/models/event-requirements.md) | Optional | - |
| `EventStatus` | [`EventStatuses?`](../../doc/models/event-statuses.md) | Optional | Indicates the current verification status type of an event. |
| `EventType` | [`EventTypes?`](../../doc/models/event-types.md) | Optional | - |
| `IsComplete` | `bool?` | Optional | - |
| `UserAction` | [`UserAction?`](../../doc/models/user-action.md) | Optional | - |
| `UserImpact` | [`UserImpact?`](../../doc/models/user-impact.md) | Optional | - |
| `Event` | [`EventCategoryTypes`](../../doc/models/event-category-types.md) | Required | The type of Registration tied to a particular event |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |

## Example (as JSON)

```json
{
  "token": "string",
  "canBeCancelled": true,
  "eventRequirementCategoryType": "ACKNOWLEDGEMENT",
  "eventRequirementType": "ACH_UPGRADE_PII_DETAILS_VALIDATED",
  "eventStatus": "UNDEFINED",
  "eventType": "REQUIRED",
  "isComplete": true,
  "userAction": "NO_ACTION",
  "userImpact": "NO_IMPACT",
  "event": "WALLET_REGISTRATION",
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

