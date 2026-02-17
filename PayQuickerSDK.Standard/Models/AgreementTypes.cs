// <copyright file="AgreementTypes.cs" company="APIMatic">
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
    /// AgreementTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgreementTypes
    {
        /// <summary>
        /// CardHolderAgreement.
        /// </summary>
        [EnumMember(Value = "CARD_HOLDER_AGREEMENT")]
        CardHolderAgreement,

        /// <summary>
        /// CardHolderAgreementConsent.
        /// </summary>
        [EnumMember(Value = "CARD_HOLDER_AGREEMENT_CONSENT")]
        CardHolderAgreementConsent,

        /// <summary>
        /// CardLimits.
        /// </summary>
        [EnumMember(Value = "CARD_LIMITS")]
        CardLimits,

        /// <summary>
        /// ESignAndConsent.
        /// </summary>
        [EnumMember(Value = "E_SIGN_AND_CONSENT")]
        ESignAndConsent,

        /// <summary>
        /// FeeAgreement.
        /// </summary>
        [EnumMember(Value = "FEE_AGREEMENT")]
        FeeAgreement,

        /// <summary>
        /// PrivacyPolicy.
        /// </summary>
        [EnumMember(Value = "PRIVACY_POLICY")]
        PrivacyPolicy,

        /// <summary>
        /// PrivacyPolicyAddendum.
        /// </summary>
        [EnumMember(Value = "PRIVACY_POLICY_ADDENDUM")]
        PrivacyPolicyAddendum,

        /// <summary>
        /// TermsOfUse.
        /// </summary>
        [EnumMember(Value = "TERMS_OF_USE")]
        TermsOfUse,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}