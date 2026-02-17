// <copyright file="TransferStatuses.cs" company="APIMatic">
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
    /// TransferStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransferStatuses
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        Accepted,

        /// <summary>
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// PendingAcceptance.
        /// </summary>
        [EnumMember(Value = "PENDING_ACCEPTANCE")]
        PendingAcceptance,

        /// <summary>
        /// Quoted.
        /// </summary>
        [EnumMember(Value = "QUOTED")]
        Quoted,

        /// <summary>
        /// Returned.
        /// </summary>
        [EnumMember(Value = "RETURNED")]
        Returned,

        /// <summary>
        /// Scheduled.
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,

        /// <summary>
        /// VerificationHold.
        /// </summary>
        [EnumMember(Value = "VERIFICATION_HOLD")]
        VerificationHold,

        /// <summary>
        /// Voided.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided
    }
}