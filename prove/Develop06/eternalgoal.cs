using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointValue)
        : base(name, description, pointValue) { }

    public override string RecordEvent()
    {
        return $"Congratulations! You have earned {_pointValue} points.";
    }
}
