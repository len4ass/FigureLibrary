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
        decimal firstSide = 7;
        decimal secondSide = 10;
        decimal thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);
    }

    [Fact]
    public void SideGetters_ReturnValues_PassedIntoConstructor()
    {
        decimal firstSide = 7;
        decimal secondSide = 10;
        decimal thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);
        
        Assert.Equal(firstSide, triangle.FirstSide);
        Assert.Equal(secondSide, triangle.SecondSide);
        Assert.Equal(thirdSide, triangle.ThirdSide);
    }

    [Fact]
    public void GetPerimeter_ReturnsCorrectPerimeter_ForValidTriangle()
    {
        decimal firstSide = 5;
        decimal secondSide = 5;
        decimal thirdSide = 8;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);

        decimal expectedPerimeter = firstSide + secondSide + thirdSide;
        decimal actualPerimeter = triangle.GetPerimeter();
        Assert.Equal(expectedPerimeter, actualPerimeter);
    }

    [Fact]
    public void GetArea_ReturnsCorrectArea_ForValidTriangle()
    {
        decimal firstSide = 5;
        decimal secondSide = 5;
        decimal thirdSide = 8;
        
        var triangle = new Triangle(
            firstSide, 
            secondSide, 
            thirdSide);

        double expectedArea = 12;
        double actualArea = triangle.GetFigureArea();
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void IsRightTriangle_ReturnsTrue_ForValidRightTriangle()
    {
        decimal firstSide = 3;
        decimal secondSide = 4;
        decimal thirdSide = 5;

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
        decimal firstSide = 7;
        decimal secondSide = 10;
        decimal thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);

        var isRightTriangle = triangle.IsRightTriangle();
        Assert.False(isRightTriangle);
    }
}