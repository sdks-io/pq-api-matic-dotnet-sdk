// <copyright file="TransferMethodTypes.cs" company="APIMatic">
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
    /// TransferMethodTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransferMethodTypes
    {
        /// <summary>
        /// Iach.
        /// </summary>
        [EnumMember(Value = "IACH")]
        Iach,

        /// <summary>
        /// Wire.
        /// </summary>
        [EnumMember(Value = "WIRE")]
        Wire,

        /// <summary>
        /// UsSamedayIach.
        /// </summary>
        [EnumMember(Value = "US_SAMEDAY_IACH")]
        UsSamedayIach,

        /// <summary>
        /// StandardEwallet.
        /// </summary>
        [EnumMember(Value = "STANDARD_EWALLET")]
        StandardEwallet,

        /// <summary>
        /// StandardPost.
        /// </summary>
        [EnumMember(Value = "STANDARD_POST")]
        StandardPost
    }
}