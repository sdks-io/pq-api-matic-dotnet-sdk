// <copyright file="ElectronicWalletField.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ElectronicWalletField.
    /// </summary>
    public class ElectronicWalletField : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletField"/> class.
        /// </summary>
        public ElectronicWalletField()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletField"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="mValue">value.</param>
        public ElectronicWalletField(
            Models.ElectronicWalletFields key,
            string mValue)
        {
            this.Key = key;
            this.MValue = mValue;
        }

        /// <summary>
        /// Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields)
        /// </summary>
        [JsonProperty("key")]
        public Models.ElectronicWalletFields Key { get; set; }

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
            return $"ElectronicWalletField : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletField other &&
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