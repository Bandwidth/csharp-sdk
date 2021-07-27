// <copyright file="ListDateTimeConverter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Utilities
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Extends from JsonConverter, allows the use of a custom converter.
    /// </summary>
    public class ListDateTimeConverter : JsonConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDateTimeConverter"/>
        /// class.
        /// </summary>
        public ListDateTimeConverter()
        {
            this.Converter = new IsoDateTimeConverter();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        public ListDateTimeConverter(Type converter)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(converter);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="converter">converter.</param>
        /// <param name="format">format.</param>
        public ListDateTimeConverter(Type converter, string format)
        {
            this.Converter = (JsonConverter)Activator.CreateInstance(converter, format);
        }

        /// <summary>
        /// Gets or sets the JsonConverter.
        /// </summary>
        public JsonConverter Converter { get; set; }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(this.Converter);
            serializer.Serialize(writer, value);
        }

        /// <inheritdoc/>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            serializer.Converters.Clear();
            serializer.Converters.Add(this.Converter);
            return serializer.Deserialize(reader, objectType);
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(List<DateTime>) || objectType == typeof(DateTime) || objectType == typeof(List<DateTimeOffset>) || objectType == typeof(DateTimeOffset))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}