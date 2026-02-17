// <copyright file="ElectronicTransferStatusTypes.cs" company="APIMatic">
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
    /// ElectronicTransferStatusTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicTransferStatusTypes
    {
        /// <summary>
        ///The bank transfer has been started to the destination bank.
        /// InProgress.
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        ///The bank transfer has been performed and the funds have arrived in the destination bank.
        /// Processed.
        /// </summary>
        [EnumMember(Value = "PROCESSED")]
        Processed,

        /// <summary>
        ///The bank transfer has failed and the funds have been sent back to the source account.
        /// Failed.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        Failed,

        /// <summary>
        ///The bank transfer has failed.
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Refunded
    }
}