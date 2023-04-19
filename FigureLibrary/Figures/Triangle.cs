using FigureLibrary.Exceptions;

namespace FigureLibrary.Figures;

public class Triangle : Figure
{
    public decimal FirstSide { get; }
    public decimal SecondSide { get; }
    public decimal ThirdSide { get; }

    public Triangle(
        decimal firstSide,
        decimal secondSide,
        decimal thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new InvalidFigureException("Triangle sides must be greater than 0.");
        }

        if (firstSide + secondSide <= thirdSide || 
            firstSide + thirdSide <= secondSide || 
            secondSide + thirdSide <= firstSide)
        {
            throw new InvalidFigureException("Given sides do not form a valid triangle.");
        }

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public decimal GetPerimeter()
    {
        return FirstSide + SecondSide + ThirdSide;
    }
     
    public bool IsRightTriangle()
    {
        decimal trianglePerimeter = FirstSide + SecondSide + ThirdSide;
        decimal smallestSide = Math.Min(FirstSide, Math.Min(SecondSide, ThirdSide));
        decimal biggestSide = Math.Max(FirstSide, Math.Max(SecondSide, ThirdSide));
        decimal middleSide = trianglePerimeter - smallestSide - biggestSide;

        decimal sumOfSquaresOfSmallerSides = smallestSide * smallestSide + middleSide * middleSide;
        decimal squareOfBiggestSide = biggestSide * biggestSide;
        if (sumOfSquaresOfSmallerSides == squareOfBiggestSide)
        {
            return true;
        }

        return false;
    } 

    public override double GetFigureArea()
    {
        decimal halfPerimeter = GetPerimeter() / 2;
        decimal areaSquared = halfPerimeter *
                       (halfPerimeter - FirstSide) *
                       (halfPerimeter - SecondSide) *
                       (halfPerimeter - ThirdSide);
        return Math.Sqrt((double)areaSquared);
    }
}