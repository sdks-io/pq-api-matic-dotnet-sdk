// <copyright file="PaymentJobResult.cs" company="APIMatic">
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
    /// PaymentJobResult.
    /// </summary>
    public class PaymentJobResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentJobResult"/> class.
        /// </summary>
        public PaymentJobResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentJobResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="portalId">portalId.</param>
        /// <param name="filename">filename.</param>
        /// <param name="fileToken">fileToken.</param>
        /// <param name="created">created.</param>
        /// <param name="notBefore">notBefore.</param>
        /// <param name="count">count.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="items">items.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public PaymentJobResult(
            string token = null,
            string portalId = null,
            string filename = null,
            string fileToken = "docu-2053aaad-c1a5-45e2-a2da-f71287f32800",
            DateTime? created = null,
            DateTime? notBefore = null,
            int? count = null,
            Models.JobTypes? type = null,
            Models.JobStatusTypes? status = null,
            List<Models.PaymentObject> items = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.PortalId = portalId;
            this.Filename = filename;
            this.FileToken = fileToken;
            this.Created = created;
            this.NotBefore = notBefore;
            this.Count = count;
            this.Type = type;
            this.Status = status;
            this.Items = items;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Reference ID in the PayQuicker Hosted Portal, if applicable.
        /// </summary>
        [JsonProperty("portalId", NullValueHandling = NullValueHandling.Ignore)]
        public string PortalId { get; set; }

        /// <summary>
        /// The name given to a computer file in order to distinguish it from other files
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the document
        /// </summary>
        [JsonProperty("fileToken", NullValueHandling = NullValueHandling.Ignore)]
        public string FileToken { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// [Transfer](#/rest/models/structures/not-before-or-after) is scheduled and will not process before this time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("notBefore", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// Job Types
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.JobTypes? Type { get; set; }

        /// <summary>
        /// Job Status Types
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.JobStatusTypes? Status { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PaymentObject> Items { get; set; }

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
            return $"PaymentJobResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentJobResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.PortalId == null && other.PortalId == null ||
                 this.PortalId?.Equals(other.PortalId) == true) &&
                (this.Filename == null && other.Filename == null ||
                 this.Filename?.Equals(other.Filename) == true) &&
                (this.FileToken == null && other.FileToken == null ||
                 this.FileToken?.Equals(other.FileToken) == true) &&
                (this.Created == null && other.Created == null ||
                 this.Created?.Equals(other.Created) == true) &&
                (this.NotBefore == null && other.NotBefore == null ||
                 this.NotBefore?.Equals(other.NotBefore) == true) &&
                (this.Count == null && other.Count == null ||
                 this.Count?.Equals(other.Count) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
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
            toStringOutput.Add($"PortalId = {this.PortalId ?? "null"}");
            toStringOutput.Add($"Filename = {this.Filename ?? "null"}");
            toStringOutput.Add($"FileToken = {this.FileToken ?? "null"}");
            toStringOutput.Add($"Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"NotBefore = {(this.NotBefore == null ? "null" : this.NotBefore.ToString())}");
            toStringOutput.Add($"Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}