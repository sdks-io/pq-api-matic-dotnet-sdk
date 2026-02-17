// <copyright file="DocumentTypes.cs" company="APIMatic">
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
    /// DocumentTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentTypes
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// ArmedForcesIdCard.
        /// </summary>
        [EnumMember(Value = "ARMED_FORCES_ID_CARD")]
        ArmedForcesIdCard,

        /// <summary>
        /// BankOrCreditCardStatement.
        /// </summary>
        [EnumMember(Value = "BANK_OR_CREDIT_CARD_STATEMENT")]
        BankOrCreditCardStatement,

        /// <summary>
        /// BankReferenceLetter.
        /// </summary>
        [EnumMember(Value = "BANK_REFERENCE_LETTER")]
        BankReferenceLetter,

        /// <summary>
        /// BirthCertificate.
        /// </summary>
        [EnumMember(Value = "BIRTH_CERTIFICATE")]
        BirthCertificate,

        /// <summary>
        /// DeedPoll.
        /// </summary>
        [EnumMember(Value = "DEED_POLL")]
        DeedPoll,

        /// <summary>
        /// DeedPollNameChange.
        /// </summary>
        [EnumMember(Value = "DEED_POLL_NAME_CHANGE")]
        DeedPollNameChange,

        /// <summary>
        /// DriversLicense.
        /// </summary>
        [EnumMember(Value = "DRIVERS_LICENSE")]
        DriversLicense,

        /// <summary>
        /// DriversLicenseBack.
        /// </summary>
        [EnumMember(Value = "DRIVERS_LICENSE_BACK")]
        DriversLicenseBack,

        /// <summary>
        /// DriversLicenseNameChange.
        /// </summary>
        [EnumMember(Value = "DRIVERS_LICENSE_NAME_CHANGE")]
        DriversLicenseNameChange,

        /// <summary>
        /// FirearmsLicense.
        /// </summary>
        [EnumMember(Value = "FIREARMS_LICENSE")]
        FirearmsLicense,

        /// <summary>
        /// HealthIdCard.
        /// </summary>
        [EnumMember(Value = "HEALTH_ID_CARD")]
        HealthIdCard,

        /// <summary>
        /// HighQualityHeadshot.
        /// </summary>
        [EnumMember(Value = "HIGH_QUALITY_HEADSHOT")]
        HighQualityHeadshot,

        /// <summary>
        /// MarriageLicense.
        /// </summary>
        [EnumMember(Value = "MARRIAGE_LICENSE")]
        MarriageLicense,

        /// <summary>
        /// MarriageLicenseNameChange.
        /// </summary>
        [EnumMember(Value = "MARRIAGE_LICENSE_NAME_CHANGE")]
        MarriageLicenseNameChange,

        /// <summary>
        /// MatriculaConsularIdCard.
        /// </summary>
        [EnumMember(Value = "MATRICULA_CONSULAR_ID_CARD")]
        MatriculaConsularIdCard,

        /// <summary>
        /// NationalIdentityCard.
        /// </summary>
        [EnumMember(Value = "NATIONAL_IDENTITY_CARD")]
        NationalIdentityCard,

        /// <summary>
        /// NationalIdentityCardFront.
        /// </summary>
        [EnumMember(Value = "NATIONAL_IDENTITY_CARD_FRONT")]
        NationalIdentityCardFront,

        /// <summary>
        /// NationalIdentityCardBack.
        /// </summary>
        [EnumMember(Value = "NATIONAL_IDENTITY_CARD_BACK")]
        NationalIdentityCardBack,

        /// <summary>
        /// NationalInsuranceCard.
        /// </summary>
        [EnumMember(Value = "NATIONAL_INSURANCE_CARD")]
        NationalInsuranceCard,

        /// <summary>
        /// OfficialNameChangeDocument.
        /// </summary>
        [EnumMember(Value = "OFFICIAL_NAME_CHANGE_DOCUMENT")]
        OfficialNameChangeDocument,

        /// <summary>
        /// OtherGovernmentIssuedId.
        /// </summary>
        [EnumMember(Value = "OTHER_GOVERNMENT_ISSUED_ID")]
        OtherGovernmentIssuedId,

        /// <summary>
        /// Passport.
        /// </summary>
        [EnumMember(Value = "PASSPORT")]
        Passport,

        /// <summary>
        /// PayStub.
        /// </summary>
        [EnumMember(Value = "PAY_STUB")]
        PayStub,

        /// <summary>
        /// ProofOfAgeCard.
        /// </summary>
        [EnumMember(Value = "PROOF_OF_AGE_CARD")]
        ProofOfAgeCard,

        /// <summary>
        /// ProvisionalDriversLicense.
        /// </summary>
        [EnumMember(Value = "PROVISIONAL_DRIVERS_LICENSE")]
        ProvisionalDriversLicense,

        /// <summary>
        /// PublicServiceCardFront.
        /// </summary>
        [EnumMember(Value = "PUBLIC_SERVICE_CARD_FRONT")]
        PublicServiceCardFront,

        /// <summary>
        /// PublicServiceCardBack.
        /// </summary>
        [EnumMember(Value = "PUBLIC_SERVICE_CARD_BACK")]
        PublicServiceCardBack,

        /// <summary>
        /// ResidentCard.
        /// </summary>
        [EnumMember(Value = "RESIDENT_CARD")]
        ResidentCard,

        /// <summary>
        /// ResidentImmigrationCard.
        /// </summary>
        [EnumMember(Value = "RESIDENT_IMMIGRATION_CARD")]
        ResidentImmigrationCard,

        /// <summary>
        /// SocialSecurityCard.
        /// </summary>
        [EnumMember(Value = "SOCIAL_SECURITY_CARD")]
        SocialSecurityCard,

        /// <summary>
        /// TaxIdentificationCardOrLetter.
        /// </summary>
        [EnumMember(Value = "TAX_IDENTIFICATION_CARD_OR_LETTER")]
        TaxIdentificationCardOrLetter,

        /// <summary>
        /// TaxStatement.
        /// </summary>
        [EnumMember(Value = "TAX_STATEMENT")]
        TaxStatement,

        /// <summary>
        /// UtilityBill.
        /// </summary>
        [EnumMember(Value = "UTILITY_BILL")]
        UtilityBill,

        /// <summary>
        /// VotersCard.
        /// </summary>
        [EnumMember(Value = "VOTERS_CARD")]
        VotersCard,

        /// <summary>
        /// ArmedForcesIdCardBack.
        /// </summary>
        [EnumMember(Value = "ARMED_FORCES_ID_CARD_BACK")]
        ArmedForcesIdCardBack,

        /// <summary>
        /// TaxDocument.
        /// </summary>
        [EnumMember(Value = "TAX_DOCUMENT")]
        TaxDocument,

        /// <summary>
        /// HealthIdCardBack.
        /// </summary>
        [EnumMember(Value = "HEALTH_ID_CARD_BACK")]
        HealthIdCardBack,

        /// <summary>
        /// ProofOfAgeCardBack.
        /// </summary>
        [EnumMember(Value = "PROOF_OF_AGE_CARD_BACK")]
        ProofOfAgeCardBack,

        /// <summary>
        /// IndependentPersonalReferenceDocument.
        /// </summary>
        [EnumMember(Value = "INDEPENDENT_PERSONAL_REFERENCE_DOCUMENT")]
        IndependentPersonalReferenceDocument,

        /// <summary>
        /// VideoCallFile.
        /// </summary>
        [EnumMember(Value = "VIDEO_CALL_FILE")]
        VideoCallFile,

        /// <summary>
        /// HomeOrAutoInsuranceCertificateOrSchedule.
        /// </summary>
        [EnumMember(Value = "HOME_OR_AUTO_INSURANCE_CERTIFICATE_OR_SCHEDULE")]
        HomeOrAutoInsuranceCertificateOrSchedule,

        /// <summary>
        /// DivorceDecreeNameChange.
        /// </summary>
        [EnumMember(Value = "DIVORCE_DECREE_NAME_CHANGE")]
        DivorceDecreeNameChange,

        /// <summary>
        /// CivilPartnershipRegistrationNameChange.
        /// </summary>
        [EnumMember(Value = "CIVIL_PARTNERSHIP_REGISTRATION_NAME_CHANGE")]
        CivilPartnershipRegistrationNameChange,

        /// <summary>
        /// RentAgreement.
        /// </summary>
        [EnumMember(Value = "RENT_AGREEMENT")]
        RentAgreement,

        /// <summary>
        /// VehicleRegistration.
        /// </summary>
        [EnumMember(Value = "VEHICLE_REGISTRATION")]
        VehicleRegistration,

        /// <summary>
        /// BenefitsConfirmationLetter.
        /// </summary>
        [EnumMember(Value = "BENEFITS_CONFIRMATION_LETTER")]
        BenefitsConfirmationLetter,

        /// <summary>
        /// ResidentCardBack.
        /// </summary>
        [EnumMember(Value = "RESIDENT_CARD_BACK")]
        ResidentCardBack,

        /// <summary>
        /// LoanAccountStatement.
        /// </summary>
        [EnumMember(Value = "LOAN_ACCOUNT_STATEMENT")]
        LoanAccountStatement,

        /// <summary>
        /// ProcessedCheck.
        /// </summary>
        [EnumMember(Value = "PROCESSED_CHECK")]
        ProcessedCheck,

        /// <summary>
        /// ResidentialDirectoryListing.
        /// </summary>
        [EnumMember(Value = "RESIDENTIAL_DIRECTORY_LISTING")]
        ResidentialDirectoryListing,

        /// <summary>
        /// GenericDocument.
        /// </summary>
        [EnumMember(Value = "GENERIC_DOCUMENT")]
        GenericDocument,

        /// <summary>
        /// GovernmentIssuedPhotoid.
        /// </summary>
        [EnumMember(Value = "GOVERNMENT_ISSUED_PHOTOID")]
        GovernmentIssuedPhotoid,

        /// <summary>
        /// GovernmentIssuedPhotoIdBack.
        /// </summary>
        [EnumMember(Value = "GOVERNMENT_ISSUED_PHOTO_ID_BACK")]
        GovernmentIssuedPhotoIdBack,

        /// <summary>
        /// SocialInsuranceNumberCard.
        /// </summary>
        [EnumMember(Value = "SOCIAL_INSURANCE_NUMBER_CARD")]
        SocialInsuranceNumberCard,

        /// <summary>
        /// SocialInsuranceNumberLetter.
        /// </summary>
        [EnumMember(Value = "SOCIAL_INSURANCE_NUMBER_LETTER")]
        SocialInsuranceNumberLetter,

        /// <summary>
        /// OtherSocialInsuranceNumberDocument.
        /// </summary>
        [EnumMember(Value = "OTHER_SOCIAL_INSURANCE_NUMBER_DOCUMENT")]
        OtherSocialInsuranceNumberDocument,

        /// <summary>
        /// PlasticCardCustomImage.
        /// </summary>
        [EnumMember(Value = "PLASTIC_CARD_CUSTOM_IMAGE")]
        PlasticCardCustomImage
    }
}