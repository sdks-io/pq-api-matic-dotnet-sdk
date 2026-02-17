// <copyright file="Translation.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// Translation.
    /// </summary>
    public class Translation : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Translation"/> class.
        /// </summary>
        public Translation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Translation"/> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="translationProp">translation.</param>
        public Translation(
            Models.Languages? language = null,
            string translationProp = null)
        {
            this.Language = language;
            this.TranslationProp = translationProp;
        }

        /// <summary>
        /// The [Language](#/rest/models/structures/language) type in IETF's BCP 47 format
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Languages? Language { get; set; }

        /// <summary>
        /// Translated string in the specified language
        /// </summary>
        [JsonProperty("translation", NullValueHandling = NullValueHandling.Ignore)]
        public string TranslationProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Translation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Translation other &&
                (this.Language == null && other.Language == null ||
                 this.Language?.Equals(other.Language) == true) &&
                (this.TranslationProp == null && other.TranslationProp == null ||
                 this.TranslationProp?.Equals(other.TranslationProp) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Language = {(this.Language == null ? "null" : this.Language.ToString())}");
            toStringOutput.Add($"TranslationProp = {this.TranslationProp ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}