// <copyright file="LockSideTypes.cs" company="APIMatic">
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
    /// LockSideTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LockSideTypes
    {
        /// <summary>
        /// Source.
        /// </summary>
        [EnumMember(Value = "SOURCE")]
        Source,

        /// <summary>
        /// Destination.
        /// </summary>
        [EnumMember(Value = "DESTINATION")]
        Destination
    }
}