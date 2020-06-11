/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard.Voice.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Status1Enum
    {
        Processing,
        Partial,
        Complete,
        Deleted,
        Error,
    }

    /// <summary>
    /// Helper for the enum type Status1Enum
    /// </summary>
    public static class Status1EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "processing", "partial", "complete", "deleted", "error" };

        /// <summary>
        /// Converts a Status1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status1Enum.Processing:
                case Status1Enum.Partial:
                case Status1Enum.Complete:
                case Status1Enum.Deleted:
                case Status1Enum.Error:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status1Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Status1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status1Enum value</returns>
        public static Status1Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Status1Enum", value));

            return (Status1Enum) index;
        }
    }
}