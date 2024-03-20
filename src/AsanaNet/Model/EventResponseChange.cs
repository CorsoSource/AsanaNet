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
    /// Information about the type of change that has occurred. This field is only present when the value of the property &#x60;action&#x60;, describing the action taken on the **resource**, is &#x60;changed&#x60;.
    /// </summary>
    [DataContract(Name = "EventResponse_change")]
    public partial class EventResponseChange : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponseChange" /> class.
        /// </summary>
        /// <param name="newValue">*Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;changed&#x60; _and_ the &#x60;new_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint..</param>
        /// <param name="addedValue">*Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;added&#x60; _and_ the &#x60;added_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint..</param>
        /// <param name="removedValue">*Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;removed&#x60; _and_ the &#x60;removed_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint..</param>
        public EventResponseChange(Object newValue = default(Object), Object addedValue = default(Object), Object removedValue = default(Object))
        {
            this.NewValue = newValue;
            this.AddedValue = addedValue;
            this.RemovedValue = removedValue;
        }

        /// <summary>
        /// The name of the field that has changed in the resource.
        /// </summary>
        /// <value>The name of the field that has changed in the resource.</value>
        /// <example>assignee</example>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; private set; }

        /// <summary>
        /// Returns false as Field should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeField()
        {
            return false;
        }
        /// <summary>
        /// The type of action taken on the **field** which has been changed.  This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, or &#x60;removed&#x60; depending on the nature of the change.
        /// </summary>
        /// <value>The type of action taken on the **field** which has been changed.  This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, or &#x60;removed&#x60; depending on the nature of the change.</value>
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
        /// *Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;changed&#x60; _and_ the &#x60;new_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint.
        /// </summary>
        /// <value>*Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;changed&#x60; _and_ the &#x60;new_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint.</value>
        /// <example>{&quot;gid&quot;:&quot;12345&quot;,&quot;resource_type&quot;:&quot;user&quot;}</example>
        [DataMember(Name = "new_value", EmitDefaultValue = true)]
        public Object NewValue { get; set; }

        /// <summary>
        /// *Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;added&#x60; _and_ the &#x60;added_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint.
        /// </summary>
        /// <value>*Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;added&#x60; _and_ the &#x60;added_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint.</value>
        /// <example>{&quot;gid&quot;:&quot;12345&quot;,&quot;resource_type&quot;:&quot;user&quot;}</example>
        [DataMember(Name = "added_value", EmitDefaultValue = true)]
        public Object AddedValue { get; set; }

        /// <summary>
        /// *Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;removed&#x60; _and_ the &#x60;removed_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint.
        /// </summary>
        /// <value>*Conditional.* This property is only present when the value of the event&#39;s &#x60;change.action&#x60; is &#x60;removed&#x60; _and_ the &#x60;removed_value&#x60; is an Asana resource. This will be only the &#x60;gid&#x60; and &#x60;resource_type&#x60; of the resource when the events come from webhooks; this will be the compact representation (and can have fields expanded with [opt_fields](/docs/inputoutput-options)) when using the [get events](/reference/getevents) endpoint.</value>
        /// <example>{&quot;gid&quot;:&quot;12345&quot;,&quot;resource_type&quot;:&quot;user&quot;}</example>
        [DataMember(Name = "removed_value", EmitDefaultValue = true)]
        public Object RemovedValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventResponseChange {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  AddedValue: ").Append(AddedValue).Append("\n");
            sb.Append("  RemovedValue: ").Append(RemovedValue).Append("\n");
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
