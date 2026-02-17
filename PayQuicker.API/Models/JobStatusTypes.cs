// <copyright file="JobStatusTypes.cs" company="APIMatic">
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
    /// JobStatusTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobStatusTypes
    {
        /// <summary>
        ///COMPLETED.
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        ///APPROVED.
        /// Approved.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        ///CANCELLED.
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        ///FAILED.
        /// Failed.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        ///IN_PROGRESS.
        /// InProgress.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        ///PARSING.
        /// Parsing.
        /// </summary>
        [EnumMember(Value = "PARSING")]
        Parsing,

        /// <summary>
        ///PENDING_REVIEW.
        /// PendingReview.
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW")]
        PendingReview,

        /// <summary>
        ///PROCESSING.
        /// Processing.
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        Processing,

        /// <summary>
        ///SCHEDULED.
        /// Scheduled.
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,

        /// <summary>
        ///SUBMITTED.
        /// Submitted.
        /// </summary>
        [EnumMember(Value = "SUBMITTED")]
        Submitted
    }
}