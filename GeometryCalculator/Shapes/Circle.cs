using System;
using GeometryCalculator.Interfaces;

namespace GeometryCalculator.Shapes;

public class Circle : IShape
{
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius be greater than 0");

        Radius = radius;
    }

    private double Radius { get; }

    public double CalculateArea() => Math.PI * Radius * Radius;
}