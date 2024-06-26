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
    /// The entity that triggered the event. Will typically be a user.
    /// </summary>
    [DataContract(Name = "AuditLogEventActor")]
    public partial class AuditLogEventActor : IValidatableObject
    {
        /// <summary>
        /// The type of actor. Can be one of &#x60;user&#x60;, &#x60;asana&#x60;, &#x60;asana_support&#x60;, &#x60;anonymous&#x60;, or &#x60;external_administrator&#x60;.
        /// </summary>
        /// <value>The type of actor. Can be one of &#x60;user&#x60;, &#x60;asana&#x60;, &#x60;asana_support&#x60;, &#x60;anonymous&#x60;, or &#x60;external_administrator&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActorTypeEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,

            /// <summary>
            /// Enum Asana for value: asana
            /// </summary>
            [EnumMember(Value = "asana")]
            Asana = 2,

            /// <summary>
            /// Enum AsanaSupport for value: asana_support
            /// </summary>
            [EnumMember(Value = "asana_support")]
            AsanaSupport = 3,

            /// <summary>
            /// Enum Anonymous for value: anonymous
            /// </summary>
            [EnumMember(Value = "anonymous")]
            Anonymous = 4,

            /// <summary>
            /// Enum ExternalAdministrator for value: external_administrator
            /// </summary>
            [EnumMember(Value = "external_administrator")]
            ExternalAdministrator = 5
        }


        /// <summary>
        /// The type of actor. Can be one of &#x60;user&#x60;, &#x60;asana&#x60;, &#x60;asana_support&#x60;, &#x60;anonymous&#x60;, or &#x60;external_administrator&#x60;.
        /// </summary>
        /// <value>The type of actor. Can be one of &#x60;user&#x60;, &#x60;asana&#x60;, &#x60;asana_support&#x60;, &#x60;anonymous&#x60;, or &#x60;external_administrator&#x60;.</value>
        /// <example>user</example>
        [DataMember(Name = "actor_type", EmitDefaultValue = false)]
        public ActorTypeEnum? ActorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventActor" /> class.
        /// </summary>
        /// <param name="actorType">The type of actor. Can be one of &#x60;user&#x60;, &#x60;asana&#x60;, &#x60;asana_support&#x60;, &#x60;anonymous&#x60;, or &#x60;external_administrator&#x60;..</param>
        /// <param name="gid">Globally unique identifier of the actor, if it is a user..</param>
        /// <param name="name">The name of the actor, if it is a user..</param>
        /// <param name="email">The email of the actor, if it is a user..</param>
        public AuditLogEventActor(ActorTypeEnum? actorType = default(ActorTypeEnum?), string gid = default(string), string name = default(string), string email = default(string))
        {
            this.ActorType = actorType;
            this.Gid = gid;
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Globally unique identifier of the actor, if it is a user.
        /// </summary>
        /// <value>Globally unique identifier of the actor, if it is a user.</value>
        /// <example>1111</example>
        [DataMember(Name = "gid", EmitDefaultValue = false)]
        public string Gid { get; set; }

        /// <summary>
        /// The name of the actor, if it is a user.
        /// </summary>
        /// <value>The name of the actor, if it is a user.</value>
        /// <example>Greg Sanchez</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The email of the actor, if it is a user.
        /// </summary>
        /// <value>The email of the actor, if it is a user.</value>
        /// <example>gregsanchez@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditLogEventActor {\n");
            sb.Append("  ActorType: ").Append(ActorType).Append("\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
