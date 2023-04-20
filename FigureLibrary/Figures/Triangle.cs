using FigureLibrary.Exceptions;

namespace FigureLibrary.Figures;

public class Triangle : Figure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public Triangle(
        double firstSide,
        double secondSide,
        double thirdSide)
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

    public bool IsRightTriangle()
    {
        double trianglePerimeter = GetPerimeter();
        double smallestSide = Math.Min(FirstSide, Math.Min(SecondSide, ThirdSide));
        double biggestSide = Math.Max(FirstSide, Math.Max(SecondSide, ThirdSide));
        double middleSide = trianglePerimeter - smallestSide - biggestSide;

        double sumOfSquaresOfSmallerSides = smallestSide * smallestSide + middleSide * middleSide;
        double squareOfBiggestSide = biggestSide * biggestSide;
        return Math.Abs(sumOfSquaresOfSmallerSides - squareOfBiggestSide) < 1e-9;
    } 

    public override double GetPerimeter()
    {
        return FirstSide + SecondSide + ThirdSide;
    }
    
    public override double GetArea()
    {
        double halfPerimeter = GetPerimeter() / 2;
        double areaSquared = halfPerimeter *
                       (halfPerimeter - FirstSide) *
                       (halfPerimeter - SecondSide) *
                       (halfPerimeter - ThirdSide);
        return Math.Sqrt(areaSquared);
    }
}