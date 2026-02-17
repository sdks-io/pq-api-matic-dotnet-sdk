// <copyright file="ElectronicWalletObject.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ElectronicWalletObject.
    /// </summary>
    public class ElectronicWalletObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletObject"/> class.
        /// </summary>
        public ElectronicWalletObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletObject"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="type">type.</param>
        /// <param name="electronicWalletCountry">electronicWalletCountry.</param>
        /// <param name="electronicWalletCurrency">electronicWalletCurrency.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="fields">fields.</param>
        /// <param name="status">status.</param>
        /// <param name="links">links.</param>
        public ElectronicWalletObject(
            string token = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            Models.ElectronicWalletTypes? type = null,
            Models.Countries? electronicWalletCountry = null,
            Models.Currencies? electronicWalletCurrency = Models.Currencies.Usd,
            DateTime? createdOn = null,
            List<Models.ElectronicWalletField> fields = null,
            Models.ElectronicWalletStatuses? status = null,
            List<Models.HateoasSelfRef> links = null)
        {
            this.Token = token;
            this.Type = type;
            this.ElectronicWalletCountry = electronicWalletCountry;
            this.ElectronicWalletCurrency = electronicWalletCurrency;
            this.CreatedOn = createdOn;
            this.Fields = fields;
            this.Status = status;
            this.Links = links;
        }

        /// <summary>
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

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
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ElectronicWalletField> Fields { get; set; }

        /// <summary>
        /// Current verification status type of the electronic wallet
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletStatuses? Status { get; set; }

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
            return $"ElectronicWalletObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletObject other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.ElectronicWalletCountry == null && other.ElectronicWalletCountry == null ||
                 this.ElectronicWalletCountry?.Equals(other.ElectronicWalletCountry) == true) &&
                (this.ElectronicWalletCurrency == null && other.ElectronicWalletCurrency == null ||
                 this.ElectronicWalletCurrency?.Equals(other.ElectronicWalletCurrency) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
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
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"ElectronicWalletCountry = {(this.ElectronicWalletCountry == null ? "null" : this.ElectronicWalletCountry.ToString())}");
            toStringOutput.Add($"ElectronicWalletCurrency = {(this.ElectronicWalletCurrency == null ? "null" : this.ElectronicWalletCurrency.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : $"[{string.Join(", ", this.Fields)} ]")}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}