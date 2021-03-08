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
    public class ParticipantSubscription 
    {
        public ParticipantSubscription() { }

        public ParticipantSubscription(string participantId)
        {
            ParticipantId = participantId;
        }

        /// <summary>
        /// Participant the subscriber should be subscribed to
        /// </summary>
        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ParticipantSubscription : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ParticipantId = {(ParticipantId == null ? "null" : ParticipantId == string.Empty ? "" : ParticipantId)}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is ParticipantSubscription other &&
                ((ParticipantId == null && other.ParticipantId == null) || (ParticipantId?.Equals(other.ParticipantId) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1364424941;

            if (ParticipantId != null)
            {
               hashCode += ParticipantId.GetHashCode();
            }

            return hashCode;
        }

    }
}