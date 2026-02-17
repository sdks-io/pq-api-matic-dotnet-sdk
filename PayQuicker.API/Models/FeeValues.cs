// <copyright file="FeeValues.cs" company="APIMatic">
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
    /// FeeValues.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeeValues
    {
        /// <summary>
        /// Percentage.
        /// </summary>
        [EnumMember(Value = "PERCENTAGE")]
        Percentage,

        /// <summary>
        /// Static.
        /// </summary>
        [EnumMember(Value = "STATIC")]
        Static
    }
}