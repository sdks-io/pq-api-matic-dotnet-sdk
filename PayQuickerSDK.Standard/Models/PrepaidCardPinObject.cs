// <copyright file="PrepaidCardPinObject.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// PrepaidCardPinObject.
    /// </summary>
    public class PrepaidCardPinObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardPinObject"/> class.
        /// </summary>
        public PrepaidCardPinObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardPinObject"/> class.
        /// </summary>
        /// <param name="cardPin">cardPin.</param>
        /// <param name="token">token.</param>
        /// <param name="links">links.</param>
        public PrepaidCardPinObject(
            string cardPin = null,
            string token = null,
            List<Models.HateoasSelfRef> links = null)
        {
            this.CardPin = cardPin;
            this.Token = token;
            this.Links = links;
        }

        /// <summary>
        /// [Card PIN](#/rest/models/structures/prepaid-card-pin) for ATM and Debit usage
        /// </summary>
        [JsonProperty("cardPin", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPin { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/prepaid-card-pin-token) used as part of a two-leg card PIN reveal request sent directly from the client that generally involves a second piece of data, such as the CVV code on the back of the card.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidCardPinObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidCardPinObject other &&
                (this.CardPin == null && other.CardPin == null ||
                 this.CardPin?.Equals(other.CardPin) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardPin = {this.CardPin ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}