// <copyright file="UserResult.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// UserResult.
    /// </summary>
    public class UserResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResult"/> class.
        /// </summary>
        public UserResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResult"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="addressLine3">addressLine3.</param>
        /// <param name="businessAddressLine1">businessAddressLine1.</param>
        /// <param name="businessAddressLine2">businessAddressLine2.</param>
        /// <param name="businessAddressLine3">businessAddressLine3.</param>
        /// <param name="businessAddressType">businessAddressType.</param>
        /// <param name="businessCity">businessCity.</param>
        /// <param name="businessContactRole">businessContactRole.</param>
        /// <param name="businessCountry">businessCountry.</param>
        /// <param name="businessName">businessName.</param>
        /// <param name="businessPostalCode">businessPostalCode.</param>
        /// <param name="businessRegion">businessRegion.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="countryOfBirth">countryOfBirth.</param>
        /// <param name="countryOfNationality">countryOfNationality.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="currency">currency.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="email">email.</param>
        /// <param name="employerId">employerId.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="gender">gender.</param>
        /// <param name="governmentId">governmentId.</param>
        /// <param name="governmentIdType">governmentIdType.</param>
        /// <param name="language">language.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="mailingAddressLine1">mailingAddressLine1.</param>
        /// <param name="mailingAddressLine2">mailingAddressLine2.</param>
        /// <param name="mailingAddressLine3">mailingAddressLine3.</param>
        /// <param name="mailingCity">mailingCity.</param>
        /// <param name="mailingCountry">mailingCountry.</param>
        /// <param name="mailingPostalCode">mailingPostalCode.</param>
        /// <param name="mailingRegion">mailingRegion.</param>
        /// <param name="mobileNumber">mobileNumber.</param>
        /// <param name="mobileNumberCountry">mobileNumberCountry.</param>
        /// <param name="occupationTitle">occupationTitle.</param>
        /// <param name="occupationType">occupationType.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="phoneNumberCountry">phoneNumberCountry.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="programUserId">programUserId.</param>
        /// <param name="region">region.</param>
        /// <param name="status">status.</param>
        /// <param name="taxResidentStatus">taxResidentStatus.</param>
        /// <param name="userType">userType.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public UserResult(
            string token = null,
            string addressLine1 = null,
            string addressLine2 = null,
            string addressLine3 = null,
            string businessAddressLine1 = null,
            string businessAddressLine2 = null,
            string businessAddressLine3 = null,
            Models.Addresses? businessAddressType = null,
            string businessCity = null,
            Models.BusinessContactRoles? businessContactRole = null,
            Models.Countries? businessCountry = null,
            string businessName = null,
            string businessPostalCode = null,
            string businessRegion = null,
            string city = null,
            Models.Countries? country = null,
            Models.Countries? countryOfBirth = null,
            Models.Countries? countryOfNationality = null,
            DateTime? createdOn = null,
            Models.Currencies? currency = Models.Currencies.Usd,
            DateTime? dateOfBirth = null,
            string email = null,
            string employerId = null,
            string firstName = null,
            Models.Genders? gender = null,
            string governmentId = null,
            Models.GovernmentIds? governmentIdType = null,
            Models.Languages? language = null,
            string lastName = null,
            string mailingAddressLine1 = null,
            string mailingAddressLine2 = null,
            string mailingAddressLine3 = null,
            string mailingCity = null,
            Models.Countries? mailingCountry = null,
            string mailingPostalCode = null,
            string mailingRegion = null,
            string mobileNumber = null,
            Models.Countries? mobileNumberCountry = null,
            string occupationTitle = null,
            Models.Occupations? occupationType = null,
            string phoneNumber = null,
            Models.Countries? phoneNumberCountry = null,
            string postalCode = null,
            string programUserId = null,
            string region = null,
            Models.UserStatuses? status = null,
            Models.TaxResidentStatuses? taxResidentStatus = null,
            Models.UserTypes? userType = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.BusinessAddressLine1 = businessAddressLine1;
            this.BusinessAddressLine2 = businessAddressLine2;
            this.BusinessAddressLine3 = businessAddressLine3;
            this.BusinessAddressType = businessAddressType;
            this.BusinessCity = businessCity;
            this.BusinessContactRole = businessContactRole;
            this.BusinessCountry = businessCountry;
            this.BusinessName = businessName;
            this.BusinessPostalCode = businessPostalCode;
            this.BusinessRegion = businessRegion;
            this.City = city;
            this.Country = country;
            this.CountryOfBirth = countryOfBirth;
            this.CountryOfNationality = countryOfNationality;
            this.CreatedOn = createdOn;
            this.Currency = currency;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.EmployerId = employerId;
            this.FirstName = firstName;
            this.Gender = gender;
            this.GovernmentId = governmentId;
            this.GovernmentIdType = governmentIdType;
            this.Language = language;
            this.LastName = lastName;
            this.MailingAddressLine1 = mailingAddressLine1;
            this.MailingAddressLine2 = mailingAddressLine2;
            this.MailingAddressLine3 = mailingAddressLine3;
            this.MailingCity = mailingCity;
            this.MailingCountry = mailingCountry;
            this.MailingPostalCode = mailingPostalCode;
            this.MailingRegion = mailingRegion;
            this.MobileNumber = mobileNumber;
            this.MobileNumberCountry = mobileNumberCountry;
            this.OccupationTitle = occupationTitle;
            this.OccupationType = occupationType;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberCountry = phoneNumberCountry;
            this.PostalCode = postalCode;
            this.ProgramUserId = programUserId;
            this.Region = region;
            this.Status = status;
            this.TaxResidentStatus = taxResidentStatus;
            this.UserType = userType;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

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
        /// Classifies the [address](#/rest/models/structures/address) type (*Residential*, *Business*, *Billing*, *Shipping*)
        /// </summary>
        [JsonProperty("businessAddressType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Addresses? BusinessAddressType { get; set; }

        /// <summary>
        /// Business city
        /// </summary>
        [JsonProperty("businessCity", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCity { get; set; }

        /// <summary>
        /// Business contact role
        /// </summary>
        [JsonProperty("businessContactRole", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BusinessContactRoles? BusinessContactRole { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("businessCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? BusinessCountry { get; set; }

        /// <summary>
        /// Business name
        /// </summary>
        [JsonProperty("businessName", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or sets BusinessPostalCode.
        /// </summary>
        [JsonProperty("businessPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessPostalCode { get; set; }

        /// <summary>
        /// Region that the business is based out of
        /// </summary>
        [JsonProperty("businessRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessRegion { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? Country { get; set; }

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
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// [Currency code type](#/rest/models/structures/country) for the object
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currencies? Currency { get; set; }

        /// <summary>
        /// Gets or sets DateOfBirth.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Contact [email address](#/rest/models/structures/email-address) for the user account for the user account
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Employer id
        /// </summary>
        [JsonProperty("employerId", NullValueHandling = NullValueHandling.Ignore)]
        public string EmployerId { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// [Gender](#/rest/models/structures/gender) as a user identifies
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Genders? Gender { get; set; }

        /// <summary>
        /// Gets or sets GovernmentId.
        /// </summary>
        [JsonProperty("governmentId", NullValueHandling = NullValueHandling.Ignore)]
        public string GovernmentId { get; set; }

        /// <summary>
        /// Indicates the type of ID submitted for user verification purposes.
        /// </summary>
        [JsonProperty("governmentIdType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GovernmentIds? GovernmentIdType { get; set; }

        /// <summary>
        /// The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Languages? Language { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

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
        /// Gets or sets MailingCity.
        /// </summary>
        [JsonProperty("mailingCity", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingCity { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("mailingCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? MailingCountry { get; set; }

        /// <summary>
        /// Gets or sets MailingPostalCode.
        /// </summary>
        [JsonProperty("mailingPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// Gets or sets MailingRegion.
        /// </summary>
        [JsonProperty("mailingRegion", NullValueHandling = NullValueHandling.Ignore)]
        public string MailingRegion { get; set; }

        /// <summary>
        /// Gets or sets MobileNumber.
        /// </summary>
        [JsonProperty("mobileNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("mobileNumberCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? MobileNumberCountry { get; set; }

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
        /// Gets or sets PhoneNumber.
        /// </summary>
        [JsonProperty("phoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Throughout the PayQuicker API, the usage of the 2-letter alpha code is used in place of the country name, e.g., for bank country or residential country.
        /// The 2-letter codes adhere to the ISO 3166-1 spec and are listed here for convenience.
        /// </summary>
        [JsonProperty("phoneNumberCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Countries? PhoneNumberCountry { get; set; }

        /// <summary>
        /// Gets or sets PostalCode.
        /// </summary>
        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// [Program identifier](#/rest/models/structures/program-user-id) for the user
        /// </summary>
        [JsonProperty("programUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramUserId { get; set; }

        /// <summary>
        /// Gets or sets Region.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Status of the user [User status type](#/rest/models/structures/user-status)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserStatuses? Status { get; set; }

        /// <summary>
        /// Tax [resident status type](#/rest/models/structures/tax-resident-status)
        /// </summary>
        [JsonProperty("taxResidentStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TaxResidentStatuses? TaxResidentStatus { get; set; }

        /// <summary>
        /// Account holder's profile [type](#/rest/models/structures/user-type)
        /// </summary>
        [JsonProperty("userType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserTypes? UserType { get; set; }

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
            return $"UserResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.AddressLine1 == null && other.AddressLine1 == null ||
                 this.AddressLine1?.Equals(other.AddressLine1) == true) &&
                (this.AddressLine2 == null && other.AddressLine2 == null ||
                 this.AddressLine2?.Equals(other.AddressLine2) == true) &&
                (this.AddressLine3 == null && other.AddressLine3 == null ||
                 this.AddressLine3?.Equals(other.AddressLine3) == true) &&
                (this.BusinessAddressLine1 == null && other.BusinessAddressLine1 == null ||
                 this.BusinessAddressLine1?.Equals(other.BusinessAddressLine1) == true) &&
                (this.BusinessAddressLine2 == null && other.BusinessAddressLine2 == null ||
                 this.BusinessAddressLine2?.Equals(other.BusinessAddressLine2) == true) &&
                (this.BusinessAddressLine3 == null && other.BusinessAddressLine3 == null ||
                 this.BusinessAddressLine3?.Equals(other.BusinessAddressLine3) == true) &&
                (this.BusinessAddressType == null && other.BusinessAddressType == null ||
                 this.BusinessAddressType?.Equals(other.BusinessAddressType) == true) &&
                (this.BusinessCity == null && other.BusinessCity == null ||
                 this.BusinessCity?.Equals(other.BusinessCity) == true) &&
                (this.BusinessContactRole == null && other.BusinessContactRole == null ||
                 this.BusinessContactRole?.Equals(other.BusinessContactRole) == true) &&
                (this.BusinessCountry == null && other.BusinessCountry == null ||
                 this.BusinessCountry?.Equals(other.BusinessCountry) == true) &&
                (this.BusinessName == null && other.BusinessName == null ||
                 this.BusinessName?.Equals(other.BusinessName) == true) &&
                (this.BusinessPostalCode == null && other.BusinessPostalCode == null ||
                 this.BusinessPostalCode?.Equals(other.BusinessPostalCode) == true) &&
                (this.BusinessRegion == null && other.BusinessRegion == null ||
                 this.BusinessRegion?.Equals(other.BusinessRegion) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.CountryOfBirth == null && other.CountryOfBirth == null ||
                 this.CountryOfBirth?.Equals(other.CountryOfBirth) == true) &&
                (this.CountryOfNationality == null && other.CountryOfNationality == null ||
                 this.CountryOfNationality?.Equals(other.CountryOfNationality) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.DateOfBirth == null && other.DateOfBirth == null ||
                 this.DateOfBirth?.Equals(other.DateOfBirth) == true) &&
                (this.Email == null && other.Email == null ||
                 this.Email?.Equals(other.Email) == true) &&
                (this.EmployerId == null && other.EmployerId == null ||
                 this.EmployerId?.Equals(other.EmployerId) == true) &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.Gender == null && other.Gender == null ||
                 this.Gender?.Equals(other.Gender) == true) &&
                (this.GovernmentId == null && other.GovernmentId == null ||
                 this.GovernmentId?.Equals(other.GovernmentId) == true) &&
                (this.GovernmentIdType == null && other.GovernmentIdType == null ||
                 this.GovernmentIdType?.Equals(other.GovernmentIdType) == true) &&
                (this.Language == null && other.Language == null ||
                 this.Language?.Equals(other.Language) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.MailingAddressLine1 == null && other.MailingAddressLine1 == null ||
                 this.MailingAddressLine1?.Equals(other.MailingAddressLine1) == true) &&
                (this.MailingAddressLine2 == null && other.MailingAddressLine2 == null ||
                 this.MailingAddressLine2?.Equals(other.MailingAddressLine2) == true) &&
                (this.MailingAddressLine3 == null && other.MailingAddressLine3 == null ||
                 this.MailingAddressLine3?.Equals(other.MailingAddressLine3) == true) &&
                (this.MailingCity == null && other.MailingCity == null ||
                 this.MailingCity?.Equals(other.MailingCity) == true) &&
                (this.MailingCountry == null && other.MailingCountry == null ||
                 this.MailingCountry?.Equals(other.MailingCountry) == true) &&
                (this.MailingPostalCode == null && other.MailingPostalCode == null ||
                 this.MailingPostalCode?.Equals(other.MailingPostalCode) == true) &&
                (this.MailingRegion == null && other.MailingRegion == null ||
                 this.MailingRegion?.Equals(other.MailingRegion) == true) &&
                (this.MobileNumber == null && other.MobileNumber == null ||
                 this.MobileNumber?.Equals(other.MobileNumber) == true) &&
                (this.MobileNumberCountry == null && other.MobileNumberCountry == null ||
                 this.MobileNumberCountry?.Equals(other.MobileNumberCountry) == true) &&
                (this.OccupationTitle == null && other.OccupationTitle == null ||
                 this.OccupationTitle?.Equals(other.OccupationTitle) == true) &&
                (this.OccupationType == null && other.OccupationType == null ||
                 this.OccupationType?.Equals(other.OccupationType) == true) &&
                (this.PhoneNumber == null && other.PhoneNumber == null ||
                 this.PhoneNumber?.Equals(other.PhoneNumber) == true) &&
                (this.PhoneNumberCountry == null && other.PhoneNumberCountry == null ||
                 this.PhoneNumberCountry?.Equals(other.PhoneNumberCountry) == true) &&
                (this.PostalCode == null && other.PostalCode == null ||
                 this.PostalCode?.Equals(other.PostalCode) == true) &&
                (this.ProgramUserId == null && other.ProgramUserId == null ||
                 this.ProgramUserId?.Equals(other.ProgramUserId) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.TaxResidentStatus == null && other.TaxResidentStatus == null ||
                 this.TaxResidentStatus?.Equals(other.TaxResidentStatus) == true) &&
                (this.UserType == null && other.UserType == null ||
                 this.UserType?.Equals(other.UserType) == true) &&
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
            toStringOutput.Add($"AddressLine1 = {this.AddressLine1 ?? "null"}");
            toStringOutput.Add($"AddressLine2 = {this.AddressLine2 ?? "null"}");
            toStringOutput.Add($"AddressLine3 = {this.AddressLine3 ?? "null"}");
            toStringOutput.Add($"BusinessAddressLine1 = {this.BusinessAddressLine1 ?? "null"}");
            toStringOutput.Add($"BusinessAddressLine2 = {this.BusinessAddressLine2 ?? "null"}");
            toStringOutput.Add($"BusinessAddressLine3 = {this.BusinessAddressLine3 ?? "null"}");
            toStringOutput.Add($"BusinessAddressType = {(this.BusinessAddressType == null ? "null" : this.BusinessAddressType.ToString())}");
            toStringOutput.Add($"BusinessCity = {this.BusinessCity ?? "null"}");
            toStringOutput.Add($"BusinessContactRole = {(this.BusinessContactRole == null ? "null" : this.BusinessContactRole.ToString())}");
            toStringOutput.Add($"BusinessCountry = {(this.BusinessCountry == null ? "null" : this.BusinessCountry.ToString())}");
            toStringOutput.Add($"BusinessName = {this.BusinessName ?? "null"}");
            toStringOutput.Add($"BusinessPostalCode = {this.BusinessPostalCode ?? "null"}");
            toStringOutput.Add($"BusinessRegion = {this.BusinessRegion ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Country = {(this.Country == null ? "null" : this.Country.ToString())}");
            toStringOutput.Add($"CountryOfBirth = {(this.CountryOfBirth == null ? "null" : this.CountryOfBirth.ToString())}");
            toStringOutput.Add($"CountryOfNationality = {(this.CountryOfNationality == null ? "null" : this.CountryOfNationality.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"Email = {this.Email ?? "null"}");
            toStringOutput.Add($"EmployerId = {this.EmployerId ?? "null"}");
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"Gender = {(this.Gender == null ? "null" : this.Gender.ToString())}");
            toStringOutput.Add($"GovernmentId = {this.GovernmentId ?? "null"}");
            toStringOutput.Add($"GovernmentIdType = {(this.GovernmentIdType == null ? "null" : this.GovernmentIdType.ToString())}");
            toStringOutput.Add($"Language = {(this.Language == null ? "null" : this.Language.ToString())}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"MailingAddressLine1 = {this.MailingAddressLine1 ?? "null"}");
            toStringOutput.Add($"MailingAddressLine2 = {this.MailingAddressLine2 ?? "null"}");
            toStringOutput.Add($"MailingAddressLine3 = {this.MailingAddressLine3 ?? "null"}");
            toStringOutput.Add($"MailingCity = {this.MailingCity ?? "null"}");
            toStringOutput.Add($"MailingCountry = {(this.MailingCountry == null ? "null" : this.MailingCountry.ToString())}");
            toStringOutput.Add($"MailingPostalCode = {this.MailingPostalCode ?? "null"}");
            toStringOutput.Add($"MailingRegion = {this.MailingRegion ?? "null"}");
            toStringOutput.Add($"MobileNumber = {this.MobileNumber ?? "null"}");
            toStringOutput.Add($"MobileNumberCountry = {(this.MobileNumberCountry == null ? "null" : this.MobileNumberCountry.ToString())}");
            toStringOutput.Add($"OccupationTitle = {this.OccupationTitle ?? "null"}");
            toStringOutput.Add($"OccupationType = {(this.OccupationType == null ? "null" : this.OccupationType.ToString())}");
            toStringOutput.Add($"PhoneNumber = {this.PhoneNumber ?? "null"}");
            toStringOutput.Add($"PhoneNumberCountry = {(this.PhoneNumberCountry == null ? "null" : this.PhoneNumberCountry.ToString())}");
            toStringOutput.Add($"PostalCode = {this.PostalCode ?? "null"}");
            toStringOutput.Add($"ProgramUserId = {this.ProgramUserId ?? "null"}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"TaxResidentStatus = {(this.TaxResidentStatus == null ? "null" : this.TaxResidentStatus.ToString())}");
            toStringOutput.Add($"UserType = {(this.UserType == null ? "null" : this.UserType.ToString())}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}