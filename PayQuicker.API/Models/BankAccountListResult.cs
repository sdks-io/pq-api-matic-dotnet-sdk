// <copyright file="BankAccountListResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// BankAccountListResult.
    /// </summary>
    public class BankAccountListResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountListResult"/> class.
        /// </summary>
        public BankAccountListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountListResult"/> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="meta">meta.</param>
        /// <param name="links">links.</param>
        public BankAccountListResult(
            List<Models.BankAccountObject> payload,
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
        public List<Models.BankAccountObject> Payload { get; set; }

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
            return $"BankAccountListResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountListResult other &&
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