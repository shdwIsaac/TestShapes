namespace TestShapes.Abstractions;

public interface IShapeFactory
{
    IShape CreateShape(params double[] parameters);
}
