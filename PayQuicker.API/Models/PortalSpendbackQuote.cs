// <copyright file="PortalSpendbackQuote.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PortalSpendbackQuote.
    /// </summary>
    public class PortalSpendbackQuote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalSpendbackQuote"/> class.
        /// </summary>
        public PortalSpendbackQuote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortalSpendbackQuote"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="email">email.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="memo">memo.</param>
        /// <param name="note">note.</param>
        /// <param name="clientSpendbackId">clientSpendbackId.</param>
        /// <param name="autoAcceptQuote">autoAcceptQuote.</param>
        public PortalSpendbackQuote(
            double? amount = 1.02,
            Models.Currencies? currency = Models.Currencies.Usd,
            string programUserId = null,
            string email = null,
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            string memo = null,
            string note = null,
            string clientSpendbackId = null,
            bool? autoAcceptQuote = null)
        {
            this.Amount = amount;
            this.Currency = currency;
            this.ProgramUserId = programUserId;
            this.Email = email;
            this.DestinationToken = destinationToken;
            this.Memo = memo;
            this.Note = note;
            this.ClientSpendbackId = clientSpendbackId;
            this.AutoAcceptQuote = autoAcceptQuote;
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
        /// [Program identifier](#/rest/models/structures/program-user-id) for the user
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("programUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramUserId { get; set; }

        /// <summary>
        /// Contact [email address](#/rest/models/structures/email-address) for the user account for the user account
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("destinationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationToken { get; set; }

        /// <summary>
        /// Optional internal [memo](#/rest/models/structures/memo) not visible to the user
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// [Optional comments](#/rest/models/structures/notes) visible to the user
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// [Unique value](#/rest/models/structures/client-transfer-id) provided by the client for the spendback
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("clientSpendbackId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSpendbackId { get; set; }

        /// <summary>
        /// Determines whether the quote is [automatically accepted](#/rest/models/structures/auto-accept-quote) or if a `POST` utilizing the token for the quote is required.
        /// </summary>
        [JsonProperty("autoAcceptQuote", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAcceptQuote { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PortalSpendbackQuote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PortalSpendbackQuote other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.ProgramUserId == null && other.ProgramUserId == null ||
                 this.ProgramUserId?.Equals(other.ProgramUserId) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.DestinationToken == null && other.DestinationToken == null ||
                 this.DestinationToken?.Equals(other.DestinationToken) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                (this.ClientSpendbackId == null && other.ClientSpendbackId == null ||
                 this.ClientSpendbackId?.Equals(other.ClientSpendbackId) == true) &&
                (this.AutoAcceptQuote == null && other.AutoAcceptQuote == null ||
                 this.AutoAcceptQuote?.Equals(other.AutoAcceptQuote) == true) &&
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
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"ClientSpendbackId = {this.ClientSpendbackId ?? "null"}");
            toStringOutput.Add($"AutoAcceptQuote = {(this.AutoAcceptQuote == null ? "null" : this.AutoAcceptQuote.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}