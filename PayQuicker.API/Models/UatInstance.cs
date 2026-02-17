// <copyright file="UatInstance.cs" company="APIMatic">
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
    /// UatInstance.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UatInstance
    {
        /// <summary>
        /// Uat1.
        /// </summary>
        [EnumMember(Value = "uat1")]
        Uat1,

        /// <summary>
        /// Uat2.
        /// </summary>
        [EnumMember(Value = "uat2")]
        Uat2,

        /// <summary>
        /// Uat3.
        /// </summary>
        [EnumMember(Value = "uat3")]
        Uat3,

        /// <summary>
        /// Uat4.
        /// </summary>
        [EnumMember(Value = "uat4")]
        Uat4,

        /// <summary>
        /// Uat5.
        /// </summary>
        [EnumMember(Value = "uat5")]
        Uat5
    }
}