// <copyright file="ProgramTypes.cs" company="APIMatic">
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
    /// ProgramTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProgramTypes
    {
        /// <summary>
        /// Commercial.
        /// </summary>
        [EnumMember(Value = "COMMERCIAL")]
        Commercial,

        /// <summary>
        /// ConsumerDisbursement.
        /// </summary>
        [EnumMember(Value = "CONSUMER_DISBURSEMENT")]
        ConsumerDisbursement,

        /// <summary>
        /// ConsumerGpr.
        /// </summary>
        [EnumMember(Value = "CONSUMER_GPR")]
        ConsumerGpr,

        /// <summary>
        /// ConsumerLoyalty.
        /// </summary>
        [EnumMember(Value = "CONSUMER_LOYALTY")]
        ConsumerLoyalty
    }
}