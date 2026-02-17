// <copyright file="MetadataItems.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// MetadataItems.
    /// </summary>
    public class MetadataItems : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataItems"/> class.
        /// </summary>
        public MetadataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataItems"/> class.
        /// </summary>
        /// <param name="timezone">timezone.</param>
        /// <param name="requestRef">requestRef.</param>
        public MetadataItems(
            string timezone,
            string requestRef)
        {
            this.Timezone = timezone;
            this.RequestRef = requestRef;
        }

        /// <summary>
        /// Timezone of the datetime objects in the response
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets RequestRef.
        /// </summary>
        [JsonProperty("requestRef")]
        public string RequestRef { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MetadataItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MetadataItems other &&
                (this.Timezone == null && other.Timezone == null ||
                 this.Timezone?.Equals(other.Timezone) == true) &&
                (this.RequestRef == null && other.RequestRef == null ||
                 this.RequestRef?.Equals(other.RequestRef) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Timezone = {this.Timezone ?? "null"}");
            toStringOutput.Add($"RequestRef = {this.RequestRef ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}