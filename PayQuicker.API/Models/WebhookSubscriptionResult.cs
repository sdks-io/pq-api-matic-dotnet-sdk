// <copyright file="WebhookSubscriptionResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// WebhookSubscriptionResult.
    /// </summary>
    public class WebhookSubscriptionResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionResult"/> class.
        /// </summary>
        public WebhookSubscriptionResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="created">created.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="url">url.</param>
        /// <param name="mNamespace">namespace.</param>
        /// <param name="status">status.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public WebhookSubscriptionResult(
            string token = null,
            DateTime? created = null,
            DateTime? lastUpdated = null,
            string url = null,
            Models.WebhookNamespaces? mNamespace = null,
            Models.WebhookSubscriptionStatuses? status = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.Created = created;
            this.LastUpdated = lastUpdated;
            this.Url = url;
            this.MNamespace = mNamespace;
            this.Status = status;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Date and time that the object was last updated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Full path of the URI used for this object
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// Namespace used to identify and refer to the object
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookNamespaces? MNamespace { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WebhookSubscriptionStatuses? Status { get; set; }

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
            return $"WebhookSubscriptionResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WebhookSubscriptionResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Created == null && other.Created == null ||
                 this.Created?.Equals(other.Created) == true) &&
                (this.LastUpdated == null && other.LastUpdated == null ||
                 this.LastUpdated?.Equals(other.LastUpdated) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                (this.MNamespace == null && other.MNamespace == null ||
                 this.MNamespace?.Equals(other.MNamespace) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
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
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"LastUpdated = {(this.LastUpdated == null ? "null" : this.LastUpdated.ToString())}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
            toStringOutput.Add($"MNamespace = {(this.MNamespace == null ? "null" : this.MNamespace.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}