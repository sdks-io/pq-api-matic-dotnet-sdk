
# Electronic Transfer Status Types

The status of a bank transfer

## Enumeration

`ElectronicTransferStatusTypes`

## Fields

| Name | Description |
|  --- | --- |
| `InProgress` | The bank transfer has been started to the destination bank. |
| `Processed` | The bank transfer has been performed and the funds have arrived in the destination bank. |
| `Failed` | The bank transfer has failed and the funds have been sent back to the source account. |
| `Refunded` | The bank transfer has failed. |

## Example

```
IN_PROGRESS
```

