// <copyright file="IdentityVerificationResultTypes.cs" company="APIMatic">
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
    /// IdentityVerificationResultTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityVerificationResultTypes
    {
        /// <summary>
        /// Pass.
        /// </summary>
        [EnumMember(Value = "PASS")]
        Pass,

        /// <summary>
        /// ServiceOffline.
        /// </summary>
        [EnumMember(Value = "SERVICE_OFFLINE")]
        ServiceOffline,

        /// <summary>
        /// Fail.
        /// </summary>
        [EnumMember(Value = "FAIL")]
        Fail,

        /// <summary>
        /// Processing.
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        Processing,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// Notyetexecuted.
        /// </summary>
        [EnumMember(Value = "NOTYETEXECUTED")]
        Notyetexecuted,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        Expired
    }
}