// <copyright file="AuthorizationObject.cs" company="APIMatic">
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
    /// AuthorizationObject.
    /// </summary>
    public class AuthorizationObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationObject"/> class.
        /// </summary>
        public AuthorizationObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationObject"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="sign">sign.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="status">status.</param>
        /// <param name="descriptions">descriptions.</param>
        /// <param name="authDate">authDate.</param>
        /// <param name="reference">reference.</param>
        public AuthorizationObject(
            Models.PrepaidCardAuthorizations? type = null,
            DateTime? createdOn = null,
            Models.Signs? sign = null,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            double? amount = 1.02,
            Models.Currencies? currency = Models.Currencies.Usd,
            Models.ReceiptStatuses? status = null,
            List<Models.Translation> descriptions = null,
            DateTime? authDate = null,
            string reference = null)
        {
            this.Type = type;
            this.CreatedOn = createdOn;
            this.Sign = sign;
            this.SourceToken = sourceToken;
            this.Amount = amount;
            this.Currency = currency;
            this.Status = status;
            this.Descriptions = descriptions;
            this.AuthDate = authDate;
            this.Reference = reference;
        }

        /// <summary>
        /// Financial types for the [prepaid card](page:resources/prepaid-cards) authorization.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaidCardAuthorizations? Type { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Receipt sign types
        /// </summary>
        [JsonProperty("sign", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Signs? Sign { get; set; }

        /// <summary>
        /// Unique identifier representing the [source of funds](#/rest/models/structures/source-token)
        /// </summary>
        [JsonProperty("sourceToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceToken { get; set; }

        /// <summary>
        /// Allocated money to be sent in the transaction.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? Currency { get; set; }

        /// <summary>
        /// Receipt status types
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReceiptStatuses? Status { get; set; }

        /// <summary>
        /// Gets or sets Descriptions.
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Translation> Descriptions { get; set; }

        /// <summary>
        /// Date that the auth was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("authDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AuthDate { get; set; }

        /// <summary>
        /// [Provider reference](#/rest/models/structures/identity-verification-provider-reference) used for performing identity checks for the provider
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AuthorizationObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AuthorizationObject other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.Sign == null && other.Sign == null ||
                 this.Sign?.Equals(other.Sign) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Descriptions == null && other.Descriptions == null ||
                 this.Descriptions?.Equals(other.Descriptions) == true) &&
                (this.AuthDate == null && other.AuthDate == null ||
                 this.AuthDate?.Equals(other.AuthDate) == true) &&
                (this.Reference == null && other.Reference == null ||
                 this.Reference?.Equals(other.Reference) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Sign = {(this.Sign == null ? "null" : this.Sign.ToString())}");
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Descriptions = {(this.Descriptions == null ? "null" : $"[{string.Join(", ", this.Descriptions)} ]")}");
            toStringOutput.Add($"AuthDate = {(this.AuthDate == null ? "null" : this.AuthDate.ToString())}");
            toStringOutput.Add($"Reference = {this.Reference ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}