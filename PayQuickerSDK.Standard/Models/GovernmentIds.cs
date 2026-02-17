// <copyright file="GovernmentIds.cs" company="APIMatic">
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
    /// GovernmentIds.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GovernmentIds
    {
        /// <summary>
        ///Identity code for both citizens and residents of Mexico.
        /// Curp.
        /// </summary>
        [EnumMember(Value = "CURP")]
        Curp,

        /// <summary>
        ///Identity card with a photo issued by an official authority.
        /// NationalIdCard.
        /// </summary>
        [EnumMember(Value = "NATIONAL_ID_CARD")]
        NationalIdCard,

        /// <summary>
        ///Travel document that certifies the identity and nationality of its holder.
        /// Passport.
        /// </summary>
        [EnumMember(Value = "PASSPORT")]
        Passport,

        /// <summary>
        ///Social Security number for citizens of the United States.
        /// Ssn.
        /// </summary>
        [EnumMember(Value = "SSN")]
        Ssn
    }
}