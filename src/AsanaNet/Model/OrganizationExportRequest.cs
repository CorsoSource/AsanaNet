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
    /// An *organization_export* request starts a job to export the complete data of the given Organization.
    /// </summary>
    [DataContract(Name = "OrganizationExportRequest")]
    public partial class OrganizationExportRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationExportRequest" /> class.
        /// </summary>
        /// <param name="organization">Globally unique identifier for the workspace or organization..</param>
        public OrganizationExportRequest(string organization = default(string))
        {
            this.Organization = organization;
        }

        /// <summary>
        /// Globally unique identifier for the workspace or organization.
        /// </summary>
        /// <value>Globally unique identifier for the workspace or organization.</value>
        /// <example>1331</example>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public string Organization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationExportRequest {\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
