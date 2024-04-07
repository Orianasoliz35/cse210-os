using System;
public class SimpleGoal : Goal
{
    public override void RecordEvent()
    {
        IsComplete = true;
        Console.WriteLine($"Completed goal: {Name}. Gained {Points} points!");
    }
}
