// <copyright file="BankAccountRequirementValidator.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// BankAccountRequirementValidator.
    /// </summary>
    public class BankAccountRequirementValidator : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequirementValidator"/> class.
        /// </summary>
        public BankAccountRequirementValidator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountRequirementValidator"/> class.
        /// </summary>
        /// <param name="expression">expression.</param>
        /// <param name="validatorType">validatorType.</param>
        public BankAccountRequirementValidator(
            string expression,
            Models.ValidatorTypes? validatorType = null)
        {
            this.ValidatorType = validatorType;
            this.Expression = expression;
        }

        /// <summary>
        /// [Validator types](#/rest/models/structures/bank-account-requirement-validator) for the required bank account information.
        /// </summary>
        [JsonProperty("validatorType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ValidatorTypes? ValidatorType { get; set; }

        /// <summary>
        /// Validation regular expression
        /// </summary>
        [JsonProperty("expression")]
        public string Expression { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountRequirementValidator : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountRequirementValidator other &&
                (this.ValidatorType == null && other.ValidatorType == null ||
                 this.ValidatorType?.Equals(other.ValidatorType) == true) &&
                (this.Expression == null && other.Expression == null ||
                 this.Expression?.Equals(other.Expression) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ValidatorType = {(this.ValidatorType == null ? "null" : this.ValidatorType.ToString())}");
            toStringOutput.Add($"Expression = {this.Expression ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}