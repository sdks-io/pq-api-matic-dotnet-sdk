// <copyright file="ElectronicWalletFields.cs" company="APIMatic">
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
    /// ElectronicWalletFields.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectronicWalletFields
    {
        /// <summary>
        ///Unknown or unrecognized.
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        ///Used for credit party identifier. For example,`012345678`.
        /// AccountNumber.
        /// </summary>
        [EnumMember(Value = "ACCOUNT_NUMBER")]
        AccountNumber,

        /// <summary>
        ///Used for credit party identifier. For example,`012345678`.
        /// GovernmentId.
        /// </summary>
        [EnumMember(Value = "GOVERNMENT_ID")]
        GovernmentId
    }
}