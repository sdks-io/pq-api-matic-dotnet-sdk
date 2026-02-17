// <copyright file="Occupations.cs" company="APIMatic">
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
    /// Occupations.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Occupations
    {
        /// <summary>
        /// Arts.
        /// </summary>
        [EnumMember(Value = "ARTS")]
        Arts,

        /// <summary>
        /// Design.
        /// </summary>
        [EnumMember(Value = "DESIGN")]
        Design,

        /// <summary>
        /// Education.
        /// </summary>
        [EnumMember(Value = "EDUCATION")]
        Education,

        /// <summary>
        /// Engineering.
        /// </summary>
        [EnumMember(Value = "ENGINEERING")]
        Engineering,

        /// <summary>
        /// Finance.
        /// </summary>
        [EnumMember(Value = "FINANCE")]
        Finance,

        /// <summary>
        /// Government.
        /// </summary>
        [EnumMember(Value = "GOVERNMENT")]
        Government,

        /// <summary>
        /// Healthcare.
        /// </summary>
        [EnumMember(Value = "HEALTHCARE")]
        Healthcare,

        /// <summary>
        /// HospitalityAndTourism.
        /// </summary>
        [EnumMember(Value = "HOSPITALITY_AND_TOURISM")]
        HospitalityAndTourism,

        /// <summary>
        /// IndependentBusinessOwner.
        /// </summary>
        [EnumMember(Value = "INDEPENDENT_BUSINESS_OWNER")]
        IndependentBusinessOwner,

        /// <summary>
        /// Law.
        /// </summary>
        [EnumMember(Value = "LAW")]
        Law,

        /// <summary>
        /// Manufacturing.
        /// </summary>
        [EnumMember(Value = "MANUFACTURING")]
        Manufacturing,

        /// <summary>
        /// Math.
        /// </summary>
        [EnumMember(Value = "MATH")]
        Math,

        /// <summary>
        /// Media.
        /// </summary>
        [EnumMember(Value = "MEDIA")]
        Media,

        /// <summary>
        /// OfficeAndAdminSupport.
        /// </summary>
        [EnumMember(Value = "OFFICE_AND_ADMIN_SUPPORT")]
        OfficeAndAdminSupport,

        /// <summary>
        /// Science.
        /// </summary>
        [EnumMember(Value = "SCIENCE")]
        Science,

        /// <summary>
        /// SocialServices.
        /// </summary>
        [EnumMember(Value = "SOCIAL_SERVICES")]
        SocialServices,

        /// <summary>
        /// Technology.
        /// </summary>
        [EnumMember(Value = "TECHNOLOGY")]
        Technology,

        /// <summary>
        /// Sales.
        /// </summary>
        [EnumMember(Value = "SALES")]
        Sales
    }
}