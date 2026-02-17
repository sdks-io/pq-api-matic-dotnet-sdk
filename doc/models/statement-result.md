
# Statement Result

## Structure

`StatementResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FileContents` | `string` | Optional | The string representation of the file content. |
| `Filename` | `string` | Optional | The name given to a computer file in order to distinguish it from other files |
| `MimeType` | `string` | Optional | A label used to identify a type of data.  Acts like a file extension on the internet. |
| `Token` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `UserToken` | `string` | Optional | Auto-generated unique identifier representing a user, prefixed with `user-`.<br><br>**Constraints**: *Minimum Length*: `41`, *Maximum Length*: `41`, *Pattern*: `^user-[0-9A-Fa-f]{8}(?:-[0-9A-Fa-f]{4}){3}-[0-9A-Fa-f]{12}$` |
| `PrepaidCardToken` | `string` | Optional | Auto-generated unique identifier representing a dest, prefixed with dest-. |
| `From` | `DateTime?` | Optional | Beginning date and time of a prepaid card statement |
| `To` | `DateTime?` | Optional | Ending date and time of a prepaid card statement |
| `Links` | [`List<HateoasSelfRef>`](../../doc/models/hateoas-self-ref.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, *Unique Items Required* |
| `Meta` | [`MetadataItems`](../../doc/models/metadata-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "fileContents": "string",
  "filename": "exampleFile.jpg",
  "mimeType": "image/jpeg",
  "token": "string",
  "userToken": "user-2bbfc967-d12e-4647-a887-d905172fb4bc",
  "prepaidCardToken": "string",
  "from": "2026-02-07T22:23:11.2214335Z",
  "to": "2026-02-07T22:23:11.2356996Z",
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

