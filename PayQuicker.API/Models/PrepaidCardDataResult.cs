// <copyright file="PrepaidCardDataResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PrepaidCardDataResult.
    /// </summary>
    public class PrepaidCardDataResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardDataResult"/> class.
        /// </summary>
        public PrepaidCardDataResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardDataResult"/> class.
        /// </summary>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="cvvNumber">cvvNumber.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="nameOnCard">nameOnCard.</param>
        /// <param name="token">token.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public PrepaidCardDataResult(
            double? cardNumber = null,
            string cvvNumber = null,
            string expiration = null,
            string nameOnCard = null,
            string token = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.CardNumber = cardNumber;
            this.CvvNumber = cvvNumber;
            this.Expiration = expiration;
            this.NameOnCard = nameOnCard;
            this.Token = token;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Unique number on the prepaid card
        /// </summary>
        [JsonProperty("cardNumber", NullValueHandling = NullValueHandling.Ignore)]
        public double? CardNumber { get; set; }

        /// <summary>
        /// Three- or four-digit [Card Verification Value (CVV)](#/rest/models/structures/cvv) number displayed on the back of a credit or debit card
        /// </summary>
        [JsonProperty("cvvNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CvvNumber { get; set; }

        /// <summary>
        /// Date that the card will expire
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiration { get; set; }

        /// <summary>
        /// Name of the card's owner
        /// </summary>
        [JsonProperty("nameOnCard", NullValueHandling = NullValueHandling.Ignore)]
        public string NameOnCard { get; set; }

        /// <summary>
        /// A token used to reveal prepaid card information in the form of image data (base64) or JSON.
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
            return $"PrepaidCardDataResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidCardDataResult other &&
                (this.CardNumber == null && other.CardNumber == null ||
                 this.CardNumber?.Equals(other.CardNumber) == true) &&
                (this.CvvNumber == null && other.CvvNumber == null ||
                 this.CvvNumber?.Equals(other.CvvNumber) == true) &&
                (this.Expiration == null && other.Expiration == null ||
                 this.Expiration?.Equals(other.Expiration) == true) &&
                (this.NameOnCard == null && other.NameOnCard == null ||
                 this.NameOnCard?.Equals(other.NameOnCard) == true) &&
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
            toStringOutput.Add($"CardNumber = {(this.CardNumber == null ? "null" : this.CardNumber.ToString())}");
            toStringOutput.Add($"CvvNumber = {this.CvvNumber ?? "null"}");
            toStringOutput.Add($"Expiration = {this.Expiration ?? "null"}");
            toStringOutput.Add($"NameOnCard = {this.NameOnCard ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}