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
    /// SectionTaskInsertRequest
    /// </summary>
    [DataContract(Name = "SectionTaskInsertRequest")]
    public partial class SectionTaskInsertRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionTaskInsertRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionTaskInsertRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionTaskInsertRequest" /> class.
        /// </summary>
        /// <param name="task">The task to add to this section. (required).</param>
        /// <param name="insertBefore">An existing task within this section before which the added task should be inserted. Cannot be provided together with insert_after..</param>
        /// <param name="insertAfter">An existing task within this section after which the added task should be inserted. Cannot be provided together with insert_before..</param>
        public SectionTaskInsertRequest(string task = default(string), string insertBefore = default(string), string insertAfter = default(string))
        {
            // to ensure "task" is required (not null)
            if (task == null)
            {
                throw new ArgumentNullException("task is a required property for SectionTaskInsertRequest and cannot be null");
            }
            this.Task = task;
            this.InsertBefore = insertBefore;
            this.InsertAfter = insertAfter;
        }

        /// <summary>
        /// The task to add to this section.
        /// </summary>
        /// <value>The task to add to this section.</value>
        /// <example>123456</example>
        [DataMember(Name = "task", IsRequired = true, EmitDefaultValue = true)]
        public string Task { get; set; }

        /// <summary>
        /// An existing task within this section before which the added task should be inserted. Cannot be provided together with insert_after.
        /// </summary>
        /// <value>An existing task within this section before which the added task should be inserted. Cannot be provided together with insert_after.</value>
        /// <example>86420</example>
        [DataMember(Name = "insert_before", EmitDefaultValue = false)]
        public string InsertBefore { get; set; }

        /// <summary>
        /// An existing task within this section after which the added task should be inserted. Cannot be provided together with insert_before.
        /// </summary>
        /// <value>An existing task within this section after which the added task should be inserted. Cannot be provided together with insert_before.</value>
        /// <example>987654</example>
        [DataMember(Name = "insert_after", EmitDefaultValue = false)]
        public string InsertAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SectionTaskInsertRequest {\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  InsertBefore: ").Append(InsertBefore).Append("\n");
            sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
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
