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
    /// GoalRelationshipResponse
    /// </summary>
    [DataContract(Name = "GoalRelationshipResponse")]
    public partial class GoalRelationshipResponse : IValidatableObject
    {
        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceSubtypeEnum
        {
            /// <summary>
            /// Enum Subgoal for value: subgoal
            /// </summary>
            [EnumMember(Value = "subgoal")]
            Subgoal = 1,

            /// <summary>
            /// Enum SupportingWork for value: supporting_work
            /// </summary>
            [EnumMember(Value = "supporting_work")]
            SupportingWork = 2
        }


        /// <summary>
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.</value>
        /// <example>subgoal</example>
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
        /// Initializes a new instance of the <see cref="GoalRelationshipResponse" /> class.
        /// </summary>
        /// <param name="supportingResource">supportingResource.</param>
        /// <param name="contributionWeight">The weight that the supporting resource&#39;s progress contributes to the supported goal&#39;s progress. This can only be 0 or 1..</param>
        /// <param name="supportedGoal">supportedGoal.</param>
        public GoalRelationshipResponse(GoalRelationshipCompactAllOfSupportingResource supportingResource = default(GoalRelationshipCompactAllOfSupportingResource), decimal contributionWeight = default(decimal), GoalRelationshipBaseAllOfSupportedGoal supportedGoal = default(GoalRelationshipBaseAllOfSupportedGoal))
        {
            this.SupportingResource = supportingResource;
            this.ContributionWeight = contributionWeight;
            this.SupportedGoal = supportedGoal;
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
        /// Gets or Sets SupportingResource
        /// </summary>
        [DataMember(Name = "supporting_resource", EmitDefaultValue = false)]
        public GoalRelationshipCompactAllOfSupportingResource SupportingResource { get; set; }

        /// <summary>
        /// The weight that the supporting resource&#39;s progress contributes to the supported goal&#39;s progress. This can only be 0 or 1.
        /// </summary>
        /// <value>The weight that the supporting resource&#39;s progress contributes to the supported goal&#39;s progress. This can only be 0 or 1.</value>
        /// <example>1</example>
        [DataMember(Name = "contribution_weight", EmitDefaultValue = false)]
        public decimal ContributionWeight { get; set; }

        /// <summary>
        /// Gets or Sets SupportedGoal
        /// </summary>
        [DataMember(Name = "supported_goal", EmitDefaultValue = false)]
        public GoalRelationshipBaseAllOfSupportedGoal SupportedGoal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoalRelationshipResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
            sb.Append("  SupportingResource: ").Append(SupportingResource).Append("\n");
            sb.Append("  ContributionWeight: ").Append(ContributionWeight).Append("\n");
            sb.Append("  SupportedGoal: ").Append(SupportedGoal).Append("\n");
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
