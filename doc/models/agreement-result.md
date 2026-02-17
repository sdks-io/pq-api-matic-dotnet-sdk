
# Agreement Result

## Structure

`AgreementResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `ContentBase64` | `string` | Optional | Program agreement content |
| `Url` | `string` | Optional | Full path of the URI to the content for the program agreement |
| `Type` | [`AgreementTypes?`](../../doc/models/agreement-types.md) | Optional | - |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |
| `Meta` | [`MetadataItems`](../../doc/models/metadata-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "token": "string",
  "contentBase64": "string",
  "url": "string",
  "type": "CARD_HOLDER_AGREEMENT",
  "links": [
    {
      "href": "string",
      "params": {
        "rel": "self"
      }
    }
  ],
  "meta": {
    "timezone": "GMT",
    "requestRef": "20260207T231757Z-r1d65bb46d495mgjhC1BL1qvx400000004rg00000000c2uh"
  }
}
```

