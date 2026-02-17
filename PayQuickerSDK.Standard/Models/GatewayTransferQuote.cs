// <copyright file="GatewayTransferQuote.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// GatewayTransferQuote.
    /// </summary>
    public class GatewayTransferQuote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTransferQuote"/> class.
        /// </summary>
        public GatewayTransferQuote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTransferQuote"/> class.
        /// </summary>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="note">note.</param>
        /// <param name="memo">memo.</param>
        /// <param name="autoAcceptQuote">autoAcceptQuote.</param>
        /// <param name="clientTransferId">clientTransferId.</param>
        /// <param name="destinationAmount">destinationAmount.</param>
        /// <param name="destinationCurrency">destinationCurrency.</param>
        /// <param name="transferLockSide">transferLockSide.</param>
        /// <param name="transferMethodType">transferMethodType.</param>
        public GatewayTransferQuote(
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            string note = null,
            string memo = null,
            bool? autoAcceptQuote = null,
            string clientTransferId = null,
            double? destinationAmount = null,
            Models.Currencies? destinationCurrency = Models.Currencies.Usd,
            Models.LockSideTypes? transferLockSide = null,
            Models.TransferMethodTypes? transferMethodType = null)
        {
            this.SourceToken = sourceToken;
            this.DestinationToken = destinationToken;
            this.Note = note;
            this.Memo = memo;
            this.AutoAcceptQuote = autoAcceptQuote;
            this.ClientTransferId = clientTransferId;
            this.DestinationAmount = destinationAmount;
            this.DestinationCurrency = destinationCurrency;
            this.TransferLockSide = transferLockSide;
            this.TransferMethodType = transferMethodType;
        }

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
        /// Determines whether the quote is [automatically accepted](#/rest/models/structures/auto-accept-quote) or if a `POST` utilizing the token for the quote is required.
        /// </summary>
        [JsonProperty("autoAcceptQuote", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAcceptQuote { get; set; }

        /// <summary>
        /// [Unique value](#/rest/models/structures/client-transfer-id) provided by the client for the transfer, utilized for reference and deduplication.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("clientTransferId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientTransferId { get; set; }

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
        /// Type of [lockside](page:additional-api-information/transfer-lockside-types) for transfers.
        /// </summary>
        [JsonProperty("transferLockSide", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LockSideTypes? TransferLockSide { get; set; }

        /// <summary>
        /// Optional transfer methods applicable only to bank and e-wallet transfers.
        /// </summary>
        [JsonProperty("transferMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransferMethodTypes? TransferMethodType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GatewayTransferQuote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GatewayTransferQuote other &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                (this.DestinationToken == null && other.DestinationToken == null ||
                 this.DestinationToken?.Equals(other.DestinationToken) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.AutoAcceptQuote == null && other.AutoAcceptQuote == null ||
                 this.AutoAcceptQuote?.Equals(other.AutoAcceptQuote) == true) &&
                (this.ClientTransferId == null && other.ClientTransferId == null ||
                 this.ClientTransferId?.Equals(other.ClientTransferId) == true) &&
                (this.DestinationAmount == null && other.DestinationAmount == null ||
                 this.DestinationAmount?.Equals(other.DestinationAmount) == true) &&
                (this.DestinationCurrency == null && other.DestinationCurrency == null ||
                 this.DestinationCurrency?.Equals(other.DestinationCurrency) == true) &&
                (this.TransferLockSide == null && other.TransferLockSide == null ||
                 this.TransferLockSide?.Equals(other.TransferLockSide) == true) &&
                (this.TransferMethodType == null && other.TransferMethodType == null ||
                 this.TransferMethodType?.Equals(other.TransferMethodType) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"AutoAcceptQuote = {(this.AutoAcceptQuote == null ? "null" : this.AutoAcceptQuote.ToString())}");
            toStringOutput.Add($"ClientTransferId = {this.ClientTransferId ?? "null"}");
            toStringOutput.Add($"DestinationAmount = {(this.DestinationAmount == null ? "null" : this.DestinationAmount.ToString())}");
            toStringOutput.Add($"DestinationCurrency = {(this.DestinationCurrency == null ? "null" : this.DestinationCurrency.ToString())}");
            toStringOutput.Add($"TransferLockSide = {(this.TransferLockSide == null ? "null" : this.TransferLockSide.ToString())}");
            toStringOutput.Add($"TransferMethodType = {(this.TransferMethodType == null ? "null" : this.TransferMethodType.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}