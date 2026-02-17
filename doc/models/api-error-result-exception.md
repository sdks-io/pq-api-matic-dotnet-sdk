
# Api Error Result Exception

## Structure

`ApiErrorResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Severity` | `string` | Required | Error Severity |
| `Error` | `string` | Required | Error Code Name |
| `Code` | `double` | Required | Error Code Number |
| `Message` | `string` | Required | Description of the error. |
| `ReferenceId` | `string` | Required | Reference ID for issue tracking. |
| `Timestamp` | `string` | Required | Timestamp of when the error occurred. |
| `RequestRef` | `string` | Optional | Request reference for issue tracking. |

## Example (as JSON)

```json
{
  "severity": "string",
  "error": "string",
  "code": 50.0,
  "message": "string",
  "referenceId": "string",
  "timestamp": "string",
  "requestRef": "20260207T231757Z-r1d65bb46d495mgjhC1BL1qvx400000004rg00000000c2uh"
}
```

