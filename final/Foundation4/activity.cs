using System;

class Activity
    {
        private string _name;
        private double _distance;
        private double _minutes;

        public Activity(string name, double distance, double minutes)
        {
            _name = name;
            _distance = distance;
            _minutes = minutes;
        }

        public virtual double GetDistance()
        {
            return _distance;
        }

        public virtual double GetSpeed()
        {
            return (_distance / _minutes) * 60;
        }

        public virtual double GetPace()
        {
            return _minutes / _distance;
        }

        public virtual string GetSummary()
        {
            return $"Activity: {_name}\nDistance: {GetDistance()} km\nSpeed: {GetSpeed()} km/h\nPace: {GetPace()} min/km";
        }
    }