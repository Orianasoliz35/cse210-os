using System;

class GoalManager
{
    private List<Goal> _goals;
    private int _userScore;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _userScore = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void UpdateGoalProgress(string goalName, int value)
    {
        Goal goal = _goals.Find(g => g.ShortName == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            if (goal.IsComplete)
            {
                _userScore += goal.Points;
                if (goal is ChecklistGoal checklistGoal)
                {
                    _userScore += checklistGoal.Bonus;
                }
            }
        }
    }
    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"\nYour Total Score: {_userScore}");
    }
}