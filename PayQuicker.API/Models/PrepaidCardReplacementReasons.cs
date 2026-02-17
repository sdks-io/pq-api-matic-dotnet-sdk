// <copyright file="PrepaidCardReplacementReasons.cs" company="APIMatic">
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
    /// PrepaidCardReplacementReasons.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaidCardReplacementReasons
    {
        /// <summary>
        /// Compromised.
        /// </summary>
        [EnumMember(Value = "COMPROMISED")]
        Compromised,

        /// <summary>
        /// Damaged.
        /// </summary>
        [EnumMember(Value = "DAMAGED")]
        Damaged,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        /// Lost.
        /// </summary>
        [EnumMember(Value = "LOST")]
        Lost,

        /// <summary>
        /// Stolen.
        /// </summary>
        [EnumMember(Value = "STOLEN")]
        Stolen
    }
}