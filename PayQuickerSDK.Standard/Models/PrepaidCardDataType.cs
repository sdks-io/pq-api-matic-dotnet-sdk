// <copyright file="PrepaidCardDataType.cs" company="APIMatic">
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
    /// PrepaidCardDataType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaidCardDataType
    {
        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "TEXT")]
        Text,

        /// <summary>
        /// Image.
        /// </summary>
        [EnumMember(Value = "IMAGE")]
        Image
    }
}