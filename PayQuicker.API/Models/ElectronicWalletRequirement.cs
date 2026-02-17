// <copyright file="ElectronicWalletRequirement.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// ElectronicWalletRequirement.
    /// </summary>
    public class ElectronicWalletRequirement : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequirement"/> class.
        /// </summary>
        public ElectronicWalletRequirement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequirement"/> class.
        /// </summary>
        /// <param name="electronicWalletType">electronicWalletType.</param>
        /// <param name="electronicWalletCountry">electronicWalletCountry.</param>
        /// <param name="electronicWalletCurrency">electronicWalletCurrency.</param>
        /// <param name="fee">fee.</param>
        /// <param name="sourceCountry">sourceCountry.</param>
        /// <param name="sourceCurrency">sourceCurrency.</param>
        /// <param name="requirements">requirements.</param>
        public ElectronicWalletRequirement(
            Models.ElectronicWalletTypes? electronicWalletType = null,
            Models.Countries? electronicWalletCountry = null,
            Models.Currencies? electronicWalletCurrency = Models.Currencies.Usd,
            Models.FeeConfiguration fee = null,
            Models.Countries? sourceCountry = null,
            Models.Currencies? sourceCurrency = Models.Currencies.Usd,
            List<Models.ElectronicWalletRequiredFields> requirements = null)
        {
            this.ElectronicWalletType = electronicWalletType;
            this.ElectronicWalletCountry = electronicWalletCountry;
            this.ElectronicWalletCurrency = electronicWalletCurrency;
            this.Fee = fee;
            this.SourceCountry = sourceCountry;
            this.SourceCurrency = sourceCurrency;
            this.Requirements = requirements;
        }

        /// <summary>
        /// Name of the electronic wallet
        /// </summary>
        [JsonProperty("electronicWalletType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletTypes? ElectronicWalletType { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("electronicWalletCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? ElectronicWalletCountry { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("electronicWalletCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? ElectronicWalletCurrency { get; set; }

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
        public List<Models.ElectronicWalletRequiredFields> Requirements { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ElectronicWalletRequirement : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletRequirement other &&
                (this.ElectronicWalletType == null && other.ElectronicWalletType == null ||
                 this.ElectronicWalletType?.Equals(other.ElectronicWalletType) == true) &&
                (this.ElectronicWalletCountry == null && other.ElectronicWalletCountry == null ||
                 this.ElectronicWalletCountry?.Equals(other.ElectronicWalletCountry) == true) &&
                (this.ElectronicWalletCurrency == null && other.ElectronicWalletCurrency == null ||
                 this.ElectronicWalletCurrency?.Equals(other.ElectronicWalletCurrency) == true) &&
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
            toStringOutput.Add($"ElectronicWalletType = {(this.ElectronicWalletType == null ? "null" : this.ElectronicWalletType.ToString())}");
            toStringOutput.Add($"ElectronicWalletCountry = {(this.ElectronicWalletCountry == null ? "null" : this.ElectronicWalletCountry.ToString())}");
            toStringOutput.Add($"ElectronicWalletCurrency = {(this.ElectronicWalletCurrency == null ? "null" : this.ElectronicWalletCurrency.ToString())}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"SourceCountry = {(this.SourceCountry == null ? "null" : this.SourceCountry.ToString())}");
            toStringOutput.Add($"SourceCurrency = {(this.SourceCurrency == null ? "null" : this.SourceCurrency.ToString())}");
            toStringOutput.Add($"Requirements = {(this.Requirements == null ? "null" : $"[{string.Join(", ", this.Requirements)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}