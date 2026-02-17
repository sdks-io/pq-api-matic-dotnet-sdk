// <copyright file="JobTypes.cs" company="APIMatic">
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
    /// JobTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobTypes
    {
        /// <summary>
        ///PAYMENTS.
        /// Payments.
        /// </summary>
        [EnumMember(Value = "PAYMENTS")]
        Payments,

        /// <summary>
        ///INVITATIONS.
        /// Invitations.
        /// </summary>
        [EnumMember(Value = "INVITATIONS")]
        Invitations
    }
}