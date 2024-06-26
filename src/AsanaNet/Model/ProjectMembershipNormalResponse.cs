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
    /// ProjectMembershipNormalResponse
    /// </summary>
    [DataContract(Name = "ProjectMembershipNormalResponse")]
    public partial class ProjectMembershipNormalResponse : IValidatableObject
    {
        /// <summary>
        /// Whether the member has admin, editor, commenter, or viewer access to the project.
        /// </summary>
        /// <value>Whether the member has admin, editor, commenter, or viewer access to the project.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessLevelEnum
        {
            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 1,

            /// <summary>
            /// Enum Editor for value: editor
            /// </summary>
            [EnumMember(Value = "editor")]
            Editor = 2,

            /// <summary>
            /// Enum Commenter for value: commenter
            /// </summary>
            [EnumMember(Value = "commenter")]
            Commenter = 3,

            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 4
        }


        /// <summary>
        /// Whether the member has admin, editor, commenter, or viewer access to the project.
        /// </summary>
        /// <value>Whether the member has admin, editor, commenter, or viewer access to the project.</value>
        /// <example>admin</example>
        [DataMember(Name = "access_level", EmitDefaultValue = false)]
        public AccessLevelEnum? AccessLevel { get; set; }

        /// <summary>
        /// Returns false as AccessLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccessLevel()
        {
            return false;
        }
        /// <summary>
        /// Whether the member has full access or comment-only access to the project.
        /// </summary>
        /// <value>Whether the member has full access or comment-only access to the project.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WriteAccessEnum
        {
            /// <summary>
            /// Enum FullWrite for value: full_write
            /// </summary>
            [EnumMember(Value = "full_write")]
            FullWrite = 1,

            /// <summary>
            /// Enum CommentOnly for value: comment_only
            /// </summary>
            [EnumMember(Value = "comment_only")]
            CommentOnly = 2
        }


        /// <summary>
        /// Whether the member has full access or comment-only access to the project.
        /// </summary>
        /// <value>Whether the member has full access or comment-only access to the project.</value>
        /// <example>full_write</example>
        [DataMember(Name = "write_access", EmitDefaultValue = false)]
        public WriteAccessEnum? WriteAccess { get; set; }

        /// <summary>
        /// Returns false as WriteAccess should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWriteAccess()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMembershipNormalResponse" /> class.
        /// </summary>
        /// <param name="resourceType">The base type of this resource..</param>
        /// <param name="parent">parent.</param>
        /// <param name="member">member.</param>
        /// <param name="user">user.</param>
        /// <param name="project">project.</param>
        public ProjectMembershipNormalResponse(string resourceType = default(string), ProjectCompact parent = default(ProjectCompact), MemberCompact member = default(MemberCompact), UserCompact user = default(UserCompact), ProjectCompact project = default(ProjectCompact))
        {
            this.ResourceType = resourceType;
            this.Parent = parent;
            this.Member = member;
            this.User = user;
            this.Project = project;
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
        /// <example>project_membership</example>
        [DataMember(Name = "resource_type", EmitDefaultValue = false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public ProjectCompact Parent { get; set; }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name = "member", EmitDefaultValue = false)]
        public MemberCompact Member { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public UserCompact User { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public ProjectCompact Project { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectMembershipNormalResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  WriteAccess: ").Append(WriteAccess).Append("\n");
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
