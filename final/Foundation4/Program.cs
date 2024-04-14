//Final Project - foundation 4, polimorphis:
using System;
using System.Collections.Generic;

namespace ActivityTracker
{

class Program
    {
        static void Main(string[] args)
        {
            var running = new Running("Morning Run", 10, 50);
            var swimming = new Swimming("Pool Swim", 20, 30);
            var cycling = new Cycling("Bike Ride", 25, 60);

            var activities = new List<Activity> { running, swimming, cycling };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}