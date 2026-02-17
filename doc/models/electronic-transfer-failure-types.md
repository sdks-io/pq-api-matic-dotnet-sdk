
# Electronic Transfer Failure Types

The type of failure for a bank transfer

## Enumeration

`ElectronicTransferFailureTypes`

## Fields

| Name | Description |
|  --- | --- |
| `IncorrectAccountNumber` | The account number is invalid or incorrect. |
| `InvalidSortCode` | The sort code or account number are invalid. |
| `AccountNotFound` | No account was found with the details provided. |
| `DestinationAccountNumberInvalid` | The destination account number is invalid. |
| `BeneficiaryAccountNumberInvalid` | The destination account number is invalid. |
| `AccountClosed` | The bank account is closed. |
| `GeneralCompliance` | GENERAL_COMPLIANCE |
| `IncorrectRoutingCode` | INCORRECT_ROUTING_CODE |
| `BelowMinAboveMaxAllowedAmount` | BELOW_MIN_ABOVE_MAX_ALLOWED_AMOUNT |
| `InvalidInsufficientPaymentDetails` | INVALID_INSUFFICIENT_PAYMENT_DETAILS |
| `InvalidBeneficiaryName` | INVALID_BENEFICIARY_NAME |
| `InvalidBeneficiaryTaxId` | INVALID_BENEFICIARY_TAX_ID |
| `InvalidBeneficiaryBankBranchAddress` | INVALID_BENEFICIARY_BANK_BRANCH_ADDRESS |
| `InvalidBeneficiaryAddress` | INVALID_BENEFICIARY_ADDRESS |
| `BankUnableToApply` | BANK_UNABLE_TO_APPLY |
| `BankCodeWrong` | BANK_CODE_WRONG |
| `Other` | The transfer failed and the reason will be in the EFTFAILURECOMMENT field |

## Example

```
INCORRECT_ACCOUNT_NUMBER
```

