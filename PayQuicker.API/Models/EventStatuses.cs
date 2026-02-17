// <copyright file="EventStatuses.cs" company="APIMatic">
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
    /// EventStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventStatuses
    {
        /// <summary>
        ///TO BE DONE
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        ///Processing of the event has been canceled.
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        ///Processing of the event has been completed.
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        ///The event is currently being processed.
        /// InProgress.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        ///The event is waiting to be processed.
        /// Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        ///The event processing has been suspended.
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        Suspended
    }
}