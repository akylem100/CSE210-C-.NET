public class SquareShape : GeometricShape
{
    private double _edge;

    public SquareShape(string shade, double edge) : base(shade)
    {
        _edge = edge;
    }

    public override double CalculateArea()
    {
        return _edge * _edge;
    }
}
