// <copyright file="ExpectedDeliveryTypes.cs" company="APIMatic">
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
    /// ExpectedDeliveryTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpectedDeliveryTypes
    {
        /// <summary>
        /// SameDay.
        /// </summary>
        [EnumMember(Value = "SAME_DAY")]
        SameDay,

        /// <summary>
        /// NextBankingDay.
        /// </summary>
        [EnumMember(Value = "NEXT_BANKING_DAY")]
        NextBankingDay
    }
}