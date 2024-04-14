using System;
class Conference : Event
    {
        private int _attendeeCount;

        public Conference(string eventName, DateTime eventDate, Address eventLocation, int attendeeCount)
            : base(eventName, eventDate, eventLocation)
        {
            _attendeeCount = attendeeCount;
        }

        public override string GetMarketingMessage()
        {
            return $"Don't miss the {_eventName} conference with {_attendeeCount} attendees: {base.GetMarketingMessage()}";
        }
    }