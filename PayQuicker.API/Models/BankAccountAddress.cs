// <copyright file="BankAccountAddress.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// BankAccountAddress.
    /// </summary>
    public class BankAccountAddress : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAddress"/> class.
        /// </summary>
        public BankAccountAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccountAddress"/> class.
        /// </summary>
        /// <param name="address1">address1.</param>
        /// <param name="city">city.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="country">country.</param>
        /// <param name="address2">address2.</param>
        /// <param name="address3">address3.</param>
        /// <param name="region">region.</param>
        public BankAccountAddress(
            string address1,
            string city,
            string postalCode,
            Models.Countries country,
            string address2 = null,
            string address3 = null,
            string region = null)
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        /// <summary>
        /// Address Line 1
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets Address2.
        /// </summary>
        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets Address3.
        /// </summary>
        [JsonProperty("address3", NullValueHandling = NullValueHandling.Ignore)]
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets Region.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets PostalCode.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("country")]
        public Models.Countries Country { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BankAccountAddress : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BankAccountAddress other &&
                (this.Address1 == null && other.Address1 == null ||
                 this.Address1?.Equals(other.Address1) == true) &&
                (this.Address2 == null && other.Address2 == null ||
                 this.Address2?.Equals(other.Address2) == true) &&
                (this.Address3 == null && other.Address3 == null ||
                 this.Address3?.Equals(other.Address3) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.PostalCode == null && other.PostalCode == null ||
                 this.PostalCode?.Equals(other.PostalCode) == true) &&
                (this.Country.Equals(other.Country)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Address1 = {this.Address1 ?? "null"}");
            toStringOutput.Add($"Address2 = {this.Address2 ?? "null"}");
            toStringOutput.Add($"Address3 = {this.Address3 ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"PostalCode = {this.PostalCode ?? "null"}");
            toStringOutput.Add($"Country = {this.Country}");

            base.ToString(toStringOutput);
        }
    }
}