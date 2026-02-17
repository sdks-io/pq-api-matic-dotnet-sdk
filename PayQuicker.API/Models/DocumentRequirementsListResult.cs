// <copyright file="DocumentRequirementsListResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// DocumentRequirementsListResult.
    /// </summary>
    public class DocumentRequirementsListResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRequirementsListResult"/> class.
        /// </summary>
        public DocumentRequirementsListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRequirementsListResult"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="meta">meta.</param>
        public DocumentRequirementsListResult(
            List<Models.UserDocumentRequirementItem> id = null,
            Models.ListMetadata meta = null)
        {
            this.Id = id;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDocumentRequirementItem> Id { get; set; }

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
            return $"DocumentRequirementsListResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DocumentRequirementsListResult other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
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
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : $"[{string.Join(", ", this.Id)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}