using System;
class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
       //eternal goals are never complete at all
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName} (Eternal)";
    }
}