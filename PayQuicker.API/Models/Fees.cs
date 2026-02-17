// <copyright file="Fees.cs" company="APIMatic">
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
    /// Fees.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Fees
    {
        /// <summary>
        /// BankTransferReversalStopNoc.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER_REVERSAL_STOP_NOC")]
        BankTransferReversalStopNoc,

        /// <summary>
        /// PaperCheckStop.
        /// </summary>
        [EnumMember(Value = "PAPER_CHECK_STOP")]
        PaperCheckStop,

        /// <summary>
        /// InstantPayment.
        /// </summary>
        [EnumMember(Value = "INSTANT_PAYMENT")]
        InstantPayment,

        /// <summary>
        /// AccountDirectDeposit.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_DIRECT_DEPOSIT")]
        AccountDirectDeposit,

        /// <summary>
        /// InboundWire.
        /// </summary>
        [EnumMember(Value = "INBOUND_WIRE")]
        InboundWire,

        /// <summary>
        /// PlasticCardPurchaseDeclined.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_PURCHASE_DECLINED")]
        PlasticCardPurchaseDeclined,

        /// <summary>
        /// AtmDeclined.
        /// </summary>
        [EnumMember(Value = "ATM_DECLINED")]
        AtmDeclined,

        /// <summary>
        /// ClearNegativeBalance.
        /// </summary>
        [EnumMember(Value = "CLEAR_NEGATIVE_BALANCE")]
        ClearNegativeBalance,

        /// <summary>
        /// PlasticCardIssuance.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_ISSUANCE")]
        PlasticCardIssuance,

        /// <summary>
        /// PlasticCardReplacementFraud.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_REPLACEMENT_FRAUD")]
        PlasticCardReplacementFraud,

        /// <summary>
        /// PlasticCardReplacementLostOrStolen.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_REPLACEMENT_LOST_OR_STOLEN")]
        PlasticCardReplacementLostOrStolen,

        /// <summary>
        /// PlasticCardReplacementExpired.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_REPLACEMENT_EXPIRED")]
        PlasticCardReplacementExpired,

        /// <summary>
        /// BankTransferCurrencyConversion.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER_CURRENCY_CONVERSION")]
        BankTransferCurrencyConversion,

        /// <summary>
        /// PaperCheckIssuanceCurrencyConversion.
        /// </summary>
        [EnumMember(Value = "PAPER_CHECK_ISSUANCE_CURRENCY_CONVERSION")]
        PaperCheckIssuanceCurrencyConversion,

        /// <summary>
        /// PlasticCardPinPurchase.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_PIN_PURCHASE")]
        PlasticCardPinPurchase,

        /// <summary>
        /// ForeignExchangeConversion.
        /// </summary>
        [EnumMember(Value = "FOREIGN_EXCHANGE_CONVERSION")]
        ForeignExchangeConversion,

        /// <summary>
        /// AtmCashWithdrawalRemoteCurrencyForeignExchange.
        /// </summary>
        [EnumMember(Value = "ATM_CASH_WITHDRAWAL_REMOTE_CURRENCY_FOREIGN_EXCHANGE")]
        AtmCashWithdrawalRemoteCurrencyForeignExchange,

        /// <summary>
        /// PaperStatement.
        /// </summary>
        [EnumMember(Value = "PAPER_STATEMENT")]
        PaperStatement,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "BANK_TRANSFER")]
        BankTransfer,

        /// <summary>
        /// PaperCheckIssuance.
        /// </summary>
        [EnumMember(Value = "PAPER_CHECK_ISSUANCE")]
        PaperCheckIssuance,

        /// <summary>
        /// AccountEnrollment.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_ENROLLMENT")]
        AccountEnrollment,

        /// <summary>
        /// MonthlyMaintenanceInactiveAccount.
        /// </summary>
        [EnumMember(Value = "MONTHLY_MAINTENANCE_INACTIVE_ACCOUNT")]
        MonthlyMaintenanceInactiveAccount,

        /// <summary>
        /// MonthlyMaintenanceActiveAccount.
        /// </summary>
        [EnumMember(Value = "MONTHLY_MAINTENANCE_ACTIVE_ACCOUNT")]
        MonthlyMaintenanceActiveAccount,

        /// <summary>
        /// AccountClosure.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_CLOSURE")]
        AccountClosure,

        /// <summary>
        /// PlasticCardPurchaseOutsideUsa.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_PURCHASE_OUTSIDE_USA")]
        PlasticCardPurchaseOutsideUsa,

        /// <summary>
        /// ExternalInitiatedBankTransfer.
        /// </summary>
        [EnumMember(Value = "EXTERNAL_INITIATED_BANK_TRANSFER")]
        ExternalInitiatedBankTransfer,

        /// <summary>
        /// CoBrandedAccountProcessingOrderFee.
        /// </summary>
        [EnumMember(Value = "CO_BRANDED_ACCOUNT_PROCESSING_ORDER_FEE")]
        CoBrandedAccountProcessingOrderFee,

        /// <summary>
        /// AtmCashWithdrawalFeeLocalCurrency.
        /// </summary>
        [EnumMember(Value = "ATM_CASH_WITHDRAWAL_FEE_LOCAL_CURRENCY")]
        AtmCashWithdrawalFeeLocalCurrency,

        /// <summary>
        /// AtmCashWithdrawalFeeOutsideCurrency.
        /// </summary>
        [EnumMember(Value = "ATM_CASH_WITHDRAWAL_FEE_OUTSIDE_CURRENCY")]
        AtmCashWithdrawalFeeOutsideCurrency,

        /// <summary>
        /// AtmBalanceInquiryFee.
        /// </summary>
        [EnumMember(Value = "ATM_BALANCE_INQUIRY_FEE")]
        AtmBalanceInquiryFee,

        /// <summary>
        /// BankTellerCashWithdrawalFee.
        /// </summary>
        [EnumMember(Value = "BANK_TELLER_CASH_WITHDRAWAL_FEE")]
        BankTellerCashWithdrawalFee,

        /// <summary>
        /// BankTellerCashWithdrawalDeclineFee.
        /// </summary>
        [EnumMember(Value = "BANK_TELLER_CASH_WITHDRAWAL_DECLINE_FEE")]
        BankTellerCashWithdrawalDeclineFee,

        /// <summary>
        /// CompanyBulkMonthlyFee.
        /// </summary>
        [EnumMember(Value = "COMPANY_BULK_MONTHLY_FEE")]
        CompanyBulkMonthlyFee,

        /// <summary>
        /// PaymentEscheatmentFee.
        /// </summary>
        [EnumMember(Value = "PAYMENT_ESCHEATMENT_FEE")]
        PaymentEscheatmentFee,

        /// <summary>
        /// SpendbackProcessingFee.
        /// </summary>
        [EnumMember(Value = "SPENDBACK_PROCESSING_FEE")]
        SpendbackProcessingFee,

        /// <summary>
        /// VirtualPlasticCardReplacementFraud.
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PLASTIC_CARD_REPLACEMENT_FRAUD")]
        VirtualPlasticCardReplacementFraud,

        /// <summary>
        /// VirtualPlasticCardReplacementLostOrStolen.
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PLASTIC_CARD_REPLACEMENT_LOST_OR_STOLEN")]
        VirtualPlasticCardReplacementLostOrStolen,

        /// <summary>
        /// VirtualPlasticCardReplacementExpired.
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PLASTIC_CARD_REPLACEMENT_EXPIRED")]
        VirtualPlasticCardReplacementExpired,

        /// <summary>
        /// ReverseFee.
        /// </summary>
        [EnumMember(Value = "REVERSE_FEE")]
        ReverseFee,

        /// <summary>
        /// LoadServiceFee.
        /// </summary>
        [EnumMember(Value = "LOAD_SERVICE_FEE")]
        LoadServiceFee,

        /// <summary>
        /// PaymentSubscriptionFee.
        /// </summary>
        [EnumMember(Value = "PAYMENT_SUBSCRIPTION_FEE")]
        PaymentSubscriptionFee,

        /// <summary>
        /// AutoAchFee.
        /// </summary>
        [EnumMember(Value = "AUTO_ACH_FEE")]
        AutoAchFee,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// BulkMonthlyFee.
        /// </summary>
        [EnumMember(Value = "BULK_MONTHLY_FEE")]
        BulkMonthlyFee,

        /// <summary>
        /// VirtualPlasticCardIssuance.
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PLASTIC_CARD_ISSUANCE")]
        VirtualPlasticCardIssuance,

        /// <summary>
        /// ElectronicWalletTransfer.
        /// </summary>
        [EnumMember(Value = "ELECTRONIC_WALLET_TRANSFER")]
        ElectronicWalletTransfer
    }
}