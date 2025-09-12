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

        public Kite(string v, int l, double a, double b, int v1) : base(v, l, a, b)
        {
            B = b;
            Name = "Kite";
        }

        public double B 
        { 
            get => _b; 
            set => _b = value; 
        }

        public override double GetArea() => (A * B) / 2;

        public override double GetPerimeter() => 2 * (Math.Sqrt(Math.Pow(A / 2, 2) + Math.Pow(B / 2, 2)));
    }
}
