using FigureLibrary.Exceptions;
using FigureLibrary.Figures;

namespace FigureLibrary.Tests.Figures;

public class TriangleTest
{
    [Fact(DisplayName = "Triangle constructor must throw InvalidFigureException on negative or zero sides")]
    public void Constructor_Throws_OnSidesLessOrEqualToZero()
    {
        Assert.Throws<InvalidFigureException>(
            () => new Triangle(
                1, 
                0, 
                -1));
    }

    [Fact(DisplayName = "Triangle constructor must throw InvalidFigureException if triangle violates triangle inequality theorem")]
    public void Constructor_Throws_OnSidesThatViolateTriangleInequalityTheorem()
    {
        Assert.Throws<InvalidFigureException>(
            () => new Triangle(
                1, 
                5, 
                12));
    }

    [Fact(DisplayName = "Triangle constructor must not throw exceptions if triangle satisfies triangle inequality theorem")]
    public void Constructor_DoesNotThrow_OnSidesThatSatisfyTriangleInequalityTheorem()
    {
        double firstSide = 7;
        double secondSide = 10;
        double thirdSide = 7;

        var triangle = new Triangle(
            firstSide,
            secondSide,
            thirdSide);
    }

    [Fact(DisplayName = "Triangle side getters must return the same values that were passed in constructor")]
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

    [Fact(DisplayName = "Triangle GetPerimeter must return perimeter calculated as sum of sides")]
    public void GetPerimeter_ReturnsPerimeter_CalculatedAsSumOfSides()
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

    [Fact(DisplayName = "Triangle GetArea must return area calculated using Heron's formula")]
    public void GetArea_ReturnsArea_CalculatedUsingHeronFormula()
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

    [Fact(DisplayName = "IsRightTriangle must return true for triangle that satisfies Pythagoras theorem")]
    public void IsRightTriangle_ReturnsTrue_ForTriangleThatSatisfiesPythagorasTheorem()
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

    [Fact(DisplayName = "IsRightTriangle must return false for triangle that does not satisfy Pythagoras theorem")]
    public void IsRightTriangle_ReturnsFalse_ForTriangleThatDoesNotSatisfyPythagorasTheorem()
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