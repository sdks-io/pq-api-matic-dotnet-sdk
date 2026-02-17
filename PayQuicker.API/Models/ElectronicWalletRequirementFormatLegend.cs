// <copyright file="ElectronicWalletRequirementFormatLegend.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// ElectronicWalletRequirementFormatLegend.
    /// </summary>
    public class ElectronicWalletRequirementFormatLegend : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequirementFormatLegend"/> class.
        /// </summary>
        public ElectronicWalletRequirementFormatLegend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequirementFormatLegend"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="descriptions">descriptions.</param>
        public ElectronicWalletRequirementFormatLegend(
            string key = null,
            List<Models.Translation> descriptions = null)
        {
            this.Key = key;
            this.Descriptions = descriptions;
        }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// Localized requirement description for display purposes
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Translation> Descriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ElectronicWalletRequirementFormatLegend : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletRequirementFormatLegend other &&
                (this.Key == null && other.Key == null ||
                 this.Key?.Equals(other.Key) == true) &&
                (this.Descriptions == null && other.Descriptions == null ||
                 this.Descriptions?.Equals(other.Descriptions) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Key = {this.Key ?? "null"}");
            toStringOutput.Add($"Descriptions = {(this.Descriptions == null ? "null" : $"[{string.Join(", ", this.Descriptions)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}