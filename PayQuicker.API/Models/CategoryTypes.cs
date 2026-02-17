// <copyright file="CategoryTypes.cs" company="APIMatic">
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
    /// CategoryTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryTypes
    {
        /// <summary>
        /// Company.
        /// </summary>
        [EnumMember(Value = "COMPANY")]
        Company,

        /// <summary>
        /// User.
        /// </summary>
        [EnumMember(Value = "USER")]
        User
    }
}