using TestShapes.Abstractions;

namespace TestShapes.Entity;

public class Circle: IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalcArea()
    {
        return Math.PI * Radius * Radius;
    }
}