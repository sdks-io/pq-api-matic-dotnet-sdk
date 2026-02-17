// <copyright file="CreateSpendbackRefundQuote.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// CreateSpendbackRefundQuote.
    /// </summary>
    public class CreateSpendbackRefundQuote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpendbackRefundQuote"/> class.
        /// </summary>
        public CreateSpendbackRefundQuote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpendbackRefundQuote"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="email">email.</param>
        /// <param name="destinationToken">destinationToken.</param>
        /// <param name="memo">memo.</param>
        /// <param name="note">note.</param>
        /// <param name="clientSpendbackRefundId">clientSpendbackRefundId.</param>
        /// <param name="autoAcceptQuote">autoAcceptQuote.</param>
        public CreateSpendbackRefundQuote(
            double? amount = null,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string programUserId = null,
            string email = null,
            string destinationToken = "dest-631b200f-665d-4dbe-bd01-3063c9dec97d",
            string memo = null,
            string note = null,
            string clientSpendbackRefundId = null,
            bool? autoAcceptQuote = null)
        {
            this.Amount = amount;
            this.SourceToken = sourceToken;
            this.ProgramUserId = programUserId;
            this.Email = email;
            this.DestinationToken = destinationToken;
            this.Memo = memo;
            this.Note = note;
            this.ClientSpendbackRefundId = clientSpendbackRefundId;
            this.AutoAcceptQuote = autoAcceptQuote;
        }

        /// <summary>
        /// Money to be refunded from original payment
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

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
        /// Unique identifier representing the [destination of funds](#/rest/models/structures/destination-token)
        /// </summary>
        [JsonProperty("destinationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationToken { get; set; }

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
        /// [Unique value](#/rest/models/structures/client-transfer-id) provided by the client for the transfer, utilized for reference and deduplication.
        /// </summary>
        [JsonProperty("clientSpendbackRefundId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSpendbackRefundId { get; set; }

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
            return $"CreateSpendbackRefundQuote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSpendbackRefundQuote other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
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
                (this.ClientSpendbackRefundId == null && other.ClientSpendbackRefundId == null ||
                 this.ClientSpendbackRefundId?.Equals(other.ClientSpendbackRefundId) == true) &&
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
            toStringOutput.Add($"SourceToken = {this.SourceToken ?? "null"}");
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"DestinationToken = {this.DestinationToken ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"ClientSpendbackRefundId = {this.ClientSpendbackRefundId ?? "null"}");
            toStringOutput.Add($"AutoAcceptQuote = {(this.AutoAcceptQuote == null ? "null" : this.AutoAcceptQuote.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}