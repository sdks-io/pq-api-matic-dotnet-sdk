// <copyright file="TokenPurposes.cs" company="APIMatic">
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
    /// TokenPurposes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenPurposes
    {
        /// <summary>
        /// CardOperation.
        /// </summary>
        [EnumMember(Value = "CARD_OPERATION")]
        CardOperation,

        /// <summary>
        /// PinOperation.
        /// </summary>
        [EnumMember(Value = "PIN_OPERATION")]
        PinOperation
    }
}