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
    /// StatusUpdateResponse
    /// </summary>
    [DataContract(Name = "StatusUpdateResponse")]
    public partial class StatusUpdateResponse : IValidatableObject
    {
        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceSubtypeEnum
        {
            /// <summary>
            /// Enum ProjectStatusUpdate for value: project_status_update
            /// </summary>
            [EnumMember(Value = "project_status_update")]
            ProjectStatusUpdate = 1,

            /// <summary>
            /// Enum PortfolioStatusUpdate for value: portfolio_status_update
            /// </summary>
            [EnumMember(Value = "portfolio_status_update")]
            PortfolioStatusUpdate = 2,

            /// <summary>
            /// Enum GoalStatusUpdate for value: goal_status_update
            /// </summary>
            [EnumMember(Value = "goal_status_update")]
            GoalStatusUpdate = 3
        }


        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent.</value>
        /// <example>project_status_update</example>
        [DataMember(Name = "resource_subtype", EmitDefaultValue = false)]
        public ResourceSubtypeEnum? ResourceSubtype { get; set; }

        /// <summary>
        /// Returns false as ResourceSubtype should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceSubtype()
        {
            return false;
        }
        /// <summary>
        /// The type associated with the status update. This represents the current state of the object this object is on.
        /// </summary>
        /// <value>The type associated with the status update. This represents the current state of the object this object is on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusTypeEnum
        {
            /// <summary>
            /// Enum OnTrack for value: on_track
            /// </summary>
            [EnumMember(Value = "on_track")]
            OnTrack = 1,

            /// <summary>
            /// Enum AtRisk for value: at_risk
            /// </summary>
            [EnumMember(Value = "at_risk")]
            AtRisk = 2,

            /// <summary>
            /// Enum OffTrack for value: off_track
            /// </summary>
            [EnumMember(Value = "off_track")]
            OffTrack = 3,

            /// <summary>
            /// Enum OnHold for value: on_hold
            /// </summary>
            [EnumMember(Value = "on_hold")]
            OnHold = 4,

            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 5,

            /// <summary>
            /// Enum Achieved for value: achieved
            /// </summary>
            [EnumMember(Value = "achieved")]
            Achieved = 6,

            /// <summary>
            /// Enum Partial for value: partial
            /// </summary>
            [EnumMember(Value = "partial")]
            Partial = 7,

            /// <summary>
            /// Enum Missed for value: missed
            /// </summary>
            [EnumMember(Value = "missed")]
            Missed = 8,

            /// <summary>
            /// Enum Dropped for value: dropped
            /// </summary>
            [EnumMember(Value = "dropped")]
            Dropped = 9
        }


        /// <summary>
        /// The type associated with the status update. This represents the current state of the object this object is on.
        /// </summary>
        /// <value>The type associated with the status update. This represents the current state of the object this object is on.</value>
        [DataMember(Name = "status_type", IsRequired = true, EmitDefaultValue = true)]
        public StatusTypeEnum StatusType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusUpdateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatusUpdateResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusUpdateResponse" /> class.
        /// </summary>
        /// <param name="title">The title of the status update..</param>
        /// <param name="text">The text content of the status update. (required).</param>
        /// <param name="htmlText">[Opt In](/docs/inputoutput-options). The text content of the status update with formatting as HTML..</param>
        /// <param name="statusType">The type associated with the status update. This represents the current state of the object this object is on. (required).</param>
        /// <param name="author">author.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="liked">True if the status is liked by the authorized user, false if not..</param>
        /// <param name="parent">parent.</param>
        public StatusUpdateResponse(string title = default(string), string text = default(string), string htmlText = default(string), StatusTypeEnum statusType = default(StatusTypeEnum), UserCompact author = default(UserCompact), UserCompact createdBy = default(UserCompact), bool liked = default(bool), StatusUpdateResponseAllOfParent parent = default(StatusUpdateResponseAllOfParent))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for StatusUpdateResponse and cannot be null");
            }
            this.Text = text;
            this.StatusType = statusType;
            this.Title = title;
            this.HtmlText = htmlText;
            this.Author = author;
            this.CreatedBy = createdBy;
            this.Liked = liked;
            this.Parent = parent;
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
        /// The title of the status update.
        /// </summary>
        /// <value>The title of the status update.</value>
        /// <example>Status Update - Jun 15</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The text content of the status update.
        /// </summary>
        /// <value>The text content of the status update.</value>
        /// <example>The project is moving forward according to plan...</example>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// [Opt In](/docs/inputoutput-options). The text content of the status update with formatting as HTML.
        /// </summary>
        /// <value>[Opt In](/docs/inputoutput-options). The text content of the status update with formatting as HTML.</value>
        /// <example>&lt;body&gt;The project &lt;strong&gt;is&lt;/strong&gt; moving forward according to plan...&lt;/body&gt;</example>
        [DataMember(Name = "html_text", EmitDefaultValue = false)]
        public string HtmlText { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public UserCompact Author { get; set; }

        /// <summary>
        /// The time at which this resource was created.
        /// </summary>
        /// <value>The time at which this resource was created.</value>
        /// <example>2012-02-22T02:06:58.147Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public UserCompact CreatedBy { get; set; }

        /// <summary>
        /// *Deprecated - please use liked instead* True if the status is hearted by the authorized user, false if not.
        /// </summary>
        /// <value>*Deprecated - please use liked instead* True if the status is hearted by the authorized user, false if not.</value>
        /// <example>true</example>
        [DataMember(Name = "hearted", EmitDefaultValue = true)]
        public bool Hearted { get; private set; }

        /// <summary>
        /// Returns false as Hearted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHearted()
        {
            return false;
        }
        /// <summary>
        /// *Deprecated - please use likes instead* Array of likes for users who have hearted this status.
        /// </summary>
        /// <value>*Deprecated - please use likes instead* Array of likes for users who have hearted this status.</value>
        [DataMember(Name = "hearts", EmitDefaultValue = false)]
        public List<Like> Hearts { get; private set; }

        /// <summary>
        /// Returns false as Hearts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHearts()
        {
            return false;
        }
        /// <summary>
        /// True if the status is liked by the authorized user, false if not.
        /// </summary>
        /// <value>True if the status is liked by the authorized user, false if not.</value>
        /// <example>true</example>
        [DataMember(Name = "liked", EmitDefaultValue = true)]
        public bool Liked { get; set; }

        /// <summary>
        /// Array of likes for users who have liked this status.
        /// </summary>
        /// <value>Array of likes for users who have liked this status.</value>
        [DataMember(Name = "likes", EmitDefaultValue = false)]
        public List<Like> Likes { get; private set; }

        /// <summary>
        /// Returns false as Likes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLikes()
        {
            return false;
        }
        /// <summary>
        /// The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the status.*
        /// </summary>
        /// <value>The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the status.*</value>
        /// <example>2012-02-22T02:06:58.147Z</example>
        [DataMember(Name = "modified_at", EmitDefaultValue = false)]
        public DateTime ModifiedAt { get; private set; }

        /// <summary>
        /// Returns false as ModifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModifiedAt()
        {
            return false;
        }
        /// <summary>
        /// *Deprecated - please use likes instead* The number of users who have hearted this status.
        /// </summary>
        /// <value>*Deprecated - please use likes instead* The number of users who have hearted this status.</value>
        /// <example>5</example>
        [DataMember(Name = "num_hearts", EmitDefaultValue = false)]
        public int NumHearts { get; private set; }

        /// <summary>
        /// Returns false as NumHearts should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumHearts()
        {
            return false;
        }
        /// <summary>
        /// The number of users who have liked this status.
        /// </summary>
        /// <value>The number of users who have liked this status.</value>
        /// <example>5</example>
        [DataMember(Name = "num_likes", EmitDefaultValue = false)]
        public int NumLikes { get; private set; }

        /// <summary>
        /// Returns false as NumLikes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumLikes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public StatusUpdateResponseAllOfParent Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatusUpdateResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  HtmlText: ").Append(HtmlText).Append("\n");
            sb.Append("  StatusType: ").Append(StatusType).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Hearted: ").Append(Hearted).Append("\n");
            sb.Append("  Hearts: ").Append(Hearts).Append("\n");
            sb.Append("  Liked: ").Append(Liked).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  NumHearts: ").Append(NumHearts).Append("\n");
            sb.Append("  NumLikes: ").Append(NumLikes).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
