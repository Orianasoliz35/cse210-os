//Eternal Quest Program File: Week #5
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var manager = new GoalManager();

        var goal1 = new SimpleGoal("Run a Marathon", "Run a full marathon", 1000);
        var goal2 = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
        var goal3 = new ChecklistGoal("Temple Visits", "Attend the temple", 50, 10, 500);

        manager.AddGoal(goal1);
        manager.AddGoal(goal2);
        manager.AddGoal(goal3);

        manager.UpdateGoalProgress("Run a Marathon", 1);
        manager.UpdateGoalProgress("Read Scriptures", 1);
        manager.UpdateGoalProgress("Temple Visits", 1);
        manager.UpdateGoalProgress("Temple Visits", 1);
        manager.UpdateGoalProgress("Temple Visits", 1);

        manager.DisplayGoals();
        manager.DisplayScore();
    }
}