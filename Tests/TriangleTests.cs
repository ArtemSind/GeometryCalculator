using GeometryCalculator.Interfaces;
using GeometryCalculator.Shapes;
using Xunit;

namespace Tests;

public class TriangleTests
{
    [Fact]
    public void Triangle_Area_Calculation_Test()
    {
        // Arrange
        IShape triangle = new Triangle(3, 4, 5);
        const int expected = 6;

        // Act
        var actual = triangle.CalculateArea();

        // Assert
        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void Triangle_IsValidTriangle_Test()
    {
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(1, 4, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(4, 2, 6));
        Assert.Throws<ArgumentException>(() => new Triangle(7, 2, 1));
    }

    [Fact]
    public void Triangle_IsRectangle_Test()
    {
        //Arrange
        var triangle = new Triangle(3, 4, 5);
        const bool expected = true;
        
        // Act
        var actual = triangle.IsRectangle();
        
        // Assert
        Assert.Equal(expected, actual);

    }
    
    [Fact]
    public void Triangle_Side_Validation_Test()
    {
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(3, 0, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5));
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 0));
    }
}