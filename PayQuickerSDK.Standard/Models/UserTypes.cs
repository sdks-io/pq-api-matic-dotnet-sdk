// <copyright file="UserTypes.cs" company="APIMatic">
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
    /// UserTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserTypes
    {
        /// <summary>
        /// Business.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        Business,

        /// <summary>
        /// Individual.
        /// </summary>
        [EnumMember(Value = "INDIVIDUAL")]
        Individual
    }
}