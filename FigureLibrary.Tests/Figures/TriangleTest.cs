using FigureLibrary.Exceptions;
using FigureLibrary.Figures;

namespace FigureLibrary.Tests.Figures;

public class TriangleTest
{
    [Fact]
    public void Constructor_Throws_OnSidesLessOrEqualToZero()
    {
        Assert.Throws<InvalidFigureException>(
            () => new Triangle(
                1, 
                0, 
                -1));
    }

    [Fact]
    public void Constructor_Throws_OnSidesThatDoNotFormValidTriangle()
    {
        Assert.Throws<InvalidFigureException>(
            () => new Triangle(
                1, 
                5, 
                12));
    }

    [Fact]
    public void Constructor_DoesNotThrow_OnSidesThatFormValidTriangle()
    {
        double firstSide = 7;
        double secondSide = 10;
        double thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);
    }

    [Fact]
    public void SideGetters_ReturnValues_PassedIntoConstructor()
    {
        double firstSide = 7;
        double secondSide = 10;
        double thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);
        
        Assert.Equal(firstSide, triangle.FirstSide, 9);
        Assert.Equal(secondSide, triangle.SecondSide, 9);
        Assert.Equal(thirdSide, triangle.ThirdSide, 9);
    }

    [Fact]
    public void GetPerimeter_ReturnsCorrectPerimeter_ForValidTriangle()
    {
        double firstSide = 5;
        double secondSide = 5;
        double thirdSide = 8;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);

        var expectedPerimeter = firstSide + secondSide + thirdSide;
        var actualPerimeter = triangle.GetPerimeter();
        Assert.Equal(expectedPerimeter, actualPerimeter, 9);
    }

    [Fact]
    public void GetArea_ReturnsCorrectArea_ForValidTriangle()
    {
        double firstSide = 5;
        double secondSide = 5;
        double thirdSide = 8;
        
        var triangle = new Triangle(
            firstSide, 
            secondSide, 
            thirdSide);

        double expectedArea = 12;
        double actualArea = triangle.GetArea();
        Assert.Equal(expectedArea, actualArea, 9);
    }

    [Fact]
    public void IsRightTriangle_ReturnsTrue_ForValidRightTriangle()
    {
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);

        var isRightTriangle = triangle.IsRightTriangle();
        Assert.True(isRightTriangle);
    }

    [Fact]
    public void IsRightTriangle_ReturnsFalse_ForValidNonRightTriangle()
    {
        double firstSide = 7;
        double secondSide = 10;
        double thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);

        var isRightTriangle = triangle.IsRightTriangle();
        Assert.False(isRightTriangle);
    }
}