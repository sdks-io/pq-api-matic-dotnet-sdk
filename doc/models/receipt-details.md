
# Receipt Details

## Structure

`ReceiptDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccountId` | `string` | Optional | Bank account ID for the bank account |
| `BankAccountIdType` | [`BankAccountFields?`](../../doc/models/bank-account-fields.md) | Optional | Classifies bank account [field types](#/rest/models/structures/bank-account-fields) |
| `BankName` | `string` | Optional | Name of the bank the account is registered to |
| `BankId` | `string` | Optional | The bank id |
| `BankIdType` | [`BankAccountFields?`](../../doc/models/bank-account-fields.md) | Optional | Classifies bank account [field types](#/rest/models/structures/bank-account-fields) |
| `BranchAddress` | `string` | Optional | The bank branch address |
| `BranchCity` | `string` | Optional | The bank branch city |
| `BranchId` | `string` | Optional | The bank branch id |
| `BranchName` | `string` | Optional | The bank branch name |
| `BranchPostalCode` | `string` | Optional | The bank branch postal code |
| `BranchPhoneNumber` | `string` | Optional | The bank branch phone number |
| `BranchRegion` | `string` | Optional | The bank branch region |
| `BeneficaryTaxId` | `string` | Optional | The beneficiary's tax id |
| `BeneficaryTaxIdType` | [`BankAccountFields?`](../../doc/models/bank-account-fields.md) | Optional | Classifies bank account [field types](#/rest/models/structures/bank-account-fields) |
| `BeneficaryName` | `string` | Optional | The name of the person chosen to inherit your account |
| `Memo` | `string` | Optional | Optional internal [memo](#/rest/models/structures/memo) not visible to the user |
| `Note` | `string` | Optional | [Optional comments](#/rest/models/structures/notes) visible to the user |
| `CorrelationToken` | `string` | Optional | [Token](#/rest/models/structures/token) representing the resource |
| `CardExpiryDate` | `string` | Optional | Date that the card will expire |
| `CardHolderName` | `string` | Optional | Name of the card's owner |
| `CardNumber` | `string` | Optional | Unique number on the prepaid card |
| `ElectronicWalletAccountNumber` | `string` | Optional | Account number for the electronic wallet |
| `ElectronicWalletAccountNumberType` | [`ElectronicWalletFields?`](../../doc/models/electronic-wallet-fields.md) | Optional | Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields) |
| `ElectronicWalletGovernmentId` | `string` | Optional | Government ID for the electronic wallet |
| `ElectronicWalletGovernmentIdType` | [`ElectronicWalletFields?`](../../doc/models/electronic-wallet-fields.md) | Optional | Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields) |
| `ElectronicWalletType` | [`ElectronicWalletTypes?`](../../doc/models/electronic-wallet-types.md) | Optional | Name of the electronic wallet |
| `MobilePhoneNumber` | `string` | Optional | - |
| `ElectronicFundsTransferType` | [`ElectronicFundsTransferTypes?`](../../doc/models/electronic-funds-transfer-types.md) | Optional | The type of transfer performed |
| `ElectronicFundsTransferFailureType` | [`ElectronicTransferFailureTypes?`](../../doc/models/electronic-transfer-failure-types.md) | Optional | The type of failure for a bank transfer |
| `ElectronicTransferStatusType` | [`ElectronicTransferStatusTypes?`](../../doc/models/electronic-transfer-status-types.md) | Optional | The status of a bank transfer |

## Example (as JSON)

```json
{
  "bankAccountId": "string",
  "bankAccountIdType": "BANK_ACH_ABA",
  "bankName": "string",
  "bankId": "string",
  "bankIdType": "BANK_ACH_ABA",
  "branchAddress": "string",
  "branchCity": "string",
  "branchId": "string",
  "branchName": "string",
  "branchPostalCode": "string",
  "branchPhoneNumber": "string",
  "branchRegion": "string",
  "beneficaryTaxId": "string",
  "beneficaryTaxIdType": "BANK_ACH_ABA",
  "beneficaryName": "string",
  "memo": "string",
  "note": "string",
  "correlationToken": "string",
  "cardExpiryDate": "string",
  "cardHolderName": "string",
  "cardNumber": "483318******4628",
  "electronicWalletAccountNumber": "string",
  "electronicWalletAccountNumberType": "UNDEFINED",
  "electronicWalletGovernmentId": "string",
  "electronicWalletGovernmentIdType": "UNDEFINED",
  "electronicWalletType": "AIRTEL_MONEY",
  "mobilePhoneNumber": "string",
  "electronicFundsTransferType": "MANUAL",
  "electronicFundsTransferFailureType": "INCORRECT_ACCOUNT_NUMBER",
  "electronicTransferStatusType": "IN_PROGRESS"
}
```

