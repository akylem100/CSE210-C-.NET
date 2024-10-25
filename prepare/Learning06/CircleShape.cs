public class CircleShape : GeometricShape
{
    private double _diameter;

    public CircleShape(string shade, double diameter) : base(shade)
    {
        _diameter = diameter;
    }

    public override double CalculateArea()
{
    return Math.Round(_diameter * _diameter * Math.PI, 2);
}
}
