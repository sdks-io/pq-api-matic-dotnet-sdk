// <copyright file="BankAccountFields.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// BankAccountFields.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountFields
    {
        /// <summary>
        ///The nine-digit code based on the U.S. Bank location where the account was opened.
        /// BankAchAba.
        /// </summary>
        [EnumMember(Value = "BANK_ACH_ABA")]
        BankAchAba,

        /// <summary>
        ///The code that identifies an individual account, at a specific financial institution, in a particular country, often referred to as the acount number.
        /// BankBban.
        /// </summary>
        [EnumMember(Value = "BANK_BBAN")]
        BankBban,

        /// <summary>
        ///A code of a bank helps customers and bankers identify a particular bank branch.
        /// BankBranchCode.
        /// </summary>
        [EnumMember(Value = "BANK_BRANCH_CODE")]
        BankBranchCode,

        /// <summary>
        ///Name of branch for the actual financial institution. For example,`Bank of America`.
        /// BankBranchName.
        /// </summary>
        [EnumMember(Value = "BANK_BRANCH_NAME")]
        BankBranchName,

        /// <summary>
        ///The 6-digit number used to identify the individual branch of a financial institution used in addition to the bank account number to identify the recipient of a transfer. For example,`082902`. where: `08` is the two-digit code for NAB bank. `2` is the branch is located in Australian Capital Territory. `902` is the NAB branch in Canberra City.
        /// BankBsbCode.
        /// </summary>
        [EnumMember(Value = "BANK_BSB_CODE")]
        BankBsbCode,

        /// <summary>
        ///The city in which the bank or financial institution associated with an account is located.
        /// BankCity.
        /// </summary>
        [EnumMember(Value = "BANK_CITY")]
        BankCity,

        /// <summary>
        ///CLABE (Clace Bancaria Estandarizada) The 18-digit account code containing the payee's bank account number. For example, `014027000000000008`.
        /// BankClabe.
        /// </summary>
        [EnumMember(Value = "BANK_CLABE")]
        BankClabe,

        /// <summary>
        ///Bank code of bank assigned to a bank.
        /// BankCode.
        /// </summary>
        [EnumMember(Value = "BANK_CODE")]
        BankCode,

        /// <summary>
        ///The ID number provided by the Mexican government to Mexican citizens and residents
        /// BankCurp.
        /// </summary>
        [EnumMember(Value = "BANK_CURP")]
        BankCurp,

        /// <summary>
        ///The standard international numbering system that identifies an overseas bank account. The number starts with a two-digit country code, then two numbers, followed by several more alphanumeric characters. For example,`Norway: NO 93 8601 1117947`.
        /// BankIban.
        /// </summary>
        [EnumMember(Value = "BANK_IBAN")]
        BankIban,

        /// <summary>
        ///Name of actual financial institution. For example,`Bank of America`.
        /// BankName.
        /// </summary>
        [EnumMember(Value = "BANK_NAME")]
        BankName,

        /// <summary>
        ///The 8- or 11-digit Business Identifier Code (BIC) for a bank that does not allow for sending and receiving financial transaction information. For example,`AAAABBCCDDD`.
        /// BankNonSwiftBic.
        /// </summary>
        [EnumMember(Value = "BANK_NON_SWIFT_BIC")]
        BankNonSwiftBic,

        /// <summary>
        ///Nigerian Uniform Bank Account Number (NUBAN) The 10-digit standard international numbering system that identifies a Nigerian bank account. For example, `0000013679`. where: `000001367` is the serial number (the first 9 digits) and is used to indicate which bank the NUBAN is associated with, as well as to point to a specific bank account at that bank. `9` (the last digit) is the [check digit](https://en.wikipedia.org/wiki/Check_digit) that determines whether the code in question is valid.
        /// BankNuban.
        /// </summary>
        [EnumMember(Value = "BANK_NUBAN")]
        BankNuban,

        /// <summary>
        ///The phone number for the actual financial institution.
        /// BankPhoneNumber.
        /// </summary>
        [EnumMember(Value = "BANK_PHONE_NUMBER")]
        BankPhoneNumber,

        /// <summary>
        ///The 5-digit postal code of the account owner's permanent residence. For example, `50314`.
        /// BankPostalCode.
        /// </summary>
        [EnumMember(Value = "BANK_POSTAL_CODE")]
        BankPostalCode,

        /// <summary>
        ///The code that represents the purpose for initiating a payment to a foreign country. For example,`/BANK/FUND TR`which is a cross-border fund transfer between banks.
        /// BankPurposeOfPaymentCode.
        /// </summary>
        [EnumMember(Value = "BANK_PURPOSE_OF_PAYMENT_CODE")]
        BankPurposeOfPaymentCode,

        /// <summary>
        ///The two-letter region [ISO abbreviation code](https://en.wikipedia.org/wiki/ISO_3166-1) of the bank's physical address.
        /// BankRegion.
        /// </summary>
        [EnumMember(Value = "BANK_REGION")]
        BankRegion,

        /// <summary>
        ///Resident Foreign Currency (RFC)The account maintained in foreign currencies for NRIs who have returned to India and hold funds in foreign currency. For example, `USD` and `GBP`.
        /// BankRfc.
        /// </summary>
        [EnumMember(Value = "BANK_RFC")]
        BankRfc,

        /// <summary>
        ///Identifies both the bank and the branch where the account is held. Sort codes used to route money transfers between financial institutions in the United Kingdom and in the Republic of Ireland. For example, `12-34-56`.
        /// BankSortCode.
        /// </summary>
        [EnumMember(Value = "BANK_SORT_CODE")]
        BankSortCode,

        /// <summary>
        ///TO BE DONE
        /// BankSsn.
        /// </summary>
        [EnumMember(Value = "BANK_SSN")]
        BankSsn,

        /// <summary>
        ///The bank address's most specific details, like `street number`, `street name`, and `building name`.
        /// BankStreetAddress.
        /// </summary>
        [EnumMember(Value = "BANK_STREET_ADDRESS")]
        BankStreetAddress,

        /// <summary>
        ///The 8- or 11-digit Business Identifier Code (BIC) for a bank that allows for sending and receiving financial transaction information. For example, `AAAABBCCDDD` where: `AAAA` is the 4-character bank code. `BB` is the 2-character country code. `CC` is the 2-character location code. `DD` is the 3-character branch code.
        /// BankSwiftBic.
        /// </summary>
        [EnumMember(Value = "BANK_SWIFT_BIC")]
        BankSwiftBic,

        /// <summary>
        ///The 9-digit code that identifies a specific financial institution. For example, `XXXXYYYYC` where: `XXXX` is the 4-digit Federal Reserve Routing Symbol. `YYYY` is the 4-digit ABA Institution Identifier. `C` is the 1-digit check digit.
        /// BankTransitCode.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSIT_CODE")]
        BankTransitCode,

        /// <summary>
        ///The 9-digit value-added tax number for the bank that is designed to tax only the value added by a business on top of the services and goods it can purchase.
        /// BankValueAddTax.
        /// </summary>
        [EnumMember(Value = "BANK_VALUE_ADD_TAX")]
        BankValueAddTax,

        /// <summary>
        ///The unique identifier for the beneficial owner. For example,`caa81a5f-ec1e-4559-8b32-d90655bfd03c`.
        /// BeneficiaryAccountNumber.
        /// </summary>
        [EnumMember(Value = "BENEFICIARY_ACCOUNT_NUMBER")]
        BeneficiaryAccountNumber,

        /// <summary>
        ///The beneficial owner's residential address.
        /// BeneficiaryAddress.
        /// </summary>
        [EnumMember(Value = "BENEFICIARY_ADDRESS")]
        BeneficiaryAddress,

        /// <summary>
        ///The legal full name for the beneficial owner.
        /// BeneficiaryName.
        /// </summary>
        [EnumMember(Value = "BENEFICIARY_NAME")]
        BeneficiaryName,

        /// <summary>
        ///The phone number for the beneficial owner.
        /// BeneficiaryPhoneNumber.
        /// </summary>
        [EnumMember(Value = "BENEFICIARY_PHONE_NUMBER")]
        BeneficiaryPhoneNumber,

        /// <summary>
        ///The tax ID for the beneficial owner.
        /// BeneficiaryTaxId.
        /// </summary>
        [EnumMember(Value = "BENEFICIARY_TAX_ID")]
        BeneficiaryTaxId,

        /// <summary>
        ///Undefined or unrecognized bank account field.
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}