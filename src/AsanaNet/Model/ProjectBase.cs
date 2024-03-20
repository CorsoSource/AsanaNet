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
    /// ProjectBase
    /// </summary>
    [DataContract(Name = "ProjectBase")]
    public partial class ProjectBase : IValidatableObject
    {
        /// <summary>
        /// Color of the project.
        /// </summary>
        /// <value>Color of the project.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            /// <summary>
            /// Enum DarkPink for value: dark-pink
            /// </summary>
            [EnumMember(Value = "dark-pink")]
            DarkPink = 1,

            /// <summary>
            /// Enum DarkGreen for value: dark-green
            /// </summary>
            [EnumMember(Value = "dark-green")]
            DarkGreen = 2,

            /// <summary>
            /// Enum DarkBlue for value: dark-blue
            /// </summary>
            [EnumMember(Value = "dark-blue")]
            DarkBlue = 3,

            /// <summary>
            /// Enum DarkRed for value: dark-red
            /// </summary>
            [EnumMember(Value = "dark-red")]
            DarkRed = 4,

            /// <summary>
            /// Enum DarkTeal for value: dark-teal
            /// </summary>
            [EnumMember(Value = "dark-teal")]
            DarkTeal = 5,

            /// <summary>
            /// Enum DarkBrown for value: dark-brown
            /// </summary>
            [EnumMember(Value = "dark-brown")]
            DarkBrown = 6,

            /// <summary>
            /// Enum DarkOrange for value: dark-orange
            /// </summary>
            [EnumMember(Value = "dark-orange")]
            DarkOrange = 7,

            /// <summary>
            /// Enum DarkPurple for value: dark-purple
            /// </summary>
            [EnumMember(Value = "dark-purple")]
            DarkPurple = 8,

            /// <summary>
            /// Enum DarkWarmGray for value: dark-warm-gray
            /// </summary>
            [EnumMember(Value = "dark-warm-gray")]
            DarkWarmGray = 9,

            /// <summary>
            /// Enum LightPink for value: light-pink
            /// </summary>
            [EnumMember(Value = "light-pink")]
            LightPink = 10,

            /// <summary>
            /// Enum LightGreen for value: light-green
            /// </summary>
            [EnumMember(Value = "light-green")]
            LightGreen = 11,

            /// <summary>
            /// Enum LightBlue for value: light-blue
            /// </summary>
            [EnumMember(Value = "light-blue")]
            LightBlue = 12,

            /// <summary>
            /// Enum LightRed for value: light-red
            /// </summary>
            [EnumMember(Value = "light-red")]
            LightRed = 13,

            /// <summary>
            /// Enum LightTeal for value: light-teal
            /// </summary>
            [EnumMember(Value = "light-teal")]
            LightTeal = 14,

            /// <summary>
            /// Enum LightBrown for value: light-brown
            /// </summary>
            [EnumMember(Value = "light-brown")]
            LightBrown = 15,

            /// <summary>
            /// Enum LightOrange for value: light-orange
            /// </summary>
            [EnumMember(Value = "light-orange")]
            LightOrange = 16,

            /// <summary>
            /// Enum LightPurple for value: light-purple
            /// </summary>
            [EnumMember(Value = "light-purple")]
            LightPurple = 17,

            /// <summary>
            /// Enum LightWarmGray for value: light-warm-gray
            /// </summary>
            [EnumMember(Value = "light-warm-gray")]
            LightWarmGray = 18,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 19,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 20
        }


        /// <summary>
        /// Color of the project.
        /// </summary>
        /// <value>Color of the project.</value>
        /// <example>light-green</example>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// The default view (list, board, calendar, or timeline) of a project.
        /// </summary>
        /// <value>The default view (list, board, calendar, or timeline) of a project.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultViewEnum
        {
            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 1,

            /// <summary>
            /// Enum Board for value: board
            /// </summary>
            [EnumMember(Value = "board")]
            Board = 2,

            /// <summary>
            /// Enum Calendar for value: calendar
            /// </summary>
            [EnumMember(Value = "calendar")]
            Calendar = 3,

            /// <summary>
            /// Enum Timeline for value: timeline
            /// </summary>
            [EnumMember(Value = "timeline")]
            Timeline = 4
        }


        /// <summary>
        /// The default view (list, board, calendar, or timeline) of a project.
        /// </summary>
        /// <value>The default view (list, board, calendar, or timeline) of a project.</value>
        /// <example>calendar</example>
        [DataMember(Name = "default_view", EmitDefaultValue = false)]
        public DefaultViewEnum? DefaultView { get; set; }
        /// <summary>
        /// The default access for users or teams who join or are added as members to the project.
        /// </summary>
        /// <value>The default access for users or teams who join or are added as members to the project.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultAccessLevelEnum
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
        /// The default access for users or teams who join or are added as members to the project.
        /// </summary>
        /// <value>The default access for users or teams who join or are added as members to the project.</value>
        /// <example>admin</example>
        [DataMember(Name = "default_access_level", EmitDefaultValue = false)]
        public DefaultAccessLevelEnum? DefaultAccessLevel { get; set; }
        /// <summary>
        /// The minimum access level needed for project members to modify this project&#39;s workflow and appearance.
        /// </summary>
        /// <value>The minimum access level needed for project members to modify this project&#39;s workflow and appearance.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MinimumAccessLevelForCustomizationEnum
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
            Editor = 2
        }


        /// <summary>
        /// The minimum access level needed for project members to modify this project&#39;s workflow and appearance.
        /// </summary>
        /// <value>The minimum access level needed for project members to modify this project&#39;s workflow and appearance.</value>
        /// <example>admin</example>
        [DataMember(Name = "minimum_access_level_for_customization", EmitDefaultValue = false)]
        public MinimumAccessLevelForCustomizationEnum? MinimumAccessLevelForCustomization { get; set; }
        /// <summary>
        /// The minimum access level needed for project members to share the project and manage project memberships.
        /// </summary>
        /// <value>The minimum access level needed for project members to share the project and manage project memberships.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MinimumAccessLevelForSharingEnum
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
            Editor = 2
        }


        /// <summary>
        /// The minimum access level needed for project members to share the project and manage project memberships.
        /// </summary>
        /// <value>The minimum access level needed for project members to share the project and manage project memberships.</value>
        /// <example>admin</example>
        [DataMember(Name = "minimum_access_level_for_sharing", EmitDefaultValue = false)]
        public MinimumAccessLevelForSharingEnum? MinimumAccessLevelForSharing { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBase" /> class.
        /// </summary>
        /// <param name="name">Name of the project. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer..</param>
        /// <param name="archived">True if the project is archived, false if not. Archived projects do not show in the UI by default and may be treated differently for queries..</param>
        /// <param name="color">Color of the project..</param>
        /// <param name="currentStatus">currentStatus.</param>
        /// <param name="currentStatusUpdate">currentStatusUpdate.</param>
        /// <param name="defaultView">The default view (list, board, calendar, or timeline) of a project..</param>
        /// <param name="dueDate">*Deprecated: new integrations should prefer the &#x60;due_on&#x60; field.*.</param>
        /// <param name="dueOn">The day on which this project is due. This takes a date with format YYYY-MM-DD..</param>
        /// <param name="htmlNotes">[Opt In](/docs/inputoutput-options). The notes of the project with formatting as HTML..</param>
        /// <param name="notes">Free-form textual information associated with the project (ie., its description)..</param>
        /// <param name="varPublic">True if the project is public to its team..</param>
        /// <param name="startOn">The day on which work for this project begins, or null if the project has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format. *Note: &#x60;due_on&#x60; or &#x60;due_at&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter. Additionally, &#x60;start_on&#x60; and &#x60;due_on&#x60; cannot be the same date.*.</param>
        /// <param name="defaultAccessLevel">The default access for users or teams who join or are added as members to the project..</param>
        /// <param name="minimumAccessLevelForCustomization">The minimum access level needed for project members to modify this project&#39;s workflow and appearance..</param>
        /// <param name="minimumAccessLevelForSharing">The minimum access level needed for project members to share the project and manage project memberships..</param>
        public ProjectBase(string name = default(string), bool archived = default(bool), ColorEnum? color = default(ColorEnum?), ProjectBaseAllOfCurrentStatus currentStatus = default(ProjectBaseAllOfCurrentStatus), ProjectBaseAllOfCurrentStatusUpdate currentStatusUpdate = default(ProjectBaseAllOfCurrentStatusUpdate), DefaultViewEnum? defaultView = default(DefaultViewEnum?), DateOnly dueDate = default(DateOnly), DateOnly dueOn = default(DateOnly), string htmlNotes = default(string), string notes = default(string), bool varPublic = default(bool), DateOnly startOn = default(DateOnly), DefaultAccessLevelEnum? defaultAccessLevel = default(DefaultAccessLevelEnum?), MinimumAccessLevelForCustomizationEnum? minimumAccessLevelForCustomization = default(MinimumAccessLevelForCustomizationEnum?), MinimumAccessLevelForSharingEnum? minimumAccessLevelForSharing = default(MinimumAccessLevelForSharingEnum?))
        {
            this.Name = name;
            this.Archived = archived;
            this.Color = color;
            this.CurrentStatus = currentStatus;
            this.CurrentStatusUpdate = currentStatusUpdate;
            this.DefaultView = defaultView;
            this.DueDate = dueDate;
            this.DueOn = dueOn;
            this.HtmlNotes = htmlNotes;
            this.Notes = notes;
            this.VarPublic = varPublic;
            this.StartOn = startOn;
            this.DefaultAccessLevel = defaultAccessLevel;
            this.MinimumAccessLevelForCustomization = minimumAccessLevelForCustomization;
            this.MinimumAccessLevelForSharing = minimumAccessLevelForSharing;
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
        /// Name of the project. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer.
        /// </summary>
        /// <value>Name of the project. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer.</value>
        /// <example>Stuff to buy</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// True if the project is archived, false if not. Archived projects do not show in the UI by default and may be treated differently for queries.
        /// </summary>
        /// <value>True if the project is archived, false if not. Archived projects do not show in the UI by default and may be treated differently for queries.</value>
        /// <example>false</example>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

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
        /// Gets or Sets CurrentStatus
        /// </summary>
        [DataMember(Name = "current_status", EmitDefaultValue = false)]
        public ProjectBaseAllOfCurrentStatus CurrentStatus { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStatusUpdate
        /// </summary>
        [DataMember(Name = "current_status_update", EmitDefaultValue = false)]
        public ProjectBaseAllOfCurrentStatusUpdate CurrentStatusUpdate { get; set; }

        /// <summary>
        /// Array of Custom Field Settings (in compact form).
        /// </summary>
        /// <value>Array of Custom Field Settings (in compact form).</value>
        [DataMember(Name = "custom_field_settings", EmitDefaultValue = false)]
        public List<CustomFieldSettingResponse> CustomFieldSettings { get; private set; }

        /// <summary>
        /// Returns false as CustomFieldSettings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomFieldSettings()
        {
            return false;
        }
        /// <summary>
        /// *Deprecated: new integrations should prefer the &#x60;due_on&#x60; field.*
        /// </summary>
        /// <value>*Deprecated: new integrations should prefer the &#x60;due_on&#x60; field.*</value>
        /// <example>Sat Sep 14 19:00:00 CDT 2019</example>
        [DataMember(Name = "due_date", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly DueDate { get; set; }

        /// <summary>
        /// The day on which this project is due. This takes a date with format YYYY-MM-DD.
        /// </summary>
        /// <value>The day on which this project is due. This takes a date with format YYYY-MM-DD.</value>
        /// <example>Sat Sep 14 19:00:00 CDT 2019</example>
        [DataMember(Name = "due_on", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly DueOn { get; set; }

        /// <summary>
        /// [Opt In](/docs/inputoutput-options). The notes of the project with formatting as HTML.
        /// </summary>
        /// <value>[Opt In](/docs/inputoutput-options). The notes of the project with formatting as HTML.</value>
        /// <example>&lt;body&gt;These are things we need to purchase.&lt;/body&gt;</example>
        [DataMember(Name = "html_notes", EmitDefaultValue = false)]
        public string HtmlNotes { get; set; }

        /// <summary>
        /// Array of users who are members of this project.
        /// </summary>
        /// <value>Array of users who are members of this project.</value>
        [DataMember(Name = "members", EmitDefaultValue = false)]
        public List<UserCompact> Members { get; private set; }

        /// <summary>
        /// Returns false as Members should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMembers()
        {
            return false;
        }
        /// <summary>
        /// The time at which this project was last modified. *Note: This does not currently reflect any changes in associations such as tasks or comments that may have been added or removed from the project.*
        /// </summary>
        /// <value>The time at which this project was last modified. *Note: This does not currently reflect any changes in associations such as tasks or comments that may have been added or removed from the project.*</value>
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
        /// Free-form textual information associated with the project (ie., its description).
        /// </summary>
        /// <value>Free-form textual information associated with the project (ie., its description).</value>
        /// <example>These are things we need to purchase.</example>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// True if the project is public to its team.
        /// </summary>
        /// <value>True if the project is public to its team.</value>
        /// <example>false</example>
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool VarPublic { get; set; }

        /// <summary>
        /// The day on which work for this project begins, or null if the project has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format. *Note: &#x60;due_on&#x60; or &#x60;due_at&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter. Additionally, &#x60;start_on&#x60; and &#x60;due_on&#x60; cannot be the same date.*
        /// </summary>
        /// <value>The day on which work for this project begins, or null if the project has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format. *Note: &#x60;due_on&#x60; or &#x60;due_at&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter. Additionally, &#x60;start_on&#x60; and &#x60;due_on&#x60; cannot be the same date.*</value>
        /// <example>Fri Sep 13 19:00:00 CDT 2019</example>
        [DataMember(Name = "start_on", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateOnly StartOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectBase {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrentStatus: ").Append(CurrentStatus).Append("\n");
            sb.Append("  CurrentStatusUpdate: ").Append(CurrentStatusUpdate).Append("\n");
            sb.Append("  CustomFieldSettings: ").Append(CustomFieldSettings).Append("\n");
            sb.Append("  DefaultView: ").Append(DefaultView).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  HtmlNotes: ").Append(HtmlNotes).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  VarPublic: ").Append(VarPublic).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  DefaultAccessLevel: ").Append(DefaultAccessLevel).Append("\n");
            sb.Append("  MinimumAccessLevelForCustomization: ").Append(MinimumAccessLevelForCustomization).Append("\n");
            sb.Append("  MinimumAccessLevelForSharing: ").Append(MinimumAccessLevelForSharing).Append("\n");
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
