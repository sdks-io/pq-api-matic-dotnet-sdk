// <copyright file="WebhookNamespaces.cs" company="APIMatic">
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
    /// WebhookNamespaces.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookNamespaces
    {
        /// <summary>
        /// BankaccountsCreated.
        /// </summary>
        [EnumMember(Value = "BANKACCOUNTS.CREATED")]
        BankaccountsCreated,

        /// <summary>
        /// BankaccountsUpdatedDetailsModified.
        /// </summary>
        [EnumMember(Value = "BANKACCOUNTS.UPDATED.DETAILS.MODIFIED")]
        BankaccountsUpdatedDetailsModified,

        /// <summary>
        /// BankaccountsUpdatedStatusApproved.
        /// </summary>
        [EnumMember(Value = "BANKACCOUNTS.UPDATED.STATUS.APPROVED")]
        BankaccountsUpdatedStatusApproved,

        /// <summary>
        /// BankaccountsUpdatedStatusCompliancehold.
        /// </summary>
        [EnumMember(Value = "BANKACCOUNTS.UPDATED.STATUS.COMPLIANCEHOLD")]
        BankaccountsUpdatedStatusCompliancehold,

        /// <summary>
        /// BankaccountsUpdatedStatusDeleted.
        /// </summary>
        [EnumMember(Value = "BANKACCOUNTS.UPDATED.STATUS.DELETED")]
        BankaccountsUpdatedStatusDeleted,

        /// <summary>
        /// PaperchecksCreated.
        /// </summary>
        [EnumMember(Value = "PAPERCHECKS.CREATED")]
        PaperchecksCreated,

        /// <summary>
        /// PaperchecksUpdatedDetailsModified.
        /// </summary>
        [EnumMember(Value = "PAPERCHECKS.UPDATED.DETAILS.MODIFIED")]
        PaperchecksUpdatedDetailsModified,

        /// <summary>
        /// PaperchecksUpdatedStatusCancelled.
        /// </summary>
        [EnumMember(Value = "PAPERCHECKS.UPDATED.STATUS.CANCELLED")]
        PaperchecksUpdatedStatusCancelled,

        /// <summary>
        /// PaperchecksUpdatedStatusInprogress.
        /// </summary>
        [EnumMember(Value = "PAPERCHECKS.UPDATED.STATUS.INPROGRESS")]
        PaperchecksUpdatedStatusInprogress,

        /// <summary>
        /// PaperchecksUpdatedStatusRedeemed.
        /// </summary>
        [EnumMember(Value = "PAPERCHECKS.UPDATED.STATUS.REDEEMED")]
        PaperchecksUpdatedStatusRedeemed,

        /// <summary>
        /// PaymentquotesAccepted.
        /// </summary>
        [EnumMember(Value = "PAYMENTQUOTES.ACCEPTED")]
        PaymentquotesAccepted,

        /// <summary>
        /// PaymentquotesCancelled.
        /// </summary>
        [EnumMember(Value = "PAYMENTQUOTES.CANCELLED")]
        PaymentquotesCancelled,

        /// <summary>
        /// PaymentquotesCreated.
        /// </summary>
        [EnumMember(Value = "PAYMENTQUOTES.CREATED")]
        PaymentquotesCreated,

        /// <summary>
        /// PaymentquotesVoided.
        /// </summary>
        [EnumMember(Value = "PAYMENTQUOTES.VOIDED")]
        PaymentquotesVoided,

        /// <summary>
        /// PrepaidcardsCreated.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.CREATED")]
        PrepaidcardsCreated,

        /// <summary>
        /// PrepaidcardsUpdatedStatusActive.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.ACTIVE")]
        PrepaidcardsUpdatedStatusActive,

        /// <summary>
        /// PrepaidcardsUpdatedStatusClosed.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.CLOSED")]
        PrepaidcardsUpdatedStatusClosed,

        /// <summary>
        /// PrepaidcardsUpdatedStatusClosedexpired.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.CLOSEDEXPIRED")]
        PrepaidcardsUpdatedStatusClosedexpired,

        /// <summary>
        /// PrepaidcardsUpdatedStatusClosedfraud.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.CLOSEDFRAUD")]
        PrepaidcardsUpdatedStatusClosedfraud,

        /// <summary>
        /// PrepaidcardsUpdatedStatusClosedlost.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.CLOSEDLOST")]
        PrepaidcardsUpdatedStatusClosedlost,

        /// <summary>
        /// PrepaidcardsUpdatedStatusClosedstolen.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.CLOSEDSTOLEN")]
        PrepaidcardsUpdatedStatusClosedstolen,

        /// <summary>
        /// PrepaidcardsUpdatedStatusCompliancehold.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.COMPLIANCEHOLD")]
        PrepaidcardsUpdatedStatusCompliancehold,

        /// <summary>
        /// PrepaidcardsUpdatedStatusPendingactivation.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.PENDINGACTIVATION")]
        PrepaidcardsUpdatedStatusPendingactivation,

        /// <summary>
        /// PrepaidcardsUpdatedStatusPendingorder.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.PENDINGORDER")]
        PrepaidcardsUpdatedStatusPendingorder,

        /// <summary>
        /// PrepaidcardsUpdatedStatusPendingrelease.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.PENDINGRELEASE")]
        PrepaidcardsUpdatedStatusPendingrelease,

        /// <summary>
        /// PrepaidcardsUpdatedStatusSuspended.
        /// </summary>
        [EnumMember(Value = "PREPAIDCARDS.UPDATED.STATUS.SUSPENDED")]
        PrepaidcardsUpdatedStatusSuspended,

        /// <summary>
        /// ReceiptsCreated.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.CREATED")]
        ReceiptsCreated,

        /// <summary>
        /// ReceiptsUpdatedDetailsModified.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.DETAILS.MODIFIED")]
        ReceiptsUpdatedDetailsModified,

        /// <summary>
        /// ReceiptsUpdatedStatusCancelled.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.CANCELLED")]
        ReceiptsUpdatedStatusCancelled,

        /// <summary>
        /// ReceiptsUpdatedStatusCompleted.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.COMPLETED")]
        ReceiptsUpdatedStatusCompleted,

        /// <summary>
        /// ReceiptsUpdatedStatusExpired.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.EXPIRED")]
        ReceiptsUpdatedStatusExpired,

        /// <summary>
        /// ReceiptsUpdatedStatusFailed.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.FAILED")]
        ReceiptsUpdatedStatusFailed,

        /// <summary>
        /// ReceiptsUpdatedStatusPending.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.PENDING")]
        ReceiptsUpdatedStatusPending,

        /// <summary>
        /// ReceiptsUpdatedStatusProcessing.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.PROCESSING")]
        ReceiptsUpdatedStatusProcessing,

        /// <summary>
        /// ReceiptsUpdatedStatusRefunded.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.REFUNDED")]
        ReceiptsUpdatedStatusRefunded,

        /// <summary>
        /// ReceiptsUpdatedStatusReturned.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.RETURNED")]
        ReceiptsUpdatedStatusReturned,

        /// <summary>
        /// ReceiptsUpdatedStatusReversed.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.REVERSED")]
        ReceiptsUpdatedStatusReversed,

        /// <summary>
        /// ReceiptsUpdatedStatusReviewrequired.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.REVIEWREQUIRED")]
        ReceiptsUpdatedStatusReviewrequired,

        /// <summary>
        /// ReceiptsUpdatedStatusScheduled.
        /// </summary>
        [EnumMember(Value = "RECEIPTS.UPDATED.STATUS.SCHEDULED")]
        ReceiptsUpdatedStatusScheduled,

        /// <summary>
        /// SpendbackquotesAccepted.
        /// </summary>
        [EnumMember(Value = "SPENDBACKQUOTES.ACCEPTED")]
        SpendbackquotesAccepted,

        /// <summary>
        /// SpendbackquotesCancelled.
        /// </summary>
        [EnumMember(Value = "SPENDBACKQUOTES.CANCELLED")]
        SpendbackquotesCancelled,

        /// <summary>
        /// SpendbackquotesCreated.
        /// </summary>
        [EnumMember(Value = "SPENDBACKQUOTES.CREATED")]
        SpendbackquotesCreated,

        /// <summary>
        /// SpendbackquotesVoided.
        /// </summary>
        [EnumMember(Value = "SPENDBACKQUOTES.VOIDED")]
        SpendbackquotesVoided,

        /// <summary>
        /// TransferquotesAccepted.
        /// </summary>
        [EnumMember(Value = "TRANSFERQUOTES.ACCEPTED")]
        TransferquotesAccepted,

        /// <summary>
        /// TransferquotesCancelled.
        /// </summary>
        [EnumMember(Value = "TRANSFERQUOTES.CANCELLED")]
        TransferquotesCancelled,

        /// <summary>
        /// TransferquotesCreated.
        /// </summary>
        [EnumMember(Value = "TRANSFERQUOTES.CREATED")]
        TransferquotesCreated,

        /// <summary>
        /// TransferquotesVoided.
        /// </summary>
        [EnumMember(Value = "TRANSFERQUOTES.VOIDED")]
        TransferquotesVoided,

        /// <summary>
        /// UsereventsCompleted.
        /// </summary>
        [EnumMember(Value = "USEREVENTS.COMPLETED")]
        UsereventsCompleted,

        /// <summary>
        /// UsereventsStarted.
        /// </summary>
        [EnumMember(Value = "USEREVENTS.STARTED")]
        UsereventsStarted,

        /// <summary>
        /// UsereventsUpdated.
        /// </summary>
        [EnumMember(Value = "USEREVENTS.UPDATED")]
        UsereventsUpdated,

        /// <summary>
        /// UsersCreated.
        /// </summary>
        [EnumMember(Value = "USERS.CREATED")]
        UsersCreated,

        /// <summary>
        /// UsersUpdatedIdvFailed.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.IDV.FAILED")]
        UsersUpdatedIdvFailed,

        /// <summary>
        /// UsersUpdatedIdvPassed.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.IDV.PASSED")]
        UsersUpdatedIdvPassed,

        /// <summary>
        /// UsersUpdatedKycApproved.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.KYC.APPROVED")]
        UsersUpdatedKycApproved,

        /// <summary>
        /// UsersUpdatedKycProvided.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.KYC.PROVIDED")]
        UsersUpdatedKycProvided,

        /// <summary>
        /// UsersUpdatedKycRejected.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.KYC.REJECTED")]
        UsersUpdatedKycRejected,

        /// <summary>
        /// UsersUpdatedKycRequired.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.KYC.REQUIRED")]
        UsersUpdatedKycRequired,

        /// <summary>
        /// UsersUpdatedStatusRegistrationcomplete.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.STATUS.REGISTRATIONCOMPLETE")]
        UsersUpdatedStatusRegistrationcomplete,

        /// <summary>
        /// UsersUpdatedStatusRegistrationinprogress.
        /// </summary>
        [EnumMember(Value = "USERS.UPDATED.STATUS.REGISTRATIONINPROGRESS")]
        UsersUpdatedStatusRegistrationinprogress,

        /// <summary>
        /// ElectronicwalletsCreated.
        /// </summary>
        [EnumMember(Value = "ELECTRONICWALLETS.CREATED")]
        ElectronicwalletsCreated,

        /// <summary>
        /// ElectronicwalletsUpdatedDetailsModified.
        /// </summary>
        [EnumMember(Value = "ELECTRONICWALLETS.UPDATED.DETAILS.MODIFIED")]
        ElectronicwalletsUpdatedDetailsModified,

        /// <summary>
        /// ElectronicwalletsUpdatedStatusApproved.
        /// </summary>
        [EnumMember(Value = "ELECTRONICWALLETS.UPDATED.STATUS.APPROVED")]
        ElectronicwalletsUpdatedStatusApproved,

        /// <summary>
        /// ElectronicwalletsUpdatedStatusCompliancehold.
        /// </summary>
        [EnumMember(Value = "ELECTRONICWALLETS.UPDATED.STATUS.COMPLIANCEHOLD")]
        ElectronicwalletsUpdatedStatusCompliancehold,

        /// <summary>
        /// ElectronicwalletsUpdatedStatusDeleted.
        /// </summary>
        [EnumMember(Value = "ELECTRONICWALLETS.UPDATED.STATUS.DELETED")]
        ElectronicwalletsUpdatedStatusDeleted,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
}