// <copyright file="TransferTypes.cs" company="APIMatic">
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
    /// TransferTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransferTypes
    {
        /// <summary>
        /// AccountToAccountTransfer.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_TO_ACCOUNT_TRANSFER")]
        AccountToAccountTransfer,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER")]
        BankTransfer,

        /// <summary>
        /// BankTransferReturn.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER_RETURN")]
        BankTransferReturn,

        /// <summary>
        /// BankTransferReversal.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER_REVERSAL")]
        BankTransferReversal,

        /// <summary>
        /// CancelledPayment.
        /// </summary>
        [EnumMember(Value = "CANCELLED_PAYMENT")]
        CancelledPayment,

        /// <summary>
        /// CardPurchase.
        /// </summary>
        [EnumMember(Value = "CARD_PURCHASE")]
        CardPurchase,

        /// <summary>
        /// CardPurchaseRefund.
        /// </summary>
        [EnumMember(Value = "CARD_PURCHASE_REFUND")]
        CardPurchaseRefund,

        /// <summary>
        /// CashWithdrawal.
        /// </summary>
        [EnumMember(Value = "CASH_WITHDRAWAL")]
        CashWithdrawal,

        /// <summary>
        /// Deposit.
        /// </summary>
        [EnumMember(Value = "DEPOSIT")]
        Deposit,

        /// <summary>
        /// EscheatedFundsReturn.
        /// </summary>
        [EnumMember(Value = "ESCHEATED_FUNDS_RETURN")]
        EscheatedFundsReturn,

        /// <summary>
        /// Fee.
        /// </summary>
        [EnumMember(Value = "FEE")]
        Fee,

        /// <summary>
        /// FeeRefund.
        /// </summary>
        [EnumMember(Value = "FEE_REFUND")]
        FeeRefund,

        /// <summary>
        /// PaperCheck.
        /// </summary>
        [EnumMember(Value = "PAPER_CHECK")]
        PaperCheck,

        /// <summary>
        /// Payment.
        /// </summary>
        [EnumMember(Value = "PAYMENT")]
        Payment,

        /// <summary>
        /// PaymentRetraction.
        /// </summary>
        [EnumMember(Value = "PAYMENT_RETRACTION")]
        PaymentRetraction,

        /// <summary>
        /// PrepaidCardLoad.
        /// </summary>
        [EnumMember(Value = "PREPAID_CARD_LOAD")]
        PrepaidCardLoad,

        /// <summary>
        /// PrepaidCardUnload.
        /// </summary>
        [EnumMember(Value = "PREPAID_CARD_UNLOAD")]
        PrepaidCardUnload,

        /// <summary>
        /// ProvisionalRefund.
        /// </summary>
        [EnumMember(Value = "PROVISIONAL_REFUND")]
        ProvisionalRefund,

        /// <summary>
        /// Spendback.
        /// </summary>
        [EnumMember(Value = "SPENDBACK")]
        Spendback,

        /// <summary>
        /// SpendbackReturn.
        /// </summary>
        [EnumMember(Value = "SPENDBACK_RETURN")]
        SpendbackReturn,

        /// <summary>
        /// ElectronicWalletTransfer.
        /// </summary>
        [EnumMember(Value = "ELECTRONIC_WALLET_TRANSFER")]
        ElectronicWalletTransfer
    }
}