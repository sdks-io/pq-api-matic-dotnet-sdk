// <copyright file="BankAccountRequirement.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// BankAccountRequirement.
    /// </summary>
    public class BankAccountRequirement : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequirement"/> class.
        /// </summary>
        public BankAccountRequirement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequirement"/> class.
        /// </summary>
        /// <param name="bankCountry">bankCountry.</param>
        /// <param name="bankCurrency">bankCurrency.</param>
        /// <param name="fee">fee.</param>
        /// <param name="sourceCountry">sourceCountry.</param>
        /// <param name="sourceCurrency">sourceCurrency.</param>
        /// <param name="requirements">requirements.</param>
        public BankAccountRequirement(
            Models.Countries? bankCountry = null,
            Models.Currencies? bankCurrency = Models.Currencies.Usd,
            Models.FeeConfiguration fee = null,
            Models.Countries? sourceCountry = null,
            Models.Currencies? sourceCurrency = Models.Currencies.Usd,
            List<Models.BankAccountRequiredFields> requirements = null)
        {
            this.BankCountry = bankCountry;
            this.BankCurrency = bankCurrency;
            this.Fee = fee;
            this.SourceCountry = sourceCountry;
            this.SourceCurrency = sourceCurrency;
            this.Requirements = requirements;
        }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("bankCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? BankCountry { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("bankCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? BankCurrency { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeConfiguration Fee { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("sourceCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? SourceCountry { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("sourceCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? SourceCurrency { get; set; }

        /// <summary>
        /// Gets or sets Requirements.
        /// </summary>
        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankAccountRequiredFields> Requirements { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountRequirement : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountRequirement other &&
                (this.BankCountry == null && other.BankCountry == null ||
                 this.BankCountry?.Equals(other.BankCountry) == true) &&
                (this.BankCurrency == null && other.BankCurrency == null ||
                 this.BankCurrency?.Equals(other.BankCurrency) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.SourceCountry == null && other.SourceCountry == null ||
                 this.SourceCountry?.Equals(other.SourceCountry) == true) &&
                (this.SourceCurrency == null && other.SourceCurrency == null ||
                 this.SourceCurrency?.Equals(other.SourceCurrency) == true) &&
                (this.Requirements == null && other.Requirements == null ||
                 this.Requirements?.Equals(other.Requirements) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BankCountry = {(this.BankCountry == null ? "null" : this.BankCountry.ToString())}");
            toStringOutput.Add($"BankCurrency = {(this.BankCurrency == null ? "null" : this.BankCurrency.ToString())}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"SourceCountry = {(this.SourceCountry == null ? "null" : this.SourceCountry.ToString())}");
            toStringOutput.Add($"SourceCurrency = {(this.SourceCurrency == null ? "null" : this.SourceCurrency.ToString())}");
            toStringOutput.Add($"Requirements = {(this.Requirements == null ? "null" : $"[{string.Join(", ", this.Requirements)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}