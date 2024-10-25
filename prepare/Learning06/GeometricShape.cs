public abstract class GeometricShape
{
    private string _shade;

    public GeometricShape(string shade)
    {
        _shade = shade;
    }

    public string GetShade()
    {
        return _shade;
    }

    public void SetShade(string shade)
    {
        _shade = shade;
    }

    public abstract double CalculateArea();
}
