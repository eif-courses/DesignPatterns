namespace DesignPatterns.Factory;

public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

public class Triangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Triangle");
    }
}


public class ShapeFactory
{
    public IShape CreateShape(ShapeType shapeType)
    {
        switch (shapeType)
        {
            case ShapeType.Circle:
                return new Circle();
            case ShapeType.Rectangle:
                return new Rectangle();
            case ShapeType.Triangle:
                return new Triangle();
            default:
                throw new ArgumentException("Invalid shape type");
        }
    }
}

public enum ShapeType
{
    Circle,
    Rectangle,
    Triangle
}