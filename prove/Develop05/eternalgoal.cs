using System;
class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName} (Eternal)";
    }
}