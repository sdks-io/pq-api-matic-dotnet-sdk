// <copyright file="BankAccountOwnership.cs" company="APIMatic">
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
    /// BankAccountOwnership.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountOwnership
    {
        /// <summary>
        /// Business.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        Business,

        /// <summary>
        /// Personal.
        /// </summary>
        [EnumMember(Value = "PERSONAL")]
        Personal
    }
}