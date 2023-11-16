using TestShapes.Abstractions;

namespace TestShapes.Entity;

public class Triangle: IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public double CalcArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRightAngled()
    {
        var a2 = SideA * SideA;
        var b2 = SideB * SideB;
        var c2 = SideC * SideC;
        
        return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
    }
}