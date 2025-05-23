/*
 * Bandwidth
 *
 * Bandwidth's Communication APIs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: letstalk@bandwidth.com
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
using OpenAPIDateConverter = Bandwidth.Standard.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// RbmMessageContentRichCard
    /// </summary>
    [JsonConverter(typeof(RbmMessageContentRichCardJsonConverter))]
    [DataContract(Name = "rbmMessageContentRichCard")]
    public partial class RbmMessageContentRichCard : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RbmMessageContentRichCard" /> class
        /// with the <see cref="RbmStandaloneCard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RbmStandaloneCard.</param>
        public RbmMessageContentRichCard(RbmStandaloneCard actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RbmMessageContentRichCard" /> class
        /// with the <see cref="RbmMessageCarouselCard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RbmMessageCarouselCard.</param>
        public RbmMessageContentRichCard(RbmMessageCarouselCard actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
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
                if (value.GetType() == typeof(RbmMessageCarouselCard) || value is RbmMessageCarouselCard)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RbmStandaloneCard) || value is RbmStandaloneCard)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: RbmMessageCarouselCard, RbmStandaloneCard");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `RbmStandaloneCard`. If the actual instance is not `RbmStandaloneCard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RbmStandaloneCard</returns>
        public RbmStandaloneCard GetRbmStandaloneCard()
        {
            return (RbmStandaloneCard)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RbmMessageCarouselCard`. If the actual instance is not `RbmMessageCarouselCard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RbmMessageCarouselCard</returns>
        public RbmMessageCarouselCard GetRbmMessageCarouselCard()
        {
            return (RbmMessageCarouselCard)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RbmMessageContentRichCard {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, RbmMessageContentRichCard.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of RbmMessageContentRichCard
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of RbmMessageContentRichCard</returns>
        public static RbmMessageContentRichCard FromJson(string jsonString)
        {
            RbmMessageContentRichCard newRbmMessageContentRichCard = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRbmMessageContentRichCard;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RbmMessageCarouselCard).GetProperty("AdditionalProperties") == null)
                {
                    newRbmMessageContentRichCard = new RbmMessageContentRichCard(JsonConvert.DeserializeObject<RbmMessageCarouselCard>(jsonString, RbmMessageContentRichCard.SerializerSettings));
                }
                else
                {
                    newRbmMessageContentRichCard = new RbmMessageContentRichCard(JsonConvert.DeserializeObject<RbmMessageCarouselCard>(jsonString, RbmMessageContentRichCard.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RbmMessageCarouselCard");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RbmMessageCarouselCard: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RbmStandaloneCard).GetProperty("AdditionalProperties") == null)
                {
                    newRbmMessageContentRichCard = new RbmMessageContentRichCard(JsonConvert.DeserializeObject<RbmStandaloneCard>(jsonString, RbmMessageContentRichCard.SerializerSettings));
                }
                else
                {
                    newRbmMessageContentRichCard = new RbmMessageContentRichCard(JsonConvert.DeserializeObject<RbmStandaloneCard>(jsonString, RbmMessageContentRichCard.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RbmStandaloneCard");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RbmStandaloneCard: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newRbmMessageContentRichCard;
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
    /// Custom JSON converter for RbmMessageContentRichCard
    /// </summary>
    public class RbmMessageContentRichCardJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(RbmMessageContentRichCard).GetMethod("ToJson").Invoke(value, null)));
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
                    return RbmMessageContentRichCard.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return RbmMessageContentRichCard.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
