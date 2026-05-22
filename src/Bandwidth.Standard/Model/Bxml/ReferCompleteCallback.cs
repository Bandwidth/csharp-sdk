using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Bandwidth.Standard.Model
{
    /// This event is sent to the referCompleteUrl of the A-leg's &lt;Refer&gt; verb when the REFER attempt completes.
    [DataContract(Name = "referCompleteCallback")]
    public partial class ReferCompleteCallback : IValidatableObject
    {
        public ReferCompleteCallback(
            string eventType = default(string),
            DateTime eventTime = default(DateTime),
            string accountId = default(string),
            string applicationId = default(string),
            string from = default(string),
            string to = default(string),
            CallDirectionEnum? direction = default(CallDirectionEnum?),
            string callId = default(string),
            string callUrl = default(string),
            DateTime startTime = default(DateTime),
            DateTime answerTime = default(DateTime),
            ReferCallStatusEnum referCallStatus = default(ReferCallStatusEnum),
            string tag = default(string),
            int? referSipResponseCode = default(int?),
            int? notifySipResponseCode = default(int?))
        {
            EventType = eventType;
            EventTime = eventTime;
            AccountId = accountId;
            ApplicationId = applicationId;
            From = from;
            To = to;
            Direction = direction;
            CallId = callId;
            CallUrl = callUrl;
            StartTime = startTime;
            AnswerTime = answerTime;
            ReferCallStatus = referCallStatus;
            Tag = tag;
            ReferSipResponseCode = referSipResponseCode;
            NotifySipResponseCode = notifySipResponseCode;
        }

        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        [DataMember(Name = "eventTime", EmitDefaultValue = false)]
        public DateTime EventTime { get; set; }

        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public CallDirectionEnum? Direction { get; set; }

        [DataMember(Name = "callId", EmitDefaultValue = false)]
        public string CallId { get; set; }

        [DataMember(Name = "callUrl", EmitDefaultValue = false)]
        public string CallUrl { get; set; }

        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        [DataMember(Name = "answerTime", EmitDefaultValue = false)]
        public DateTime AnswerTime { get; set; }

        [DataMember(Name = "referCallStatus", EmitDefaultValue = false)]
        public ReferCallStatusEnum ReferCallStatus { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = true)]
        public string Tag { get; set; }

        [DataMember(Name = "referSipResponseCode", EmitDefaultValue = true)]
        public int? ReferSipResponseCode { get; set; }

        [DataMember(Name = "notifySipResponseCode", EmitDefaultValue = true)]
        public int? NotifySipResponseCode { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReferCompleteCallback {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  CallUrl: ").Append(CallUrl).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  AnswerTime: ").Append(AnswerTime).Append("\n");
            sb.Append("  ReferCallStatus: ").Append(ReferCallStatus).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  ReferSipResponseCode: ").Append(ReferSipResponseCode).Append("\n");
            sb.Append("  NotifySipResponseCode: ").Append(NotifySipResponseCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}