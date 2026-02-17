// <copyright file="CreateOrUpdateBankAccount.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// CreateOrUpdateBankAccount.
    /// </summary>
    public class CreateOrUpdateBankAccount : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateBankAccount"/> class.
        /// </summary>
        public CreateOrUpdateBankAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateBankAccount"/> class.
        /// </summary>
        /// <param name="bankAccountOwnershipType">bankAccountOwnershipType.</param>
        /// <param name="bankCountry">bankCountry.</param>
        /// <param name="bankCurrency">bankCurrency.</param>
        /// <param name="description">description.</param>
        /// <param name="fields">fields.</param>
        /// <param name="type">type.</param>
        /// <param name="transferMethodType">transferMethodType.</param>
        /// <param name="address">address.</param>
        public CreateOrUpdateBankAccount(
            Models.BankAccountOwnership? bankAccountOwnershipType = null,
            Models.Countries? bankCountry = null,
            Models.Currencies? bankCurrency = Models.Currencies.Usd,
            string description = null,
            List<Models.BankAccountField> fields = null,
            Models.BankAccountTypes? type = null,
            Models.TransferMethodTypes? transferMethodType = null,
            Models.BankAccountAddress address = null)
        {
            this.BankAccountOwnershipType = bankAccountOwnershipType;
            this.BankCountry = bankCountry;
            this.BankCurrency = bankCurrency;
            this.Description = description;
            this.Fields = fields;
            this.Type = type;
            this.TransferMethodType = transferMethodType;
            this.Address = address;
        }

        /// <summary>
        /// Account [ownership types](#/rest/models/structures/bank-account-ownership)
        /// </summary>
        [JsonProperty("bankAccountOwnershipType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountOwnership? BankAccountOwnershipType { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("bankCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? BankCountry { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("bankCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? BankCurrency { get; set; }

        /// <summary>
        /// User-supplied description of the bank account for reference
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BankAccountField> Fields { get; set; }

        /// <summary>
        /// Financial purpose of the [bank account](#/rest/models/structures/bank-account-type)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountTypes? Type { get; set; }

        /// <summary>
        /// Optional transfer methods applicable only to bank and e-wallet transfers.
        /// </summary>
        [JsonProperty("transferMethodType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransferMethodTypes? TransferMethodType { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountAddress Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrUpdateBankAccount : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateBankAccount other &&
                (this.BankAccountOwnershipType == null && other.BankAccountOwnershipType == null ||
                 this.BankAccountOwnershipType?.Equals(other.BankAccountOwnershipType) == true) &&
                (this.BankCountry == null && other.BankCountry == null ||
                 this.BankCountry?.Equals(other.BankCountry) == true) &&
                (this.BankCurrency == null && other.BankCurrency == null ||
                 this.BankCurrency?.Equals(other.BankCurrency) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.TransferMethodType == null && other.TransferMethodType == null ||
                 this.TransferMethodType?.Equals(other.TransferMethodType) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BankAccountOwnershipType = {(this.BankAccountOwnershipType == null ? "null" : this.BankAccountOwnershipType.ToString())}");
            toStringOutput.Add($"BankCountry = {(this.BankCountry == null ? "null" : this.BankCountry.ToString())}");
            toStringOutput.Add($"BankCurrency = {(this.BankCurrency == null ? "null" : this.BankCurrency.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : $"[{string.Join(", ", this.Fields)} ]")}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"TransferMethodType = {(this.TransferMethodType == null ? "null" : this.TransferMethodType.ToString())}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}