using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R 
        { 
            get => _r; 
            set => _r = ValidateR(value); 
        }

        public Circle(string v, double r)
        {
            R = r;
            Name = "Circle";
        }

        public override double GetArea() => Math.PI * Math.Pow(R, 2);
        
        public override double GetPerimeter() => 2 * Math.PI * R;
        
        private double ValidateR(double r)
        {
            if (r < 0)
            {
                throw new Exception($"Circle Error, the radius {r} cannot negative.");
            }
            return r;
        }
    }
}
