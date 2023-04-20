using FigureLibrary.Exceptions;

namespace FigureLibrary.Figures;

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new InvalidFigureException("Circle radius must be greater than 0.");
        }
        
        Radius = radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}