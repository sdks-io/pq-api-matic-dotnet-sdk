// <copyright file="PrepaidCardDataTokenObject.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// PrepaidCardDataTokenObject.
    /// </summary>
    public class PrepaidCardDataTokenObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardDataTokenObject"/> class.
        /// </summary>
        public PrepaidCardDataTokenObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidCardDataTokenObject"/> class.
        /// </summary>
        /// <param name="cardProcessorType">cardProcessorType.</param>
        /// <param name="tokenPurposeType">tokenPurposeType.</param>
        /// <param name="resourceValue">resourceValue.</param>
        /// <param name="token">token.</param>
        /// <param name="url">url.</param>
        /// <param name="links">links.</param>
        public PrepaidCardDataTokenObject(
            Models.CardProcessors cardProcessorType,
            Models.TokenPurposes tokenPurposeType,
            string resourceValue = null,
            string token = null,
            string url = null,
            List<Models.HateoasSelfRef> links = null)
        {
            this.CardProcessorType = cardProcessorType;
            this.ResourceValue = resourceValue;
            this.Token = token;
            this.TokenPurposeType = tokenPurposeType;
            this.Url = url;
            this.Links = links;
        }

        /// <summary>
        /// The processor type for the prepaid card
        /// </summary>
        [JsonProperty("cardProcessorType")]
        public Models.CardProcessors CardProcessorType { get; set; }

        /// <summary>
        /// Value of the target resource
        /// </summary>
        [JsonProperty("resourceValue", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceValue { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Purpose of the token
        /// </summary>
        [JsonProperty("tokenPurposeType")]
        public Models.TokenPurposes TokenPurposeType { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidCardDataTokenObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidCardDataTokenObject other &&
                (this.CardProcessorType.Equals(other.CardProcessorType)) &&
                (this.ResourceValue == null && other.ResourceValue == null ||
                 this.ResourceValue?.Equals(other.ResourceValue) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.TokenPurposeType.Equals(other.TokenPurposeType)) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
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
            toStringOutput.Add($"CardProcessorType = {this.CardProcessorType}");
            toStringOutput.Add($"ResourceValue = {this.ResourceValue ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"TokenPurposeType = {this.TokenPurposeType}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}