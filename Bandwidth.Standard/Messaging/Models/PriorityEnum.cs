// <copyright file="PriorityEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Bandwidth.Standard.Messaging.Models
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
    /// PriorityEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriorityEnum
    {
        /// <summary>
        /// Default.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// High.
        /// </summary>
        [EnumMember(Value = "high")]
        High,
    }
}