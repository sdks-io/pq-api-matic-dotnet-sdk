// <copyright file="IdvCheckObject.cs" company="APIMatic">
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
    /// IdvCheckObject.
    /// </summary>
    public class IdvCheckObject : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdvCheckObject"/> class.
        /// </summary>
        public IdvCheckObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdvCheckObject"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="userToken">userToken.</param>
        /// <param name="idvProviderReference">idvProviderReference.</param>
        /// <param name="idvResult">idvResult.</param>
        /// <param name="idvSubResult">idvSubResult.</param>
        /// <param name="idvProvider">idvProvider.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="raw">raw.</param>
        /// <param name="idvCheckType">idvCheckType.</param>
        /// <param name="idvDisposition">idvDisposition.</param>
        /// <param name="links">links.</param>
        public IdvCheckObject(
            string token = null,
            string userToken = null,
            string idvProviderReference = null,
            Models.IdentityVerificationResultTypes? idvResult = null,
            Models.IdentityVerificationResultSubTypes? idvSubResult = null,
            Models.IdentityVerificationProviders? idvProvider = null,
            DateTime? createdOn = null,
            string raw = null,
            string idvCheckType = null,
            string idvDisposition = null,
            List<Models.HateoasSelfRef> links = null)
        {
            this.Token = token;
            this.UserToken = userToken;
            this.IdvProviderReference = idvProviderReference;
            this.IdvResult = idvResult;
            this.IdvSubResult = idvSubResult;
            this.IdvProvider = idvProvider;
            this.CreatedOn = createdOn;
            this.Raw = raw;
            this.IdvCheckType = idvCheckType;
            this.IdvDisposition = idvDisposition;
            this.Links = links;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("userToken", NullValueHandling = NullValueHandling.Ignore)]
        public string UserToken { get; set; }

        /// <summary>
        /// [Provider reference](#/rest/models/structures/identity-verification-provider-reference) used for performing identity checks for the provider
        /// </summary>
        [JsonProperty("idvProviderReference", NullValueHandling = NullValueHandling.Ignore)]
        public string IdvProviderReference { get; set; }

        /// <summary>
        /// Result type of [verification](#/rest/models/structures/identity-verification-result-type)
        /// </summary>
        [JsonProperty("idvResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IdentityVerificationResultTypes? IdvResult { get; set; }

        /// <summary>
        /// Sub result type of [verification](#/rest/models/structures/identity-verification-sub-result-type)
        /// </summary>
        [JsonProperty("idvSubResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IdentityVerificationResultSubTypes? IdvSubResult { get; set; }

        /// <summary>
        /// Provider types of [verification](#/rest/models/structures/identity-verification-provider-type) that can be used for performing identity checks
        /// </summary>
        [JsonProperty("idvProvider", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IdentityVerificationProviders? IdvProvider { get; set; }

        /// <summary>
        /// Time object was [created](#/rest/models/structures/created-on)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Contains the raw (unprocessed) [output](/#/rest/models/structures/identity-verification-provider-raw-output) from the IDV provider
        /// </summary>
        [JsonProperty("raw", NullValueHandling = NullValueHandling.Ignore)]
        public string Raw { get; set; }

        /// <summary>
        /// [Type](#/rest/models/structures/identity-verification-check-type) of verification used for performing an identity check
        /// </summary>
        [JsonProperty("idvCheckType", NullValueHandling = NullValueHandling.Ignore)]
        public string IdvCheckType { get; set; }

        /// <summary>
        /// Disposition type of [verification](#/rest/models/structures/identity-verification-disposition-type)
        /// </summary>
        [JsonProperty("idvDisposition", NullValueHandling = NullValueHandling.Ignore)]
        public string IdvDisposition { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IdvCheckObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IdvCheckObject other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.UserToken == null && other.UserToken == null ||
                 this.UserToken?.Equals(other.UserToken) == true) &&
                (this.IdvProviderReference == null && other.IdvProviderReference == null ||
                 this.IdvProviderReference?.Equals(other.IdvProviderReference) == true) &&
                (this.IdvResult == null && other.IdvResult == null ||
                 this.IdvResult?.Equals(other.IdvResult) == true) &&
                (this.IdvSubResult == null && other.IdvSubResult == null ||
                 this.IdvSubResult?.Equals(other.IdvSubResult) == true) &&
                (this.IdvProvider == null && other.IdvProvider == null ||
                 this.IdvProvider?.Equals(other.IdvProvider) == true) &&
                (this.CreatedOn == null && other.CreatedOn == null ||
                 this.CreatedOn?.Equals(other.CreatedOn) == true) &&
                (this.Raw == null && other.Raw == null ||
                 this.Raw?.Equals(other.Raw) == true) &&
                (this.IdvCheckType == null && other.IdvCheckType == null ||
                 this.IdvCheckType?.Equals(other.IdvCheckType) == true) &&
                (this.IdvDisposition == null && other.IdvDisposition == null ||
                 this.IdvDisposition?.Equals(other.IdvDisposition) == true) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"UserToken = {this.UserToken ?? "null"}");
            toStringOutput.Add($"IdvProviderReference = {this.IdvProviderReference ?? "null"}");
            toStringOutput.Add($"IdvResult = {(this.IdvResult == null ? "null" : this.IdvResult.ToString())}");
            toStringOutput.Add($"IdvSubResult = {(this.IdvSubResult == null ? "null" : this.IdvSubResult.ToString())}");
            toStringOutput.Add($"IdvProvider = {(this.IdvProvider == null ? "null" : this.IdvProvider.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Raw = {this.Raw ?? "null"}");
            toStringOutput.Add($"IdvCheckType = {this.IdvCheckType ?? "null"}");
            toStringOutput.Add($"IdvDisposition = {this.IdvDisposition ?? "null"}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}