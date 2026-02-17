// <copyright file="IdentityVerificationResultSubTypes.cs" company="APIMatic">
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
    /// IdentityVerificationResultSubTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityVerificationResultSubTypes
    {
        /// <summary>
        /// Hard.
        /// </summary>
        [EnumMember(Value = "HARD")]
        Hard,

        /// <summary>
        /// Soft.
        /// </summary>
        [EnumMember(Value = "SOFT")]
        Soft
    }
}