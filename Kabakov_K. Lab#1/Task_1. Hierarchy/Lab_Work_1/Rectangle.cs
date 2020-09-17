using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1Hierarchy
{
    class Rectangle : Quadrangle
    {
        public Rectangle(double sideA, double sideB) : base(sideA, sideB) { }

        public double GetArea()
        {
            return area = sideA * sideB;
        }

        public double GetPerimeter()
        {
            return perimeter = (sideA + sideB) * 2;
        }
    }
}
