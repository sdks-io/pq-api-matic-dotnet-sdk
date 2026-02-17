// <copyright file="DeliveryDetails.cs" company="APIMatic">
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
    /// DeliveryDetails.
    /// </summary>
    public class DeliveryDetails : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryDetails"/> class.
        /// </summary>
        public DeliveryDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryDetails"/> class.
        /// </summary>
        /// <param name="minimumDeliveryMinutes">minimumDeliveryMinutes.</param>
        /// <param name="maximumDeliveryMinutes">maximumDeliveryMinutes.</param>
        /// <param name="expectedDelivery">expectedDelivery.</param>
        /// <param name="expectedDeliveryTime">expectedDeliveryTime.</param>
        public DeliveryDetails(
            int? minimumDeliveryMinutes = null,
            int? maximumDeliveryMinutes = null,
            Models.ExpectedDeliveryTypes? expectedDelivery = null,
            DateTime? expectedDeliveryTime = null)
        {
            this.MinimumDeliveryMinutes = minimumDeliveryMinutes;
            this.MaximumDeliveryMinutes = maximumDeliveryMinutes;
            this.ExpectedDelivery = expectedDelivery;
            this.ExpectedDeliveryTime = expectedDeliveryTime;
        }

        /// <summary>
        /// Gets or sets MinimumDeliveryMinutes.
        /// </summary>
        [JsonProperty("minimumDeliveryMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumDeliveryMinutes { get; set; }

        /// <summary>
        /// Gets or sets MaximumDeliveryMinutes.
        /// </summary>
        [JsonProperty("maximumDeliveryMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumDeliveryMinutes { get; set; }

        /// <summary>
        /// Transfer expected delivery types
        /// </summary>
        [JsonProperty("expectedDelivery", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExpectedDeliveryTypes? ExpectedDelivery { get; set; }

        /// <summary>
        /// The time of the expected delivery. Does not include the date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expectedDeliveryTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpectedDeliveryTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeliveryDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeliveryDetails other &&
                (this.MinimumDeliveryMinutes == null && other.MinimumDeliveryMinutes == null ||
                 this.MinimumDeliveryMinutes?.Equals(other.MinimumDeliveryMinutes) == true) &&
                (this.MaximumDeliveryMinutes == null && other.MaximumDeliveryMinutes == null ||
                 this.MaximumDeliveryMinutes?.Equals(other.MaximumDeliveryMinutes) == true) &&
                (this.ExpectedDelivery == null && other.ExpectedDelivery == null ||
                 this.ExpectedDelivery?.Equals(other.ExpectedDelivery) == true) &&
                (this.ExpectedDeliveryTime == null && other.ExpectedDeliveryTime == null ||
                 this.ExpectedDeliveryTime?.Equals(other.ExpectedDeliveryTime) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MinimumDeliveryMinutes = {(this.MinimumDeliveryMinutes == null ? "null" : this.MinimumDeliveryMinutes.ToString())}");
            toStringOutput.Add($"MaximumDeliveryMinutes = {(this.MaximumDeliveryMinutes == null ? "null" : this.MaximumDeliveryMinutes.ToString())}");
            toStringOutput.Add($"ExpectedDelivery = {(this.ExpectedDelivery == null ? "null" : this.ExpectedDelivery.ToString())}");
            toStringOutput.Add($"ExpectedDeliveryTime = {(this.ExpectedDeliveryTime == null ? "null" : this.ExpectedDeliveryTime.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}