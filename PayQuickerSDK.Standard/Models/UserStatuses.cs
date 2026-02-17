// <copyright file="UserStatuses.cs" company="APIMatic">
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
    /// UserStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserStatuses
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Closed.
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        Closed,

        /// <summary>
        /// InProgress.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress
    }
}