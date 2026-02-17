// <copyright file="HateoasRelationship.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// HateoasRelationship.
    /// </summary>
    public class HateoasRelationship : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HateoasRelationship"/> class.
        /// </summary>
        public HateoasRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HateoasRelationship"/> class.
        /// </summary>
        /// <param name="rel">rel.</param>
        public HateoasRelationship(
            string rel)
        {
            this.Rel = rel;
        }

        /// <summary>
        /// Indicates the relationship between the target and current resources.
        /// </summary>
        [JsonProperty("rel")]
        public string Rel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"HateoasRelationship : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is HateoasRelationship other &&
                (this.Rel == null && other.Rel == null ||
                 this.Rel?.Equals(other.Rel) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Rel = {this.Rel ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}