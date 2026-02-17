// <copyright file="ValidatorTypes.cs" company="APIMatic">
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
    /// ValidatorTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidatorTypes
    {
        /// <summary>
        /// Length.
        /// </summary>
        [EnumMember(Value = "LENGTH")]
        Length,

        /// <summary>
        /// Regex.
        /// </summary>
        [EnumMember(Value = "REGEX")]
        Regex,

        /// <summary>
        /// Range.
        /// </summary>
        [EnumMember(Value = "RANGE")]
        Range,

        /// <summary>
        /// Required.
        /// </summary>
        [EnumMember(Value = "REQUIRED")]
        Required,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}