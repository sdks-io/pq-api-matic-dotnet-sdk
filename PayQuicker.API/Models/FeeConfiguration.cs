// <copyright file="FeeConfiguration.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// FeeConfiguration.
    /// </summary>
    public class FeeConfiguration : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeConfiguration"/> class.
        /// </summary>
        public FeeConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeConfiguration"/> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="distribution">distribution.</param>
        /// <param name="source">source.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="transactionAmount">transactionAmount.</param>
        /// <param name="type">type.</param>
        /// <param name="valueAmount">valueAmount.</param>
        /// <param name="valueType">valueType.</param>
        public FeeConfiguration(
            Models.CategoryTypes? category = null,
            List<Models.FeeDistribution> distribution = null,
            Models.FeeSources? source = null,
            double? totalAmount = null,
            double? transactionAmount = null,
            Models.Fees? type = null,
            string valueAmount = null,
            Models.FeeValues? valueType = null)
        {
            this.Category = category;
            this.Distribution = distribution;
            this.Source = source;
            this.TotalAmount = totalAmount;
            this.TransactionAmount = transactionAmount;
            this.Type = type;
            this.ValueAmount = valueAmount;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Category types
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CategoryTypes? Category { get; set; }

        /// <summary>
        /// Gets or sets Distribution.
        /// </summary>
        [JsonProperty("distribution", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FeeDistribution> Distribution { get; set; }

        /// <summary>
        /// Fee source types
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeSources? Source { get; set; }

        /// <summary>
        /// Total amount of money for all transactions
        /// </summary>
        [JsonProperty("totalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAmount { get; set; }

        /// <summary>
        /// Total amount of money for the transaction
        /// </summary>
        [JsonProperty("transactionAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// Fee types
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fees? Type { get; set; }

        /// <summary>
        /// Value of the target resource
        /// </summary>
        [JsonProperty("valueAmount", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueAmount { get; set; }

        /// <summary>
        /// Fee value types
        /// </summary>
        [JsonProperty("valueType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeValues? ValueType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FeeConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FeeConfiguration other &&
                (this.Category == null && other.Category == null ||
                 this.Category?.Equals(other.Category) == true) &&
                (this.Distribution == null && other.Distribution == null ||
                 this.Distribution?.Equals(other.Distribution) == true) &&
                (this.Source == null && other.Source == null ||
                 this.Source?.Equals(other.Source) == true) &&
                (this.TotalAmount == null && other.TotalAmount == null ||
                 this.TotalAmount?.Equals(other.TotalAmount) == true) &&
                (this.TransactionAmount == null && other.TransactionAmount == null ||
                 this.TransactionAmount?.Equals(other.TransactionAmount) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.ValueAmount == null && other.ValueAmount == null ||
                 this.ValueAmount?.Equals(other.ValueAmount) == true) &&
                (this.ValueType == null && other.ValueType == null ||
                 this.ValueType?.Equals(other.ValueType) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Category = {(this.Category == null ? "null" : this.Category.ToString())}");
            toStringOutput.Add($"Distribution = {(this.Distribution == null ? "null" : $"[{string.Join(", ", this.Distribution)} ]")}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount.ToString())}");
            toStringOutput.Add($"TransactionAmount = {(this.TransactionAmount == null ? "null" : this.TransactionAmount.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"ValueAmount = {this.ValueAmount ?? "null"}");
            toStringOutput.Add($"ValueType = {(this.ValueType == null ? "null" : this.ValueType.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}