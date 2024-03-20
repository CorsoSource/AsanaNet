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
    /// StoryBase
    /// </summary>
    [DataContract(Name = "StoryBase")]
    public partial class StoryBase : IValidatableObject
    {
        /// <summary>
        /// The name of the sticker in this story. &#x60;null&#x60; if there is no sticker.
        /// </summary>
        /// <value>The name of the sticker in this story. &#x60;null&#x60; if there is no sticker.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StickerNameEnum
        {
            /// <summary>
            /// Enum GreenCheckmark for value: green_checkmark
            /// </summary>
            [EnumMember(Value = "green_checkmark")]
            GreenCheckmark = 1,

            /// <summary>
            /// Enum PeopleDancing for value: people_dancing
            /// </summary>
            [EnumMember(Value = "people_dancing")]
            PeopleDancing = 2,

            /// <summary>
            /// Enum DancingUnicorn for value: dancing_unicorn
            /// </summary>
            [EnumMember(Value = "dancing_unicorn")]
            DancingUnicorn = 3,

            /// <summary>
            /// Enum Heart for value: heart
            /// </summary>
            [EnumMember(Value = "heart")]
            Heart = 4,

            /// <summary>
            /// Enum PartyPopper for value: party_popper
            /// </summary>
            [EnumMember(Value = "party_popper")]
            PartyPopper = 5,

            /// <summary>
            /// Enum PeopleWavingFlags for value: people_waving_flags
            /// </summary>
            [EnumMember(Value = "people_waving_flags")]
            PeopleWavingFlags = 6,

            /// <summary>
            /// Enum SplashingNarwhal for value: splashing_narwhal
            /// </summary>
            [EnumMember(Value = "splashing_narwhal")]
            SplashingNarwhal = 7,

            /// <summary>
            /// Enum Trophy for value: trophy
            /// </summary>
            [EnumMember(Value = "trophy")]
            Trophy = 8,

            /// <summary>
            /// Enum YetiRidingUnicorn for value: yeti_riding_unicorn
            /// </summary>
            [EnumMember(Value = "yeti_riding_unicorn")]
            YetiRidingUnicorn = 9,

            /// <summary>
            /// Enum CelebratingPeople for value: celebrating_people
            /// </summary>
            [EnumMember(Value = "celebrating_people")]
            CelebratingPeople = 10,

            /// <summary>
            /// Enum DeterminedClimbers for value: determined_climbers
            /// </summary>
            [EnumMember(Value = "determined_climbers")]
            DeterminedClimbers = 11,

            /// <summary>
            /// Enum PhoenixSpreadingLove for value: phoenix_spreading_love
            /// </summary>
            [EnumMember(Value = "phoenix_spreading_love")]
            PhoenixSpreadingLove = 12
        }


        /// <summary>
        /// The name of the sticker in this story. &#x60;null&#x60; if there is no sticker.
        /// </summary>
        /// <value>The name of the sticker in this story. &#x60;null&#x60; if there is no sticker.</value>
        /// <example>dancing_unicorn</example>
        [DataMember(Name = "sticker_name", EmitDefaultValue = false)]
        public StickerNameEnum? StickerName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryBase" /> class.
        /// </summary>
        /// <param name="text">The plain text of the comment to add. Cannot be used with html_text..</param>
        /// <param name="htmlText">[Opt In](/docs/inputoutput-options). HTML formatted text for a comment. This will not include the name of the creator..</param>
        /// <param name="isPinned">*Conditional*. Whether the story should be pinned on the resource..</param>
        /// <param name="stickerName">The name of the sticker in this story. &#x60;null&#x60; if there is no sticker..</param>
        public StoryBase(string text = default(string), string htmlText = default(string), bool isPinned = default(bool), StickerNameEnum? stickerName = default(StickerNameEnum?))
        {
            this.Text = text;
            this.HtmlText = htmlText;
            this.IsPinned = isPinned;
            this.StickerName = stickerName;
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
        /// The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.
        /// </summary>
        /// <value>The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning.</value>
        /// <example>comment_added</example>
        [DataMember(Name = "resource_subtype", EmitDefaultValue = false)]
        public string ResourceSubtype { get; private set; }

        /// <summary>
        /// Returns false as ResourceSubtype should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceSubtype()
        {
            return false;
        }
        /// <summary>
        /// The plain text of the comment to add. Cannot be used with html_text.
        /// </summary>
        /// <value>The plain text of the comment to add. Cannot be used with html_text.</value>
        /// <example>This is a comment.</example>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// [Opt In](/docs/inputoutput-options). HTML formatted text for a comment. This will not include the name of the creator.
        /// </summary>
        /// <value>[Opt In](/docs/inputoutput-options). HTML formatted text for a comment. This will not include the name of the creator.</value>
        /// <example>&lt;body&gt;This is a comment.&lt;/body&gt;</example>
        [DataMember(Name = "html_text", EmitDefaultValue = false)]
        public string HtmlText { get; set; }

        /// <summary>
        /// *Conditional*. Whether the story should be pinned on the resource.
        /// </summary>
        /// <value>*Conditional*. Whether the story should be pinned on the resource.</value>
        /// <example>false</example>
        [DataMember(Name = "is_pinned", EmitDefaultValue = true)]
        public bool IsPinned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoryBase {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ResourceSubtype: ").Append(ResourceSubtype).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  HtmlText: ").Append(HtmlText).Append("\n");
            sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
            sb.Append("  StickerName: ").Append(StickerName).Append("\n");
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