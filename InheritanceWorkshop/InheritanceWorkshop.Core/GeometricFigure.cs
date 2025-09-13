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
            return $"{Name}\t\t => Area.....: {GetArea(),15:N5}\t Perimeter: {GetPerimeter(),15:N5}";
        }
    }
}