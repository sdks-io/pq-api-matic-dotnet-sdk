// <copyright file="BankAccountRequirementListResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// BankAccountRequirementListResult.
    /// </summary>
    public class BankAccountRequirementListResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequirementListResult"/> class.
        /// </summary>
        public BankAccountRequirementListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequirementListResult"/> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public BankAccountRequirementListResult(
            List<Models.BankAccountRequirement> payload = null,
            List<Models.HateoasSelfRef> links = null,
            Models.ListMetadata meta = null)
        {
            this.Payload = payload;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets Payload.
        /// </summary>
        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankAccountRequirement> Payload { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListMetadata Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountRequirementListResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountRequirementListResult other &&
                (this.Payload == null && other.Payload == null ||
                 this.Payload?.Equals(other.Payload) == true) &&
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
            toStringOutput.Add($"Payload = {(this.Payload == null ? "null" : $"[{string.Join(", ", this.Payload)} ]")}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}