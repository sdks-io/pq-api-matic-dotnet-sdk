// <copyright file="EventRequirements.cs" company="APIMatic">
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
    /// EventRequirements.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventRequirements
    {
        /// <summary>
        /// AchUpgradePiiDetailsValidated.
        /// </summary>
        [EnumMember(Value = "ACH_UPGRADE_PII_DETAILS_VALIDATED")]
        AchUpgradePiiDetailsValidated,

        /// <summary>
        /// AgreementsAccepted.
        /// </summary>
        [EnumMember(Value = "AGREEMENTS_ACCEPTED")]
        AgreementsAccepted,

        /// <summary>
        /// DocumentsRequired.
        /// </summary>
        [EnumMember(Value = "DOCUMENTS_REQUIRED")]
        DocumentsRequired,

        /// <summary>
        /// EmailAddressVerified.
        /// </summary>
        [EnumMember(Value = "EMAIL_ADDRESS_VERIFIED")]
        EmailAddressVerified,

        /// <summary>
        /// FinancialProcessorAccountCreated.
        /// </summary>
        [EnumMember(Value = "FINANCIAL_PROCESSOR_ACCOUNT_CREATED")]
        FinancialProcessorAccountCreated,

        /// <summary>
        /// IdentityVerified.
        /// </summary>
        [EnumMember(Value = "IDENTITY_VERIFIED")]
        IdentityVerified,

        /// <summary>
        /// MfaRegistrationCancelled.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_CANCELLED")]
        MfaRegistrationCancelled,

        /// <summary>
        /// MfaRegistrationChallengeSent.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_CHALLENGE_SENT")]
        MfaRegistrationChallengeSent,

        /// <summary>
        /// MfaRegistrationCompleted.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_COMPLETED")]
        MfaRegistrationCompleted,

        /// <summary>
        /// MfaRegistrationPiiCollected.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_PII_COLLECTED")]
        MfaRegistrationPiiCollected,

        /// <summary>
        /// MfaRegistrationProcessorRegistration.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_PROCESSOR_REGISTRATION")]
        MfaRegistrationProcessorRegistration,

        /// <summary>
        /// MfaRegistrationTypeChanged.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_TYPE_CHANGED")]
        MfaRegistrationTypeChanged,

        /// <summary>
        /// MfaRegistrationValidation.
        /// </summary>
        [EnumMember(Value = "MFA_REGISTRATION_VALIDATION")]
        MfaRegistrationValidation,

        /// <summary>
        /// OrderPlasticCard.
        /// </summary>
        [EnumMember(Value = "ORDER_PLASTIC_CARD")]
        OrderPlasticCard,

        /// <summary>
        /// PepSanctionsScreeningVerified.
        /// </summary>
        [EnumMember(Value = "PEP_SANCTIONS_SCREENING_VERIFIED")]
        PepSanctionsScreeningVerified,

        /// <summary>
        /// PersonalDetailsCollected.
        /// </summary>
        [EnumMember(Value = "PERSONAL_DETAILS_COLLECTED")]
        PersonalDetailsCollected,

        /// <summary>
        /// ProcessExecuted.
        /// </summary>
        [EnumMember(Value = "PROCESS_EXECUTED")]
        ProcessExecuted,

        /// <summary>
        /// TypeUndefined.
        /// </summary>
        [EnumMember(Value = "TYPE_UNDEFINED")]
        TypeUndefined,

        /// <summary>
        /// UserCreated.
        /// </summary>
        [EnumMember(Value = "USER_CREATED")]
        UserCreated
    }
}