// <copyright file="Addresses.cs" company="APIMatic">
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
    /// Addresses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Addresses
    {
        /// <summary>
        ///Business Address
        /// Business.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        Business,

        /// <summary>
        ///Mailing Address
        /// Mailing.
        /// </summary>
        [EnumMember(Value = "MAILING")]
        Mailing,

        /// <summary>
        ///Residential Address
        /// Residental.
        /// </summary>
        [EnumMember(Value = "RESIDENTIAL")]
        Residental,

        /// <summary>
        ///Unknown or undefined address type
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}