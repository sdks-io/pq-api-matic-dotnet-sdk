// <copyright file="DocumentStatusTypes.cs" company="APIMatic">
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
    /// DocumentStatusTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentStatusTypes
    {
        /// <summary>
        /// NotProvided.
        /// </summary>
        [EnumMember(Value = "NOT_PROVIDED")]
        NotProvided,

        /// <summary>
        /// Provided.
        /// </summary>
        [EnumMember(Value = "PROVIDED")]
        Provided,

        /// <summary>
        /// UnderReview.
        /// </summary>
        [EnumMember(Value = "UNDER_REVIEW")]
        UnderReview,

        /// <summary>
        /// Approved.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        /// Rejected.
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        Rejected
    }
}