// <copyright file="Environment.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PayQuickerSDK.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production.
        /// </summary>
        [EnumMember(Value = "production")]
        Production,

        /// <summary>
        /// Sandbox is used for both sandbox testing and customer UAT..
        /// </summary>
        [EnumMember(Value = "sandbox")]
        Sandbox,

        /// <summary>
        /// UAT is used for both sandbox testing and customer UAT..
        /// </summary>
        [EnumMember(Value = "uat")]
        Uat,

        /// <summary>
        /// Development is used for local development testing..
        /// </summary>
        [EnumMember(Value = "development")]
        Development,
    }
}
