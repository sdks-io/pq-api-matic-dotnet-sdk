
# Translation

[Localized](#/rest/models/structures/key-value-pair-language-type-string) requirement description for display purposes

## Structure

`Translation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Language` | [`Languages?`](../../doc/models/languages.md) | Optional | The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format |
| `Translation` | `string` | Optional | Translated string in the specified language |

## Example (as JSON)

```json
{
  "language": "en-US",
  "translation": "string"
}
```

