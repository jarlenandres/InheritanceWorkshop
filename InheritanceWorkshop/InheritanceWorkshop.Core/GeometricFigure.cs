namespace InheritanceWorkshop.Core
{
    public abstract class GeometricFigure
    {
        // Properties public
        public string Name { get; set; } = null!;

        // Abstract method
        public abstract double GetArea();

        public abstract double GetPerimeter();

        // Override ToString method
        public override string ToString()
        {
            return $"{Name}          => Area.....: {GetArea(),20:N5}    Perimeter: {GetPerimeter(),20:N5}";
        }
    }
}
