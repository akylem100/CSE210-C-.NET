using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction() //Constructor, no parameters, initializes numbers to 1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) //Constructor, one parameter
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //Constructor, two parameters
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}