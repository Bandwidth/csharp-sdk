using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bandwidth.Standard.Model
{
    /// Result of a refer attempt.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferCallStatusEnum
    {
        /// Enum Success for value: success
        [EnumMember(Value = "success")]
        Success = 1,

        /// Enum Failure for value: failure
        [EnumMember(Value = "failure")]
        Failure = 2
    }
}