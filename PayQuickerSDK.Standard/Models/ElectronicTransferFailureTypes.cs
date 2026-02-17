// <copyright file="ElectronicTransferFailureTypes.cs" company="APIMatic">
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
    /// ElectronicTransferFailureTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicTransferFailureTypes
    {
        /// <summary>
        ///The account number is invalid or incorrect.
        /// IncorrectAccountNumber.
        /// </summary>
        [EnumMember(Value = "INCORRECT_ACCOUNT_NUMBER")]
        IncorrectAccountNumber,

        /// <summary>
        ///The sort code or account number are invalid.
        /// InvalidSortCode.
        /// </summary>
        [EnumMember(Value = "INVALID_SORT_CODE")]
        InvalidSortCode,

        /// <summary>
        ///No account was found with the details provided.
        /// AccountNotFound.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_NOT_FOUND")]
        AccountNotFound,

        /// <summary>
        ///The destination account number is invalid.
        /// DestinationAccountNumberInvalid.
        /// </summary>
        [EnumMember(Value = "DESTINATION_ACCOUNT_NUMBER_INVALID")]
        DestinationAccountNumberInvalid,

        /// <summary>
        ///The destination account number is invalid.
        /// BeneficiaryAccountNumberInvalid.
        /// </summary>
        [EnumMember(Value = "BENEFICIARY_ACCOUNT_NUMBER_INVALID")]
        BeneficiaryAccountNumberInvalid,

        /// <summary>
        ///The bank account is closed.
        /// AccountClosed.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_CLOSED")]
        AccountClosed,

        /// <summary>
        ///GENERAL_COMPLIANCE
        /// GeneralCompliance.
        /// </summary>
        [EnumMember(Value = "GENERAL_COMPLIANCE")]
        GeneralCompliance,

        /// <summary>
        ///INCORRECT_ROUTING_CODE
        /// IncorrectRoutingCode.
        /// </summary>
        [EnumMember(Value = "INCORRECT_ROUTING_CODE")]
        IncorrectRoutingCode,

        /// <summary>
        ///BELOW_MIN_ABOVE_MAX_ALLOWED_AMOUNT
        /// BelowMinAboveMaxAllowedAmount.
        /// </summary>
        [EnumMember(Value = "BELOW_MIN_ABOVE_MAX_ALLOWED_AMOUNT")]
        BelowMinAboveMaxAllowedAmount,

        /// <summary>
        ///INVALID_INSUFFICIENT_PAYMENT_DETAILS
        /// InvalidInsufficientPaymentDetails.
        /// </summary>
        [EnumMember(Value = "INVALID_INSUFFICIENT_PAYMENT_DETAILS")]
        InvalidInsufficientPaymentDetails,

        /// <summary>
        ///INVALID_BENEFICIARY_NAME
        /// InvalidBeneficiaryName.
        /// </summary>
        [EnumMember(Value = "INVALID_BENEFICIARY_NAME")]
        InvalidBeneficiaryName,

        /// <summary>
        ///INVALID_BENEFICIARY_TAX_ID
        /// InvalidBeneficiaryTaxId.
        /// </summary>
        [EnumMember(Value = "INVALID_BENEFICIARY_TAX_ID")]
        InvalidBeneficiaryTaxId,

        /// <summary>
        ///INVALID_BENEFICIARY_BANK_BRANCH_ADDRESS
        /// InvalidBeneficiaryBankBranchAddress.
        /// </summary>
        [EnumMember(Value = "INVALID_BENEFICIARY_BANK_BRANCH_ADDRESS")]
        InvalidBeneficiaryBankBranchAddress,

        /// <summary>
        ///INVALID_BENEFICIARY_ADDRESS
        /// InvalidBeneficiaryAddress.
        /// </summary>
        [EnumMember(Value = "INVALID_BENEFICIARY_ADDRESS")]
        InvalidBeneficiaryAddress,

        /// <summary>
        ///BANK_UNABLE_TO_APPLY
        /// BankUnableToApply.
        /// </summary>
        [EnumMember(Value = "BANK_UNABLE_TO_APPLY")]
        BankUnableToApply,

        /// <summary>
        ///BANK_CODE_WRONG
        /// BankCodeWrong.
        /// </summary>
        [EnumMember(Value = "BANK_CODE_WRONG")]
        BankCodeWrong,

        /// <summary>
        ///The transfer failed and the reason will be in the EFTFAILURECOMMENT field
        /// Other.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other
    }
}