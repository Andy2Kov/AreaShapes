using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapes
{
    class Triangle : Shapes 
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (Math.Round(Math.Pow(c, 2), 10) == Math.Round(Math.Pow(a, 2) + Math.Pow(b, 2), 10))
            {
                ShapeName = "Прямоугольный треугольник";
            }
            else
            {
                ShapeName = "Треугольник";
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 10);
        }
    }
}
