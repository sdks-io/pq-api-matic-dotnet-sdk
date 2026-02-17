// <copyright file="CreateOrUpdateDocument.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using PayQuickerSDK.Standard.Utilities;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// CreateOrUpdateDocument.
    /// </summary>
    public class CreateOrUpdateDocument : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateDocument"/> class.
        /// </summary>
        public CreateOrUpdateDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateDocument"/> class.
        /// </summary>
        /// <param name="fields">fields.</param>
        /// <param name="upload">upload.</param>
        public CreateOrUpdateDocument(
            Models.CreateOrUpdateDocumentFields fields = null,
            JsonValue upload = null)
        {
            this.Fields = fields;
            this.Upload = upload;
        }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateOrUpdateDocumentFields Fields { get; set; }

        /// <summary>
        /// Document to be uploaded
        /// </summary>
        [JsonProperty("upload", NullValueHandling = NullValueHandling.Ignore)]
        public JsonValue Upload { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrUpdateDocument : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateDocument other &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Upload == null && other.Upload == null ||
                 this.Upload?.Equals(other.Upload) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"Upload = {(this.Upload == null ? "null" : this.Upload.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}