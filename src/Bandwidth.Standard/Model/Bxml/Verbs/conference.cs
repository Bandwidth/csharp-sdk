using System.Collections.Generic;
using bxml;

namespace bxml.verbs
{

    public class Conference : Verb
    {
        public string Name { get; set; }
        public bool Mute { get; set; }
        public bool Hold { get; set; }

        public string CallIdsToCoach { get; set; }

        public string ConferenceEventUrl { get; set; }

        public string ConferenceEventMethod { get; set; }


        public string ConferenceEventFallbackUrl { get; set; }


        public string ConferenceEventFallbackMethod { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FallbackUsername { get; set; }


        public string FallbackPassword { get; set; }

        public new string Tag { get; set; }

        public string CallbackTimeout { get; set; }

        public override Dictionary<string, string> Attributes
        {
            get
            {
                var attributes = base.Attributes;

                if (this.Mute)
                {
                    attributes.Add("mute", "true");
                }
                if (!string.IsNullOrEmpty(this.CallIdsToCoach))
                {
                    attributes.Add("callIdsToCoach", this.CallIdsToCoach);
                }

                return attributes;

            }
            set
            {
                var attributes = base.Attributes;

                if (this.Mute)
                {
                    attributes.Add("mute", "true");
                }
                if (!string.IsNullOrEmpty(this.CallIdsToCoach))
                {
                    attributes.Add("callIdsToCoach", this.CallIdsToCoach);
                }

            }
        }


        public Conference() : base("Conference", "name")
        {
            Console.WriteLine("I'm in the constructor");
        }
        public void AddAttributes()
        {

            Dictionary<string, string> attributes = new Dictionary<string, string>();

            if (this.Mute)
            {
                attributes.Add("mute", "true");
            }
            if (this.Hold)
            {
                attributes.Add("hold", "true");
            }
            if (!string.IsNullOrEmpty(this.CallIdsToCoach))
            {
                attributes.Add("callIdsToCoach", this.CallIdsToCoach);
            }
            if (!string.IsNullOrEmpty(this.ConferenceEventUrl))
            {
                attributes.Add("conferenceEventUrl", this.ConferenceEventUrl);
            }
            if (!string.IsNullOrEmpty(this.ConferenceEventMethod))
            {
                attributes.Add("conferenceEventMethod", this.ConferenceEventMethod);
            }
            if (!string.IsNullOrEmpty(this.ConferenceEventFallbackUrl))
            {
                attributes.Add("conferenceEventFallbackUrl", this.ConferenceEventFallbackUrl);
            }
            if (!string.IsNullOrEmpty(this.ConferenceEventFallbackMethod))
            {
                attributes.Add("conferenceEventFallbackMethod", this.ConferenceEventFallbackMethod);
            }
            if (!string.IsNullOrEmpty(this.Username))
            {
                attributes.Add("username", this.Username);
            }
            if (!string.IsNullOrEmpty(this.Password))
            {
                attributes.Add("password", this.Password);
            }
            if (!string.IsNullOrEmpty(this.FallbackUsername))
            {
                attributes.Add("fallbackUsername", this.FallbackUsername);
            }
            if (!string.IsNullOrEmpty(this.FallbackPassword))
            {
                attributes.Add("fallbackPassword", this.FallbackPassword);
            }
            if (!string.IsNullOrEmpty(this.Tag))
            {
                attributes.Add("tag", this.Tag);
            }
            if (!string.IsNullOrEmpty(this.CallbackTimeout))
            {
                attributes.Add("callbackTimeout", this.CallbackTimeout);
            }

            base.Attributes = attributes;
            base.Content = this.Name;
            Console.WriteLine("TAG: ", base.Tag);
            Console.WriteLine("Name: ", this.Name);
        }
    }
}
