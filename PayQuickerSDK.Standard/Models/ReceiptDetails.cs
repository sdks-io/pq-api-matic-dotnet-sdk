// <copyright file="ReceiptDetails.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ReceiptDetails.
    /// </summary>
    public class ReceiptDetails : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptDetails"/> class.
        /// </summary>
        public ReceiptDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptDetails"/> class.
        /// </summary>
        /// <param name="bankAccountId">bankAccountId.</param>
        /// <param name="bankAccountIdType">bankAccountIdType.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="bankId">bankId.</param>
        /// <param name="bankIdType">bankIdType.</param>
        /// <param name="branchAddress">branchAddress.</param>
        /// <param name="branchCity">branchCity.</param>
        /// <param name="branchId">branchId.</param>
        /// <param name="branchName">branchName.</param>
        /// <param name="branchPostalCode">branchPostalCode.</param>
        /// <param name="branchPhoneNumber">branchPhoneNumber.</param>
        /// <param name="branchRegion">branchRegion.</param>
        /// <param name="beneficaryTaxId">beneficaryTaxId.</param>
        /// <param name="beneficaryTaxIdType">beneficaryTaxIdType.</param>
        /// <param name="beneficaryName">beneficaryName.</param>
        /// <param name="memo">memo.</param>
        /// <param name="note">note.</param>
        /// <param name="correlationToken">correlationToken.</param>
        /// <param name="cardExpiryDate">cardExpiryDate.</param>
        /// <param name="cardHolderName">cardHolderName.</param>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="electronicWalletAccountNumber">electronicWalletAccountNumber.</param>
        /// <param name="electronicWalletAccountNumberType">electronicWalletAccountNumberType.</param>
        /// <param name="electronicWalletGovernmentId">electronicWalletGovernmentId.</param>
        /// <param name="electronicWalletGovernmentIdType">electronicWalletGovernmentIdType.</param>
        /// <param name="electronicWalletType">electronicWalletType.</param>
        /// <param name="mobilePhoneNumber">mobilePhoneNumber.</param>
        /// <param name="electronicFundsTransferType">electronicFundsTransferType.</param>
        /// <param name="electronicFundsTransferFailureType">electronicFundsTransferFailureType.</param>
        /// <param name="electronicTransferStatusType">electronicTransferStatusType.</param>
        public ReceiptDetails(
            string bankAccountId = null,
            Models.BankAccountFields? bankAccountIdType = null,
            string bankName = null,
            string bankId = null,
            Models.BankAccountFields? bankIdType = null,
            string branchAddress = null,
            string branchCity = null,
            string branchId = null,
            string branchName = null,
            string branchPostalCode = null,
            string branchPhoneNumber = null,
            string branchRegion = null,
            string beneficaryTaxId = null,
            Models.BankAccountFields? beneficaryTaxIdType = null,
            string beneficaryName = null,
            string memo = null,
            string note = null,
            string correlationToken = null,
            string cardExpiryDate = null,
            string cardHolderName = null,
            string cardNumber = null,
            string electronicWalletAccountNumber = null,
            Models.ElectronicWalletFields? electronicWalletAccountNumberType = null,
            string electronicWalletGovernmentId = null,
            Models.ElectronicWalletFields? electronicWalletGovernmentIdType = null,
            Models.ElectronicWalletTypes? electronicWalletType = null,
            string mobilePhoneNumber = null,
            Models.ElectronicFundsTransferTypes? electronicFundsTransferType = null,
            Models.ElectronicTransferFailureTypes? electronicFundsTransferFailureType = null,
            Models.ElectronicTransferStatusTypes? electronicTransferStatusType = null)
        {
            this.BankAccountId = bankAccountId;
            this.BankAccountIdType = bankAccountIdType;
            this.BankName = bankName;
            this.BankId = bankId;
            this.BankIdType = bankIdType;
            this.BranchAddress = branchAddress;
            this.BranchCity = branchCity;
            this.BranchId = branchId;
            this.BranchName = branchName;
            this.BranchPostalCode = branchPostalCode;
            this.BranchPhoneNumber = branchPhoneNumber;
            this.BranchRegion = branchRegion;
            this.BeneficaryTaxId = beneficaryTaxId;
            this.BeneficaryTaxIdType = beneficaryTaxIdType;
            this.BeneficaryName = beneficaryName;
            this.Memo = memo;
            this.Note = note;
            this.CorrelationToken = correlationToken;
            this.CardExpiryDate = cardExpiryDate;
            this.CardHolderName = cardHolderName;
            this.CardNumber = cardNumber;
            this.ElectronicWalletAccountNumber = electronicWalletAccountNumber;
            this.ElectronicWalletAccountNumberType = electronicWalletAccountNumberType;
            this.ElectronicWalletGovernmentId = electronicWalletGovernmentId;
            this.ElectronicWalletGovernmentIdType = electronicWalletGovernmentIdType;
            this.ElectronicWalletType = electronicWalletType;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.ElectronicFundsTransferType = electronicFundsTransferType;
            this.ElectronicFundsTransferFailureType = electronicFundsTransferFailureType;
            this.ElectronicTransferStatusType = electronicTransferStatusType;
        }

        /// <summary>
        /// Bank account ID for the bank account
        /// </summary>
        [JsonProperty("bankAccountId", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountId { get; set; }

        /// <summary>
        /// Classifies bank account [field types](#/rest/models/structures/bank-account-fields)
        /// </summary>
        [JsonProperty("bankAccountIdType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountFields? BankAccountIdType { get; set; }

        /// <summary>
        /// Name of the bank the account is registered to
        /// </summary>
        [JsonProperty("bankName", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// The bank id
        /// </summary>
        [JsonProperty("bankId", NullValueHandling = NullValueHandling.Ignore)]
        public string BankId { get; set; }

        /// <summary>
        /// Classifies bank account [field types](#/rest/models/structures/bank-account-fields)
        /// </summary>
        [JsonProperty("bankIdType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountFields? BankIdType { get; set; }

        /// <summary>
        /// The bank branch address
        /// </summary>
        [JsonProperty("branchAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchAddress { get; set; }

        /// <summary>
        /// The bank branch city
        /// </summary>
        [JsonProperty("branchCity", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchCity { get; set; }

        /// <summary>
        /// The bank branch id
        /// </summary>
        [JsonProperty("branchId", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchId { get; set; }

        /// <summary>
        /// The bank branch name
        /// </summary>
        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// The bank branch postal code
        /// </summary>
        [JsonProperty("branchPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchPostalCode { get; set; }

        /// <summary>
        /// The bank branch phone number
        /// </summary>
        [JsonProperty("branchPhoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchPhoneNumber { get; set; }

        /// <summary>
        /// The bank branch region
        /// </summary>
        [JsonProperty("branchRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchRegion { get; set; }

        /// <summary>
        /// The beneficiary's tax id
        /// </summary>
        [JsonProperty("beneficaryTaxId", NullValueHandling = NullValueHandling.Ignore)]
        public string BeneficaryTaxId { get; set; }

        /// <summary>
        /// Classifies bank account [field types](#/rest/models/structures/bank-account-fields)
        /// </summary>
        [JsonProperty("beneficaryTaxIdType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountFields? BeneficaryTaxIdType { get; set; }

        /// <summary>
        /// The name of the person chosen to inherit your account
        /// </summary>
        [JsonProperty("beneficaryName", NullValueHandling = NullValueHandling.Ignore)]
        public string BeneficaryName { get; set; }

        /// <summary>
        /// Optional internal [memo](#/rest/models/structures/memo) not visible to the user
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// [Optional comments](#/rest/models/structures/notes) visible to the user
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("correlationToken", NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationToken { get; set; }

        /// <summary>
        /// Date that the card will expire
        /// </summary>
        [JsonProperty("cardExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string CardExpiryDate { get; set; }

        /// <summary>
        /// Name of the card's owner
        /// </summary>
        [JsonProperty("cardHolderName", NullValueHandling = NullValueHandling.Ignore)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// Unique number on the prepaid card
        /// </summary>
        [JsonProperty("cardNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Account number for the electronic wallet
        /// </summary>
        [JsonProperty("electronicWalletAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string ElectronicWalletAccountNumber { get; set; }

        /// <summary>
        /// Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields)
        /// </summary>
        [JsonProperty("electronicWalletAccountNumberType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletFields? ElectronicWalletAccountNumberType { get; set; }

        /// <summary>
        /// Government ID for the electronic wallet
        /// </summary>
        [JsonProperty("electronicWalletGovernmentId", NullValueHandling = NullValueHandling.Ignore)]
        public string ElectronicWalletGovernmentId { get; set; }

        /// <summary>
        /// Classifies electronic wallet [field types](#/rest/models/structures/electronic-wallet-fields)
        /// </summary>
        [JsonProperty("electronicWalletGovernmentIdType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletFields? ElectronicWalletGovernmentIdType { get; set; }

        /// <summary>
        /// Name of the electronic wallet
        /// </summary>
        [JsonProperty("electronicWalletType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicWalletTypes? ElectronicWalletType { get; set; }

        /// <summary>
        /// Gets or sets MobilePhoneNumber.
        /// </summary>
        [JsonProperty("mobilePhoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// The type of transfer performed
        /// </summary>
        [JsonProperty("electronicFundsTransferType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicFundsTransferTypes? ElectronicFundsTransferType { get; set; }

        /// <summary>
        /// The type of failure for a bank transfer
        /// </summary>
        [JsonProperty("electronicFundsTransferFailureType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicTransferFailureTypes? ElectronicFundsTransferFailureType { get; set; }

        /// <summary>
        /// The status of a bank transfer
        /// </summary>
        [JsonProperty("electronicTransferStatusType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectronicTransferStatusTypes? ElectronicTransferStatusType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReceiptDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReceiptDetails other &&
                (this.BankAccountId == null && other.BankAccountId == null ||
                 this.BankAccountId?.Equals(other.BankAccountId) == true) &&
                (this.BankAccountIdType == null && other.BankAccountIdType == null ||
                 this.BankAccountIdType?.Equals(other.BankAccountIdType) == true) &&
                (this.BankName == null && other.BankName == null ||
                 this.BankName?.Equals(other.BankName) == true) &&
                (this.BankId == null && other.BankId == null ||
                 this.BankId?.Equals(other.BankId) == true) &&
                (this.BankIdType == null && other.BankIdType == null ||
                 this.BankIdType?.Equals(other.BankIdType) == true) &&
                (this.BranchAddress == null && other.BranchAddress == null ||
                 this.BranchAddress?.Equals(other.BranchAddress) == true) &&
                (this.BranchCity == null && other.BranchCity == null ||
                 this.BranchCity?.Equals(other.BranchCity) == true) &&
                (this.BranchId == null && other.BranchId == null ||
                 this.BranchId?.Equals(other.BranchId) == true) &&
                (this.BranchName == null && other.BranchName == null ||
                 this.BranchName?.Equals(other.BranchName) == true) &&
                (this.BranchPostalCode == null && other.BranchPostalCode == null ||
                 this.BranchPostalCode?.Equals(other.BranchPostalCode) == true) &&
                (this.BranchPhoneNumber == null && other.BranchPhoneNumber == null ||
                 this.BranchPhoneNumber?.Equals(other.BranchPhoneNumber) == true) &&
                (this.BranchRegion == null && other.BranchRegion == null ||
                 this.BranchRegion?.Equals(other.BranchRegion) == true) &&
                (this.BeneficaryTaxId == null && other.BeneficaryTaxId == null ||
                 this.BeneficaryTaxId?.Equals(other.BeneficaryTaxId) == true) &&
                (this.BeneficaryTaxIdType == null && other.BeneficaryTaxIdType == null ||
                 this.BeneficaryTaxIdType?.Equals(other.BeneficaryTaxIdType) == true) &&
                (this.BeneficaryName == null && other.BeneficaryName == null ||
                 this.BeneficaryName?.Equals(other.BeneficaryName) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                (this.CorrelationToken == null && other.CorrelationToken == null ||
                 this.CorrelationToken?.Equals(other.CorrelationToken) == true) &&
                (this.CardExpiryDate == null && other.CardExpiryDate == null ||
                 this.CardExpiryDate?.Equals(other.CardExpiryDate) == true) &&
                (this.CardHolderName == null && other.CardHolderName == null ||
                 this.CardHolderName?.Equals(other.CardHolderName) == true) &&
                (this.CardNumber == null && other.CardNumber == null ||
                 this.CardNumber?.Equals(other.CardNumber) == true) &&
                (this.ElectronicWalletAccountNumber == null && other.ElectronicWalletAccountNumber == null ||
                 this.ElectronicWalletAccountNumber?.Equals(other.ElectronicWalletAccountNumber) == true) &&
                (this.ElectronicWalletAccountNumberType == null && other.ElectronicWalletAccountNumberType == null ||
                 this.ElectronicWalletAccountNumberType?.Equals(other.ElectronicWalletAccountNumberType) == true) &&
                (this.ElectronicWalletGovernmentId == null && other.ElectronicWalletGovernmentId == null ||
                 this.ElectronicWalletGovernmentId?.Equals(other.ElectronicWalletGovernmentId) == true) &&
                (this.ElectronicWalletGovernmentIdType == null && other.ElectronicWalletGovernmentIdType == null ||
                 this.ElectronicWalletGovernmentIdType?.Equals(other.ElectronicWalletGovernmentIdType) == true) &&
                (this.ElectronicWalletType == null && other.ElectronicWalletType == null ||
                 this.ElectronicWalletType?.Equals(other.ElectronicWalletType) == true) &&
                (this.MobilePhoneNumber == null && other.MobilePhoneNumber == null ||
                 this.MobilePhoneNumber?.Equals(other.MobilePhoneNumber) == true) &&
                (this.ElectronicFundsTransferType == null && other.ElectronicFundsTransferType == null ||
                 this.ElectronicFundsTransferType?.Equals(other.ElectronicFundsTransferType) == true) &&
                (this.ElectronicFundsTransferFailureType == null && other.ElectronicFundsTransferFailureType == null ||
                 this.ElectronicFundsTransferFailureType?.Equals(other.ElectronicFundsTransferFailureType) == true) &&
                (this.ElectronicTransferStatusType == null && other.ElectronicTransferStatusType == null ||
                 this.ElectronicTransferStatusType?.Equals(other.ElectronicTransferStatusType) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BankAccountId = {this.BankAccountId ?? "null"}");
            toStringOutput.Add($"BankAccountIdType = {(this.BankAccountIdType == null ? "null" : this.BankAccountIdType.ToString())}");
            toStringOutput.Add($"BankName = {this.BankName ?? "null"}");
            toStringOutput.Add($"BankId = {this.BankId ?? "null"}");
            toStringOutput.Add($"BankIdType = {(this.BankIdType == null ? "null" : this.BankIdType.ToString())}");
            toStringOutput.Add($"BranchAddress = {this.BranchAddress ?? "null"}");
            toStringOutput.Add($"BranchCity = {this.BranchCity ?? "null"}");
            toStringOutput.Add($"BranchId = {this.BranchId ?? "null"}");
            toStringOutput.Add($"BranchName = {this.BranchName ?? "null"}");
            toStringOutput.Add($"BranchPostalCode = {this.BranchPostalCode ?? "null"}");
            toStringOutput.Add($"BranchPhoneNumber = {this.BranchPhoneNumber ?? "null"}");
            toStringOutput.Add($"BranchRegion = {this.BranchRegion ?? "null"}");
            toStringOutput.Add($"BeneficaryTaxId = {this.BeneficaryTaxId ?? "null"}");
            toStringOutput.Add($"BeneficaryTaxIdType = {(this.BeneficaryTaxIdType == null ? "null" : this.BeneficaryTaxIdType.ToString())}");
            toStringOutput.Add($"BeneficaryName = {this.BeneficaryName ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Note = {this.Note ?? "null"}");
            toStringOutput.Add($"CorrelationToken = {this.CorrelationToken ?? "null"}");
            toStringOutput.Add($"CardExpiryDate = {this.CardExpiryDate ?? "null"}");
            toStringOutput.Add($"CardHolderName = {this.CardHolderName ?? "null"}");
            toStringOutput.Add($"CardNumber = {this.CardNumber ?? "null"}");
            toStringOutput.Add($"ElectronicWalletAccountNumber = {this.ElectronicWalletAccountNumber ?? "null"}");
            toStringOutput.Add($"ElectronicWalletAccountNumberType = {(this.ElectronicWalletAccountNumberType == null ? "null" : this.ElectronicWalletAccountNumberType.ToString())}");
            toStringOutput.Add($"ElectronicWalletGovernmentId = {this.ElectronicWalletGovernmentId ?? "null"}");
            toStringOutput.Add($"ElectronicWalletGovernmentIdType = {(this.ElectronicWalletGovernmentIdType == null ? "null" : this.ElectronicWalletGovernmentIdType.ToString())}");
            toStringOutput.Add($"ElectronicWalletType = {(this.ElectronicWalletType == null ? "null" : this.ElectronicWalletType.ToString())}");
            toStringOutput.Add($"MobilePhoneNumber = {this.MobilePhoneNumber ?? "null"}");
            toStringOutput.Add($"ElectronicFundsTransferType = {(this.ElectronicFundsTransferType == null ? "null" : this.ElectronicFundsTransferType.ToString())}");
            toStringOutput.Add($"ElectronicFundsTransferFailureType = {(this.ElectronicFundsTransferFailureType == null ? "null" : this.ElectronicFundsTransferFailureType.ToString())}");
            toStringOutput.Add($"ElectronicTransferStatusType = {(this.ElectronicTransferStatusType == null ? "null" : this.ElectronicTransferStatusType.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}