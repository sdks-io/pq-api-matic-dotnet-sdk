// <copyright file="PrepaidCardPinTokenResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PrepaidCardPinTokenResult.
    /// </summary>
    public class PrepaidCardPinTokenResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardPinTokenResult"/> class.
        /// </summary>
        public PrepaidCardPinTokenResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardPinTokenResult"/> class.
        /// </summary>
        /// <param name="cardProcessorType">cardProcessorType.</param>
        /// <param name="cardPinToken">cardPinToken.</param>
        /// <param name="token">token.</param>
        /// <param name="url">url.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public PrepaidCardPinTokenResult(
            Models.CardProcessors? cardProcessorType = null,
            string cardPinToken = null,
            string token = null,
            string url = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.CardProcessorType = cardProcessorType;
            this.CardPinToken = cardPinToken;
            this.Token = token;
            this.Url = url;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// The processor type for the prepaid card
        /// </summary>
        [JsonProperty("cardProcessorType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CardProcessors? CardProcessorType { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/prepaid-card-pin-token) used as part of a two-leg card PIN reveal request sent directly from the client that generally involves a second piece of data, such as the CVV code on the back of the card.
        /// </summary>
        [JsonProperty("cardPinToken", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPinToken { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Full path of the URI to perform the request action against a prepaid card that replaces the need to build the URL with query params.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

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
            return $"PrepaidCardPinTokenResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidCardPinTokenResult other &&
                (this.CardProcessorType == null && other.CardProcessorType == null ||
                 this.CardProcessorType?.Equals(other.CardProcessorType) == true) &&
                (this.CardPinToken == null && other.CardPinToken == null ||
                 this.CardPinToken?.Equals(other.CardPinToken) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
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
            toStringOutput.Add($"CardProcessorType = {(this.CardProcessorType == null ? "null" : this.CardProcessorType.ToString())}");
            toStringOutput.Add($"CardPinToken = {this.CardPinToken ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}