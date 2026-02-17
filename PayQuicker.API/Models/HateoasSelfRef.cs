// <copyright file="HateoasSelfRef.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// HateoasSelfRef.
    /// </summary>
    public class HateoasSelfRef : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HateoasSelfRef"/> class.
        /// </summary>
        public HateoasSelfRef()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HateoasSelfRef"/> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="mParams">params.</param>
        public HateoasSelfRef(
            string href = null,
            Models.HateoasRelationship mParams = null)
        {
            this.Href = href;
            this.MParams = mParams;
        }

        /// <summary>
        /// Gets or sets Href.
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// Indicates the HATEOS relationship between the target and current resources.
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HateoasRelationship MParams { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"HateoasSelfRef : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is HateoasSelfRef other &&
                (this.Href == null && other.Href == null ||
                 this.Href?.Equals(other.Href) == true) &&
                (this.MParams == null && other.MParams == null ||
                 this.MParams?.Equals(other.MParams) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Href = {this.Href ?? "null"}");
            toStringOutput.Add($"MParams = {(this.MParams == null ? "null" : this.MParams.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}