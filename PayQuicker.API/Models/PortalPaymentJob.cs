// <copyright file="PortalPaymentJob.cs" company="APIMatic">
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
    /// PortalPaymentJob.
    /// </summary>
    public class PortalPaymentJob : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalPaymentJob"/> class.
        /// </summary>
        public PortalPaymentJob()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortalPaymentJob"/> class.
        /// </summary>
        /// <param name="notBefore">notBefore.</param>
        /// <param name="notAfter">notAfter.</param>
        /// <param name="items">items.</param>
        public PortalPaymentJob(
            DateTime? notBefore = null,
            DateTime? notAfter = null,
            List<Models.PortalPaymentJobQuote> items = null)
        {
            this.NotBefore = notBefore;
            this.NotAfter = notAfter;
            this.Items = items;
        }

        /// <summary>
        /// [Transfer](#/rest/models/structures/not-before-or-after) is scheduled and will not process before this time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("notBefore", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// [Transfer](#/rest/models/structures/not-before-or-after) expires if not completed prior to this time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("notAfter", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PortalPaymentJobQuote> Items { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PortalPaymentJob : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PortalPaymentJob other &&
                (this.NotBefore == null && other.NotBefore == null ||
                 this.NotBefore?.Equals(other.NotBefore) == true) &&
                (this.NotAfter == null && other.NotAfter == null ||
                 this.NotAfter?.Equals(other.NotAfter) == true) &&
                (this.Items == null && other.Items == null ||
                 this.Items?.Equals(other.Items) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NotBefore = {(this.NotBefore == null ? "null" : this.NotBefore.ToString())}");
            toStringOutput.Add($"NotAfter = {(this.NotAfter == null ? "null" : this.NotAfter.ToString())}");
            toStringOutput.Add($"Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}