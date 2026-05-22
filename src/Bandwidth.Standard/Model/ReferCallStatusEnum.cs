using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bandwidth.Standard.Model
{
    /// <summary>
    /// Result of a refer attempt.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferCallStatusEnum
    {
        /// <summary>
        /// Enum Success for value: success
        /// </summary>
        [EnumMember(Value = "success")]
        Success = 1,

        /// <summary>
        /// Enum Failure for value: failure
        /// </summary>
        [EnumMember(Value = "failure")]
        Failure = 2
    }
}
