// <copyright file="OrderPrepaidCard.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// OrderPrepaidCard.
    /// </summary>
    public class OrderPrepaidCard : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPrepaidCard"/> class.
        /// </summary>
        public OrderPrepaidCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPrepaidCard"/> class.
        /// </summary>
        /// <param name="cardPackage">cardPackage.</param>
        /// <param name="programToken">programToken.</param>
        /// <param name="cardReferenceNumber">cardReferenceNumber.</param>
        public OrderPrepaidCard(
            string cardPackage = null,
            string programToken = null,
            string cardReferenceNumber = null)
        {
            this.CardPackage = cardPackage;
            this.ProgramToken = programToken;
            this.CardReferenceNumber = cardReferenceNumber;
        }

        /// <summary>
        /// [Package](#/rest/models/structures/prepaid-card-package) for the card being displayed, including artwork, packaging, and delivery method
        /// </summary>
        [JsonProperty("cardPackage", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPackage { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a program, prefixed with prog-
        /// </summary>
        [JsonProperty("programToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramToken { get; set; }

        /// <summary>
        /// Number that is printed on the back of a plastic card.
        /// </summary>
        [JsonProperty("cardReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CardReferenceNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderPrepaidCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderPrepaidCard other &&
                (this.CardPackage == null && other.CardPackage == null ||
                 this.CardPackage?.Equals(other.CardPackage) == true) &&
                (this.ProgramToken == null && other.ProgramToken == null ||
                 this.ProgramToken?.Equals(other.ProgramToken) == true) &&
                (this.CardReferenceNumber == null && other.CardReferenceNumber == null ||
                 this.CardReferenceNumber?.Equals(other.CardReferenceNumber) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardPackage = {this.CardPackage ?? "null"}");
            toStringOutput.Add($"ProgramToken = {this.ProgramToken ?? "null"}");
            toStringOutput.Add($"CardReferenceNumber = {this.CardReferenceNumber ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}