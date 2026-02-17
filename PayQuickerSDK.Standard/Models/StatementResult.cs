// <copyright file="StatementResult.cs" company="APIMatic">
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
    /// StatementResult.
    /// </summary>
    public class StatementResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementResult"/> class.
        /// </summary>
        public StatementResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementResult"/> class.
        /// </summary>
        /// <param name="fileContents">fileContents.</param>
        /// <param name="filename">filename.</param>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="token">token.</param>
        /// <param name="userToken">userToken.</param>
        /// <param name="prepaidCardToken">prepaidCardToken.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public StatementResult(
            string fileContents = null,
            string filename = null,
            string mimeType = null,
            string token = null,
            string userToken = null,
            string prepaidCardToken = null,
            DateTime? from = null,
            DateTime? to = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.FileContents = fileContents;
            this.Filename = filename;
            this.MimeType = mimeType;
            this.Token = token;
            this.UserToken = userToken;
            this.PrepaidCardToken = prepaidCardToken;
            this.From = from;
            this.To = to;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// The string representation of the file content.
        /// </summary>
        [JsonProperty("fileContents", NullValueHandling = NullValueHandling.Ignore)]
        public string FileContents { get; set; }

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
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a user, prefixed with `user-`.
        /// </summary>
        [JsonProperty("userToken", NullValueHandling = NullValueHandling.Ignore)]
        public string UserToken { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a dest, prefixed with dest-.
        /// </summary>
        [JsonProperty("prepaidCardToken", NullValueHandling = NullValueHandling.Ignore)]
        public string PrepaidCardToken { get; set; }

        /// <summary>
        /// Beginning date and time of a prepaid card statement
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? From { get; set; }

        /// <summary>
        /// Ending date and time of a prepaid card statement
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? To { get; set; }

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
            return $"StatementResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is StatementResult other &&
                (this.FileContents == null && other.FileContents == null ||
                 this.FileContents?.Equals(other.FileContents) == true) &&
                (this.Filename == null && other.Filename == null ||
                 this.Filename?.Equals(other.Filename) == true) &&
                (this.MimeType == null && other.MimeType == null ||
                 this.MimeType?.Equals(other.MimeType) == true) &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.UserToken == null && other.UserToken == null ||
                 this.UserToken?.Equals(other.UserToken) == true) &&
                (this.PrepaidCardToken == null && other.PrepaidCardToken == null ||
                 this.PrepaidCardToken?.Equals(other.PrepaidCardToken) == true) &&
                (this.From == null && other.From == null ||
                 this.From?.Equals(other.From) == true) &&
                (this.To == null && other.To == null ||
                 this.To?.Equals(other.To) == true) &&
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
            toStringOutput.Add($"FileContents = {this.FileContents ?? "null"}");
            toStringOutput.Add($"Filename = {this.Filename ?? "null"}");
            toStringOutput.Add($"MimeType = {this.MimeType ?? "null"}");
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"UserToken = {this.UserToken ?? "null"}");
            toStringOutput.Add($"PrepaidCardToken = {this.PrepaidCardToken ?? "null"}");
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}