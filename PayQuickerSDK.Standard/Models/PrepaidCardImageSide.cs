// <copyright file="PrepaidCardImageSide.cs" company="APIMatic">
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
    /// PrepaidCardImageSide.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaidCardImageSide
    {
        /// <summary>
        /// Front.
        /// </summary>
        [EnumMember(Value = "FRONT")]
        Front,

        /// <summary>
        /// Back.
        /// </summary>
        [EnumMember(Value = "BACK")]
        Back
    }
}