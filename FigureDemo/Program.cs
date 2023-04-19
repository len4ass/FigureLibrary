using FigureLibrary.Figures;

// Полиморфно работаем с фигурами
Figure circleAsFigure = new Circle(2);
Console.WriteLine($"Circle area (using base class reference): {circleAsFigure.GetFigureArea()}");

Figure triangleAsFigure = new Triangle(5, 5, 8);
Console.WriteLine($"Triangle area (using base class reference): {triangleAsFigure.GetFigureArea()}");

// Можем вернуться к конкретным реализациям
var circle = (Circle) circleAsFigure;
Console.WriteLine($"Circle area (using implementation class reference): {circle.GetFigureArea()}");
Console.WriteLine($"Circle radius: {circle.Radius}");

var triangle = (Triangle) triangleAsFigure;
Console.WriteLine($"Triangle area (using implementation class reference): {triangle.GetFigureArea()}");
Console.WriteLine($"Triangle perimeter: {triangle.GetPerimeter()}");
Console.WriteLine($"Triangle is right: {triangle.IsRightTriangle()}");
Console.WriteLine($"Triangle sides: {triangle.FirstSide}, {triangle.SecondSide}, {triangle.ThirdSide}");