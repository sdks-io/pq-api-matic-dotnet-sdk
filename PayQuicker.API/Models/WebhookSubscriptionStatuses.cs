// <copyright file="WebhookSubscriptionStatuses.cs" company="APIMatic">
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
    /// WebhookSubscriptionStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSubscriptionStatuses
    {
        /// <summary>
        /// Available.
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        Available,

        /// <summary>
        /// Subscribed.
        /// </summary>
        [EnumMember(Value = "SUBSCRIBED")]
        Subscribed,

        /// <summary>
        /// Unsubscribed.
        /// </summary>
        [EnumMember(Value = "UNSUBSCRIBED")]
        Unsubscribed,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}