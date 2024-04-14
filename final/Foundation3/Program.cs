//Final Project - foundation 4, Inheritance:
using System;
using System.Collections.Generic;

namespace EventMarketing

 class Program
    {
        static void Main(string[] args)
        {
            var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            var address2 = new Address("456 Elm St", "Othercity", "NY", "USA");

            var webinar = new Webinar("Webinar on AI", new DateTime(2023, 1, 15), address1, "Dr. Smith");
            var conference = new Conference("Tech Conference", new DateTime(2023, 2, 20), address2, 500);

            Console.WriteLine(webinar.GetMarketingMessage());
            Console.WriteLine(conference.GetMarketingMessage());
        }
    }