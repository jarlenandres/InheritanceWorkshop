using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Trapeze : Triangle
    {
        private double _d;

        public Trapeze(string v, double a, double b, double c, double d, double h) : base(v, a, b, c, h)
        {
            D = d;
            Name = "Trapeze";
        }

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public override double GetArea() => ((D + B) * H) / 2;

        public override double GetPerimeter() => A + B + C + D;

        private double ValidateD(double d)
        {
            if (d < 0)
            {
                throw new Exception($"Trapeze Error, the side {d}, cannot negative.");
            }
            return d;
        }
    }
}