// <copyright file="BalanceResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// BalanceResult.
    /// </summary>
    public class BalanceResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResult"/> class.
        /// </summary>
        public BalanceResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResult"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="formattedAmount">formattedAmount.</param>
        /// <param name="token">token.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public BalanceResult(
            double amount,
            Models.Currencies currency,
            string formattedAmount,
            string token,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Amount = amount;
            this.Currency = currency;
            this.FormattedAmount = formattedAmount;
            this.Token = token;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Amount of money in the account
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency")]
        public Models.Currencies Currency { get; set; }

        /// <summary>
        /// Combination of the amount and currency type
        /// </summary>
        [JsonProperty("formattedAmount")]
        public string FormattedAmount { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetadataItems Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BalanceResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BalanceResult other &&
                (this.Amount.Equals(other.Amount)) &&
                (this.Currency.Equals(other.Currency)) &&
                (this.FormattedAmount == null && other.FormattedAmount == null ||
                 this.FormattedAmount?.Equals(other.FormattedAmount) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Currency = {this.Currency}");
            toStringOutput.Add($"FormattedAmount = {this.FormattedAmount ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}