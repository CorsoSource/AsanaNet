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
    /// Contains keys &#x60;start_on&#x60; and &#x60;end_on&#x60; for the vacation dates for the user in this workspace. If &#x60;start_on&#x60; is null, the entire &#x60;vacation_dates&#x60; object will be null. If &#x60;end_on&#x60; is before today, the entire &#x60;vacation_dates&#x60; object will be null.
    /// </summary>
    [DataContract(Name = "WorkspaceMembershipResponse_allOf_vacation_dates")]
    public partial class WorkspaceMembershipResponseAllOfVacationDates : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMembershipResponseAllOfVacationDates" /> class.
        /// </summary>
        /// <param name="startOn">The day on which the user&#39;s vacation in this workspace starts. This is a date with &#x60;YYYY-MM-DD&#x60; format..</param>
        /// <param name="endOn">The day on which the user&#39;s vacation in this workspace ends, or null if there is no end date. This is a date with &#x60;YYYY-MM-DD&#x60; format..</param>
        public WorkspaceMembershipResponseAllOfVacationDates(string startOn = default(string), string endOn = default(string))
        {
            this.StartOn = startOn;
            this.EndOn = endOn;
        }

        /// <summary>
        /// The day on which the user&#39;s vacation in this workspace starts. This is a date with &#x60;YYYY-MM-DD&#x60; format.
        /// </summary>
        /// <value>The day on which the user&#39;s vacation in this workspace starts. This is a date with &#x60;YYYY-MM-DD&#x60; format.</value>
        /// <example>2022-11-05</example>
        [DataMember(Name = "start_on", EmitDefaultValue = false)]
        public string StartOn { get; set; }

        /// <summary>
        /// The day on which the user&#39;s vacation in this workspace ends, or null if there is no end date. This is a date with &#x60;YYYY-MM-DD&#x60; format.
        /// </summary>
        /// <value>The day on which the user&#39;s vacation in this workspace ends, or null if there is no end date. This is a date with &#x60;YYYY-MM-DD&#x60; format.</value>
        /// <example>2022-11-07</example>
        [DataMember(Name = "end_on", EmitDefaultValue = true)]
        public string EndOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceMembershipResponseAllOfVacationDates {\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
            sb.Append("  EndOn: ").Append(EndOn).Append("\n");
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