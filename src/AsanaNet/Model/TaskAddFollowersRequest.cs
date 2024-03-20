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
    /// TaskAddFollowersRequest
    /// </summary>
    [DataContract(Name = "TaskAddFollowersRequest")]
    public partial class TaskAddFollowersRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAddFollowersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskAddFollowersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAddFollowersRequest" /> class.
        /// </summary>
        /// <param name="followers">An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user. (required).</param>
        public TaskAddFollowersRequest(List<string> followers = default(List<string>))
        {
            // to ensure "followers" is required (not null)
            if (followers == null)
            {
                throw new ArgumentNullException("followers is a required property for TaskAddFollowersRequest and cannot be null");
            }
            this.Followers = followers;
        }

        /// <summary>
        /// An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user.
        /// </summary>
        /// <value>An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user.</value>
        /// <example>[&quot;13579&quot;,&quot;321654&quot;]</example>
        [DataMember(Name = "followers", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Followers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskAddFollowersRequest {\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
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
