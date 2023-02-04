using System;
using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Shapes;

public class Triangle : IShape
{
    public Triangle(double side1, double side2, double side3)
    {
        if (!IsValidTriangle(side1,side2,side3))
            throw new ArgumentException("Triangle with such sides does not exist");
        
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            throw new ArgumentException("Side length should be greater than 0");
        
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }

    public double CalculateArea()
    {
        var halfP = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(halfP * (halfP - Side1) * (halfP - Side2) * (halfP - Side3));
    }

    public bool IsRectangle() =>
        Math.Abs(Math.Pow(Side1, 2) + Math.Pow(Side2, 2) - Math.Pow(Side3, 2)) < 0.001
        || Math.Abs(Math.Pow(Side1, 2) + Math.Pow(Side3, 2) - Math.Pow(Side2, 2)) < 0.001
        || Math.Abs(Math.Pow(Side2, 2) + Math.Pow(Side3, 2) - Math.Pow(Side1, 2)) < 0.001;

    private static bool IsValidTriangle(double side1, double side2, double side3) =>
        side1 + side2 > side3 &&
        side1 + side3 > side2 &&
        side2 + side3 > side1;
}