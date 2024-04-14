using System;

class Swimming : Activity
    {
        private int _laps;

        public Swimming(string name, int laps, double minutes)
            : base(name, 0, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000; // Convert laps to km
        }
    }
