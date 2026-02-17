// <copyright file="PrepaidCardPinResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PrepaidCardPinResult.
    /// </summary>
    public class PrepaidCardPinResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardPinResult"/> class.
        /// </summary>
        public PrepaidCardPinResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardPinResult"/> class.
        /// </summary>
        /// <param name="cardPin">cardPin.</param>
        /// <param name="token">token.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public PrepaidCardPinResult(
            string cardPin = null,
            string token = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.CardPin = cardPin;
            this.Token = token;
            this.Links = links;
            this.Meta = meta;
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
            return $"PrepaidCardPinResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidCardPinResult other &&
                (this.CardPin == null && other.CardPin == null ||
                 this.CardPin?.Equals(other.CardPin) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
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
            toStringOutput.Add($"CardPin = {this.CardPin ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}