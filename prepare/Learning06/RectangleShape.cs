public class RectangularShape : GeometricShape
{
    private double _height;
    private double _breadth;

    public RectangularShape(string shade, double height, double breadth) : base(shade)
    {
        _height = height;
        _breadth = breadth;
    }

    public override double CalculateArea()
    {
        return _height * _breadth;
    }
}
