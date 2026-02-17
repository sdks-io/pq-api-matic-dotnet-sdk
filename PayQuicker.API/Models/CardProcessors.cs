// <copyright file="CardProcessors.cs" company="APIMatic">
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
    /// CardProcessors.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardProcessors
    {
        /// <summary>
        /// Fis.
        /// </summary>
        [EnumMember(Value = "FIS")]
        Fis,

        /// <summary>
        /// Flex.
        /// </summary>
        [EnumMember(Value = "FLEX")]
        Flex,

        /// <summary>
        /// Eps.
        /// </summary>
        [EnumMember(Value = "EPS")]
        Eps,

        /// <summary>
        /// Toka.
        /// </summary>
        [EnumMember(Value = "TOKA")]
        Toka,

        /// <summary>
        /// Qolo.
        /// </summary>
        [EnumMember(Value = "QOLO")]
        Qolo,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}