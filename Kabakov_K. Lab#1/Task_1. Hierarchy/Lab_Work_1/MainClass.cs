using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1Hierarchy
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Square square = new Square(2);
            square.GetArea();
            square.GetPerimeter();
            square.DisplayQuadrangleInfo();

            Rectangle triangle = new Rectangle(2, 3);
            triangle.GetArea();
            triangle.GetPerimeter();
            triangle.DisplayQuadrangleInfo();
        }
    }
}
