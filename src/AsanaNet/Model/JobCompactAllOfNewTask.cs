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
    /// JobCompactAllOfNewTask
    /// </summary>
    [DataContract(Name = "JobCompact_allOf_new_task")]
    public partial class JobCompactAllOfNewTask : IValidatableObject
    {
        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceSubtypeEnum
        {
            /// <summary>
            /// Enum DefaultTask for value: default_task
            /// </summary>
            [EnumMember(Value = "default_task")]
            DefaultTask = 1,

            /// <summary>
            /// Enum Milestone for value: milestone
            /// </summary>
            [EnumMember(Value = "milestone")]
            Milestone = 2,

            /// <summary>
            /// Enum Section for value: section
            /// </summary>
            [EnumMember(Value = "section")]
            Section = 3,

            /// <summary>
            /// Enum Approval for value: approval
            /// </summary>
            [EnumMember(Value = "approval")]
            Approval = 4
        }


        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date.</value>
        /// <example>default_task</example>
        [DataMember(Name = "resource_subtype", EmitDefaultValue = false)]
        public ResourceSubtypeEnum? ResourceSubtype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobCompactAllOfNewTask" /> class.
        /// </summary>
        /// <param name="name">The name of the task..</param>
        /// <param name="resourceSubtype">The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date..</param>
        /// <param name="createdBy">createdBy.</param>
        public JobCompactAllOfNewTask(string name = default(string), ResourceSubtypeEnum? resourceSubtype = default(ResourceSubtypeEnum?), TaskCompactAllOfCreatedBy createdBy = default(TaskCompactAllOfCreatedBy))
        {
            this.Name = name;
            this.ResourceSubtype = resourceSubtype;
            this.CreatedBy = createdBy;
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
        /// The name of the task.
        /// </summary>
        /// <value>The name of the task.</value>
        /// <example>Bug Task</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public TaskCompactAllOfCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobCompactAllOfNewTask {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
