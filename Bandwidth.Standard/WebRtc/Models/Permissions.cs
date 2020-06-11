/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard.WebRtc.Models
{
    public class Permissions 
    {
        public Permissions() { }

        public Permissions(bool canPublish,
            Models.MediaTypeEnum mediaType)
        {
            CanPublish = canPublish;
            MediaType = mediaType;
        }

        /// <summary>
        /// Whether this participant is allowed to publish media
        /// </summary>
        [JsonProperty("canPublish")]
        public bool CanPublish { get; set; }

        /// <summary>
        /// The type of media the participant is allowed to publish
        /// VIDEO permission implies AUDIO permission as well
        /// </summary>
        [JsonProperty("mediaType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.MediaTypeEnum MediaType { get; set; }

    }
}