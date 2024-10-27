using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue) 
        : base(name, description, pointValue) { }

    public override string RecordEvent()
    {
        _completed = true;
        return $"Congratulations! You have earned {_pointValue} points.";
    }
}
