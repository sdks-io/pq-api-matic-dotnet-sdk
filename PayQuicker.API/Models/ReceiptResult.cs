// <copyright file="ReceiptResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// ReceiptResult.
    /// </summary>
    public class ReceiptResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptResult"/> class.
        /// </summary>
        public ReceiptResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="type">type.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="sign">sign.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="status">status.</param>
        /// <param name="descriptions">descriptions.</param>
        /// <param name="deliveryDetails">deliveryDetails.</param>
        /// <param name="details">details.</param>
        /// <param name="fxRate">fxRate.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public ReceiptResult(
            string token = "rcpt-b7fda294-8d3a-48e8-9a11-ef7be07a732c",
            Models.TransferTypes? type = null,
            DateTime? createdOn = null,
            Models.Signs? sign = null,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            double? amount = 1.02,
            Models.Currencies? currency = Models.Currencies.Usd,
            Models.ReceiptStatuses? status = null,
            List<Models.ReceiptDescriptions> descriptions = null,
            Models.DeliveryDetails deliveryDetails = null,
            Models.ReceiptDetails details = null,
            Models.FxRate fxRate = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.Type = type;
            this.CreatedOn = createdOn;
            this.Sign = sign;
            this.SourceToken = sourceToken;
            this.DestinationToken = destinationToken;
            this.Amount = amount;
            this.Currency = currency;
            this.Status = status;
            this.Descriptions = descriptions;
            this.DeliveryDetails = deliveryDetails;
            this.Details = details;
            this.FxRate = fxRate;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// [Transfer type](#/rest/models/structures/transfer-type)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransferTypes? Type { get; set; }

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
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonProperty("destinationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationToken { get; set; }

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
        public List<Models.ReceiptDescriptions> Descriptions { get; set; }

        /// <summary>
        /// The delivery details of a Bank transfer with the minimum and maximum delivery in minutes or the expected delivery time.
        /// </summary>
        [JsonProperty("deliveryDetails", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryDetails DeliveryDetails { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReceiptDetails Details { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        [JsonProperty("fxRate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FxRate FxRate { get; set; }

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
            return $"ReceiptResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReceiptResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.Sign == null && other.Sign == null ||
                 this.Sign?.Equals(other.Sign) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                (this.DestinationToken == null && other.DestinationToken == null ||
                 this.DestinationToken?.Equals(other.DestinationToken) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Descriptions == null && other.Descriptions == null ||
                 this.Descriptions?.Equals(other.Descriptions) == true) &&
                (this.DeliveryDetails == null && other.DeliveryDetails == null ||
                 this.DeliveryDetails?.Equals(other.DeliveryDetails) == true) &&
                (this.Details == null && other.Details == null ||
                 this.Details?.Equals(other.Details) == true) &&
                (this.FxRate == null && other.FxRate == null ||
                 this.FxRate?.Equals(other.FxRate) == true) &&
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
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Sign = {(this.Sign == null ? "null" : this.Sign.ToString())}");
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Descriptions = {(this.Descriptions == null ? "null" : $"[{string.Join(", ", this.Descriptions)} ]")}");
            toStringOutput.Add($"DeliveryDetails = {(this.DeliveryDetails == null ? "null" : this.DeliveryDetails.ToString())}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"FxRate = {(this.FxRate == null ? "null" : this.FxRate.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}