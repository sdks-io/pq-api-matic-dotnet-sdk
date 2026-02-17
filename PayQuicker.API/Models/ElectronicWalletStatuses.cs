// <copyright file="ElectronicWalletStatuses.cs" company="APIMatic">
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
    /// ElectronicWalletStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicWalletStatuses
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Deleted.
        /// </summary>
        [EnumMember(Value = "DELETED")]
        Deleted,

        /// <summary>
        /// PendingVerification.
        /// </summary>
        [EnumMember(Value = "PENDING_VERIFICATION")]
        PendingVerification,

        /// <summary>
        /// Verified.
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        Verified,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
}