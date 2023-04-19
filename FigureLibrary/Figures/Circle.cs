using FigureLibrary.Exceptions;

namespace FigureLibrary.Figures;

public class Circle : Figure
{
    public decimal Radius { get; }

    public Circle(decimal radius)
    {
        if (radius <= 0)
        {
            throw new InvalidFigureException("Circle radius must be greater than 0.");
        }
        
        Radius = radius;
    }
    
    public override double GetFigureArea()
    {
        double radius = (double) Radius;
        return Math.PI * radius * radius;
    }
}