using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public Rhombus(string v, int l, double a, double b) : base(v, a)
        {
            D1 = a;
            D2 = b;
            Name = "Rhombus";
        }

        public double D1 
        { 
            get => _d1; 
            set => _d1 = ValidateD1(value); 
        }
        public double D2 
        { 
            get => _d2; 
            set => _d2 = ValidateD2(value); 
        }
        public override double GetArea() => (D1 * D2) / 2;

        public override double GetPerimeter() => Math.Sqrt(Math.Pow(D1 / 2, 2) + Math.Pow(D2 / 2, 2)) * 4;

        private double ValidateD1(double d1)
        {
            if (d1 < 0)
            {
                throw new Exception($"Rhombus Error, the diagonal {d1}, cannot negative.");
            }
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 < 0)
            {
                throw new Exception($"Rhombus Error, the diagonal {d2}, cannot negative.");
            }
            return d2;
        }
    }
}
