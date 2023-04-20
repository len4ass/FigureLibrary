using FigureLibrary.Exceptions;
using FigureLibrary.Figures;

namespace FigureLibrary.Tests.Figures;

public class CircleTest
{
    [Fact(DisplayName = "Circle constructor must throw InvalidFigureException on radius less or equal to zero")]
    public void Constructor_Throws_OnRadiusLessOrEqualToZero()
    {
        Assert.Throws<InvalidFigureException>(() => new Circle(-1));
    }

    [Fact(DisplayName = "Circle constructor must not throw on radius greater than zero")]
    public void Constructor_DoesNotThrow_OnRadiusGreaterThanZero()
    {
        var radius = 2;
        var circle = new Circle(radius);
    }

    [Fact(DisplayName = "Circle radius getter must return radius that was passed in constructor")]
    public void RadiusGetter_ReturnsValuePassedInConstructor()
    {
        var radius = 2;
        var circle = new Circle(radius);
        
        Assert.Equal(radius, circle.Radius, 9);
    }

    [Fact(DisplayName = "Circle GetPerimeter must return perimeter calculated using this formula: 2 * PI * Radius")]
    public void GetPerimeter_ReturnsPerimeter_CalculatedUsingCirclePerimeter_ForCircleWithGivenRadius()
    {
        var radius = 2;
        var circle = new Circle(radius);

        var expectedPerimeter = 2 * Math.PI * radius;
        var actualPerimeter = circle.GetPerimeter();
        Assert.Equal(expectedPerimeter, actualPerimeter, 9);
    }
    
    [Fact(DisplayName = "Circle GetArea must return area calculated using this formula: PI * Radius * Radius")]
    public void GetArea_ReturnsArea_CalculatedUsingCircleAreaFormula_ForCircleWithGivenRadius()
    {
        var radius = 2;
        var circle = new Circle(radius);

        var expectedArea = Math.PI * radius * radius;
        var actualArea = circle.GetArea();
        Assert.Equal(expectedArea, actualArea, 9);
    }
}