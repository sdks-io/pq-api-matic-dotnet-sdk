// <copyright file="PaymentPurposes.cs" company="APIMatic">
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
    /// PaymentPurposes.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentPurposes
    {
        /// <summary>
        /// Bonus.
        /// </summary>
        [EnumMember(Value = "BONUS")]
        Bonus,

        /// <summary>
        /// Expense.
        /// </summary>
        [EnumMember(Value = "EXPENSE")]
        Expense,

        /// <summary>
        /// Income.
        /// </summary>
        [EnumMember(Value = "INCOME")]
        Income,

        /// <summary>
        /// NonTaxable.
        /// </summary>
        [EnumMember(Value = "NON_TAXABLE")]
        NonTaxable,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// Taxable.
        /// </summary>
        [EnumMember(Value = "TAXABLE")]
        Taxable,

        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        Undefined
    }
}