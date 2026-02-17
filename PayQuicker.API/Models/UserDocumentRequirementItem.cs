// <copyright file="UserDocumentRequirementItem.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// UserDocumentRequirementItem.
    /// </summary>
    public class UserDocumentRequirementItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocumentRequirementItem"/> class.
        /// </summary>
        public UserDocumentRequirementItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocumentRequirementItem"/> class.
        /// </summary>
        /// <param name="countryOfBirth">countryOfBirth.</param>
        /// <param name="countryOfNationality">countryOfNationality.</param>
        /// <param name="documents">documents.</param>
        public UserDocumentRequirementItem(
            string countryOfBirth = null,
            string countryOfNationality = null,
            List<Models.UserDocumentRequirementItemDocumentsItems> documents = null)
        {
            this.CountryOfBirth = countryOfBirth;
            this.CountryOfNationality = countryOfNationality;
            this.Documents = documents;
        }

        /// <summary>
        /// Gets or sets CountryOfBirth.
        /// </summary>
        [JsonProperty("countryOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryOfBirth { get; set; }

        /// <summary>
        /// Gets or sets CountryOfNationality.
        /// </summary>
        [JsonProperty("countryOfNationality", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryOfNationality { get; set; }

        /// <summary>
        /// Gets or sets Documents.
        /// </summary>
        [JsonProperty("documents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDocumentRequirementItemDocumentsItems> Documents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UserDocumentRequirementItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserDocumentRequirementItem other &&
                (this.CountryOfBirth == null && other.CountryOfBirth == null ||
                 this.CountryOfBirth?.Equals(other.CountryOfBirth) == true) &&
                (this.CountryOfNationality == null && other.CountryOfNationality == null ||
                 this.CountryOfNationality?.Equals(other.CountryOfNationality) == true) &&
                (this.Documents == null && other.Documents == null ||
                 this.Documents?.Equals(other.Documents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CountryOfBirth = {this.CountryOfBirth ?? "null"}");
            toStringOutput.Add($"CountryOfNationality = {this.CountryOfNationality ?? "null"}");
            toStringOutput.Add($"Documents = {(this.Documents == null ? "null" : $"[{string.Join(", ", this.Documents)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}