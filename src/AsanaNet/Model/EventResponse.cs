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
    /// An *event* is an object representing a change to a resource that was observed by an event subscription or delivered asynchronously to the target location of an active webhook.  The event may be triggered by a different &#x60;user&#x60; than the subscriber. For example, if user A subscribes to a task and user B modified it, the event’s user will be user B. Note: Some events are generated by the system, and will have &#x60;null&#x60; as the user. API consumers should make sure to handle this case.  The &#x60;resource&#x60; that triggered the event may be different from the one that the events were requested for or the webhook is subscribed to. For example, a subscription to a project will contain events for tasks contained within the project.  **Note:** pay close attention to the relationship between the fields &#x60;Event.action&#x60; and &#x60;Event.change.action&#x60;. &#x60;Event.action&#x60; represents the action taken on the resource itself, and &#x60;Event.change.action&#x60; represents how the information within the resource&#39;s fields have been modified.  For instance, consider these scenarios:   * When at task is added to a project, &#x60;Event.action&#x60; will be &#x60;added&#x60;, &#x60;Event.parent&#x60; will be an object with the &#x60;id&#x60; and &#x60;type&#x60; of the project, and there will be no &#x60;change&#x60; field.   * When an assignee is set on the task, &#x60;Event.parent&#x60; will be &#x60;null&#x60;, &#x60;Event.action&#x60; will be &#x60;changed&#x60;, &#x60;Event.change.action&#x60; will be &#x60;changed&#x60;, and &#x60;new_value&#x60; will be an object with the user&#39;s &#x60;id&#x60; and &#x60;type&#x60;.   * When a collaborator is added to the task, &#x60;Event.parent&#x60; will be &#x60;null&#x60;, &#x60;Event.action&#x60; will be &#x60;changed&#x60;, &#x60;Event.change.action&#x60; will be &#x60;added&#x60;, and &#x60;added_value&#x60; will be an object with the user&#39;s &#x60;id&#x60; and &#x60;type&#x60;.
    /// </summary>
    [DataContract(Name = "EventResponse")]
    public partial class EventResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponse" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="resource">resource.</param>
        /// <param name="parent">parent.</param>
        /// <param name="change">change.</param>
        public EventResponse(EventResponseUser user = default(EventResponseUser), EventResponseResource resource = default(EventResponseResource), EventResponseParent parent = default(EventResponseParent), EventResponseChange change = default(EventResponseChange))
        {
            this.User = user;
            this.Resource = resource;
            this.Parent = parent;
            this.Change = change;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EventResponseUser User { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public EventResponseResource Resource { get; set; }

        /// <summary>
        /// *Deprecated: Refer to the resource_type of the resource.* The type of the resource that generated the event.
        /// </summary>
        /// <value>*Deprecated: Refer to the resource_type of the resource.* The type of the resource that generated the event.</value>
        /// <example>task</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// The type of action taken on the **resource** that triggered the event.  This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, &#x60;removed&#x60;, &#x60;deleted&#x60;, or &#x60;undeleted&#x60; depending on the nature of the event.
        /// </summary>
        /// <value>The type of action taken on the **resource** that triggered the event.  This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, &#x60;removed&#x60;, &#x60;deleted&#x60;, or &#x60;undeleted&#x60; depending on the nature of the event.</value>
        /// <example>changed</example>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; private set; }

        /// <summary>
        /// Returns false as Action should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAction()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public EventResponseParent Parent { get; set; }

        /// <summary>
        /// The timestamp when the event occurred.
        /// </summary>
        /// <value>The timestamp when the event occurred.</value>
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
        /// Gets or Sets Change
        /// </summary>
        [DataMember(Name = "change", EmitDefaultValue = false)]
        public EventResponseChange Change { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventResponse {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
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
