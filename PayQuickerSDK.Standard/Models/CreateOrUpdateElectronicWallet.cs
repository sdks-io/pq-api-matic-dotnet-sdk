// <copyright file="CreateOrUpdateElectronicWallet.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// CreateOrUpdateElectronicWallet.
    /// </summary>
    public class CreateOrUpdateElectronicWallet : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateElectronicWallet"/> class.
        /// </summary>
        public CreateOrUpdateElectronicWallet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateElectronicWallet"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="electronicWalletCountry">electronicWalletCountry.</param>
        /// <param name="electronicWalletCurrency">electronicWalletCurrency.</param>
        /// <param name="fields">fields.</param>
        public CreateOrUpdateElectronicWallet(
            Models.ElectronicWalletTypes? type = null,
            Models.Countries? electronicWalletCountry = null,
            Models.Currencies? electronicWalletCurrency = Models.Currencies.Usd,
            List<Models.ElectronicWalletField> fields = null)
        {
            this.Type = type;
            this.ElectronicWalletCountry = electronicWalletCountry;
            this.ElectronicWalletCurrency = electronicWalletCurrency;
            this.Fields = fields;
        }

        /// <summary>
        /// Name of the electronic wallet
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletTypes? Type { get; set; }

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
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ElectronicWalletField> Fields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrUpdateElectronicWallet : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateElectronicWallet other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.ElectronicWalletCountry == null && other.ElectronicWalletCountry == null ||
                 this.ElectronicWalletCountry?.Equals(other.ElectronicWalletCountry) == true) &&
                (this.ElectronicWalletCurrency == null && other.ElectronicWalletCurrency == null ||
                 this.ElectronicWalletCurrency?.Equals(other.ElectronicWalletCurrency) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"ElectronicWalletCountry = {(this.ElectronicWalletCountry == null ? "null" : this.ElectronicWalletCountry.ToString())}");
            toStringOutput.Add($"ElectronicWalletCurrency = {(this.ElectronicWalletCurrency == null ? "null" : this.ElectronicWalletCurrency.ToString())}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : $"[{string.Join(", ", this.Fields)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}