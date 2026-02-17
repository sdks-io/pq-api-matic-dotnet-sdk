// <copyright file="ReceiptDescriptions.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// ReceiptDescriptions.
    /// </summary>
    public class ReceiptDescriptions : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptDescriptions"/> class.
        /// </summary>
        public ReceiptDescriptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptDescriptions"/> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="translation">translation.</param>
        public ReceiptDescriptions(
            Models.Languages? language = null,
            string translation = null)
        {
            this.Language = language;
            this.Translation = translation;
        }

        /// <summary>
        /// The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Languages? Language { get; set; }

        /// <summary>
        /// Description translated to the indicated language
        /// </summary>
        [JsonProperty("translation", NullValueHandling = NullValueHandling.Ignore)]
        public string Translation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReceiptDescriptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReceiptDescriptions other &&
                (this.Language == null && other.Language == null ||
                 this.Language?.Equals(other.Language) == true) &&
                (this.Translation == null && other.Translation == null ||
                 this.Translation?.Equals(other.Translation) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Language = {(this.Language == null ? "null" : this.Language.ToString())}");
            toStringOutput.Add($"Translation = {this.Translation ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}