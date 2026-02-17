// <copyright file="EventRequirementCategories.cs" company="APIMatic">
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
    /// EventRequirementCategories.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventRequirementCategories
    {
        /// <summary>
        /// Acknowledgement.
        /// </summary>
        [EnumMember(Value = "ACKNOWLEDGEMENT")]
        Acknowledgement,

        /// <summary>
        /// CategoryUndefined.
        /// </summary>
        [EnumMember(Value = "CATEGORY_UNDEFINED")]
        CategoryUndefined,

        /// <summary>
        /// ExternalReferenceKyc.
        /// </summary>
        [EnumMember(Value = "EXTERNAL_REFERENCE_KYC")]
        ExternalReferenceKyc,

        /// <summary>
        /// GeoIpVerification.
        /// </summary>
        [EnumMember(Value = "GEO_IP_VERIFICATION")]
        GeoIpVerification,

        /// <summary>
        /// Kyc.
        /// </summary>
        [EnumMember(Value = "KYC")]
        Kyc,

        /// <summary>
        /// Tax.
        /// </summary>
        [EnumMember(Value = "TAX")]
        Tax,

        /// <summary>
        /// VideoCallKyc.
        /// </summary>
        [EnumMember(Value = "VIDEO_CALL_KYC")]
        VideoCallKyc
    }
}