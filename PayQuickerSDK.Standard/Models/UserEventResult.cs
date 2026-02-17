// <copyright file="UserEventResult.cs" company="APIMatic">
// PayQuickerSDK.Standard
//
// This file was automatically generated for PayQuicker by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PayQuickerSDK.Standard.Models
{
    /// <summary>
    /// UserEventResult.
    /// </summary>
    public class UserEventResult : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventResult"/> class.
        /// </summary>
        public UserEventResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventResult"/> class.
        /// </summary>
        /// <param name="mEvent">event.</param>
        /// <param name="token">token.</param>
        /// <param name="canBeCancelled">canBeCancelled.</param>
        /// <param name="eventRequirementCategoryType">eventRequirementCategoryType.</param>
        /// <param name="eventRequirementType">eventRequirementType.</param>
        /// <param name="eventStatus">eventStatus.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="isComplete">isComplete.</param>
        /// <param name="userAction">userAction.</param>
        /// <param name="userImpact">userImpact.</param>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        public UserEventResult(
            Models.EventCategoryTypes mEvent,
            string token = null,
            bool? canBeCancelled = null,
            Models.EventRequirementCategories? eventRequirementCategoryType = null,
            Models.EventRequirements? eventRequirementType = null,
            Models.EventStatuses? eventStatus = null,
            Models.EventTypes? eventType = null,
            bool? isComplete = null,
            Models.UserAction? userAction = null,
            Models.UserImpact? userImpact = null,
            List<Models.HateoasSelfRef> links = null,
            Models.MetadataItems meta = null)
        {
            this.Token = token;
            this.CanBeCancelled = canBeCancelled;
            this.EventRequirementCategoryType = eventRequirementCategoryType;
            this.EventRequirementType = eventRequirementType;
            this.EventStatus = eventStatus;
            this.EventType = eventType;
            this.IsComplete = isComplete;
            this.UserAction = userAction;
            this.UserImpact = userImpact;
            this.MEvent = mEvent;
            this.Links = links;
            this.Meta = meta;
        }

        /// <summary>
        /// [Token](#/rest/models/structures/token) representing the resource
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets CanBeCancelled.
        /// </summary>
        [JsonProperty("canBeCancelled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanBeCancelled { get; set; }

        /// <summary>
        /// Gets or sets EventRequirementCategoryType.
        /// </summary>
        [JsonProperty("eventRequirementCategoryType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EventRequirementCategories? EventRequirementCategoryType { get; set; }

        /// <summary>
        /// Gets or sets EventRequirementType.
        /// </summary>
        [JsonProperty("eventRequirementType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EventRequirements? EventRequirementType { get; set; }

        /// <summary>
        /// Indicates the current verification status type of an event.
        /// </summary>
        [JsonProperty("eventStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EventStatuses? EventStatus { get; set; }

        /// <summary>
        /// Gets or sets EventType.
        /// </summary>
        [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EventTypes? EventType { get; set; }

        /// <summary>
        /// Gets or sets IsComplete.
        /// </summary>
        [JsonProperty("isComplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Gets or sets UserAction.
        /// </summary>
        [JsonProperty("userAction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserAction? UserAction { get; set; }

        /// <summary>
        /// Gets or sets UserImpact.
        /// </summary>
        [JsonProperty("userImpact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserImpact? UserImpact { get; set; }

        /// <summary>
        /// The type of Registration tied to a particular event
        /// </summary>
        [JsonProperty("event")]
        public Models.EventCategoryTypes MEvent { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.HateoasSelfRef> Links { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetadataItems Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UserEventResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UserEventResult other &&
                (this.Token == null && other.Token == null ||
                 this.Token?.Equals(other.Token) == true) &&
                (this.CanBeCancelled == null && other.CanBeCancelled == null ||
                 this.CanBeCancelled?.Equals(other.CanBeCancelled) == true) &&
                (this.EventRequirementCategoryType == null && other.EventRequirementCategoryType == null ||
                 this.EventRequirementCategoryType?.Equals(other.EventRequirementCategoryType) == true) &&
                (this.EventRequirementType == null && other.EventRequirementType == null ||
                 this.EventRequirementType?.Equals(other.EventRequirementType) == true) &&
                (this.EventStatus == null && other.EventStatus == null ||
                 this.EventStatus?.Equals(other.EventStatus) == true) &&
                (this.EventType == null && other.EventType == null ||
                 this.EventType?.Equals(other.EventType) == true) &&
                (this.IsComplete == null && other.IsComplete == null ||
                 this.IsComplete?.Equals(other.IsComplete) == true) &&
                (this.UserAction == null && other.UserAction == null ||
                 this.UserAction?.Equals(other.UserAction) == true) &&
                (this.UserImpact == null && other.UserImpact == null ||
                 this.UserImpact?.Equals(other.UserImpact) == true) &&
                (this.MEvent.Equals(other.MEvent)) &&
                (this.Links == null && other.Links == null ||
                 this.Links?.Equals(other.Links) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Token = {this.Token ?? "null"}");
            toStringOutput.Add($"CanBeCancelled = {(this.CanBeCancelled == null ? "null" : this.CanBeCancelled.ToString())}");
            toStringOutput.Add($"EventRequirementCategoryType = {(this.EventRequirementCategoryType == null ? "null" : this.EventRequirementCategoryType.ToString())}");
            toStringOutput.Add($"EventRequirementType = {(this.EventRequirementType == null ? "null" : this.EventRequirementType.ToString())}");
            toStringOutput.Add($"EventStatus = {(this.EventStatus == null ? "null" : this.EventStatus.ToString())}");
            toStringOutput.Add($"EventType = {(this.EventType == null ? "null" : this.EventType.ToString())}");
            toStringOutput.Add($"IsComplete = {(this.IsComplete == null ? "null" : this.IsComplete.ToString())}");
            toStringOutput.Add($"UserAction = {(this.UserAction == null ? "null" : this.UserAction.ToString())}");
            toStringOutput.Add($"UserImpact = {(this.UserImpact == null ? "null" : this.UserImpact.ToString())}");
            toStringOutput.Add($"MEvent = {this.MEvent}");
            toStringOutput.Add($"Links = {(this.Links == null ? "null" : $"[{string.Join(", ", this.Links)} ]")}");
            toStringOutput.Add($"Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}