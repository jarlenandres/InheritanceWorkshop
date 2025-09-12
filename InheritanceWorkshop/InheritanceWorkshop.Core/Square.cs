using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Square : GeometricFigure
    {
        // Private attributes
        private double _a;

        // Constructor method
        public Square(string v, double a)
        {
            A = a;
            Name = "Square";
        }

        // Public properties
        public double A 
        { 
            get => _a; 
            set => _a = ValidateA(value); 
        }

        // Methods
        public override double GetArea() => A;
        
        public override double GetPerimeter() => Math.Sqrt(A) * 4;

        private double ValidateA(double a)
        {
            if (a < 0)
            {
                throw new Exception($"Square Error, the length {a}, cannot negative.");
            }
            return a * a;
        }
    }
}
