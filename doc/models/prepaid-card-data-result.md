
# Prepaid Card Data Result

## Structure

`PrepaidCardDataResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardNumber` | `double?` | Optional | Unique number on the prepaid card |
| `CvvNumber` | `string` | Optional | Three- or four-digit [Card Verification Value (CVV)](#/rest/models/structures/cvv) number displayed on the back of a credit or debit card |
| `Expiration` | `string` | Optional | Date that the card will expire |
| `NameOnCard` | `string` | Optional | Name of the card's owner |
| `Token` | `string` | Optional | A token used to reveal prepaid card information in the form of image data (base64) or JSON. |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |
| `Meta` | [`MetadataItems`](../../doc/models/metadata-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "cardNumber": 50.0,
  "cvvNumber": "string",
  "expiration": "string",
  "nameOnCard": "string",
  "token": "iEureKuLW1gZQ7d3/2ijX4+6bDZuUwpp2QmhPfedarncS2Cde1Ebmby+dxfeP7+Iaty9YYCLFwY42HHOm03dliH7Jp0Yo/sjOb/FmSQ3IOVYpNSYBcZYGmgpyBEG9gPa2HRIKK8+NcPVjjb+0gfqFAI52Emk0P+VPaBZ2NgsENV/I4MuIkWsUXha3QZh49a0EK3wO14jwR4BosY/rk0/9F5uJEWUjv8gvPej+dCFyMnybjj6jPK9f/gFlPUYVHuS",
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

