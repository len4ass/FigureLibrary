using FigureLibrary.Exceptions;
using FigureLibrary.Figures;

namespace FigureLibrary.Tests.Figures;

public class CircleTest
{
    [Fact]
    public void Constructor_Throws_OnRadiusLessOrEqualToZero()
    {
        Assert.Throws<InvalidFigureException>(() => new Circle(-1));
    }

    [Fact]
    public void Constructor_DoesNotThrow_OnRadiusGreaterThanZero()
    {
        var radius = 2;
        var circle = new Circle(radius);
    }

    [Fact]
    public void RadiusGetter_ReturnsValuePassedInConstructor()
    {
        var radius = 2;
        var circle = new Circle(radius);
        
        Assert.Equal(radius, circle.Radius, 9);
    }

    [Fact]
    public void GetPerimeter_ReturnsCorrectPerimeter_ForCircleWithGivenRadius()
    {
        var radius = 2;
        var circle = new Circle(radius);

        var expectedPerimeter = 2 * Math.PI * radius;
        var actualPerimeter = circle.GetPerimeter();
        Assert.Equal(expectedPerimeter, actualPerimeter, 9);
    }
    
    [Fact]
    public void GetArea_ReturnsCorrectArea_ForCircleWithGivenRadius()
    {
        var radius = 2;
        var circle = new Circle(radius);

        var expectedArea = Math.PI * radius * radius;
        var actualArea = circle.GetArea();
        Assert.Equal(expectedArea, actualArea, 9);
    }
}