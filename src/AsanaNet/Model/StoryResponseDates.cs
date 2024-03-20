/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/openapi/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AsanaNet.Client.OpenAPIDateConverter;

namespace AsanaNet.Model
{
    /// <summary>
    /// *Conditional*
    /// </summary>
    [DataContract(Name = "StoryResponseDates")]
    public partial class StoryResponseDates : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryResponseDates" /> class.
        /// </summary>
        /// <param name="startOn">The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date..</param>
        /// <param name="dueAt">The UTC date and time on which this task is due, or null if the task has no due time. This takes an ISO 8601 date string in UTC and should not be used together with &#x60;due_on&#x60;..</param>
        /// <param name="dueOn">The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;..</param>
        public StoryResponseDates(DateOnly startOn = default(DateOnly), DateTime? dueAt = default(DateTime?), DateOnly dueOn = default(DateOnly))
        {
            this.StartOn = startOn;
            this.DueAt = dueAt;
            this.DueOn = dueOn;
        }

        /// <summary>
        /// The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date.
        /// </summary>
        /// <value>The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date.</value>
        /// <example>Fri Sep 13 19:00:00 CDT 2019</example>
        [DataMember(Name = "start_on", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly StartOn { get; set; }

        /// <summary>
        /// The UTC date and time on which this task is due, or null if the task has no due time. This takes an ISO 8601 date string in UTC and should not be used together with &#x60;due_on&#x60;.
        /// </summary>
        /// <value>The UTC date and time on which this task is due, or null if the task has no due time. This takes an ISO 8601 date string in UTC and should not be used together with &#x60;due_on&#x60;.</value>
        /// <example>2019-09-15T02:06:58.158Z</example>
        [DataMember(Name = "due_at", EmitDefaultValue = true)]
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;.
        /// </summary>
        /// <value>The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;.</value>
        /// <example>Sat Sep 14 19:00:00 CDT 2019</example>
        [DataMember(Name = "due_on", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly DueOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoryResponseDates {\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  DueAt: ").Append(DueAt).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
