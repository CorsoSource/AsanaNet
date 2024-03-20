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
    /// The full record for all events that have occurred since the sync token was created.
    /// </summary>
    [DataContract(Name = "getEvents_200_response")]
    public partial class GetEvents200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvents200Response" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="sync">A sync token to be used with the next call to the /events endpoint..</param>
        /// <param name="hasMore">Indicates whether there are more events to pull..</param>
        public GetEvents200Response(List<EventResponse> data = default(List<EventResponse>), string sync = default(string), bool hasMore = default(bool))
        {
            this.Data = data;
            this.Sync = sync;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<EventResponse> Data { get; set; }

        /// <summary>
        /// A sync token to be used with the next call to the /events endpoint.
        /// </summary>
        /// <value>A sync token to be used with the next call to the /events endpoint.</value>
        /// <example>de4774f6915eae04714ca93bb2f5ee81</example>
        [DataMember(Name = "sync", EmitDefaultValue = false)]
        public string Sync { get; set; }

        /// <summary>
        /// Indicates whether there are more events to pull.
        /// </summary>
        /// <value>Indicates whether there are more events to pull.</value>
        /// <example>true</example>
        [DataMember(Name = "has_more", EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEvents200Response {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
