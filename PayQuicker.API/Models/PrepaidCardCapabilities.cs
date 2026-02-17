// <copyright file="PrepaidCardCapabilities.cs" company="APIMatic">
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
    /// PrepaidCardCapabilities.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaidCardCapabilities
    {
        /// <summary>
        ///The prepaid card supports ApplePay and can be added to an iOS device.
        /// Applepay.
        /// </summary>
        [EnumMember(Value = "APPLEPAY")]
        Applepay,

        /// <summary>
        ///The prepaid card supports banking details that allow for loads (i.e., direct deposit).
        /// BankIn.
        /// </summary>
        [EnumMember(Value = "BANK_IN")]
        BankIn,

        /// <summary>
        ///The prepaid card supports transfers to external bank accounts.
        /// BankOut.
        /// </summary>
        [EnumMember(Value = "BANK_OUT")]
        BankOut,

        /// <summary>
        ///The prepaid card supports Google Pay and can be added to a supported Android device.
        /// Googlepay.
        /// </summary>
        [EnumMember(Value = "GOOGLEPAY")]
        Googlepay,

        /// <summary>
        ///The prepaid card supports revealing the card details or rendered card image via the API.
        /// RevealCard.
        /// </summary>
        [EnumMember(Value = "REVEAL_CARD")]
        RevealCard,

        /// <summary>
        ///TO BE DONE
        /// RevealPin.
        /// </summary>
        [EnumMember(Value = "REVEAL_PIN")]
        RevealPin,

        /// <summary>
        ///The prepaid card supports Samsung Pay and can be added to a supported Samsung device.
        /// Samsungpay.
        /// </summary>
        [EnumMember(Value = "SAMSUNGPAY")]
        Samsungpay,

        /// <summary>
        ///The prepaid card supports setting the PIN via the API.
        /// SetPin.
        /// </summary>
        [EnumMember(Value = "SET_PIN")]
        SetPin,

        /// <summary>
        ///The prepaid card supports contactless transactions at supported terminals.
        /// Contactless.
        /// </summary>
        [EnumMember(Value = "CONTACTLESS")]
        Contactless
    }
}