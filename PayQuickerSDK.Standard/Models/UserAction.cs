// <copyright file="UserAction.cs" company="APIMatic">
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
    /// UserAction.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserAction
    {
        /// <summary>
        /// NoAction.
        /// </summary>
        [EnumMember(Value = "NO_ACTION")]
        NoAction,

        /// <summary>
        /// UploadDocuments.
        /// </summary>
        [EnumMember(Value = "UPLOAD_DOCUMENTS")]
        UploadDocuments,

        /// <summary>
        /// ReviseDocuments.
        /// </summary>
        [EnumMember(Value = "REVISE_DOCUMENTS")]
        ReviseDocuments
    }
}