// <copyright file="BusinessContactRoles.cs" company="APIMatic">
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
    /// BusinessContactRoles.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessContactRoles
    {
        /// <summary>
        /// Manager.
        /// </summary>
        [EnumMember(Value = "MANAGER")]
        Manager,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// Owner.
        /// </summary>
        [EnumMember(Value = "OWNER")]
        Owner,

        /// <summary>
        /// Partner.
        /// </summary>
        [EnumMember(Value = "PARTNER")]
        Partner
    }
}