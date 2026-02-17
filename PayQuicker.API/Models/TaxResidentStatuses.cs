// <copyright file="TaxResidentStatuses.cs" company="APIMatic">
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
    /// TaxResidentStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxResidentStatuses
    {
        /// <summary>
        /// No.
        /// </summary>
        [EnumMember(Value = "NO")]
        No,

        /// <summary>
        /// Yes.
        /// </summary>
        [EnumMember(Value = "YES")]
        Yes,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}