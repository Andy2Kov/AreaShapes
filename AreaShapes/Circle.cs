using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapes
{
    class Circle : Shapes 
    {
        double rad;

        public Circle(double r)
        {
            ShapeName = "Круг";

            this.rad = r; 
        }

        public override double Area()
        {
            double p = Math.PI * Math.Pow(rad, 2);
            return Math.Round(p, 10);
        }

    }
}
