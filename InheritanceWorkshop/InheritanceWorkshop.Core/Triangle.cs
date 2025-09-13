using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWorkshop.Core
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public Triangle(string v, double a, double b, double c, double h) : base(v, a, b)
        {
            C = c;
            H = h;
            Name = "Triangle";
            B = b;
            A = a;
        }

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public override double GetArea() => (B * H) / 2;

        public override double GetPerimeter() => A + B + C;

        private double ValidateC(double c)
        {
            if (c < 0)
            {
                throw new Exception($"Triangle Error, the side {c}, cannot negative.");
            }
            return c;
        }

        private double ValidateH(double h)
        {
            if (h < 0)
            {
                throw new Exception($"Triangle Error, the height {h}, cannot negative.");
            }
            return h;
        }
    }
}