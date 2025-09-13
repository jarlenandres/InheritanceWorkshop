using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public Parallelogram(string v, double a, double b, double h) : base(v, a, b)
        {
            H = h;
            Name = "Parallelogram";
            B = b;
            A = a;
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public override double GetArea() => B * H;

        public override double GetPerimeter() => 2 * (A + B);

        private double ValidateH(double h)
        {
            if (h < 0)
            {
                throw new Exception($"Parallelogram Error, the height {h}, cannot negative.");
            }
            return h;
        }
    }
}