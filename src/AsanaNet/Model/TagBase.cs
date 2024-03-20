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
    /// TagBase
    /// </summary>
    [DataContract(Name = "TagBase")]
    public partial class TagBase : IValidatableObject
    {
        /// <summary>
        /// Color of the tag.
        /// </summary>
        /// <value>Color of the tag.</value>
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
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 19
        }


        /// <summary>
        /// Color of the tag.
        /// </summary>
        /// <value>Color of the tag.</value>
        /// <example>light-green</example>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TagBase" /> class.
        /// </summary>
        /// <param name="name">Name of the tag. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer..</param>
        /// <param name="color">Color of the tag..</param>
        /// <param name="notes">Free-form textual information associated with the tag (i.e. its description)..</param>
        public TagBase(string name = default(string), ColorEnum? color = default(ColorEnum?), string notes = default(string))
        {
            this.Name = name;
            this.Color = color;
            this.Notes = notes;
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
        /// Name of the tag. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer.
        /// </summary>
        /// <value>Name of the tag. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer.</value>
        /// <example>Stuff to buy</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Free-form textual information associated with the tag (i.e. its description).
        /// </summary>
        /// <value>Free-form textual information associated with the tag (i.e. its description).</value>
        /// <example>Mittens really likes the stuff from Humboldt.</example>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TagBase {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
