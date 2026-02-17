// <copyright file="SpendbackQuoteAcceptResult.cs" company="APIMatic">
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
    /// SpendbackQuoteAcceptResult.
    /// </summary>
    public class SpendbackQuoteAcceptResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendbackQuoteAcceptResult"/> class.
        /// </summary>
        public SpendbackQuoteAcceptResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendbackQuoteAcceptResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="portalId">portalId.</param>
        /// <param name="amount">amount.</param>
        /// <param name="clientSpendbackId">clientSpendbackId.</param>
        /// <param name="created">created.</param>
        /// <param name="currency">currency.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="fee">fee.</param>
        /// <param name="memo">memo.</param>
        /// <param name="note">note.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="email">email.</param>
        /// <param name="status">status.</param>
        /// <param name="receiptToken">receiptToken.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public SpendbackQuoteAcceptResult(
            string token = null,
            string portalId = null,
            double? amount = 1.02,
            string clientSpendbackId = null,
            DateTime? created = null,
            Models.Currencies? currency = Models.Currencies.Usd,
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            Models.FeeConfiguration fee = null,
            string memo = null,
            string note = null,
            Models.PaymentPurposes? purpose = null,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string programUserId = null,
            string email = null,
            Models.TransferStatuses? status = null,
            string receiptToken = "rcpt-b7fda294-8d3a-48e8-9a11-ef7be07a732c",
            List<Models.SpendbackRefundObject> refunds = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.PortalId = portalId;
            this.Amount = amount;
            this.ClientSpendbackId = clientSpendbackId;
            this.Created = created;
            this.Currency = currency;
            this.DestinationToken = destinationToken;
            this.Fee = fee;
            this.Memo = memo;
            this.Note = note;
            this.Purpose = purpose;
            this.SourceToken = sourceToken;
            this.ProgramUserId = programUserId;
            this.Email = email;
            this.Status = status;
            this.ReceiptToken = receiptToken;
            this.Refunds = refunds;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Reference ID in the PayQuicker Hosted Portal, if applicable.
        /// </summary>
        [JsonProperty("portalId", NullValueHandling = NullValueHandling.Ignore)]
        public string PortalId { get; set; }

        /// <summary>
        /// Allocated money to be sent in the transaction.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// [Unique value](#/rest/models/structures/client-transfer-id) provided by the client for the spendback
        /// </summary>
        [JsonProperty("clientSpendbackId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSpendbackId { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? Currency { get; set; }

        /// <summary>
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonProperty("destinationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationToken { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeConfiguration Fee { get; set; }

        /// <summary>
        /// Optional internal [memo](#/rest/models/structures/memo) not visible to the user
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// [Optional comments](#/rest/models/structures/notes) visible to the user
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// Used to identify the [purpose of a payment](#/models/structures/payment-object) and impacts reporting and calculated taxable earnings (if utilizing tax services)
        /// </summary>
        [JsonProperty("purpose", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentPurposes? Purpose { get; set; }

        /// <summary>
        /// Unique identifier representing the [source of funds](#/rest/models/structures/source-token)
        /// </summary>
        [JsonProperty("sourceToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceToken { get; set; }

        /// <summary>
        /// [Program identifier](#/rest/models/structures/program-user-id) for the user
        /// </summary>
        [JsonProperty("programUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramUserId { get; set; }

        /// <summary>
        /// Contact [email address](#/rest/models/structures/email-address) for the user account for the user account
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Current status of a [transfer](#/rest/models/structures/transfer)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransferStatuses? Status { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a receipt, prefixed with `rcpt-`.
        /// </summary>
        [JsonProperty("receiptToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiptToken { get; set; }

        /// <summary>
        /// Gets or sets Refunds.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SpendbackRefundObject> Refunds { get; set; }

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
            return $"SpendbackQuoteAcceptResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SpendbackQuoteAcceptResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.PortalId == null && other.PortalId == null ||
                 this.PortalId?.Equals(other.PortalId) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.ClientSpendbackId == null && other.ClientSpendbackId == null ||
                 this.ClientSpendbackId?.Equals(other.ClientSpendbackId) == true) &&
                (this.Created == null && other.Created == null ||
                 this.Created?.Equals(other.Created) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.DestinationToken == null && other.DestinationToken == null ||
                 this.DestinationToken?.Equals(other.DestinationToken) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                (this.Purpose == null && other.Purpose == null ||
                 this.Purpose?.Equals(other.Purpose) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                (this.ProgramUserId == null && other.ProgramUserId == null ||
                 this.ProgramUserId?.Equals(other.ProgramUserId) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.ReceiptToken == null && other.ReceiptToken == null ||
                 this.ReceiptToken?.Equals(other.ReceiptToken) == true) &&
                (this.Refunds == null && other.Refunds == null ||
                 this.Refunds?.Equals(other.Refunds) == true) &&
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
            toStringOutput.Add($"PortalId = {this.PortalId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"ClientSpendbackId = {this.ClientSpendbackId ?? "null"}");
            toStringOutput.Add($"Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"Purpose = {(this.Purpose == null ? "null" : this.Purpose.ToString())}");
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"ReceiptToken = {this.ReceiptToken ?? "null"}");
            toStringOutput.Add($"Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}