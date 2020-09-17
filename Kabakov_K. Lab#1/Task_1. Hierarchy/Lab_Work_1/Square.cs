using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1Hierarchy
{
    class Square : Quadrangle
    {
        public Square(double sideA) : base(sideA) { }

        public double GetArea()
        {
            return area = Math.Pow(sideA, 2);
        }

        public double GetPerimeter()
        {
            return perimeter = sideA * 4.0;
        }

    }
}
