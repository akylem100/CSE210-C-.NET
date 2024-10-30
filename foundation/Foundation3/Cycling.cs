public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, string name, int duration, double speed) : base(date, duration, name)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _duration) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
