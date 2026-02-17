// <copyright file="BankTypes.cs" company="APIMatic">
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
    /// BankTypes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankTypes
    {
        /// <summary>
        /// Mcb.
        /// </summary>
        [EnumMember(Value = "MCB")]
        Mcb,

        /// <summary>
        /// Peoples.
        /// </summary>
        [EnumMember(Value = "PEOPLES")]
        Peoples,

        /// <summary>
        /// Pps.
        /// </summary>
        [EnumMember(Value = "PPS")]
        Pps,

        /// <summary>
        /// Toka.
        /// </summary>
        [EnumMember(Value = "TOKA")]
        Toka,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined,

        /// <summary>
        /// Choiceltd.
        /// </summary>
        [EnumMember(Value = "CHOICELTD")]
        Choiceltd,

        /// <summary>
        /// Flex.
        /// </summary>
        [EnumMember(Value = "FLEX")]
        Flex,

        /// <summary>
        /// Rewards.
        /// </summary>
        [EnumMember(Value = "REWARDS")]
        Rewards,

        /// <summary>
        /// Pathward.
        /// </summary>
        [EnumMember(Value = "PATHWARD")]
        Pathward,

        /// <summary>
        /// Sutton.
        /// </summary>
        [EnumMember(Value = "SUTTON")]
        Sutton
    }
}