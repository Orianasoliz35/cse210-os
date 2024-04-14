using System;
class Webinar : Event
    {
        private string _hostName;

        public Webinar(string eventName, DateTime eventDate, Address eventLocation, string hostName)
            : base(eventName, eventDate, eventLocation)
        {
            _hostName = hostName;
        }

        public override string GetMarketingMessage()
        {
            return $"Join {_hostName} for an exciting webinar: {base.GetMarketingMessage()}";
        }
    }