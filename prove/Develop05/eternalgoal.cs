using System;
public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for eternal goal: {Name}. Gained {Points} points!");
    }
}
