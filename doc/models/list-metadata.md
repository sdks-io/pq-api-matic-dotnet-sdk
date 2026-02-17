
# List Metadata

## Structure

`ListMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PageNo` | `string` | Required | **Default**: `"1"` |
| `PageSize` | `string` | Required | **Default**: `"10"` |
| `PageCount` | `string` | Required | **Default**: `"1"` |
| `RecordCount` | `string` | Required | - |
| `Timezone` | `string` | Required | Timezone of the datetime objects in the response |
| `RequestRef` | `string` | Required | - |

## Example (as JSON)

```json
{
  "pageNo": "string",
  "pageSize": "string",
  "pageCount": "string",
  "recordCount": "string",
  "timezone": "GMT",
  "requestRef": "20260207T231757Z-r1d65bb46d495mgjhC1BL1qvx400000004rg00000000c2uh"
}
```

