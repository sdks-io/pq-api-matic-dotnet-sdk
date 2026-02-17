
# Prepaid Card Pin Object

## Structure

`PrepaidCardPinObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardPin` | `string` | Optional | [Card PIN](#/rest/models/structures/prepaid-card-pin) for ATM and Debit usage |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/prepaid-card-pin-token) used as part of a two-leg card PIN reveal request sent directly from the client that generally involves a second piece of data, such as the CVV code on the back of the card. |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |

## Example (as JSON)

```json
{
  "cardPin": "string",
  "token": "string",
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

