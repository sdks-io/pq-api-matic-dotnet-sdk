// <copyright file="UserImpact.cs" company="APIMatic">
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
    /// UserImpact.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserImpact
    {
        /// <summary>
        /// NoImpact.
        /// </summary>
        [EnumMember(Value = "NO_IMPACT")]
        NoImpact,

        /// <summary>
        /// UserRestrictions.
        /// </summary>
        [EnumMember(Value = "USER_RESTRICTIONS")]
        UserRestrictions,

        /// <summary>
        /// UserSuspended.
        /// </summary>
        [EnumMember(Value = "USER_SUSPENDED")]
        UserSuspended,

        /// <summary>
        /// UserPendingRegistration.
        /// </summary>
        [EnumMember(Value = "USER_PENDING_REGISTRATION")]
        UserPendingRegistration,

        /// <summary>
        /// UserClosed.
        /// </summary>
        [EnumMember(Value = "USER_CLOSED")]
        UserClosed
    }
}