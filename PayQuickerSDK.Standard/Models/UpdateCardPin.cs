// <copyright file="UpdateCardPin.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// UpdateCardPin.
    /// </summary>
    public class UpdateCardPin : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardPin"/> class.
        /// </summary>
        public UpdateCardPin()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCardPin"/> class.
        /// </summary>
        /// <param name="cardPinToken">cardPinToken.</param>
        /// <param name="cardPin">cardPin.</param>
        public UpdateCardPin(
            string cardPinToken = null,
            string cardPin = null)
        {
            this.CardPinToken = cardPinToken;
            this.CardPin = cardPin;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/prepaid-card-pin-token) used as part of a two-leg card PIN reveal request sent directly from the client that generally involves a second piece of data, such as the CVV code on the back of the card.
        /// </summary>
        [JsonProperty("cardPinToken", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPinToken { get; set; }

        /// <summary>
        /// [Card PIN](#/rest/models/structures/prepaid-card-pin) for ATM and Debit usage
        /// </summary>
        [JsonProperty("cardPin", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCardPin : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCardPin other &&
                (this.CardPinToken == null && other.CardPinToken == null ||
                 this.CardPinToken?.Equals(other.CardPinToken) == true) &&
                (this.CardPin == null && other.CardPin == null ||
                 this.CardPin?.Equals(other.CardPin) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardPinToken = {this.CardPinToken ?? "null"}");
            toStringOutput.Add($"CardPin = {this.CardPin ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}