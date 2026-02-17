// <copyright file="CardNetworks.cs" company="APIMatic">
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
    /// CardNetworks.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardNetworks
    {
        /// <summary>
        /// MasterCard.
        /// </summary>
        [EnumMember(Value = "MASTER_CARD")]
        MasterCard,

        /// <summary>
        /// Visa.
        /// </summary>
        [EnumMember(Value = "VISA")]
        Visa
    }
}