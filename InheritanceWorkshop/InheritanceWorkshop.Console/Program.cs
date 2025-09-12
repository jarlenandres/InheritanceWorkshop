using InheritanceWorkshop.Core;
try{
    var circle = new Circle(nameof(Circle), 5);
    var square = new Square(nameof(Square), 10);
    var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
    var kite = new Kite(nameof(Kite), 7, 6, 5, 8);

    var figures = new List<GeometricFigure> { circle, square, rhombus, kite };
    foreach (var figure in figures)
    {
        Console.WriteLine(figure);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

