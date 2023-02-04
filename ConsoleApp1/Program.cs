using GeometryCalculator.Interfaces;
using GeometryCalculator.Shapes;

var shapes = new IShape[] {new Circle(3), new Circle(5), new Triangle(3, 4, 5)};

foreach (var shape in shapes)
{
    Console.WriteLine(shape.CalculateArea());
}
