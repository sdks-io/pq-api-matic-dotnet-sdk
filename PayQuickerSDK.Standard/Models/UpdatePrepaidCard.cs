// <copyright file="UpdatePrepaidCard.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// UpdatePrepaidCard.
    /// </summary>
    public class UpdatePrepaidCard : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrepaidCard"/> class.
        /// </summary>
        public UpdatePrepaidCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrepaidCard"/> class.
        /// </summary>
        /// <param name="cardPackage">cardPackage.</param>
        /// <param name="status">status.</param>
        public UpdatePrepaidCard(
            string cardPackage = null,
            Models.PrepaidCardStatuses? status = null)
        {
            this.CardPackage = cardPackage;
            this.Status = status;
        }

        /// <summary>
        /// [Package](#/rest/models/structures/prepaid-card-package) for the card being displayed, including artwork, packaging, and delivery method
        /// </summary>
        [JsonProperty("cardPackage", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPackage { get; set; }

        /// <summary>
        /// Current [status](#/rest/models/structures/prepaid-card-status) of the prepaid card
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PrepaidCardStatuses? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdatePrepaidCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdatePrepaidCard other &&
                (this.CardPackage == null && other.CardPackage == null ||
                 this.CardPackage?.Equals(other.CardPackage) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardPackage = {this.CardPackage ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}