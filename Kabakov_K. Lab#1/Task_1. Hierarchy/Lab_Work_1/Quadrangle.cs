using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1Hierarchy
{
    class Quadrangle
    {
        //Поля содержащие основные данные объекта.
        protected double sideA, sideB;
        protected double perimeter, area;

        public double SideA { set { sideA = value; } }
        public double SideB { set { sideB = value; } }
        public double Perimeter { set { perimeter = value; } }
        public double Area { set { area = value; } }

        public Quadrangle() { }

        //Конструктор для квадрата.
        public Quadrangle(double sideA)
        {
            SideA = sideA;
        }

        //Конструктор для прямоугольника.
        public Quadrangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public void DisplayQuadrangleInfo()
        {
            Console.WriteLine($"Figure perimeter is: {perimeter}.");
            Console.WriteLine($"Figure area is: {area}.");
        }

    }
}
