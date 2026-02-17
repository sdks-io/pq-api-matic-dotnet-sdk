// <copyright file="PrepaidCardResult.cs" company="APIMatic">
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
    /// PrepaidCardResult.
    /// </summary>
    public class PrepaidCardResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardResult"/> class.
        /// </summary>
        public PrepaidCardResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="cardNetwork">cardNetwork.</param>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="cardPackage">cardPackage.</param>
        /// <param name="country">country.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="currency">currency.</param>
        /// <param name="cvv">cvv.</param>
        /// <param name="expires">expires.</param>
        /// <param name="status">status.</param>
        /// <param name="bankInDetails">bankInDetails.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="userToken">userToken.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public PrepaidCardResult(
            string token = null,
            Models.CardNetworks? cardNetwork = null,
            string cardNumber = null,
            string cardPackage = null,
            Models.Countries? country = null,
            DateTime? createdOn = null,
            Models.Currencies? currency = Models.Currencies.Usd,
            string cvv = null,
            string expires = null,
            Models.PrepaidCardStatuses? status = null,
            List<Models.BankAccountField> bankInDetails = null,
            List<Models.PrepaidCardCapabilities> capabilities = null,
            string userToken = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.CardNetwork = cardNetwork;
            this.CardNumber = cardNumber;
            this.CardPackage = cardPackage;
            this.Country = country;
            this.CreatedOn = createdOn;
            this.Currency = currency;
            this.Cvv = cvv;
            this.Expires = expires;
            this.Status = status;
            this.BankInDetails = bankInDetails;
            this.Capabilities = capabilities;
            this.UserToken = userToken;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Major [credit card network](#/rest/models/structures/card-network) types
        /// </summary>
        [JsonProperty("cardNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardNetworks? CardNetwork { get; set; }

        /// <summary>
        /// Unique number on the prepaid card
        /// </summary>
        [JsonProperty("cardNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNumber { get; set; }

        /// <summary>
        /// [Package](#/rest/models/structures/prepaid-card-package) for the card being displayed, including artwork, packaging, and delivery method
        /// </summary>
        [JsonProperty("cardPackage", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPackage { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? Country { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? Currency { get; set; }

        /// <summary>
        /// Three- or four-digit [Card Verification Value (CVV)](#/rest/models/structures/cvv) number displayed on the back of a credit or debit card
        /// </summary>
        [JsonProperty("cvv", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvv { get; set; }

        /// <summary>
        /// Date and time the object will [expire](#/rest/models/structures/expiration)
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public string Expires { get; set; }

        /// <summary>
        /// Current [status](#/rest/models/structures/prepaid-card-status) of the prepaid card
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaidCardStatuses? Status { get; set; }

        /// <summary>
        /// Gets or sets BankInDetails.
        /// </summary>
        [JsonProperty("bankInDetails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankAccountField> BankInDetails { get; set; }

        /// <summary>
        /// Gets or sets Capabilities.
        /// </summary>
        [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PrepaidCardCapabilities> Capabilities { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a user, prefixed with `user-`.
        /// </summary>
        [JsonProperty("userToken", NullValueHandling = NullValueHandling.Ignore)]
        public string UserToken { get; set; }

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
            return $"PrepaidCardResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidCardResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.CardNetwork == null && other.CardNetwork == null ||
                 this.CardNetwork?.Equals(other.CardNetwork) == true) &&
                (this.CardNumber == null && other.CardNumber == null ||
                 this.CardNumber?.Equals(other.CardNumber) == true) &&
                (this.CardPackage == null && other.CardPackage == null ||
                 this.CardPackage?.Equals(other.CardPackage) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Cvv == null && other.Cvv == null ||
                 this.Cvv?.Equals(other.Cvv) == true) &&
                (this.Expires == null && other.Expires == null ||
                 this.Expires?.Equals(other.Expires) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.BankInDetails == null && other.BankInDetails == null ||
                 this.BankInDetails?.Equals(other.BankInDetails) == true) &&
                (this.Capabilities == null && other.Capabilities == null ||
                 this.Capabilities?.Equals(other.Capabilities) == true) &&
                (this.UserToken == null && other.UserToken == null ||
                 this.UserToken?.Equals(other.UserToken) == true) &&
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
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"CardNetwork = {(this.CardNetwork == null ? "null" : this.CardNetwork.ToString())}");
            toStringOutput.Add($"CardNumber = {this.CardNumber ?? "null"}");
            toStringOutput.Add($"CardPackage = {this.CardPackage ?? "null"}");
            toStringOutput.Add($"Country = {(this.Country == null ? "null" : this.Country.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"Cvv = {this.Cvv ?? "null"}");
            toStringOutput.Add($"Expires = {this.Expires ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"BankInDetails = {(this.BankInDetails == null ? "null" : $"[{string.Join(", ", this.BankInDetails)} ]")}");
            toStringOutput.Add($"Capabilities = {(this.Capabilities == null ? "null" : $"[{string.Join(", ", this.Capabilities)} ]")}");
            toStringOutput.Add($"UserToken = {this.UserToken ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}