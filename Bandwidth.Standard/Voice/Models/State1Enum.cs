// <copyright file="State1Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Voice.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Bandwidth.Standard;
    using Bandwidth.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// State1Enum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum State1Enum
    {
        /// <summary>
        /// NOTRECORDING.
        /// </summary>
        [EnumMember(Value = "NOT_RECORDING")]
        NOTRECORDING,

        /// <summary>
        /// PAUSED.
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        PAUSED,

        /// <summary>
        /// RECORDING.
        /// </summary>
        [EnumMember(Value = "RECORDING")]
        RECORDING,
    }
}