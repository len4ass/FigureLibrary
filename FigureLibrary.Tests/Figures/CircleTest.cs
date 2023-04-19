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
        
        Assert.Equal(radius, circle.Radius);
    }

    [Fact]
    public void GetArea_ReturnsCorrectArea_ForCircleWithGivenRadius()
    {
        var radius = 1;
        var circle = new Circle(radius);

        var expected = Math.PI;
        var actual = circle.GetFigureArea();
        Assert.Equal(expected, actual);
    }
}