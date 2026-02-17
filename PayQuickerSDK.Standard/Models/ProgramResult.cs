// <copyright file="ProgramResult.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ProgramResult.
    /// </summary>
    public class ProgramResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramResult"/> class.
        /// </summary>
        public ProgramResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="currency">currency.</param>
        /// <param name="bank">bank.</param>
        /// <param name="type">type.</param>
        /// <param name="electronicWallets">electronicWallets.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public ProgramResult(
            string token,
            Models.Currencies currency,
            Models.BankTypes bank,
            Models.ProgramTypes type,
            List<Models.ElectronicWalletType> electronicWallets = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.Currency = currency;
            this.Bank = bank;
            this.ElectronicWallets = electronicWallets;
            this.Type = type;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// Auto-generated unique identifier representing a program, prefixed with prog-
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency")]
        public Models.Currencies Currency { get; set; }

        /// <summary>
        /// Name of the bank
        /// </summary>
        [JsonProperty("bank")]
        public Models.BankTypes Bank { get; set; }

        /// <summary>
        /// Gets or sets ElectronicWallets.
        /// </summary>
        [JsonProperty("electronicWallets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ElectronicWalletType> ElectronicWallets { get; set; }

        /// <summary>
        /// Indicates the type of program associated with a prepaid card
        /// </summary>
        [JsonProperty("type")]
        public Models.ProgramTypes Type { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetadataItems Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProgramResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProgramResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.Currency.Equals(other.Currency)) &&
                (this.Bank.Equals(other.Bank)) &&
                (this.ElectronicWallets == null && other.ElectronicWallets == null ||
                 this.ElectronicWallets?.Equals(other.ElectronicWallets) == true) &&
                (this.Type.Equals(other.Type)) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency}");
            toStringOutput.Add($"Bank = {this.Bank}");
            toStringOutput.Add($"ElectronicWallets = {(this.ElectronicWallets == null ? "null" : $"[{string.Join(", ", this.ElectronicWallets)} ]")}");
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}