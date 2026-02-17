// <copyright file="CreateOrUpdateUser.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// CreateOrUpdateUser.
    /// </summary>
    public class CreateOrUpdateUser : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateUser"/> class.
        /// </summary>
        public CreateOrUpdateUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateUser"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="email">email.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="taxResidentStatus">taxResidentStatus.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="mobileNumber">mobileNumber.</param>
        /// <param name="phoneNumberCountry">phoneNumberCountry.</param>
        /// <param name="mobileNumberCountry">mobileNumberCountry.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="addressLine3">addressLine3.</param>
        /// <param name="city">city.</param>
        /// <param name="region">region.</param>
        /// <param name="country">country.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="gender">gender.</param>
        /// <param name="userType">userType.</param>
        /// <param name="language">language.</param>
        /// <param name="countryOfBirth">countryOfBirth.</param>
        /// <param name="countryOfNationality">countryOfNationality.</param>
        /// <param name="businessContactRole">businessContactRole.</param>
        /// <param name="governmentIdType">governmentIdType.</param>
        /// <param name="governmentId">governmentId.</param>
        /// <param name="occupationTitle">occupationTitle.</param>
        /// <param name="occupationType">occupationType.</param>
        /// <param name="mailingAddressLine1">mailingAddressLine1.</param>
        /// <param name="mailingAddressLine2">mailingAddressLine2.</param>
        /// <param name="mailingAddressLine3">mailingAddressLine3.</param>
        /// <param name="mailingCountry">mailingCountry.</param>
        /// <param name="mailingCity">mailingCity.</param>
        /// <param name="mailingRegion">mailingRegion.</param>
        /// <param name="mailingPostalCode">mailingPostalCode.</param>
        /// <param name="businessAddressLine1">businessAddressLine1.</param>
        /// <param name="businessAddressLine2">businessAddressLine2.</param>
        /// <param name="businessAddressLine3">businessAddressLine3.</param>
        /// <param name="businessCountry">businessCountry.</param>
        /// <param name="businessCity">businessCity.</param>
        /// <param name="businessRegion">businessRegion.</param>
        /// <param name="businessPostalCode">businessPostalCode.</param>
        /// <param name="premiseNumber">premiseNumber.</param>
        /// <param name="programToken">programToken.</param>
        /// <param name="primaryUserToken">primaryUserToken.</param>
        public CreateOrUpdateUser(
            Models.Currencies? currency = Models.Currencies.Usd,
            string programUserId = null,
            string email = null,
            string firstName = null,
            string lastName = null,
            DateTime? dateOfBirth = null,
            Models.TaxResidentStatuses? taxResidentStatus = null,
            string phoneNumber = null,
            string mobileNumber = null,
            Models.Countries? phoneNumberCountry = null,
            Models.Countries? mobileNumberCountry = null,
            string addressLine1 = null,
            string addressLine2 = null,
            string addressLine3 = null,
            string city = null,
            string region = null,
            Models.Countries? country = null,
            string postalCode = null,
            Models.Genders? gender = null,
            Models.UserTypes? userType = null,
            Models.Languages? language = null,
            Models.Countries? countryOfBirth = null,
            Models.Countries? countryOfNationality = null,
            Models.BusinessContactRoles? businessContactRole = null,
            Models.GovernmentIds? governmentIdType = null,
            string governmentId = null,
            string occupationTitle = null,
            Models.Occupations? occupationType = null,
            string mailingAddressLine1 = null,
            string mailingAddressLine2 = null,
            string mailingAddressLine3 = null,
            Models.Countries? mailingCountry = null,
            string mailingCity = null,
            string mailingRegion = null,
            string mailingPostalCode = null,
            string businessAddressLine1 = null,
            string businessAddressLine2 = null,
            string businessAddressLine3 = null,
            Models.Countries? businessCountry = null,
            string businessCity = null,
            string businessRegion = null,
            string businessPostalCode = null,
            string premiseNumber = null,
            string programToken = null,
            string primaryUserToken = null)
        {
            this.Currency = currency;
            this.ProgramUserId = programUserId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.TaxResidentStatus = taxResidentStatus;
            this.PhoneNumber = phoneNumber;
            this.MobileNumber = mobileNumber;
            this.PhoneNumberCountry = phoneNumberCountry;
            this.MobileNumberCountry = mobileNumberCountry;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.Region = region;
            this.Country = country;
            this.PostalCode = postalCode;
            this.Gender = gender;
            this.UserType = userType;
            this.Language = language;
            this.CountryOfBirth = countryOfBirth;
            this.CountryOfNationality = countryOfNationality;
            this.BusinessContactRole = businessContactRole;
            this.GovernmentIdType = governmentIdType;
            this.GovernmentId = governmentId;
            this.OccupationTitle = occupationTitle;
            this.OccupationType = occupationType;
            this.MailingAddressLine1 = mailingAddressLine1;
            this.MailingAddressLine2 = mailingAddressLine2;
            this.MailingAddressLine3 = mailingAddressLine3;
            this.MailingCountry = mailingCountry;
            this.MailingCity = mailingCity;
            this.MailingRegion = mailingRegion;
            this.MailingPostalCode = mailingPostalCode;
            this.BusinessAddressLine1 = businessAddressLine1;
            this.BusinessAddressLine2 = businessAddressLine2;
            this.BusinessAddressLine3 = businessAddressLine3;
            this.BusinessCountry = businessCountry;
            this.BusinessCity = businessCity;
            this.BusinessRegion = businessRegion;
            this.BusinessPostalCode = businessPostalCode;
            this.PremiseNumber = premiseNumber;
            this.ProgramToken = programToken;
            this.PrimaryUserToken = primaryUserToken;
        }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? Currency { get; set; }

        /// <summary>
        /// [Program identifier](#/rest/models/structures/program-user-id) for the user
        /// </summary>
        [JsonProperty("programUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramUserId { get; set; }

        /// <summary>
        /// Contact [email address](#/rest/models/structures/email-address) for the user account for the user account
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets DateOfBirth.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Tax [resident status type](#/rest/models/structures/tax-resident-status)
        /// </summary>
        [JsonProperty("taxResidentStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TaxResidentStatuses? TaxResidentStatus { get; set; }

        /// <summary>
        /// Gets or sets PhoneNumber.
        /// </summary>
        [JsonProperty("phoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets MobileNumber.
        /// </summary>
        [JsonProperty("mobileNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("phoneNumberCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? PhoneNumberCountry { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("mobileNumberCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? MobileNumberCountry { get; set; }

        /// <summary>
        /// Address Line 1
        /// </summary>
        [JsonProperty("addressLine1", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets AddressLine2.
        /// </summary>
        [JsonProperty("addressLine2", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets AddressLine3.
        /// </summary>
        [JsonProperty("addressLine3", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets Region.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? Country { get; set; }

        /// <summary>
        /// Gets or sets PostalCode.
        /// </summary>
        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// [Gender](#/rest/models/structures/gender) as a user identifies
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Genders? Gender { get; set; }

        /// <summary>
        /// Account holder's profile [type](#/rest/models/structures/user-type)
        /// </summary>
        [JsonProperty("userType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserTypes? UserType { get; set; }

        /// <summary>
        /// The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Languages? Language { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("countryOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? CountryOfBirth { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("countryOfNationality", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? CountryOfNationality { get; set; }

        /// <summary>
        /// Business contact role
        /// </summary>
        [JsonProperty("businessContactRole", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BusinessContactRoles? BusinessContactRole { get; set; }

        /// <summary>
        /// Indicates the type of ID submitted for user verification purposes.
        /// </summary>
        [JsonProperty("governmentIdType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GovernmentIds? GovernmentIdType { get; set; }

        /// <summary>
        /// Gets or sets GovernmentId.
        /// </summary>
        [JsonProperty("governmentId", NullValueHandling = NullValueHandling.Ignore)]
        public string GovernmentId { get; set; }

        /// <summary>
        /// Gets or sets OccupationTitle.
        /// </summary>
        [JsonProperty("occupationTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string OccupationTitle { get; set; }

        /// <summary>
        /// [Type of occupation](#/rest/models/structures/occupation) for the user
        /// </summary>
        [JsonProperty("occupationType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Occupations? OccupationType { get; set; }

        /// <summary>
        /// Gets or sets MailingAddressLine1.
        /// </summary>
        [JsonProperty("mailingAddressLine1", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingAddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets MailingAddressLine2.
        /// </summary>
        [JsonProperty("mailingAddressLine2", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingAddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets MailingAddressLine3.
        /// </summary>
        [JsonProperty("mailingAddressLine3", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingAddressLine3 { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("mailingCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? MailingCountry { get; set; }

        /// <summary>
        /// Gets or sets MailingCity.
        /// </summary>
        [JsonProperty("mailingCity", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingCity { get; set; }

        /// <summary>
        /// Gets or sets MailingRegion.
        /// </summary>
        [JsonProperty("mailingRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingRegion { get; set; }

        /// <summary>
        /// Gets or sets MailingPostalCode.
        /// </summary>
        [JsonProperty("mailingPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// Business address line 1
        /// </summary>
        [JsonProperty("businessAddressLine1", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessAddressLine1 { get; set; }

        /// <summary>
        /// Business address line 2
        /// </summary>
        [JsonProperty("businessAddressLine2", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessAddressLine2 { get; set; }

        /// <summary>
        /// Business address line 3
        /// </summary>
        [JsonProperty("businessAddressLine3", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessAddressLine3 { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("businessCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? BusinessCountry { get; set; }

        /// <summary>
        /// Business city
        /// </summary>
        [JsonProperty("businessCity", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCity { get; set; }

        /// <summary>
        /// Region that the business is based out of
        /// </summary>
        [JsonProperty("businessRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessRegion { get; set; }

        /// <summary>
        /// Gets or sets BusinessPostalCode.
        /// </summary>
        [JsonProperty("businessPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessPostalCode { get; set; }

        /// <summary>
        /// Gets or sets PremiseNumber.
        /// </summary>
        [JsonProperty("premiseNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PremiseNumber { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a program, prefixed with prog-
        /// </summary>
        [JsonProperty("programToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramToken { get; set; }

        /// <summary>
        /// Auto-generated unique identifier representing a user, prefixed with `user-`.
        /// </summary>
        [JsonProperty("primaryUserToken", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryUserToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrUpdateUser : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrUpdateUser other &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.ProgramUserId == null && other.ProgramUserId == null ||
                 this.ProgramUserId?.Equals(other.ProgramUserId) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.DateOfBirth == null && other.DateOfBirth == null ||
                 this.DateOfBirth?.Equals(other.DateOfBirth) == true) &&
                (this.TaxResidentStatus == null && other.TaxResidentStatus == null ||
                 this.TaxResidentStatus?.Equals(other.TaxResidentStatus) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.MobileNumber == null && other.MobileNumber == null ||
                 this.MobileNumber?.Equals(other.MobileNumber) == true) &&
                (this.PhoneNumberCountry == null && other.PhoneNumberCountry == null ||
                 this.PhoneNumberCountry?.Equals(other.PhoneNumberCountry) == true) &&
                (this.MobileNumberCountry == null && other.MobileNumberCountry == null ||
                 this.MobileNumberCountry?.Equals(other.MobileNumberCountry) == true) &&
                (this.AddressLine1 == null && other.AddressLine1 == null ||
                 this.AddressLine1?.Equals(other.AddressLine1) == true) &&
                (this.AddressLine2 == null && other.AddressLine2 == null ||
                 this.AddressLine2?.Equals(other.AddressLine2) == true) &&
                (this.AddressLine3 == null && other.AddressLine3 == null ||
                 this.AddressLine3?.Equals(other.AddressLine3) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.PostalCode == null && other.PostalCode == null ||
                 this.PostalCode?.Equals(other.PostalCode) == true) &&
                (this.Gender == null && other.Gender == null ||
                 this.Gender?.Equals(other.Gender) == true) &&
                (this.UserType == null && other.UserType == null ||
                 this.UserType?.Equals(other.UserType) == true) &&
                (this.Language == null && other.Language == null ||
                 this.Language?.Equals(other.Language) == true) &&
                (this.CountryOfBirth == null && other.CountryOfBirth == null ||
                 this.CountryOfBirth?.Equals(other.CountryOfBirth) == true) &&
                (this.CountryOfNationality == null && other.CountryOfNationality == null ||
                 this.CountryOfNationality?.Equals(other.CountryOfNationality) == true) &&
                (this.BusinessContactRole == null && other.BusinessContactRole == null ||
                 this.BusinessContactRole?.Equals(other.BusinessContactRole) == true) &&
                (this.GovernmentIdType == null && other.GovernmentIdType == null ||
                 this.GovernmentIdType?.Equals(other.GovernmentIdType) == true) &&
                (this.GovernmentId == null && other.GovernmentId == null ||
                 this.GovernmentId?.Equals(other.GovernmentId) == true) &&
                (this.OccupationTitle == null && other.OccupationTitle == null ||
                 this.OccupationTitle?.Equals(other.OccupationTitle) == true) &&
                (this.OccupationType == null && other.OccupationType == null ||
                 this.OccupationType?.Equals(other.OccupationType) == true) &&
                (this.MailingAddressLine1 == null && other.MailingAddressLine1 == null ||
                 this.MailingAddressLine1?.Equals(other.MailingAddressLine1) == true) &&
                (this.MailingAddressLine2 == null && other.MailingAddressLine2 == null ||
                 this.MailingAddressLine2?.Equals(other.MailingAddressLine2) == true) &&
                (this.MailingAddressLine3 == null && other.MailingAddressLine3 == null ||
                 this.MailingAddressLine3?.Equals(other.MailingAddressLine3) == true) &&
                (this.MailingCountry == null && other.MailingCountry == null ||
                 this.MailingCountry?.Equals(other.MailingCountry) == true) &&
                (this.MailingCity == null && other.MailingCity == null ||
                 this.MailingCity?.Equals(other.MailingCity) == true) &&
                (this.MailingRegion == null && other.MailingRegion == null ||
                 this.MailingRegion?.Equals(other.MailingRegion) == true) &&
                (this.MailingPostalCode == null && other.MailingPostalCode == null ||
                 this.MailingPostalCode?.Equals(other.MailingPostalCode) == true) &&
                (this.BusinessAddressLine1 == null && other.BusinessAddressLine1 == null ||
                 this.BusinessAddressLine1?.Equals(other.BusinessAddressLine1) == true) &&
                (this.BusinessAddressLine2 == null && other.BusinessAddressLine2 == null ||
                 this.BusinessAddressLine2?.Equals(other.BusinessAddressLine2) == true) &&
                (this.BusinessAddressLine3 == null && other.BusinessAddressLine3 == null ||
                 this.BusinessAddressLine3?.Equals(other.BusinessAddressLine3) == true) &&
                (this.BusinessCountry == null && other.BusinessCountry == null ||
                 this.BusinessCountry?.Equals(other.BusinessCountry) == true) &&
                (this.BusinessCity == null && other.BusinessCity == null ||
                 this.BusinessCity?.Equals(other.BusinessCity) == true) &&
                (this.BusinessRegion == null && other.BusinessRegion == null ||
                 this.BusinessRegion?.Equals(other.BusinessRegion) == true) &&
                (this.BusinessPostalCode == null && other.BusinessPostalCode == null ||
                 this.BusinessPostalCode?.Equals(other.BusinessPostalCode) == true) &&
                (this.PremiseNumber == null && other.PremiseNumber == null ||
                 this.PremiseNumber?.Equals(other.PremiseNumber) == true) &&
                (this.ProgramToken == null && other.ProgramToken == null ||
                 this.ProgramToken?.Equals(other.ProgramToken) == true) &&
                (this.PrimaryUserToken == null && other.PrimaryUserToken == null ||
                 this.PrimaryUserToken?.Equals(other.PrimaryUserToken) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"TaxResidentStatus = {(this.TaxResidentStatus == null ? "null" : this.TaxResidentStatus.ToString())}");
            toStringOutput.Add($"PhoneNumber = {this.PhoneNumber ?? "null"}");
            toStringOutput.Add($"MobileNumber = {this.MobileNumber ?? "null"}");
            toStringOutput.Add($"PhoneNumberCountry = {(this.PhoneNumberCountry == null ? "null" : this.PhoneNumberCountry.ToString())}");
            toStringOutput.Add($"MobileNumberCountry = {(this.MobileNumberCountry == null ? "null" : this.MobileNumberCountry.ToString())}");
            toStringOutput.Add($"AddressLine1 = {this.AddressLine1 ?? "null"}");
            toStringOutput.Add($"AddressLine2 = {this.AddressLine2 ?? "null"}");
            toStringOutput.Add($"AddressLine3 = {this.AddressLine3 ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"Country = {(this.Country == null ? "null" : this.Country.ToString())}");
            toStringOutput.Add($"PostalCode = {this.PostalCode ?? "null"}");
            toStringOutput.Add($"Gender = {(this.Gender == null ? "null" : this.Gender.ToString())}");
            toStringOutput.Add($"UserType = {(this.UserType == null ? "null" : this.UserType.ToString())}");
            toStringOutput.Add($"Language = {(this.Language == null ? "null" : this.Language.ToString())}");
            toStringOutput.Add($"CountryOfBirth = {(this.CountryOfBirth == null ? "null" : this.CountryOfBirth.ToString())}");
            toStringOutput.Add($"CountryOfNationality = {(this.CountryOfNationality == null ? "null" : this.CountryOfNationality.ToString())}");
            toStringOutput.Add($"BusinessContactRole = {(this.BusinessContactRole == null ? "null" : this.BusinessContactRole.ToString())}");
            toStringOutput.Add($"GovernmentIdType = {(this.GovernmentIdType == null ? "null" : this.GovernmentIdType.ToString())}");
            toStringOutput.Add($"GovernmentId = {this.GovernmentId ?? "null"}");
            toStringOutput.Add($"OccupationTitle = {this.OccupationTitle ?? "null"}");
            toStringOutput.Add($"OccupationType = {(this.OccupationType == null ? "null" : this.OccupationType.ToString())}");
            toStringOutput.Add($"MailingAddressLine1 = {this.MailingAddressLine1 ?? "null"}");
            toStringOutput.Add($"MailingAddressLine2 = {this.MailingAddressLine2 ?? "null"}");
            toStringOutput.Add($"MailingAddressLine3 = {this.MailingAddressLine3 ?? "null"}");
            toStringOutput.Add($"MailingCountry = {(this.MailingCountry == null ? "null" : this.MailingCountry.ToString())}");
            toStringOutput.Add($"MailingCity = {this.MailingCity ?? "null"}");
            toStringOutput.Add($"MailingRegion = {this.MailingRegion ?? "null"}");
            toStringOutput.Add($"MailingPostalCode = {this.MailingPostalCode ?? "null"}");
            toStringOutput.Add($"BusinessAddressLine1 = {this.BusinessAddressLine1 ?? "null"}");
            toStringOutput.Add($"BusinessAddressLine2 = {this.BusinessAddressLine2 ?? "null"}");
            toStringOutput.Add($"BusinessAddressLine3 = {this.BusinessAddressLine3 ?? "null"}");
            toStringOutput.Add($"BusinessCountry = {(this.BusinessCountry == null ? "null" : this.BusinessCountry.ToString())}");
            toStringOutput.Add($"BusinessCity = {this.BusinessCity ?? "null"}");
            toStringOutput.Add($"BusinessRegion = {this.BusinessRegion ?? "null"}");
            toStringOutput.Add($"BusinessPostalCode = {this.BusinessPostalCode ?? "null"}");
            toStringOutput.Add($"PremiseNumber = {this.PremiseNumber ?? "null"}");
            toStringOutput.Add($"ProgramToken = {this.ProgramToken ?? "null"}");
            toStringOutput.Add($"PrimaryUserToken = {this.PrimaryUserToken ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}