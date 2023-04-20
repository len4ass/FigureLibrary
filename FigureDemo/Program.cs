using FigureLibrary.Figures;

// Полиморфно работаем с фигурами
Figure circleAsFigure = new Circle(3);
Console.WriteLine($"Circle area (using base class reference): {circleAsFigure.GetArea()}");
Console.WriteLine($"Circle perimeter (using base class reference): {circleAsFigure.GetPerimeter()}");

Figure triangleAsFigure = new Triangle(5, 5, 8);
Console.WriteLine($"Triangle area (using base class reference): {triangleAsFigure.GetArea()}");
Console.WriteLine($"Triangle perimeter (using base class reference): {triangleAsFigure.GetPerimeter()}");

// Можем вернуться к конкретным реализациям
var circle = (Circle) circleAsFigure;
Console.WriteLine($"Circle area (using implementation class reference): {circle.GetArea()}");
Console.WriteLine($"Circle perimeter (using implementation class reference): {circle.GetPerimeter()}");
Console.WriteLine($"Circle radius: {circle.Radius}");

var triangle = (Triangle) triangleAsFigure;
Console.WriteLine($"Triangle area (using implementation class reference): {triangle.GetArea()}");
Console.WriteLine($"Triangle perimeter (using implementation class reference): {triangle.GetPerimeter()}");
Console.WriteLine($"Triangle is right: {triangle.IsRightTriangle()}");
Console.WriteLine($"Triangle sides: {triangle.FirstSide}, {triangle.SecondSide}, {triangle.ThirdSide}");