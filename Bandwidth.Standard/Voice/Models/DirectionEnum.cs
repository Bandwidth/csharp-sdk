// <copyright file="DirectionEnum.cs" company="APIMatic">
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
    /// DirectionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectionEnum
    {
        /// <summary>
        /// Inbound.
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Outbound.
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound,
    }
}