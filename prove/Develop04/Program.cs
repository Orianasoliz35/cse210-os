//Mindfulness Program File : Week 4
using System;
public class Program
{
    public static void Main()
    {
        Activity[] activities = new Activity[]
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        foreach (Activity activity in activities)
        {
            Console.Write($"Enter the duration of the {activity.GetType().Name} Activity (in seconds): ");
            int duration = int.Parse(Console.ReadLine());
            activity.StartActivity(duration);
        }
    }
}