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
    /// TaskTemplateResponse
    /// </summary>
    [DataContract(Name = "TaskTemplateResponse")]
    public partial class TaskTemplateResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTemplateResponse" /> class.
        /// </summary>
        /// <param name="name">Name of the task template..</param>
        /// <param name="project">project.</param>
        /// <param name="template">The configuration for the task that will be created from this template..</param>
        /// <param name="createdBy">The user who created this task template..</param>
        /// <param name="createdAt">The time at which this task template was created..</param>
        public TaskTemplateResponse(string name = default(string), TaskTemplateResponseAllOfProject project = default(TaskTemplateResponseAllOfProject), TaskTemplateRecipe template = default(TaskTemplateRecipe), UserCompact createdBy = default(UserCompact), DateTime createdAt = default(DateTime))
        {
            this.Name = name;
            this.Project = project;
            this.Template = template;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
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
        /// Name of the task template.
        /// </summary>
        /// <value>Name of the task template.</value>
        /// <example>Bug Report Template</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = true)]
        public TaskTemplateResponseAllOfProject Project { get; set; }

        /// <summary>
        /// The configuration for the task that will be created from this template.
        /// </summary>
        /// <value>The configuration for the task that will be created from this template.</value>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public TaskTemplateRecipe Template { get; set; }

        /// <summary>
        /// The user who created this task template.
        /// </summary>
        /// <value>The user who created this task template.</value>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public UserCompact CreatedBy { get; set; }

        /// <summary>
        /// The time at which this task template was created.
        /// </summary>
        /// <value>The time at which this task template was created.</value>
        /// <example>2019-01-01T00:00Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskTemplateResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
