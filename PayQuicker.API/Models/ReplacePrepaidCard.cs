// <copyright file="ReplacePrepaidCard.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// ReplacePrepaidCard.
    /// </summary>
    public class ReplacePrepaidCard : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplacePrepaidCard"/> class.
        /// </summary>
        public ReplacePrepaidCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplacePrepaidCard"/> class.
        /// </summary>
        /// <param name="cardPackage">cardPackage.</param>
        /// <param name="cardReplacementReason">cardReplacementReason.</param>
        public ReplacePrepaidCard(
            string cardPackage = null,
            Models.PrepaidCardReplacementReasons? cardReplacementReason = null)
        {
            this.CardPackage = cardPackage;
            this.CardReplacementReason = cardReplacementReason;
        }

        /// <summary>
        /// [Package](#/rest/models/structures/prepaid-card-package) for the card being displayed, including artwork, packaging, and delivery method
        /// </summary>
        [JsonProperty("cardPackage", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPackage { get; set; }

        /// <summary>
        /// Reason for [prepaid card](page:resources/prepaid-cards) replacement.
        /// </summary>
        [JsonProperty("cardReplacementReason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaidCardReplacementReasons? CardReplacementReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReplacePrepaidCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReplacePrepaidCard other &&
                (this.CardPackage == null && other.CardPackage == null ||
                 this.CardPackage?.Equals(other.CardPackage) == true) &&
                (this.CardReplacementReason == null && other.CardReplacementReason == null ||
                 this.CardReplacementReason?.Equals(other.CardReplacementReason) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardPackage = {this.CardPackage ?? "null"}");
            toStringOutput.Add($"CardReplacementReason = {(this.CardReplacementReason == null ? "null" : this.CardReplacementReason.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}