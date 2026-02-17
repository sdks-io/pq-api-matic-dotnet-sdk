// <copyright file="BankAccountRequiredFields.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// BankAccountRequiredFields.
    /// </summary>
    public class BankAccountRequiredFields : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequiredFields"/> class.
        /// </summary>
        public BankAccountRequiredFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequiredFields"/> class.
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="requirement">requirement.</param>
        /// <param name="description">description.</param>
        /// <param name="validators">validators.</param>
        public BankAccountRequiredFields(
            Models.BankAccountRequirementFormat format = null,
            Models.BankAccountFields? requirement = null,
            List<Models.Translation> description = null,
            List<Models.BankAccountRequirementValidator> validators = null)
        {
            this.Format = format;
            this.Requirement = requirement;
            this.Description = description;
            this.Validators = validators;
        }

        /// <summary>
        /// Classifies the [format](#/rest/models/structures/bank-account-requirement-format) of the required information for a bank account
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountRequirementFormat Format { get; set; }

        /// <summary>
        /// Classifies bank account [field types](#/rest/models/structures/bank-account-fields)
        /// </summary>
        [JsonProperty("requirement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountFields? Requirement { get; set; }

        /// <summary>
        /// Localized requirement description for display purposes
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Translation> Description { get; set; }

        /// <summary>
        /// Gets or sets Validators.
        /// </summary>
        [JsonProperty("validators", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankAccountRequirementValidator> Validators { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountRequiredFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountRequiredFields other &&
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