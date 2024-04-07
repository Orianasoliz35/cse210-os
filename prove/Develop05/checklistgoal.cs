using System;
public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private readonly int _targetCompletion;
    private readonly int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus)
    {
        Name = name;
        Points = points;
        _targetCompletion = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCompletion)
        {
            IsComplete = true;
            int totalPoints = Points * _targetCompletion + _bonus;
            Console.WriteLine($"Completed checklist goal: {Name}. Gained {totalPoints} points!");
        }
        else
        {
            Console.WriteLine($"Recorded event for checklist goal: {Name}. Gained {Points} points.");
        }
    }
}

