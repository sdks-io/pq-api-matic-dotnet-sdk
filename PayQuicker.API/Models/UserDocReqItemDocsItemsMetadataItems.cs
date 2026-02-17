// <copyright file="UserDocReqItemDocsItemsMetadataItems.cs" company="APIMatic">
// PayQuicker.API
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuicker.API.Models
{
    /// <summary>
    /// UserDocReqItemDocsItemsMetadataItems.
    /// </summary>
    public class UserDocReqItemDocsItemsMetadataItems : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocReqItemDocsItemsMetadataItems"/> class.
        /// </summary>
        public UserDocReqItemDocsItemsMetadataItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocReqItemDocsItemsMetadataItems"/> class.
        /// </summary>
        /// <param name="dataType">dataType.</param>
        /// <param name="fieldType">fieldType.</param>
        /// <param name="name">name.</param>
        public UserDocReqItemDocsItemsMetadataItems(
            string dataType = null,
            string fieldType = null,
            List<Models.UserDocReqItemDocsItemsMetadataItemsNameItems> name = null)
        {
            this.DataType = dataType;
            this.FieldType = fieldType;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets DataType.
        /// </summary>
        [JsonProperty("dataType", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets FieldType.
        /// </summary>
        [JsonProperty("fieldType", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UserDocReqItemDocsItemsMetadataItemsNameItems> Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UserDocReqItemDocsItemsMetadataItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserDocReqItemDocsItemsMetadataItems other &&
                (this.DataType == null && other.DataType == null ||
                 this.DataType?.Equals(other.DataType) == true) &&
                (this.FieldType == null && other.FieldType == null ||
                 this.FieldType?.Equals(other.FieldType) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DataType = {this.DataType ?? "null"}");
            toStringOutput.Add($"FieldType = {this.FieldType ?? "null"}");
            toStringOutput.Add($"Name = {(this.Name == null ? "null" : $"[{string.Join(", ", this.Name)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}