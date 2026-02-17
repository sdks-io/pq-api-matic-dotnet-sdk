// <copyright file="RetrieveCardData.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// RetrieveCardData.
    /// </summary>
    public class RetrieveCardData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCardData"/> class.
        /// </summary>
        public RetrieveCardData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCardData"/> class.
        /// </summary>
        /// <param name="token">Token.</param>
        public RetrieveCardData(
            string token = null)
        {
            this.Token = token;
        }

        /// <summary>
        /// A token used to reveal prepaid card information in the form of image data (base64) or JSON.
        /// </summary>
        [JsonProperty("Token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RetrieveCardData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RetrieveCardData other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Token = {this.Token ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}