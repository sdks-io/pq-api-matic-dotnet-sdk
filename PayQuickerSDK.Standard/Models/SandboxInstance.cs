// <copyright file="SandboxInstance.cs" company="APIMatic">
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
    /// SandboxInstance.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SandboxInstance
    {
        /// <summary>
        /// Sandbox.
        /// </summary>
        [EnumMember(Value = "sandbox")]
        Sandbox,

        /// <summary>
        /// Sbx1.
        /// </summary>
        [EnumMember(Value = "sbx1")]
        Sbx1,

        /// <summary>
        /// Sbx2.
        /// </summary>
        [EnumMember(Value = "sbx2")]
        Sbx2,

        /// <summary>
        /// Sbx3.
        /// </summary>
        [EnumMember(Value = "sbx3")]
        Sbx3,

        /// <summary>
        /// Sbx4.
        /// </summary>
        [EnumMember(Value = "sbx4")]
        Sbx4,

        /// <summary>
        /// Sbx5.
        /// </summary>
        [EnumMember(Value = "sbx5")]
        Sbx5,

        /// <summary>
        /// Sbx6.
        /// </summary>
        [EnumMember(Value = "sbx6")]
        Sbx6,

        /// <summary>
        /// Sbx7.
        /// </summary>
        [EnumMember(Value = "sbx7")]
        Sbx7,

        /// <summary>
        /// Sbx8.
        /// </summary>
        [EnumMember(Value = "sbx8")]
        Sbx8,

        /// <summary>
        /// Sbx9.
        /// </summary>
        [EnumMember(Value = "sbx9")]
        Sbx9,

        /// <summary>
        /// Sbx10.
        /// </summary>
        [EnumMember(Value = "sbx10")]
        Sbx10,

        /// <summary>
        /// Sbx11.
        /// </summary>
        [EnumMember(Value = "sbx11")]
        Sbx11
    }
}