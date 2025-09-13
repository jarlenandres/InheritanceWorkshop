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
            return $"{Name,13}  =>  Area.....: {GetArea(),16:N5}    Perimeter: {GetPerimeter(),15:N5}";
        }
    }
}