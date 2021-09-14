// <copyright file="ModeEnum.cs" company="APIMatic">
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
    /// ModeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModeEnum
    {
        /// <summary>
        /// Sync.
        /// </summary>
        [EnumMember(Value = "sync")]
        Sync,

        /// <summary>
        /// Async.
        /// </summary>
        [EnumMember(Value = "async")]
        Async,
    }
}