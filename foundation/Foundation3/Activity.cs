public class Activity
{
    private string _date;
    protected int _duration;
    private string _name;

    public Activity(string date, int duration, string name)
    {
        _date = date;
        _duration = duration;
        _name = name;
    }

    public virtual double GetDistance() 
    {
        return 0;
    }
    public virtual double GetSpeed() 
    {
        return 0;
    }
    public virtual double GetPace() 
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_duration} min) - Distance {Math.Round(GetDistance(), 1)} miles, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile";
    }
}
