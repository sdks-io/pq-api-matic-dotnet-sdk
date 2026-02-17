// <copyright file="PrepaidCardStatuses.cs" company="APIMatic">
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
    /// PrepaidCardStatuses.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaidCardStatuses
    {
        /// <summary>
        ///The prepaid card is active and ready to use.
        /// Activated.
        /// </summary>
        [EnumMember(Value = "ACTIVATED")]
        Activated,

        /// <summary>
        ///The prepaid card is damaged and is no longer usable.
        /// Closed.
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        Closed,

        /// <summary>
        ///The prepaid card is expired and is no longer usable.
        /// ClosedLostStolenDamaged.
        /// </summary>
        [EnumMember(Value = "CLOSED_LOST_STOLEN_DAMAGED")]
        ClosedLostStolenDamaged,

        /// <summary>
        ///The prepaid card has been suspended for compliance reasons.
        /// ComplianceHold.
        /// </summary>
        [EnumMember(Value = "COMPLIANCE_HOLD")]
        ComplianceHold,

        /// <summary>
        ///The expiration date set for the prepaid card has elapsed. The prepaid card will no longer be accepted.
        /// Expired.
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired,

        /// <summary>
        ///The prepaid card has been created but has not yet been activated. Instantly issued cards are activated automatically.Plastic cards are activated upon delivery and require the CVV on the back of the prepaid card to complete.
        /// PendingActivation.
        /// </summary>
        [EnumMember(Value = "PENDING_ACTIVATION")]
        PendingActivation,

        /// <summary>
        ///The prepaid card is awaiting order placement and will transition to PENDING_ACTIVATION once ordered.
        /// Queued.
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        Queued,

        /// <summary>
        ///TO BE DONE
        /// Staged.
        /// </summary>
        [EnumMember(Value = "STAGED")]
        Staged,

        /// <summary>
        ///The prepaid card has been suspended and may neither send nor receive funds.
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        Suspended
    }
}