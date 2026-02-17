// <copyright file="TransferResult.cs" company="APIMatic">
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
    /// TransferResult.
    /// </summary>
    public class TransferResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResult"/> class.
        /// </summary>
        public TransferResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="portalId">portalId.</param>
        /// <param name="clientTransferId">clientTransferId.</param>
        /// <param name="created">created.</param>
        /// <param name="deliveryDetails">deliveryDetails.</param>
        /// <param name="destinationAmount">destinationAmount.</param>
        /// <param name="destinationCurrency">destinationCurrency.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="fee">fee.</param>
        /// <param name="fxRate">fxRate.</param>
        /// <param name="memo">memo.</param>
        /// <param name="note">note.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="email">email.</param>
        /// <param name="status">status.</param>
        /// <param name="receiptToken">receiptToken.</param>
        /// <param name="transferLockSide">transferLockSide.</param>
        /// <param name="transferMethodType">transferMethodType.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public TransferResult(
            string token = null,
            string portalId = null,
            string clientTransferId = null,
            DateTime? created = null,
            Models.DeliveryDetails deliveryDetails = null,
            double? destinationAmount = null,
            Models.Currencies? destinationCurrency = Models.Currencies.Usd,
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            Models.FeeDistribution fee = null,
            Models.FxRate fxRate = null,
            string memo = null,
            string note = null,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string programUserId = null,
            string email = null,
            Models.TransferStatuses? status = null,
            string receiptToken = "rcpt-b7fda294-8d3a-48e8-9a11-ef7be07a732c",
            Models.LockSideTypes? transferLockSide = null,
            Models.TransferMethodTypes? transferMethodType = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.PortalId = portalId;
            this.ClientTransferId = clientTransferId;
            this.Created = created;
            this.DeliveryDetails = deliveryDetails;
            this.DestinationAmount = destinationAmount;
            this.DestinationCurrency = destinationCurrency;
            this.DestinationToken = destinationToken;
            this.Fee = fee;
            this.FxRate = fxRate;
            this.Memo = memo;
            this.Note = note;
            this.SourceToken = sourceToken;
            this.ProgramUserId = programUserId;
            this.Email = email;
            this.Status = status;
            this.ReceiptToken = receiptToken;
            this.TransferLockSide = transferLockSide;
            this.TransferMethodType = transferMethodType;
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
        /// [Unique value](#/rest/models/structures/client-transfer-id) provided by the client for the transfer, utilized for reference and deduplication.
        /// </summary>
        [JsonProperty("clientTransferId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientTransferId { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The delivery details of a Bank transfer with the minimum and maximum delivery in minutes or the expected delivery time.
        /// </summary>
        [JsonProperty("deliveryDetails", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryDetails DeliveryDetails { get; set; }

        /// <summary>
        /// Allocated money to be sent in the transaction.
        /// </summary>
        [JsonProperty("destinationAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? DestinationAmount { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("destinationCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? DestinationCurrency { get; set; }

        /// <summary>
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonProperty("destinationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationToken { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FeeDistribution Fee { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        [JsonProperty("fxRate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FxRate FxRate { get; set; }

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
        /// Type of [lockside](page:additional-api-information/transfer-lockside-types) for transfers.
        /// </summary>
        [JsonProperty("transferLockSide", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LockSideTypes? TransferLockSide { get; set; }

        /// <summary>
        /// Optional transfer methods applicable only to bank and e-wallet transfers.
        /// </summary>
        [JsonProperty("transferMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransferMethodTypes? TransferMethodType { get; set; }

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
            return $"TransferResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TransferResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.PortalId == null && other.PortalId == null ||
                 this.PortalId?.Equals(other.PortalId) == true) &&
                (this.ClientTransferId == null && other.ClientTransferId == null ||
                 this.ClientTransferId?.Equals(other.ClientTransferId) == true) &&
                (this.Created == null && other.Created == null ||
                 this.Created?.Equals(other.Created) == true) &&
                (this.DeliveryDetails == null && other.DeliveryDetails == null ||
                 this.DeliveryDetails?.Equals(other.DeliveryDetails) == true) &&
                (this.DestinationAmount == null && other.DestinationAmount == null ||
                 this.DestinationAmount?.Equals(other.DestinationAmount) == true) &&
                (this.DestinationCurrency == null && other.DestinationCurrency == null ||
                 this.DestinationCurrency?.Equals(other.DestinationCurrency) == true) &&
                (this.DestinationToken == null && other.DestinationToken == null ||
                 this.DestinationToken?.Equals(other.DestinationToken) == true) &&
                (this.Fee == null && other.Fee == null ||
                 this.Fee?.Equals(other.Fee) == true) &&
                (this.FxRate == null && other.FxRate == null ||
                 this.FxRate?.Equals(other.FxRate) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
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
                (this.TransferLockSide == null && other.TransferLockSide == null ||
                 this.TransferLockSide?.Equals(other.TransferLockSide) == true) &&
                (this.TransferMethodType == null && other.TransferMethodType == null ||
                 this.TransferMethodType?.Equals(other.TransferMethodType) == true) &&
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
            toStringOutput.Add($"ClientTransferId = {this.ClientTransferId ?? "null"}");
            toStringOutput.Add($"Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"DeliveryDetails = {(this.DeliveryDetails == null ? "null" : this.DeliveryDetails.ToString())}");
            toStringOutput.Add($"DestinationAmount = {(this.DestinationAmount == null ? "null" : this.DestinationAmount.ToString())}");
            toStringOutput.Add($"DestinationCurrency = {(this.DestinationCurrency == null ? "null" : this.DestinationCurrency.ToString())}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Fee = {(this.Fee == null ? "null" : this.Fee.ToString())}");
            toStringOutput.Add($"FxRate = {(this.FxRate == null ? "null" : this.FxRate.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"ReceiptToken = {this.ReceiptToken ?? "null"}");
            toStringOutput.Add($"TransferLockSide = {(this.TransferLockSide == null ? "null" : this.TransferLockSide.ToString())}");
            toStringOutput.Add($"TransferMethodType = {(this.TransferMethodType == null ? "null" : this.TransferMethodType.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}