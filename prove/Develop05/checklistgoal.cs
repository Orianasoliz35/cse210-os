using System;
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{ShortName} ({_amountCompleted}/{_target} times)";
    }
    public new bool IsComplete
    {
        get { return _isComplete; }
    }
    public int Bonus { get; internal set; }
}
