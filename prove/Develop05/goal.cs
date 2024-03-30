using System;

class Goal
{
    public string ShortName { get; private set; }
    public string Description { get; private set; }
    public int Points { get; private set; }
    public bool IsComplete { get; private set; }

    public Goal(string shortName, string description, int points)
    {
        ShortName = shortName;
        Description = description;
        Points = points;
        IsComplete = false;
    }
    public virtual void RecordEvent()
    {
        IsComplete = true;
    }
    public virtual string GetStringRepresentation()
    {
        return $"{ShortName} ({(IsComplete ? "Completed" : "Not Completed")})";
    }
}