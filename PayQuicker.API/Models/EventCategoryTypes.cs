// <copyright file="EventCategoryTypes.cs" company="APIMatic">
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
    /// EventCategoryTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventCategoryTypes
    {
        /// <summary>
        /// WalletRegistration.
        /// </summary>
        [EnumMember(Value = "WALLET_REGISTRATION")]
        WalletRegistration,

        /// <summary>
        /// PrepaidCardRegistration.
        /// </summary>
        [EnumMember(Value = "PREPAID_CARD_REGISTRATION")]
        PrepaidCardRegistration,

        /// <summary>
        /// UpdateRegistration.
        /// </summary>
        [EnumMember(Value = "UPDATE_REGISTRATION")]
        UpdateRegistration
    }
}