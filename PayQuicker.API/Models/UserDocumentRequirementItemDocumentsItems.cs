// <copyright file="UserDocumentRequirementItemDocumentsItems.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// UserDocumentRequirementItemDocumentsItems.
    /// </summary>
    public class UserDocumentRequirementItemDocumentsItems : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocumentRequirementItemDocumentsItems"/> class.
        /// </summary>
        public UserDocumentRequirementItemDocumentsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocumentRequirementItemDocumentsItems"/> class.
        /// </summary>
        /// <param name="exampleImage">exampleImage.</param>
        /// <param name="supplementalDocuments">supplementalDocuments.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        public UserDocumentRequirementItemDocumentsItems(
            string exampleImage = null,
            List<Models.UserDocReqItemDocsItemsSupplementalDocsItems> supplementalDocuments = null,
            List<Models.UserDocReqItemDocsItemsMetadataItems> metadata = null,
            Models.DocumentStatusTypes? status = null,
            Models.DocumentTypes? type = null)
        {
            this.ExampleImage = exampleImage;
            this.SupplementalDocuments = supplementalDocuments;
            this.Metadata = metadata;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Full path of the URI used for this object
        /// </summary>
        [JsonProperty("exampleImage", NullValueHandling = NullValueHandling.Ignore)]
        public string ExampleImage { get; set; }

        /// <summary>
        /// Gets or sets SupplementalDocuments.
        /// </summary>
        [JsonProperty("supplementalDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDocReqItemDocsItemsSupplementalDocsItems> SupplementalDocuments { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDocReqItemDocsItemsMetadataItems> Metadata { get; set; }

        /// <summary>
        /// Status Type of a document
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DocumentStatusTypes? Status { get; set; }

        /// <summary>
        /// Indicates the enums for KYC.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DocumentTypes? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UserDocumentRequirementItemDocumentsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserDocumentRequirementItemDocumentsItems other &&
                (this.ExampleImage == null && other.ExampleImage == null ||
                 this.ExampleImage?.Equals(other.ExampleImage) == true) &&
                (this.SupplementalDocuments == null && other.SupplementalDocuments == null ||
                 this.SupplementalDocuments?.Equals(other.SupplementalDocuments) == true) &&
                (this.Metadata == null && other.Metadata == null ||
                 this.Metadata?.Equals(other.Metadata) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ExampleImage = {this.ExampleImage ?? "null"}");
            toStringOutput.Add($"SupplementalDocuments = {(this.SupplementalDocuments == null ? "null" : $"[{string.Join(", ", this.SupplementalDocuments)} ]")}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}