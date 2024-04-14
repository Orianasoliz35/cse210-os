using System;

class Running : Activity
    {
        public Running(string name, double distance, double minutes)
            : base(name, distance, minutes)
        {
        }

        public override double GetDistance()
        {
            return base.GetDistance() * 0.62; // Convert km to miles
        }

        public override double GetSpeed()
        {
            return base.GetSpeed() * 0.62; // Convert km/h to mph
        }

        public override double GetPace()
        {
            return base.GetPace() * 0.62; // Convert min/km to min/mile
        }
    }