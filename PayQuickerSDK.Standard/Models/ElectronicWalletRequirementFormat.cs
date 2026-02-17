// <copyright file="ElectronicWalletRequirementFormat.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ElectronicWalletRequirementFormat.
    /// </summary>
    public class ElectronicWalletRequirementFormat : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequirementFormat"/> class.
        /// </summary>
        public ElectronicWalletRequirementFormat()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequirementFormat"/> class.
        /// </summary>
        /// <param name="example">example.</param>
        /// <param name="legend">legend.</param>
        public ElectronicWalletRequirementFormat(
            string example = null,
            List<Models.ElectronicWalletRequirementFormatLegend> legend = null)
        {
            this.Example = example;
            this.Legend = legend;
        }

        /// <summary>
        /// Example of a requirement generated from the validator(s)
        /// </summary>
        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public string Example { get; set; }

        /// <summary>
        /// Gets or sets Legend.
        /// </summary>
        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ElectronicWalletRequirementFormatLegend> Legend { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ElectronicWalletRequirementFormat : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletRequirementFormat other &&
                (this.Example == null && other.Example == null ||
                 this.Example?.Equals(other.Example) == true) &&
                (this.Legend == null && other.Legend == null ||
                 this.Legend?.Equals(other.Legend) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Example = {this.Example ?? "null"}");
            toStringOutput.Add($"Legend = {(this.Legend == null ? "null" : $"[{string.Join(", ", this.Legend)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}