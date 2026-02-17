// <copyright file="ElectronicWalletType.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ElectronicWalletType.
    /// </summary>
    public class ElectronicWalletType : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletType"/> class.
        /// </summary>
        public ElectronicWalletType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletType"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="electronicWalletCountry">electronicWalletCountry.</param>
        /// <param name="electronicWalletCurrency">electronicWalletCurrency.</param>
        public ElectronicWalletType(
            Models.ElectronicWalletTypes type,
            Models.Countries electronicWalletCountry,
            Models.Currencies electronicWalletCurrency)
        {
            this.Type = type;
            this.ElectronicWalletCountry = electronicWalletCountry;
            this.ElectronicWalletCurrency = electronicWalletCurrency;
        }

        /// <summary>
        /// Name of the electronic wallet
        /// </summary>
        [JsonProperty("type")]
        public Models.ElectronicWalletTypes Type { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("electronicWalletCountry")]
        public Models.Countries ElectronicWalletCountry { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("electronicWalletCurrency")]
        public Models.Currencies ElectronicWalletCurrency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ElectronicWalletType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletType other &&
                (this.Type.Equals(other.Type)) &&
                (this.ElectronicWalletCountry.Equals(other.ElectronicWalletCountry)) &&
                (this.ElectronicWalletCurrency.Equals(other.ElectronicWalletCurrency)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"ElectronicWalletCountry = {this.ElectronicWalletCountry}");
            toStringOutput.Add($"ElectronicWalletCurrency = {this.ElectronicWalletCurrency}");

            base.ToString(toStringOutput);
        }
    }
}