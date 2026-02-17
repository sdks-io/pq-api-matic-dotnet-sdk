// <copyright file="FeeResponsibilityParties.cs" company="APIMatic">
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
    /// FeeResponsibilityParties.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeeResponsibilityParties
    {
        /// <summary>
        /// Company.
        /// </summary>
        [EnumMember(Value = "COMPANY")]
        Company,

        /// <summary>
        /// User.
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Payquicker.
        /// </summary>
        [EnumMember(Value = "PAYQUICKER")]
        Payquicker,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}