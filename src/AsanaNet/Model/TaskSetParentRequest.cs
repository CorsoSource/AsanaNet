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
    /// TaskSetParentRequest
    /// </summary>
    [DataContract(Name = "TaskSetParentRequest")]
    public partial class TaskSetParentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSetParentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskSetParentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSetParentRequest" /> class.
        /// </summary>
        /// <param name="parent">The new parent of the task, or &#x60;null&#x60; for no parent. (required).</param>
        /// <param name="insertAfter">A subtask of the parent to insert the task after, or &#x60;null&#x60; to insert at the beginning of the list..</param>
        /// <param name="insertBefore">A subtask of the parent to insert the task before, or &#x60;null&#x60; to insert at the end of the list..</param>
        public TaskSetParentRequest(string parent = default(string), string insertAfter = default(string), string insertBefore = default(string))
        {
            // to ensure "parent" is required (not null)
            if (parent == null)
            {
                throw new ArgumentNullException("parent is a required property for TaskSetParentRequest and cannot be null");
            }
            this.Parent = parent;
            this.InsertAfter = insertAfter;
            this.InsertBefore = insertBefore;
        }

        /// <summary>
        /// The new parent of the task, or &#x60;null&#x60; for no parent.
        /// </summary>
        /// <value>The new parent of the task, or &#x60;null&#x60; for no parent.</value>
        /// <example>987654</example>
        [DataMember(Name = "parent", IsRequired = true, EmitDefaultValue = true)]
        public string Parent { get; set; }

        /// <summary>
        /// A subtask of the parent to insert the task after, or &#x60;null&#x60; to insert at the beginning of the list.
        /// </summary>
        /// <value>A subtask of the parent to insert the task after, or &#x60;null&#x60; to insert at the beginning of the list.</value>
        /// <example>null</example>
        [DataMember(Name = "insert_after", EmitDefaultValue = false)]
        public string InsertAfter { get; set; }

        /// <summary>
        /// A subtask of the parent to insert the task before, or &#x60;null&#x60; to insert at the end of the list.
        /// </summary>
        /// <value>A subtask of the parent to insert the task before, or &#x60;null&#x60; to insert at the end of the list.</value>
        /// <example>124816</example>
        [DataMember(Name = "insert_before", EmitDefaultValue = false)]
        public string InsertBefore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskSetParentRequest {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
            sb.Append("  InsertBefore: ").Append(InsertBefore).Append("\n");
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
