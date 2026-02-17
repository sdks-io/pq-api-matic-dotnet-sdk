// <copyright file="Signs.cs" company="APIMatic">
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
    /// Signs.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Signs
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        Credit,

        /// <summary>
        /// Debit.
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        Debit,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}