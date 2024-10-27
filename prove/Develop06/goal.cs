using System;

public abstract class Goal
{
    private string _goalName;
    private string _description;
    protected int _pointValue;
    protected bool _completed;

    public Goal(string goalName, string description, int pointValue)
    {
        _goalName = goalName;
        _description = description;
        _pointValue = pointValue;
        _completed = false;
    }

    public abstract string RecordEvent();

    public virtual string DisplayGoalStatus()
    {
        return _completed ? "[X]" : "[ ]";
    }

    public string GetGoalName() => _goalName;
    public string GetDescription() => _description;
    public int GetPointValue() => _pointValue;
    public bool IsCompleted() => _completed;
}
