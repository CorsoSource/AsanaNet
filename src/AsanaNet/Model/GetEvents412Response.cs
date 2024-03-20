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
    /// GetEvents412Response
    /// </summary>
    [DataContract(Name = "getEvents_412_response")]
    public partial class GetEvents412Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvents412Response" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        public GetEvents412Response(List<GetEvents412ResponseErrorsInner> errors = default(List<GetEvents412ResponseErrorsInner>))
        {
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<GetEvents412ResponseErrorsInner> Errors { get; set; }

        /// <summary>
        /// A sync token to be used with the next call to the /events endpoint.
        /// </summary>
        /// <value>A sync token to be used with the next call to the /events endpoint.</value>
        /// <example>de4774f6915eae04714ca93bb2f5ee81</example>
        [DataMember(Name = "sync", EmitDefaultValue = false)]
        public string Sync { get; private set; }

        /// <summary>
        /// Returns false as Sync should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSync()
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
            sb.Append("class GetEvents412Response {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
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