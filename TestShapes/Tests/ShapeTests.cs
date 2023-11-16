using TestShapes.Entity;
using Xunit;

namespace TestShapes.Tests;

public class ShapeTests
{
    [Fact]
    public void TestCircleArea()
    {
        var circle = new Circle(5);
        Assert.Equal(78.539, circle.CalcArea(), 0.001);
    }

    [Fact]
    public void TestTriangleArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalcArea(), 0.001);
    }

    [Fact]
    public void TestIsRightAngled()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        var nonRightTriangle = new Triangle(3, 4, 6);

        Assert.True(rightTriangle.IsRightAngled());
        Assert.False(nonRightTriangle.IsRightAngled());
    }
}