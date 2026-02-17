// <copyright file="BankAccountField.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// BankAccountField.
    /// </summary>
    public class BankAccountField : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountField"/> class.
        /// </summary>
        public BankAccountField()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountField"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="mValue">value.</param>
        public BankAccountField(
            Models.BankAccountFields key,
            string mValue)
        {
            this.Key = key;
            this.MValue = mValue;
        }

        /// <summary>
        /// Classifies bank account [field types](#/rest/models/structures/bank-account-fields)
        /// </summary>
        [JsonProperty("key")]
        public Models.BankAccountFields Key { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountField : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountField other &&
                (this.Key.Equals(other.Key)) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Key = {this.Key}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}