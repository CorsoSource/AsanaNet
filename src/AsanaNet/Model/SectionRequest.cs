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
    /// SectionRequest
    /// </summary>
    [DataContract(Name = "SectionRequest")]
    public partial class SectionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionRequest" /> class.
        /// </summary>
        /// <param name="name">The text to be displayed as the section name. This cannot be an empty string. (required).</param>
        /// <param name="insertBefore">An existing section within this project before which the added section should be inserted. Cannot be provided together with insert_after..</param>
        /// <param name="insertAfter">An existing section within this project after which the added section should be inserted. Cannot be provided together with insert_before..</param>
        public SectionRequest(string name = default(string), string insertBefore = default(string), string insertAfter = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SectionRequest and cannot be null");
            }
            this.Name = name;
            this.InsertBefore = insertBefore;
            this.InsertAfter = insertAfter;
        }

        /// <summary>
        /// The text to be displayed as the section name. This cannot be an empty string.
        /// </summary>
        /// <value>The text to be displayed as the section name. This cannot be an empty string.</value>
        /// <example>Next Actions</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// An existing section within this project before which the added section should be inserted. Cannot be provided together with insert_after.
        /// </summary>
        /// <value>An existing section within this project before which the added section should be inserted. Cannot be provided together with insert_after.</value>
        /// <example>86420</example>
        [DataMember(Name = "insert_before", EmitDefaultValue = false)]
        public string InsertBefore { get; set; }

        /// <summary>
        /// An existing section within this project after which the added section should be inserted. Cannot be provided together with insert_before.
        /// </summary>
        /// <value>An existing section within this project after which the added section should be inserted. Cannot be provided together with insert_before.</value>
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
            sb.Append("class SectionRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
