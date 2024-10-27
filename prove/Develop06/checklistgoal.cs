using System;

public class ChecklistGoal : Goal
{
    private int _eventCount;
    private int _eventCountGoal;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int pointValue, int eventCount, int bonusPoints, int eventCountGoal)
        : base(name, description, pointValue)
    {
        _eventCount = eventCount;
        _eventCountGoal = eventCountGoal;
        _bonusPoints = bonusPoints;
    }

    public int eventCount => _eventCount;
    public int eventCountGoal => _eventCountGoal;
    public int bonusPoints => _bonusPoints;

    public override string RecordEvent()
    {
        _eventCount += 1;
        if (_eventCount >= _eventCountGoal)
        {
            _completed = true;
            _pointValue += _bonusPoints;
            return $"You have reached your true goal and earned an extra {_bonusPoints} points!"; 
        }
        return $"Congratulations! You have earned {_pointValue} points.";
    }

    public override string DisplayGoalStatus()
    {
        return $"{base.DisplayGoalStatus()} {_eventCount}/{_eventCountGoal}";
    }
}
