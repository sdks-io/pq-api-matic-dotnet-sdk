// <copyright file="Genders.cs" company="APIMatic">
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
    /// Genders.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Genders
    {
        /// <summary>
        /// Female.
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        Female,

        /// <summary>
        /// Male.
        /// </summary>
        [EnumMember(Value = "MALE")]
        Male,

        /// <summary>
        /// NotSpecified.
        /// </summary>
        [EnumMember(Value = "NOT_SPECIFIED")]
        NotSpecified,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// GenderNeutral.
        /// </summary>
        [EnumMember(Value = "GENDER_NEUTRAL")]
        GenderNeutral
    }
}