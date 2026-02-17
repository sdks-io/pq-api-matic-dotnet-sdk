// <copyright file="ReceiptStatuses.cs" company="APIMatic">
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
    /// ReceiptStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiptStatuses
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Complete.
        /// </summary>
        [EnumMember(Value = "COMPLETE")]
        Complete,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        Canceled,

        /// <summary>
        /// Scheduled.
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,

        /// <summary>
        /// ReviewRequired.
        /// </summary>
        [EnumMember(Value = "REVIEW_REQUIRED")]
        ReviewRequired,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        Refunded,

        /// <summary>
        /// Processing.
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        Processing,

        /// <summary>
        /// Reversed.
        /// </summary>
        [EnumMember(Value = "REVERSED")]
        Reversed,

        /// <summary>
        /// Unsettled.
        /// </summary>
        [EnumMember(Value = "UNSETTLED")]
        Unsettled
    }
}