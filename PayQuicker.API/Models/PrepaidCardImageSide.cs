// <copyright file="PrepaidCardImageSide.cs" company="APIMatic">
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