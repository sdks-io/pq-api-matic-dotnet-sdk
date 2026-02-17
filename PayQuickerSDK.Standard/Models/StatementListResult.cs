// <copyright file="StatementListResult.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// StatementListResult.
    /// </summary>
    public class StatementListResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementListResult"/> class.
        /// </summary>
        public StatementListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementListResult"/> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="meta">meta.</param>
        /// <param name="links">links.</param>
        public StatementListResult(
            List<Models.StatementObject> payload,
            Models.ListMetadata meta,
            List<Models.HateoasSelfRef> links)
        {
            this.Payload = payload;
            this.Meta = meta;
            this.Links = links;
        }

        /// <summary>
        /// Gets or sets Payload.
        /// </summary>
        [JsonProperty("payload")]
        public List<Models.StatementObject> Payload { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta")]
        public Models.ListMetadata Meta { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links")]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"StatementListResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is StatementListResult other &&
                (this.Payload == null && other.Payload == null ||
                 this.Payload?.Equals(other.Payload) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
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
            toStringOutput.Add($"Payload = {(this.Payload == null ? "null" : $"[{string.Join(", ", this.Payload)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}