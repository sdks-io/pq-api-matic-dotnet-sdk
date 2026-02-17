// <copyright file="DocumentResult.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// DocumentResult.
    /// </summary>
    public class DocumentResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentResult"/> class.
        /// </summary>
        public DocumentResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentResult"/> class.
        /// </summary>
        /// <param name="createDate">createDate.</param>
        /// <param name="token">token.</param>
        /// <param name="links">links.</param>
        /// <param name="fields">fields.</param>
        /// <param name="filename">filename.</param>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="meta">meta.</param>
        public DocumentResult(
            DateTime createDate,
            string token,
            List<Models.HateoasSelfRef> links,
            List<Models.DocumentDetails> fields = null,
            string filename = null,
            string mimeType = null,
            Models.MetadataItems meta = null)
        {
            this.CreateDate = createDate;
            this.Fields = fields;
            this.Filename = filename;
            this.MimeType = mimeType;
            this.Token = token;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DocumentDetails> Fields { get; set; }

        /// <summary>
        /// The name given to a computer file in order to distinguish it from other files
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; }

        /// <summary>
        /// A label used to identify a type of data.  Acts like a file extension on the internet.
        /// </summary>
        [JsonProperty("mimeType", NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the document
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links")]
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
            return $"DocumentResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DocumentResult other &&
                (this.CreateDate.Equals(other.CreateDate)) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Filename == null && other.Filename == null ||
                 this.Filename?.Equals(other.Filename) == true) &&
                (this.MimeType == null && other.MimeType == null ||
                 this.MimeType?.Equals(other.MimeType) == true) &&
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
            toStringOutput.Add($"CreateDate = {this.CreateDate}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : $"[{string.Join(", ", this.Fields)} ]")}");
            toStringOutput.Add($"Filename = {this.Filename ?? "null"}");
            toStringOutput.Add($"MimeType = {this.MimeType ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}