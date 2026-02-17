
# User Document Requirement Item

## Structure

`UserDocumentRequirementItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CountryOfBirth` | `string` | Optional | - |
| `CountryOfNationality` | `string` | Optional | - |
| `Documents` | [`List<UserDocumentRequirementItemDocumentsItems>`](../../doc/models/user-document-requirement-item-documents-items.md) | Optional | - |

## Example (as JSON)

```json
{
  "countryOfBirth": "string",
  "countryOfNationality": "string",
  "documents": [
    {
      "exampleImage": "string",
      "supplementalDocuments": [
        {
          "exampleImage": "string",
          "status": "NOT_PROVIDED",
          "type": "UNDEFINED"
        }
      ],
      "metadata": [
        {
          "dataType": "string",
          "fieldType": "string",
          "name": [
            {
              "language": "string",
              "translation": "string"
            }
          ]
        }
      ],
      "status": "NOT_PROVIDED",
      "type": "UNDEFINED"
    }
  ]
}
```

