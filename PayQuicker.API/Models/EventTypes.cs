// <copyright file="EventTypes.cs" company="APIMatic">
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
    /// EventTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventTypes
    {
        /// <summary>
        /// Required.
        /// </summary>
        [EnumMember(Value = "REQUIRED")]
        Required,

        /// <summary>
        /// Optional.
        /// </summary>
        [EnumMember(Value = "OPTIONAL")]
        Optional
    }
}