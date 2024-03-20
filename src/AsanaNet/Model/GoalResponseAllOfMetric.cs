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
    /// GoalResponseAllOfMetric
    /// </summary>
    [DataContract(Name = "GoalResponse_allOf_metric")]
    public partial class GoalResponseAllOfMetric : IValidatableObject
    {
        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceSubtypeEnum
        {
            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 1
        }


        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.</value>
        /// <example>number</example>
        [DataMember(Name = "resource_subtype", EmitDefaultValue = false)]
        public ResourceSubtypeEnum? ResourceSubtype { get; set; }

        /// <summary>
        /// Returns false as ResourceSubtype should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceSubtype()
        {
            return false;
        }
        /// <summary>
        /// A supported unit of measure for the goal metric, or none.
        /// </summary>
        /// <value>A supported unit of measure for the goal metric, or none.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Currency for value: currency
            /// </summary>
            [EnumMember(Value = "currency")]
            Currency = 2,

            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 3
        }


        /// <summary>
        /// A supported unit of measure for the goal metric, or none.
        /// </summary>
        /// <value>A supported unit of measure for the goal metric, or none.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public UnitEnum? Unit { get; set; }
        /// <summary>
        /// This field defines how the progress value of a goal metric is being calculated. A goal&#39;s progress can be provided manually by the user, calculated automatically from contributing subgoals, projects, or tasks, or managed by an integration with an external data source, such as Salesforce.
        /// </summary>
        /// <value>This field defines how the progress value of a goal metric is being calculated. A goal&#39;s progress can be provided manually by the user, calculated automatically from contributing subgoals, projects, or tasks, or managed by an integration with an external data source, such as Salesforce.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProgressSourceEnum
        {
            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 1,

            /// <summary>
            /// Enum SubgoalProgress for value: subgoal_progress
            /// </summary>
            [EnumMember(Value = "subgoal_progress")]
            SubgoalProgress = 2,

            /// <summary>
            /// Enum ProjectTaskCompletion for value: project_task_completion
            /// </summary>
            [EnumMember(Value = "project_task_completion")]
            ProjectTaskCompletion = 3,

            /// <summary>
            /// Enum ProjectMilestoneCompletion for value: project_milestone_completion
            /// </summary>
            [EnumMember(Value = "project_milestone_completion")]
            ProjectMilestoneCompletion = 4,

            /// <summary>
            /// Enum TaskCompletion for value: task_completion
            /// </summary>
            [EnumMember(Value = "task_completion")]
            TaskCompletion = 5,

            /// <summary>
            /// Enum External for value: external
            /// </summary>
            [EnumMember(Value = "external")]
            External = 6
        }


        /// <summary>
        /// This field defines how the progress value of a goal metric is being calculated. A goal&#39;s progress can be provided manually by the user, calculated automatically from contributing subgoals, projects, or tasks, or managed by an integration with an external data source, such as Salesforce.
        /// </summary>
        /// <value>This field defines how the progress value of a goal metric is being calculated. A goal&#39;s progress can be provided manually by the user, calculated automatically from contributing subgoals, projects, or tasks, or managed by an integration with an external data source, such as Salesforce.</value>
        /// <example>manual</example>
        [DataMember(Name = "progress_source", EmitDefaultValue = false)]
        public ProgressSourceEnum? ProgressSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalResponseAllOfMetric" /> class.
        /// </summary>
        /// <param name="precision">*Conditional*. Only relevant for goal metrics of type ‘Number’. This field dictates the number of places after the decimal to round to, i.e. 0 is integer values, 1 rounds to the nearest tenth, and so on. Must be between 0 and 6, inclusive. For percentage format, this may be unintuitive, as a value of 0.25 has a precision of 0, while a value of 0.251 has a precision of 1. This is due to 0.25 being displayed as 25%..</param>
        /// <param name="unit">A supported unit of measure for the goal metric, or none..</param>
        /// <param name="currencyCode">ISO 4217 currency code to format this custom field. This will be null if the &#x60;unit&#x60; is not &#x60;currency&#x60;..</param>
        /// <param name="initialNumberValue">This number is the start value of a goal metric of type number..</param>
        /// <param name="targetNumberValue">This number is the end value of a goal metric of type number. This number cannot equal &#x60;initial_number_value&#x60;..</param>
        /// <param name="currentNumberValue">This number is the current value of a goal metric of type number..</param>
        /// <param name="progressSource">This field defines how the progress value of a goal metric is being calculated. A goal&#39;s progress can be provided manually by the user, calculated automatically from contributing subgoals, projects, or tasks, or managed by an integration with an external data source, such as Salesforce..</param>
        public GoalResponseAllOfMetric(int precision = default(int), UnitEnum? unit = default(UnitEnum?), string currencyCode = default(string), decimal initialNumberValue = default(decimal), decimal targetNumberValue = default(decimal), decimal currentNumberValue = default(decimal), ProgressSourceEnum? progressSource = default(ProgressSourceEnum?))
        {
            this.Precision = precision;
            this.Unit = unit;
            this.CurrencyCode = currencyCode;
            this.InitialNumberValue = initialNumberValue;
            this.TargetNumberValue = targetNumberValue;
            this.CurrentNumberValue = currentNumberValue;
            this.ProgressSource = progressSource;
        }

        /// <summary>
        /// Globally unique identifier of the resource, as a string.
        /// </summary>
        /// <value>Globally unique identifier of the resource, as a string.</value>
        /// <example>12345</example>
        [DataMember(Name = "gid", EmitDefaultValue = false)]
        public string Gid { get; private set; }

        /// <summary>
        /// Returns false as Gid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGid()
        {
            return false;
        }
        /// <summary>
        /// The base type of this resource.
        /// </summary>
        /// <value>The base type of this resource.</value>
        /// <example>task</example>
        [DataMember(Name = "resource_type", EmitDefaultValue = false)]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Returns false as ResourceType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceType()
        {
            return false;
        }
        /// <summary>
        /// *Conditional*. Only relevant for goal metrics of type ‘Number’. This field dictates the number of places after the decimal to round to, i.e. 0 is integer values, 1 rounds to the nearest tenth, and so on. Must be between 0 and 6, inclusive. For percentage format, this may be unintuitive, as a value of 0.25 has a precision of 0, while a value of 0.251 has a precision of 1. This is due to 0.25 being displayed as 25%.
        /// </summary>
        /// <value>*Conditional*. Only relevant for goal metrics of type ‘Number’. This field dictates the number of places after the decimal to round to, i.e. 0 is integer values, 1 rounds to the nearest tenth, and so on. Must be between 0 and 6, inclusive. For percentage format, this may be unintuitive, as a value of 0.25 has a precision of 0, while a value of 0.251 has a precision of 1. This is due to 0.25 being displayed as 25%.</value>
        /// <example>2</example>
        [DataMember(Name = "precision", EmitDefaultValue = false)]
        public int Precision { get; set; }

        /// <summary>
        /// ISO 4217 currency code to format this custom field. This will be null if the &#x60;unit&#x60; is not &#x60;currency&#x60;.
        /// </summary>
        /// <value>ISO 4217 currency code to format this custom field. This will be null if the &#x60;unit&#x60; is not &#x60;currency&#x60;.</value>
        /// <example>EUR</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// This number is the start value of a goal metric of type number.
        /// </summary>
        /// <value>This number is the start value of a goal metric of type number.</value>
        /// <example>5.2</example>
        [DataMember(Name = "initial_number_value", EmitDefaultValue = false)]
        public decimal InitialNumberValue { get; set; }

        /// <summary>
        /// This number is the end value of a goal metric of type number. This number cannot equal &#x60;initial_number_value&#x60;.
        /// </summary>
        /// <value>This number is the end value of a goal metric of type number. This number cannot equal &#x60;initial_number_value&#x60;.</value>
        /// <example>10.2</example>
        [DataMember(Name = "target_number_value", EmitDefaultValue = false)]
        public decimal TargetNumberValue { get; set; }

        /// <summary>
        /// This number is the current value of a goal metric of type number.
        /// </summary>
        /// <value>This number is the current value of a goal metric of type number.</value>
        /// <example>8.12</example>
        [DataMember(Name = "current_number_value", EmitDefaultValue = false)]
        public decimal CurrentNumberValue { get; set; }

        /// <summary>
        /// This string is the current value of a goal metric of type string.
        /// </summary>
        /// <value>This string is the current value of a goal metric of type string.</value>
        /// <example>8.12</example>
        [DataMember(Name = "current_display_value", EmitDefaultValue = false)]
        public string CurrentDisplayValue { get; private set; }

        /// <summary>
        /// Returns false as CurrentDisplayValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrentDisplayValue()
        {
            return false;
        }
        /// <summary>
        /// *Conditional*. Only relevant for &#x60;progress_source&#x60; of type &#x60;external&#x60;. This boolean indicates whether the requester has the ability to update the current value of this metric. This returns &#x60;true&#x60; if the external metric was created by the requester, &#x60;false&#x60; otherwise.
        /// </summary>
        /// <value>*Conditional*. Only relevant for &#x60;progress_source&#x60; of type &#x60;external&#x60;. This boolean indicates whether the requester has the ability to update the current value of this metric. This returns &#x60;true&#x60; if the external metric was created by the requester, &#x60;false&#x60; otherwise.</value>
        /// <example>true</example>
        [DataMember(Name = "can_manage", EmitDefaultValue = true)]
        public bool CanManage { get; private set; }

        /// <summary>
        /// Returns false as CanManage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanManage()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoalResponseAllOfMetric {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  InitialNumberValue: ").Append(InitialNumberValue).Append("\n");
            sb.Append("  TargetNumberValue: ").Append(TargetNumberValue).Append("\n");
            sb.Append("  CurrentNumberValue: ").Append(CurrentNumberValue).Append("\n");
            sb.Append("  CurrentDisplayValue: ").Append(CurrentDisplayValue).Append("\n");
            sb.Append("  ProgressSource: ").Append(ProgressSource).Append("\n");
            sb.Append("  CanManage: ").Append(CanManage).Append("\n");
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
