// <copyright file="FeeSources.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// FeeSources.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeeSources
    {
        /// <summary>
        /// Transaction.
        /// </summary>
        [EnumMember(Value = "TRANSACTION")]
        Transaction,

        /// <summary>
        /// User.
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}