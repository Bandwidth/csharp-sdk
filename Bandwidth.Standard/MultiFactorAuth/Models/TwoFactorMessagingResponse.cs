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

namespace Bandwidth.Standard.MultiFactorAuth.Models
{
    public class TwoFactorMessagingResponse 
    {
        public TwoFactorMessagingResponse() { }

        public TwoFactorMessagingResponse(string messageId = null)
        {
            MessageId = messageId;
        }

        /// <summary>
        /// Getter for messageId
        /// </summary>
        [JsonProperty("messageId", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageId { get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorMessagingResponse : ({string.Join(", ", toStringOutput)})";
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MessageId = {(MessageId == null ? "null" : MessageId == string.Empty ? "" : MessageId)}");
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

            return obj is TwoFactorMessagingResponse other &&
                ((MessageId == null && other.MessageId == null) || (MessageId?.Equals(other.MessageId) == true));
        }

        public override int GetHashCode()
        {
            int hashCode = 1575158831;

            if (MessageId != null)
            {
               hashCode += MessageId.GetHashCode();
            }

            return hashCode;
        }

    }
}