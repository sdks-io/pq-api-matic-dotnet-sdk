
# Prepaid Card Statuses

Current [status](#/rest/models/structures/prepaid-card-status) of the prepaid card

## Enumeration

`PrepaidCardStatuses`

## Fields

| Name | Description |
|  --- | --- |
| `Activated` | The prepaid card is active and ready to use. |
| `Closed` | The prepaid card is damaged and is no longer usable. |
| `ClosedLostStolenDamaged` | The prepaid card is expired and is no longer usable. |
| `ComplianceHold` | The prepaid card has been suspended for compliance reasons. |
| `Expired` | The expiration date set for the prepaid card has elapsed. The prepaid card will no longer be accepted. |
| `PendingActivation` | The prepaid card has been created but has not yet been activated. Instantly issued cards are activated automatically.Plastic cards are activated upon delivery and require the CVV on the back of the prepaid card to complete. |
| `Queued` | The prepaid card is awaiting order placement and will transition to PENDING_ACTIVATION once ordered. |
| `Staged` | TO BE DONE |
| `Suspended` | The prepaid card has been suspended and may neither send nor receive funds. |

## Example

```
ACTIVATED
```

