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
    /// ProjectBriefResponse
    /// </summary>
    [DataContract(Name = "ProjectBriefResponse")]
    public partial class ProjectBriefResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBriefResponse" /> class.
        /// </summary>
        /// <param name="title">The title of the project brief..</param>
        /// <param name="htmlText">HTML formatted text for the project brief..</param>
        /// <param name="text">[Opt In](/docs/inputoutput-options). The plain text of the project brief..</param>
        /// <param name="project">project.</param>
        public ProjectBriefResponse(string title = default(string), string htmlText = default(string), string text = default(string), ProjectBriefResponseAllOfProject project = default(ProjectBriefResponseAllOfProject))
        {
            this.Title = title;
            this.HtmlText = htmlText;
            this.Text = text;
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
        /// The title of the project brief.
        /// </summary>
        /// <value>The title of the project brief.</value>
        /// <example>Stuff to buy — Project Brief</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// HTML formatted text for the project brief.
        /// </summary>
        /// <value>HTML formatted text for the project brief.</value>
        /// <example>&lt;body&gt;This is a &lt;strong&gt;project brief&lt;/strong&gt;.&lt;/body&gt;</example>
        [DataMember(Name = "html_text", EmitDefaultValue = false)]
        public string HtmlText { get; set; }

        /// <summary>
        /// [Opt In](/docs/inputoutput-options). The plain text of the project brief.
        /// </summary>
        /// <value>[Opt In](/docs/inputoutput-options). The plain text of the project brief.</value>
        /// <example>This is a project brief.</example>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// A url that points directly to the object within Asana.
        /// </summary>
        /// <value>A url that points directly to the object within Asana.</value>
        /// <example>https://app.asana.com/0/11111111/22222222</example>
        [DataMember(Name = "permalink_url", EmitDefaultValue = false)]
        public string PermalinkUrl { get; private set; }

        /// <summary>
        /// Returns false as PermalinkUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePermalinkUrl()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public ProjectBriefResponseAllOfProject Project { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectBriefResponse {\n");
            sb.Append("  Gid: ").Append(Gid).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  HtmlText: ").Append(HtmlText).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  PermalinkUrl: ").Append(PermalinkUrl).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
