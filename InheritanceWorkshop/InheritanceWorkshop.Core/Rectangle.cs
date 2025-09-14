using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Rectangle : Square
    {
        private double _b;

        public Rectangle(string v, double a, double b) : base(v, a)
        {
            B = b;
            Name = "Rectangle";
        }

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public override double GetArea() => A * B;

        public override double GetPerimeter() => 2 * (A + B);

        private double ValidateB(double b)
        {
            if (b < 0)
            {
                throw new Exception($"Rectangle Error, the length {b}, cannot negative.");
            }
            return b;
        }
    }
}