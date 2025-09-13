using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Kite : Rhombus
    {
        private double _b;

        public Kite(string v, int l, double d1, double d2, double b) : base(v, l, d1, d2)
        {
            B = b;
            Name = "Kite";
            A = l;
            D1 = d1;
            D2 = d2;
        }

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public override double GetArea() => (D1 * D2) / 2;

        public override double GetPerimeter() => 2 * (A + B);

        private double ValidateB(double b)
        {
            if (b < 0)
            {
                throw new Exception($"Kite Error, the length {b}, cannot negative.");
            }
            return b;
        }
    }
}