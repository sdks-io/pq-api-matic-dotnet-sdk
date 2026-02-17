// <copyright file="FeeDistribution.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// FeeDistribution.
    /// </summary>
    public class FeeDistribution : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeDistribution"/> class.
        /// </summary>
        public FeeDistribution()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeDistribution"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="description">description.</param>
        /// <param name="formattedAmount">formattedAmount.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="responsibility">responsibility.</param>
        /// <param name="responsibilitySource">responsibilitySource.</param>
        /// <param name="sourceToken">sourceToken.</param>
        public FeeDistribution(
            double? amount = 1.02,
            Models.Currencies? currency = Models.Currencies.Usd,
            List<Models.ReceiptDescriptions> description = null,
            string formattedAmount = "$0.05 USD",
            double? percentage = null,
            Models.FeeResponsibilityParties? responsibility = null,
            Models.FeeResponsibilitySources? responsibilitySource = null,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860")
        {
            this.Amount = amount;
            this.Currency = currency;
            this.Description = description;
            this.FormattedAmount = formattedAmount;
            this.Percentage = percentage;
            this.Responsibility = responsibility;
            this.ResponsibilitySource = responsibilitySource;
            this.SourceToken = sourceToken;
        }

        /// <summary>
        /// Allocated money to be sent in the transaction.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? Currency { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReceiptDescriptions> Description { get; set; }

        /// <summary>
        /// Combination of the amount and currency type
        /// </summary>
        [JsonProperty("formattedAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string FormattedAmount { get; set; }

        /// <summary>
        /// Fee percentage that the responsible account pays
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }

        /// <summary>
        /// Fee responsibility types
        /// </summary>
        [JsonProperty("responsibility", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeResponsibilityParties? Responsibility { get; set; }

        /// <summary>
        /// Fee responsibility source types
        /// </summary>
        [JsonProperty("responsibilitySource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeResponsibilitySources? ResponsibilitySource { get; set; }

        /// <summary>
        /// Unique identifier representing the [source of funds](#/rest/models/structures/source-token)
        /// </summary>
        [JsonProperty("sourceToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeeDistribution : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeeDistribution other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.FormattedAmount == null && other.FormattedAmount == null ||
                 this.FormattedAmount?.Equals(other.FormattedAmount) == true) &&
                (this.Percentage == null && other.Percentage == null ||
                 this.Percentage?.Equals(other.Percentage) == true) &&
                (this.Responsibility == null && other.Responsibility == null ||
                 this.Responsibility?.Equals(other.Responsibility) == true) &&
                (this.ResponsibilitySource == null && other.ResponsibilitySource == null ||
                 this.ResponsibilitySource?.Equals(other.ResponsibilitySource) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"Description = {(this.Description == null ? "null" : $"[{string.Join(", ", this.Description)} ]")}");
            toStringOutput.Add($"FormattedAmount = {this.FormattedAmount ?? "null"}");
            toStringOutput.Add($"Percentage = {(this.Percentage == null ? "null" : this.Percentage.ToString())}");
            toStringOutput.Add($"Responsibility = {(this.Responsibility == null ? "null" : this.Responsibility.ToString())}");
            toStringOutput.Add($"ResponsibilitySource = {(this.ResponsibilitySource == null ? "null" : this.ResponsibilitySource.ToString())}");
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}