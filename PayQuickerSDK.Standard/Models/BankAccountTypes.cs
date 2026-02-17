// <copyright file="BankAccountTypes.cs" company="APIMatic">
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
    /// BankAccountTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountTypes
    {
        /// <summary>
        ///An account at a financial institution against which checks can be drawn by the account depositor.
        /// Checking.
        /// </summary>
        [EnumMember(Value = "CHECKING")]
        Checking,

        /// <summary>
        ///An interest-bearing account at a bank or credit union.
        /// MoneyMarket.
        /// </summary>
        [EnumMember(Value = "MONEY_MARKET")]
        MoneyMarket,

        /// <summary>
        ///An account at a financial institution that pays interest but cannot be used directly as money in the narrow sense of a medium of exchange.
        /// Savings.
        /// </summary>
        [EnumMember(Value = "SAVINGS")]
        Savings,

        /// <summary>
        ///Unknown or unrecognized.
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}