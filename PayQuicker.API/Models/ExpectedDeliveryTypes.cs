// <copyright file="ExpectedDeliveryTypes.cs" company="APIMatic">
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