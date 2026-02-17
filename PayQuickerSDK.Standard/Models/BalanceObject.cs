// <copyright file="BalanceObject.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// BalanceObject.
    /// </summary>
    public class BalanceObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceObject"/> class.
        /// </summary>
        public BalanceObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceObject"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="formattedAmount">formattedAmount.</param>
        /// <param name="token">token.</param>
        /// <param name="links">links.</param>
        public BalanceObject(
            double amount,
            Models.Currencies currency,
            string formattedAmount,
            string token,
            List<Models.HateoasSelfRef> links = null)
        {
            this.Amount = amount;
            this.Currency = currency;
            this.FormattedAmount = formattedAmount;
            this.Token = token;
            this.Links = links;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BalanceObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BalanceObject other &&
                (this.Amount.Equals(other.Amount)) &&
                (this.Currency.Equals(other.Currency)) &&
                (this.FormattedAmount == null && other.FormattedAmount == null ||
                 this.FormattedAmount?.Equals(other.FormattedAmount) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
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

            base.ToString(toStringOutput);
        }
    }
}