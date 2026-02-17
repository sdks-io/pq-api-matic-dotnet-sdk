// <copyright file="CreateOrUpdateDocumentFields.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// CreateOrUpdateDocumentFields.
    /// </summary>
    public class CreateOrUpdateDocumentFields : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateDocumentFields"/> class.
        /// </summary>
        public CreateOrUpdateDocumentFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateDocumentFields"/> class.
        /// </summary>
        /// <param name="fields">fields.</param>
        public CreateOrUpdateDocumentFields(
            List<Models.DocumentDetails> fields = null)
        {
            this.Fields = fields;
        }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DocumentDetails> Fields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrUpdateDocumentFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateDocumentFields other &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : $"[{string.Join(", ", this.Fields)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}