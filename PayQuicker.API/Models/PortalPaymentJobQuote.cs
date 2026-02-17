// <copyright file="PortalPaymentJobQuote.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PortalPaymentJobQuote.
    /// </summary>
    public class PortalPaymentJobQuote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalPaymentJobQuote"/> class.
        /// </summary>
        public PortalPaymentJobQuote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortalPaymentJobQuote"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="sourceToken">sourceToken.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="email">email.</param>
        /// <param name="note">note.</param>
        /// <param name="memo">memo.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="clientPaymentId">clientPaymentId.</param>
        public PortalPaymentJobQuote(
            double? amount = 1.02,
            Models.Currencies? currency = Models.Currencies.Usd,
            string sourceToken = "acct-3908ab5a-6ce1-474d-8b80-a63a7b147860",
            string programUserId = null,
            string email = null,
            string note = null,
            string memo = null,
            Models.PaymentPurposes? purpose = null,
            string clientPaymentId = "d4b6f130-1d1c-4ce2-903a-0c1ad128f55e")
        {
            this.Amount = amount;
            this.Currency = currency;
            this.SourceToken = sourceToken;
            this.ProgramUserId = programUserId;
            this.Email = email;
            this.Note = note;
            this.Memo = memo;
            this.Purpose = purpose;
            this.ClientPaymentId = clientPaymentId;
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
        /// [Optional comments](#/rest/models/structures/notes) visible to the user
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// Optional internal [memo](#/rest/models/structures/memo) not visible to the user
        /// </summary>
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
        [JsonProperty("clientPaymentId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPaymentId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PortalPaymentJobQuote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PortalPaymentJobQuote other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.SourceToken == null && other.SourceToken == null ||
                 this.SourceToken?.Equals(other.SourceToken) == true) &&
                (this.ProgramUserId == null && other.ProgramUserId == null ||
                 this.ProgramUserId?.Equals(other.ProgramUserId) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Purpose == null && other.Purpose == null ||
                 this.Purpose?.Equals(other.Purpose) == true) &&
                (this.ClientPaymentId == null && other.ClientPaymentId == null ||
                 this.ClientPaymentId?.Equals(other.ClientPaymentId) == true) &&
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
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Purpose = {(this.Purpose == null ? "null" : this.Purpose.ToString())}");
            toStringOutput.Add($"ClientPaymentId = {this.ClientPaymentId ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}