// <copyright file="ElectronicFundsTransferTypes.cs" company="APIMatic">
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
    /// ElectronicFundsTransferTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicFundsTransferTypes
    {
        /// <summary>
        /// Manual.
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        Manual,

        /// <summary>
        /// Automatic.
        /// </summary>
        [EnumMember(Value = "AUTOMATIC")]
        Automatic
    }
}