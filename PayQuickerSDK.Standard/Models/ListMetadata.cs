// <copyright file="ListMetadata.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// ListMetadata.
    /// </summary>
    public class ListMetadata : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetadata"/> class.
        /// </summary>
        public ListMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetadata"/> class.
        /// </summary>
        /// <param name="pageNo">pageNo.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageCount">pageCount.</param>
        /// <param name="recordCount">recordCount.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="requestRef">requestRef.</param>
        public ListMetadata(
            string pageNo,
            string pageSize,
            string pageCount,
            string recordCount,
            string timezone,
            string requestRef)
        {
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.PageCount = pageCount;
            this.RecordCount = recordCount;
            this.Timezone = timezone;
            this.RequestRef = requestRef;
        }

        /// <summary>
        /// Gets or sets PageNo.
        /// </summary>
        [JsonProperty("pageNo")]
        public string PageNo { get; set; }

        /// <summary>
        /// Gets or sets PageSize.
        /// </summary>
        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        /// <summary>
        /// Gets or sets PageCount.
        /// </summary>
        [JsonProperty("pageCount")]
        public string PageCount { get; set; }

        /// <summary>
        /// Gets or sets RecordCount.
        /// </summary>
        [JsonProperty("recordCount")]
        public string RecordCount { get; set; }

        /// <summary>
        /// Timezone of the datetime objects in the response
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets RequestRef.
        /// </summary>
        [JsonProperty("requestRef")]
        public string RequestRef { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListMetadata : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListMetadata other &&
                (this.PageNo == null && other.PageNo == null ||
                 this.PageNo?.Equals(other.PageNo) == true) &&
                (this.PageSize == null && other.PageSize == null ||
                 this.PageSize?.Equals(other.PageSize) == true) &&
                (this.PageCount == null && other.PageCount == null ||
                 this.PageCount?.Equals(other.PageCount) == true) &&
                (this.RecordCount == null && other.RecordCount == null ||
                 this.RecordCount?.Equals(other.RecordCount) == true) &&
                (this.Timezone == null && other.Timezone == null ||
                 this.Timezone?.Equals(other.Timezone) == true) &&
                (this.RequestRef == null && other.RequestRef == null ||
                 this.RequestRef?.Equals(other.RequestRef) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PageNo = {this.PageNo ?? "null"}");
            toStringOutput.Add($"PageSize = {this.PageSize ?? "null"}");
            toStringOutput.Add($"PageCount = {this.PageCount ?? "null"}");
            toStringOutput.Add($"RecordCount = {this.RecordCount ?? "null"}");
            toStringOutput.Add($"Timezone = {this.Timezone ?? "null"}");
            toStringOutput.Add($"RequestRef = {this.RequestRef ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}