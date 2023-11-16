using TestShapes.Abstractions;
using TestShapes.Entity;

namespace TestShapes.Factory;

public class ShapeFactory : IShapeFactory
{
    private readonly Dictionary<int, Func<double[], IShape>> _shapeCreationStrategies;

    public ShapeFactory()
    {
        _shapeCreationStrategies = new Dictionary<int, Func<double[], IShape>>
        {
            [1] = parameters => new Circle(parameters[0]),
            [3] = parameters => new Triangle(parameters[0], parameters[1], parameters[2])
        };
    }

    public IShape CreateShape(params double[] parameters)
    {
        var numberOfParameters = parameters.Length;
        if (_shapeCreationStrategies.TryGetValue(numberOfParameters, out var creationStrategy))
        {
            return creationStrategy(parameters);
        }

        throw new ArgumentException($"Ошибка количества аргументов: {numberOfParameters}");
    }
    
    public void AddShape(int countParameters, Func<double[], IShape> shapeClass)
    {
        if (_shapeCreationStrategies.TryAdd(countParameters, shapeClass))
        {
            return;
        }

        throw new ArgumentException($"Элемент с количеством парметров: {countParameters}, уже есть в словаре");
    }
}