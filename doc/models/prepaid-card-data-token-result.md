
# Prepaid Card Data Token Result

## Structure

`PrepaidCardDataTokenResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardProcessorType` | [`CardProcessors`](../../doc/models/card-processors.md) | Required | The processor type for the prepaid card |
| `ResourceValue` | `string` | Optional | Value of the target resource |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `TokenPurposeType` | [`TokenPurposes`](../../doc/models/token-purposes.md) | Required | Purpose of the token |
| `Url` | `string` | Optional | Full path of the URI to perform the request action against a prepaid card that replaces the need to build the URL with query params. |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |
| `Meta` | [`MetadataItems`](../../doc/models/metadata-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "cardProcessorType": "QOLO",
  "resourceValue": "string",
  "token": "string",
  "tokenPurposeType": "CARD_OPERATION",
  "url": "string",
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

