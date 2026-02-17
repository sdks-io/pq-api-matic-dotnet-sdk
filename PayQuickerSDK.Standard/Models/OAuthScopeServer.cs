// <copyright file="OAuthScopeServer.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// OAuthScopeServer.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OAuthScopeServer
    {
        /// <summary>
        ///readonly scope
        /// Readonly.
        /// </summary>
        [EnumMember(Value = "readonly")]
        Readonly,

        /// <summary>
        ///modify scope
        /// Modify.
        /// </summary>
        [EnumMember(Value = "modify")]
        Modify
    }

    internal static class OAuthScopeServerExtensions
    {
        internal static string GetValues(this IEnumerable<OAuthScopeServer> values) => values != null
            ? string.Join(" ", values.Select(s => s.GetValue()).Where(s => !string.IsNullOrEmpty(s)).ToArray())
            : null;

        private static string GetValue(this Enum value) =>
            value.GetType()
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == value.ToString())
                ?.GetCustomAttribute<EnumMemberAttribute>(false)
                ?.Value;
    }
}