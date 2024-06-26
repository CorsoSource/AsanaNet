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
    /// GoalResponse
    /// </summary>
    [DataContract(Name = "GoalResponse")]
    public partial class GoalResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the goal..</param>
        /// <param name="htmlNotes">The notes of the goal with formatting as HTML..</param>
        /// <param name="notes">Free-form textual information associated with the goal (i.e. its description)..</param>
        /// <param name="dueOn">The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;..</param>
        /// <param name="startOn">The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date..</param>
        /// <param name="isWorkspaceLevel">*Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team..</param>
        /// <param name="liked">True if the goal is liked by the authorized user, false if not..</param>
        /// <param name="team">team.</param>
        /// <param name="workspace">workspace.</param>
        /// <param name="followers">Array of users who are members of this goal..</param>
        /// <param name="timePeriod">timePeriod.</param>
        /// <param name="metric">metric.</param>
        /// <param name="owner">owner.</param>
        /// <param name="currentStatusUpdate">currentStatusUpdate.</param>
        public GoalResponse(string name = default(string), string htmlNotes = default(string), string notes = default(string), string dueOn = default(string), string startOn = default(string), bool isWorkspaceLevel = default(bool), bool liked = default(bool), GoalResponseAllOfTeam team = default(GoalResponseAllOfTeam), GoalResponseAllOfWorkspace workspace = default(GoalResponseAllOfWorkspace), List<UserCompact> followers = default(List<UserCompact>), GoalResponseAllOfTimePeriod timePeriod = default(GoalResponseAllOfTimePeriod), GoalResponseAllOfMetric metric = default(GoalResponseAllOfMetric), GoalResponseAllOfOwner owner = default(GoalResponseAllOfOwner), GoalResponseAllOfCurrentStatusUpdate currentStatusUpdate = default(GoalResponseAllOfCurrentStatusUpdate))
        {
            this.Name = name;
            this.HtmlNotes = htmlNotes;
            this.Notes = notes;
            this.DueOn = dueOn;
            this.StartOn = startOn;
            this.IsWorkspaceLevel = isWorkspaceLevel;
            this.Liked = liked;
            this.Team = team;
            this.Workspace = workspace;
            this.Followers = followers;
            this.TimePeriod = timePeriod;
            this.Metric = metric;
            this.Owner = owner;
            this.CurrentStatusUpdate = currentStatusUpdate;
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
        /// The name of the goal.
        /// </summary>
        /// <value>The name of the goal.</value>
        /// <example>Grow web traffic by 30%</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The notes of the goal with formatting as HTML.
        /// </summary>
        /// <value>The notes of the goal with formatting as HTML.</value>
        /// <example>&lt;body&gt;Start building brand awareness.&lt;/body&gt;</example>
        [DataMember(Name = "html_notes", EmitDefaultValue = false)]
        public string HtmlNotes { get; set; }

        /// <summary>
        /// Free-form textual information associated with the goal (i.e. its description).
        /// </summary>
        /// <value>Free-form textual information associated with the goal (i.e. its description).</value>
        /// <example>Start building brand awareness.</example>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;.
        /// </summary>
        /// <value>The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;.</value>
        /// <example>2019-09-15</example>
        [DataMember(Name = "due_on", EmitDefaultValue = true)]
        public string DueOn { get; set; }

        /// <summary>
        /// The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date.
        /// </summary>
        /// <value>The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date.</value>
        /// <example>2019-09-14</example>
        [DataMember(Name = "start_on", EmitDefaultValue = true)]
        public string StartOn { get; set; }

        /// <summary>
        /// *Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team.
        /// </summary>
        /// <value>*Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team.</value>
        /// <example>true</example>
        [DataMember(Name = "is_workspace_level", EmitDefaultValue = true)]
        public bool IsWorkspaceLevel { get; set; }

        /// <summary>
        /// True if the goal is liked by the authorized user, false if not.
        /// </summary>
        /// <value>True if the goal is liked by the authorized user, false if not.</value>
        /// <example>false</example>
        [DataMember(Name = "liked", EmitDefaultValue = true)]
        public bool Liked { get; set; }

        /// <summary>
        /// Array of likes for users who have liked this goal.
        /// </summary>
        /// <value>Array of likes for users who have liked this goal.</value>
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
        /// The number of users who have liked this goal.
        /// </summary>
        /// <value>The number of users who have liked this goal.</value>
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
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        public GoalResponseAllOfTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Workspace
        /// </summary>
        [DataMember(Name = "workspace", EmitDefaultValue = false)]
        public GoalResponseAllOfWorkspace Workspace { get; set; }

        /// <summary>
        /// Array of users who are members of this goal.
        /// </summary>
        /// <value>Array of users who are members of this goal.</value>
        [DataMember(Name = "followers", EmitDefaultValue = false)]
        public List<UserCompact> Followers { get; set; }

        /// <summary>
        /// Gets or Sets TimePeriod
        /// </summary>
        [DataMember(Name = "time_period", EmitDefaultValue = false)]
        public GoalResponseAllOfTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name = "metric", EmitDefaultValue = false)]
        public GoalResponseAllOfMetric Metric { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public GoalResponseAllOfOwner Owner { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStatusUpdate
        /// </summary>
        [DataMember(Name = "current_status_update", EmitDefaultValue = false)]
        public GoalResponseAllOfCurrentStatusUpdate CurrentStatusUpdate { get; set; }

        /// <summary>
        /// The current status of this goal. When the goal is open, its status can be &#x60;green&#x60;, &#x60;yellow&#x60;, and &#x60;red&#x60; to reflect \&quot;On Track\&quot;, \&quot;At Risk\&quot;, and \&quot;Off Track\&quot;, respectively. When the goal is closed, the value can be &#x60;missed&#x60;, &#x60;achieved&#x60;, &#x60;partial&#x60;, or &#x60;dropped&#x60;. *Note* you can only write to this property if &#x60;metric&#x60; is set.
        /// </summary>
        /// <value>The current status of this goal. When the goal is open, its status can be &#x60;green&#x60;, &#x60;yellow&#x60;, and &#x60;red&#x60; to reflect \&quot;On Track\&quot;, \&quot;At Risk\&quot;, and \&quot;Off Track\&quot;, respectively. When the goal is closed, the value can be &#x60;missed&#x60;, &#x60;achieved&#x60;, &#x60;partial&#x60;, or &#x60;dropped&#x60;. *Note* you can only write to this property if &#x60;metric&#x60; is set.</value>
        /// <example>green</example>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; private set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
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
            sb.Append("class GoalResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HtmlNotes: ").Append(HtmlNotes).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  IsWorkspaceLevel: ").Append(IsWorkspaceLevel).Append("\n");
            sb.Append("  Liked: ").Append(Liked).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  NumLikes: ").Append(NumLikes).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Workspace: ").Append(Workspace).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  CurrentStatusUpdate: ").Append(CurrentStatusUpdate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
