// <copyright file="IdentityVerificationProviders.cs" company="APIMatic">
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
    /// IdentityVerificationProviders.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityVerificationProviders
    {
        /// <summary>
        /// Equifax.
        /// </summary>
        [EnumMember(Value = "EQUIFAX")]
        Equifax,

        /// <summary>
        /// W2.
        /// </summary>
        [EnumMember(Value = "W2")]
        W2,

        /// <summary>
        /// Fisidology.
        /// </summary>
        [EnumMember(Value = "FISIDOLOGY")]
        Fisidology,

        /// <summary>
        /// Ofacanalyzer.
        /// </summary>
        [EnumMember(Value = "OFACANALYZER")]
        Ofacanalyzer,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// Hooyu.
        /// </summary>
        [EnumMember(Value = "HOOYU")]
        Hooyu,

        /// <summary>
        /// Lexisnexisivi.
        /// </summary>
        [EnumMember(Value = "LEXISNEXISIVI")]
        Lexisnexisivi,

        /// <summary>
        /// Qolo.
        /// </summary>
        [EnumMember(Value = "QOLO")]
        Qolo
    }
}