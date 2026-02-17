// <copyright file="FeeResponsibilitySources.cs" company="APIMatic">
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
    /// FeeResponsibilitySources.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeeResponsibilitySources
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        Credit,

        /// <summary>
        /// Schedule.
        /// </summary>
        [EnumMember(Value = "SCHEDULE")]
        Schedule
    }
}