// <copyright file="FxRate.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// FxRate.
    /// </summary>
    public class FxRate : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxRate"/> class.
        /// </summary>
        public FxRate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FxRate"/> class.
        /// </summary>
        /// <param name="destinationAmount">destinationAmount.</param>
        /// <param name="destinationCurrency">destinationCurrency.</param>
        /// <param name="destinationFormattedAmount">destinationFormattedAmount.</param>
        /// <param name="rate">rate.</param>
        /// <param name="sourceAmount">sourceAmount.</param>
        /// <param name="sourceCurrency">sourceCurrency.</param>
        /// <param name="sourceFormattedAmount">sourceFormattedAmount.</param>
        public FxRate(
            double? destinationAmount = null,
            Models.Currencies? destinationCurrency = Models.Currencies.Usd,
            string destinationFormattedAmount = "$0.05 USD",
            double? rate = null,
            double? sourceAmount = 1.02,
            Models.Currencies? sourceCurrency = Models.Currencies.Usd,
            string sourceFormattedAmount = "$0.05 USD")
        {
            this.DestinationAmount = destinationAmount;
            this.DestinationCurrency = destinationCurrency;
            this.DestinationFormattedAmount = destinationFormattedAmount;
            this.Rate = rate;
            this.SourceAmount = sourceAmount;
            this.SourceCurrency = sourceCurrency;
            this.SourceFormattedAmount = sourceFormattedAmount;
        }

        /// <summary>
        /// Allocated money to be sent in the transaction.
        /// </summary>
        [JsonProperty("destinationAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? DestinationAmount { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("destinationCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? DestinationCurrency { get; set; }

        /// <summary>
        /// Combination of the amount and currency type
        /// </summary>
        [JsonProperty("destinationFormattedAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationFormattedAmount { get; set; }

        /// <summary>
        /// Exchange [rate](#/rest/models/structures/rate)
        /// </summary>
        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate { get; set; }

        /// <summary>
        /// Allocated money to be sent in the transaction.
        /// </summary>
        [JsonProperty("sourceAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? SourceAmount { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("sourceCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? SourceCurrency { get; set; }

        /// <summary>
        /// Combination of the amount and currency type
        /// </summary>
        [JsonProperty("sourceFormattedAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFormattedAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FxRate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FxRate other &&
                (this.DestinationAmount == null && other.DestinationAmount == null ||
                 this.DestinationAmount?.Equals(other.DestinationAmount) == true) &&
                (this.DestinationCurrency == null && other.DestinationCurrency == null ||
                 this.DestinationCurrency?.Equals(other.DestinationCurrency) == true) &&
                (this.DestinationFormattedAmount == null && other.DestinationFormattedAmount == null ||
                 this.DestinationFormattedAmount?.Equals(other.DestinationFormattedAmount) == true) &&
                (this.Rate == null && other.Rate == null ||
                 this.Rate?.Equals(other.Rate) == true) &&
                (this.SourceAmount == null && other.SourceAmount == null ||
                 this.SourceAmount?.Equals(other.SourceAmount) == true) &&
                (this.SourceCurrency == null && other.SourceCurrency == null ||
                 this.SourceCurrency?.Equals(other.SourceCurrency) == true) &&
                (this.SourceFormattedAmount == null && other.SourceFormattedAmount == null ||
                 this.SourceFormattedAmount?.Equals(other.SourceFormattedAmount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DestinationAmount = {(this.DestinationAmount == null ? "null" : this.DestinationAmount.ToString())}");
            toStringOutput.Add($"DestinationCurrency = {(this.DestinationCurrency == null ? "null" : this.DestinationCurrency.ToString())}");
            toStringOutput.Add($"DestinationFormattedAmount = {this.DestinationFormattedAmount ?? "null"}");
            toStringOutput.Add($"Rate = {(this.Rate == null ? "null" : this.Rate.ToString())}");
            toStringOutput.Add($"SourceAmount = {(this.SourceAmount == null ? "null" : this.SourceAmount.ToString())}");
            toStringOutput.Add($"SourceCurrency = {(this.SourceCurrency == null ? "null" : this.SourceCurrency.ToString())}");
            toStringOutput.Add($"SourceFormattedAmount = {this.SourceFormattedAmount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}