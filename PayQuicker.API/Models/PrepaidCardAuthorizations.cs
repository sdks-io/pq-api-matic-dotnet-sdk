// <copyright file="PrepaidCardAuthorizations.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PrepaidCardAuthorizations.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaidCardAuthorizations
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER")]
        BankTransfer,

        /// <summary>
        /// PaperCheck.
        /// </summary>
        [EnumMember(Value = "PAPER_CHECK")]
        PaperCheck,

        /// <summary>
        /// Deposit.
        /// </summary>
        [EnumMember(Value = "DEPOSIT")]
        Deposit,

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
        /// Payment.
        /// </summary>
        [EnumMember(Value = "PAYMENT")]
        Payment,

        /// <summary>
        /// CancelledPayment.
        /// </summary>
        [EnumMember(Value = "CANCELLED_PAYMENT")]
        CancelledPayment,

        /// <summary>
        /// CashWithdrawal.
        /// </summary>
        [EnumMember(Value = "CASH_WITHDRAWAL")]
        CashWithdrawal,

        /// <summary>
        /// Spendback.
        /// </summary>
        [EnumMember(Value = "SPENDBACK")]
        Spendback,

        /// <summary>
        /// BankTransferReversal.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER_REVERSAL")]
        BankTransferReversal,

        /// <summary>
        /// SpendbackReturn.
        /// </summary>
        [EnumMember(Value = "SPENDBACK_RETURN")]
        SpendbackReturn,

        /// <summary>
        /// BankTransferReturn.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER_RETURN")]
        BankTransferReturn,

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
        /// PaymentRetraction.
        /// </summary>
        [EnumMember(Value = "PAYMENT_RETRACTION")]
        PaymentRetraction,

        /// <summary>
        /// AccountToAccountTransfer.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_TO_ACCOUNT_TRANSFER")]
        AccountToAccountTransfer,

        /// <summary>
        /// EscheatedFundsReturn.
        /// </summary>
        [EnumMember(Value = "ESCHEATED_FUNDS_RETURN")]
        EscheatedFundsReturn,

        /// <summary>
        /// UnsettledAuthorization.
        /// </summary>
        [EnumMember(Value = "UNSETTLED_AUTHORIZATION")]
        UnsettledAuthorization,

        /// <summary>
        /// FeeRebate.
        /// </summary>
        [EnumMember(Value = "FEE_REBATE")]
        FeeRebate,

        /// <summary>
        /// EftFxMargin.
        /// </summary>
        [EnumMember(Value = "EFT_FX_MARGIN")]
        EftFxMargin,

        /// <summary>
        /// ElectronicWalletTransfer.
        /// </summary>
        [EnumMember(Value = "ELECTRONIC_WALLET_TRANSFER")]
        ElectronicWalletTransfer
    }
}