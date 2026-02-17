// <copyright file="UserDocReqItemDocsItemsSupplementalDocsItems.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// UserDocReqItemDocsItemsSupplementalDocsItems.
    /// </summary>
    public class UserDocReqItemDocsItemsSupplementalDocsItems : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocReqItemDocsItemsSupplementalDocsItems"/> class.
        /// </summary>
        public UserDocReqItemDocsItemsSupplementalDocsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocReqItemDocsItemsSupplementalDocsItems"/> class.
        /// </summary>
        /// <param name="exampleImage">exampleImage.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        public UserDocReqItemDocsItemsSupplementalDocsItems(
            string exampleImage = null,
            Models.DocumentStatusTypes? status = null,
            Models.DocumentTypes? type = null)
        {
            this.ExampleImage = exampleImage;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Full path of the URI used for this object
        /// </summary>
        [JsonProperty("exampleImage", NullValueHandling = NullValueHandling.Ignore)]
        public string ExampleImage { get; set; }

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
            return $"UserDocReqItemDocsItemsSupplementalDocsItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserDocReqItemDocsItemsSupplementalDocsItems other &&
                (this.ExampleImage == null && other.ExampleImage == null ||
                 this.ExampleImage?.Equals(other.ExampleImage) == true) &&
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
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}