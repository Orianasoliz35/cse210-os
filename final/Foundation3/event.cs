using System;
class Event
    {
        private string _eventName;
        private DateTime _eventDate;
        private Address _eventLocation;

        public Event(string eventName, DateTime eventDate, Address eventLocation)
        {
            _eventName = eventName;
            _eventDate = eventDate;
            _eventLocation = eventLocation;
        }

        public virtual string GetMarketingMessage()
        {
            return $"Join us for the {_eventName} event!";
        }
    }