// <copyright file="AgreementObject.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// AgreementObject.
    /// </summary>
    public class AgreementObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementObject"/> class.
        /// </summary>
        public AgreementObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementObject"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="contentBase64">contentBase64.</param>
        /// <param name="url">url.</param>
        /// <param name="type">type.</param>
        /// <param name="links">links.</param>
        public AgreementObject(
            string token = null,
            string contentBase64 = null,
            string url = null,
            Models.AgreementTypes? type = null,
            List<Models.HateoasSelfRef> links = null)
        {
            this.Token = token;
            this.ContentBase64 = contentBase64;
            this.Url = url;
            this.Type = type;
            this.Links = links;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Program agreement content
        /// </summary>
        [JsonProperty("contentBase64", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentBase64 { get; set; }

        /// <summary>
        /// Full path of the URI to the content for the program agreement
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AgreementTypes? Type { get; set; }

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
            return $"AgreementObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AgreementObject other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.ContentBase64 == null && other.ContentBase64 == null ||
                 this.ContentBase64?.Equals(other.ContentBase64) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
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
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"ContentBase64 = {this.ContentBase64 ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}