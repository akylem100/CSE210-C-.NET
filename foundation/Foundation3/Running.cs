public class Running : Activity
{
    private double _distance;

    public Running(string date, string name, int duration, double distance) : base(date, duration, name)
    {
        _distance = distance;
        name = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }
}
