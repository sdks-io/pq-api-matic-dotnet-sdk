// <copyright file="UploadFields.cs" company="APIMatic">
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
    /// UploadFields.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UploadFields
    {
        /// <summary>
        /// ExpirationDate.
        /// </summary>
        [EnumMember(Value = "EXPIRATION_DATE")]
        ExpirationDate,

        /// <summary>
        /// Status.
        /// </summary>
        [EnumMember(Value = "STATUS")]
        Status,

        /// <summary>
        /// Type.
        /// </summary>
        [EnumMember(Value = "TYPE")]
        Type
    }
}