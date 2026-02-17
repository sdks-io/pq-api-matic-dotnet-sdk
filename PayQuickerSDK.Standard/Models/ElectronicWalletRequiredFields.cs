// <copyright file="ElectronicWalletRequiredFields.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ElectronicWalletRequiredFields.
    /// </summary>
    public class ElectronicWalletRequiredFields : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequiredFields"/> class.
        /// </summary>
        public ElectronicWalletRequiredFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicWalletRequiredFields"/> class.
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="requirement">requirement.</param>
        /// <param name="description">description.</param>
        /// <param name="validators">validators.</param>
        public ElectronicWalletRequiredFields(
            Models.ElectronicWalletRequirementFormat format = null,
            Models.ElectronicWalletFields? requirement = null,
            List<Models.Translation> description = null,
            List<Models.ElectronicWalletRequirementValidator> validators = null)
        {
            this.Format = format;
            this.Requirement = requirement;
            this.Description = description;
            this.Validators = validators;
        }

        /// <summary>
        /// Classifies the [format](#/rest/models/structures/electronic-wallet-requirement-format) of the required information for an electronic wallet
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletRequirementFormat Format { get; set; }

        /// <summary>
        /// Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields)
        /// </summary>
        [JsonProperty("requirement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletFields? Requirement { get; set; }

        /// <summary>
        /// Localized requirement description for display purposes
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Translation> Description { get; set; }

        /// <summary>
        /// Gets or sets Validators.
        /// </summary>
        [JsonProperty("validators", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ElectronicWalletRequirementValidator> Validators { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ElectronicWalletRequiredFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ElectronicWalletRequiredFields other &&
                (this.Format == null && other.Format == null ||
                 this.Format?.Equals(other.Format) == true) &&
                (this.Requirement == null && other.Requirement == null ||
                 this.Requirement?.Equals(other.Requirement) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Validators == null && other.Validators == null ||
                 this.Validators?.Equals(other.Validators) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Format = {(this.Format == null ? "null" : this.Format.ToString())}");
            toStringOutput.Add($"Requirement = {(this.Requirement == null ? "null" : this.Requirement.ToString())}");
            toStringOutput.Add($"Description = {(this.Description == null ? "null" : $"[{string.Join(", ", this.Description)} ]")}");
            toStringOutput.Add($"Validators = {(this.Validators == null ? "null" : $"[{string.Join(", ", this.Validators)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}