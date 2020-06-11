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
    public enum Status2Enum
    {
        None,
        Processing,
        Available,
        Error,
        Timeout,
        Filesizetoobig,
        Filesizetoosmall,
    }

    /// <summary>
    /// Helper for the enum type Status2Enum
    /// </summary>
    public static class Status2EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "none", "processing", "available", "error", "timeout", "file-size-too-big", "file-size-too-small" };

        /// <summary>
        /// Converts a Status2Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status2Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status2Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status2Enum.None:
                case Status2Enum.Processing:
                case Status2Enum.Available:
                case Status2Enum.Error:
                case Status2Enum.Timeout:
                case Status2Enum.Filesizetoobig:
                case Status2Enum.Filesizetoosmall:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status2Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status2Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status2Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Status2Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status2Enum value</returns>
        public static Status2Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Status2Enum", value));

            return (Status2Enum) index;
        }
    }
}