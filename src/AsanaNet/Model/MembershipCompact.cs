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
using System.Reflection;

namespace AsanaNet.Model
{
    /// <summary>
    /// MembershipCompact
    /// </summary>
    [JsonConverter(typeof(MembershipCompactJsonConverter))]
    [DataContract(Name = "MembershipCompact")]
    public partial class MembershipCompact : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipCompact" /> class
        /// with the <see cref="GoalMembershipCompact" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GoalMembershipCompact.</param>
        public MembershipCompact(GoalMembershipCompact actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipCompact" /> class
        /// with the <see cref="ProjectMembershipCompactResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProjectMembershipCompactResponse.</param>
        public MembershipCompact(ProjectMembershipCompactResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(GoalMembershipCompact))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProjectMembershipCompactResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GoalMembershipCompact, ProjectMembershipCompactResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GoalMembershipCompact`. If the actual instance is not `GoalMembershipCompact`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GoalMembershipCompact</returns>
        public GoalMembershipCompact GetGoalMembershipCompact()
        {
            return (GoalMembershipCompact)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ProjectMembershipCompactResponse`. If the actual instance is not `ProjectMembershipCompactResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProjectMembershipCompactResponse</returns>
        public ProjectMembershipCompactResponse GetProjectMembershipCompactResponse()
        {
            return (ProjectMembershipCompactResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MembershipCompact {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, MembershipCompact.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of MembershipCompact
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of MembershipCompact</returns>
        public static MembershipCompact FromJson(string jsonString)
        {
            MembershipCompact newMembershipCompact = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newMembershipCompact;
            }

            try
            {
                newMembershipCompact = new MembershipCompact(JsonConvert.DeserializeObject<GoalMembershipCompact>(jsonString, MembershipCompact.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newMembershipCompact;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GoalMembershipCompact: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newMembershipCompact = new MembershipCompact(JsonConvert.DeserializeObject<ProjectMembershipCompactResponse>(jsonString, MembershipCompact.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newMembershipCompact;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProjectMembershipCompactResponse: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
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

    /// <summary>
    /// Custom JSON converter for MembershipCompact
    /// </summary>
    public class MembershipCompactJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(MembershipCompact).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return MembershipCompact.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return MembershipCompact.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
