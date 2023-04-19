namespace FigureLibrary.Exceptions;

public class InvalidFigureException : ArgumentException
{
    public InvalidFigureException(string message)
        : base(message)
    {
    }
}