using GeometryCalculator.Interfaces;
using GeometryCalculator.Shapes;
using Xunit;

namespace Tests;

public class CircleTests
{
    [Fact]
    public void Circle_Area_Calculation_Test()
    {
        // Arrange
        IShape circle = new Circle(12);
        const double expected = Math.PI * 12 * 12;

        // Act
        var actual = circle.CalculateArea();

        // Assert
        Assert.Equal(expected, actual, 2);
    }
    
    [Fact]
    public void Circle_Radius_Validation_Test()
    {
        // Assert
        Assert.Throws<ArgumentException>(() => new Circle(-5));
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
}