using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<GeometricShape> shapeCollection = new List<GeometricShape>();

        SquareShape square = new SquareShape("Red", 3);
        shapeCollection.Add(square);

        RectangularShape rectangle = new RectangularShape("Blue", 4, 5);
        shapeCollection.Add(rectangle);

        CircleShape circle = new CircleShape("Green", 6);
        shapeCollection.Add(circle);

        foreach (GeometricShape shape in shapeCollection)
        {
            string shade = shape.GetShade();
            double area = shape.CalculateArea();

            Console.WriteLine($"The {shade} shape has an area of {area}.");
        }
        
    }
}
