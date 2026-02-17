// <copyright file="GatewayPaymentQuote.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// GatewayPaymentQuote.
    /// </summary>
    public class GatewayPaymentQuote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPaymentQuote"/> class.
        /// </summary>
        public GatewayPaymentQuote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPaymentQuote"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="note">note.</param>
        /// <param name="memo">memo.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="clientPaymentId">clientPaymentId.</param>
        /// <param name="autoAcceptQuote">autoAcceptQuote.</param>
        /// <param name="notBefore">notBefore.</param>
        /// <param name="notAfter">notAfter.</param>
        public GatewayPaymentQuote(
            double? amount = 1.02,
            Models.Currencies? currency = Models.Currencies.Usd,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            string note = null,
            string memo = null,
            Models.PaymentPurposes? purpose = null,
            string clientPaymentId = "d4b6f130-1d1c-4ce2-903a-0c1ad128f55e",
            bool? autoAcceptQuote = null,
            DateTime? notBefore = null,
            DateTime? notAfter = null)
        {
            this.Amount = amount;
            this.Currency = currency;
            this.SourceToken = sourceToken;
            this.DestinationToken = destinationToken;
            this.Note = note;
            this.Memo = memo;
            this.Purpose = purpose;
            this.ClientPaymentId = clientPaymentId;
            this.AutoAcceptQuote = autoAcceptQuote;
            this.NotBefore = notBefore;
            this.NotAfter = notAfter;
        }

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
        /// Unique identifier representing the [source of funds](#/rest/models/structures/source-token)
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("sourceToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceToken { get; set; }

        /// <summary>
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("destinationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationToken { get; set; }

        /// <summary>
        /// [Optional comments](#/rest/models/structures/notes) visible to the user
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// Optional internal [memo](#/rest/models/structures/memo) not visible to the user
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Used to identify the [purpose of a payment](#/models/structures/payment-object) and impacts reporting and calculated taxable earnings (if utilizing tax services)
        /// </summary>
        [JsonProperty("purpose", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentPurposes? Purpose { get; set; }

        /// <summary>
        /// Unique value provided by the client for the [payment](page:resources/payments), utilized for reference and deduplication.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("clientPaymentId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPaymentId { get; set; }

        /// <summary>
        /// Determines whether the quote is [automatically accepted](#/rest/models/structures/auto-accept-quote) or if a `POST` utilizing the token for the quote is required.
        /// </summary>
        [JsonProperty("autoAcceptQuote", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAcceptQuote { get; set; }

        /// <summary>
        /// [Transfer](#/rest/models/structures/not-before-or-after) is scheduled and will not process before this time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("notBefore", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// [Transfer](#/rest/models/structures/not-before-or-after) expires if not completed prior to this time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("notAfter", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NotAfter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GatewayPaymentQuote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GatewayPaymentQuote other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                (this.DestinationToken == null && other.DestinationToken == null ||
                 this.DestinationToken?.Equals(other.DestinationToken) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Purpose == null && other.Purpose == null ||
                 this.Purpose?.Equals(other.Purpose) == true) &&
                (this.ClientPaymentId == null && other.ClientPaymentId == null ||
                 this.ClientPaymentId?.Equals(other.ClientPaymentId) == true) &&
                (this.AutoAcceptQuote == null && other.AutoAcceptQuote == null ||
                 this.AutoAcceptQuote?.Equals(other.AutoAcceptQuote) == true) &&
                (this.NotBefore == null && other.NotBefore == null ||
                 this.NotBefore?.Equals(other.NotBefore) == true) &&
                (this.NotAfter == null && other.NotAfter == null ||
                 this.NotAfter?.Equals(other.NotAfter) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Purpose = {(this.Purpose == null ? "null" : this.Purpose.ToString())}");
            toStringOutput.Add($"ClientPaymentId = {this.ClientPaymentId ?? "null"}");
            toStringOutput.Add($"AutoAcceptQuote = {(this.AutoAcceptQuote == null ? "null" : this.AutoAcceptQuote.ToString())}");
            toStringOutput.Add($"NotBefore = {(this.NotBefore == null ? "null" : this.NotBefore.ToString())}");
            toStringOutput.Add($"NotAfter = {(this.NotAfter == null ? "null" : this.NotAfter.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}