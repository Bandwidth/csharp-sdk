using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bandwidth.Standard.Utilities
{
    /// <summary>
    /// Extends from JsonConverter, allows the use of a custom converter.
    /// </summary>
    class ListDateTimeConverter : JsonConverter
    {
        /// <summary>
        /// Initializes a new instance of the ListDateTimeConverter object.
        /// </summary>
        public ListDateTimeConverter()
        {
            Converter = new IsoDateTimeConverter();
        }

        /// <summary>
        /// Initializes a new instance of the ListDateTimeConverter object based 
        /// on the provided type.
        /// </summary>
        public ListDateTimeConverter(Type Converter)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(Converter);
        }

        /// <summary>
        /// Initializes a new instance of the ListDateTimeConverter object based 
        /// on the provided type and format.
        /// </summary>
        public ListDateTimeConverter(Type Converter,string format)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(Converter,format);
        }

        /// <summary>
        /// Getter/Setter for the JsonConverter.
        /// </summary>
        public JsonConverter Converter { get; set; }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(Converter);
            serializer.Serialize(writer,value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(Converter);
            return serializer.Deserialize(reader, objectType);
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(List<DateTime>)||objectType == typeof(DateTime) || objectType == typeof(List<DateTimeOffset>)||objectType == typeof(DateTimeOffset))
                return true;
            else
                return false;
        }
    }
}