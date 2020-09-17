using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Classes_Hierarchy
{
    class Employee : Human
    {
        protected string workplace;
        protected int salary;

        //Сеттеры
        public string Workplace { set { workplace = value; } }
        public int Salary { set { salary = value; } }

        //Конструкторы
        public Employee() { }

        public Employee(string name, string surname, string sex, int age, string workplace, int salary) 
        : base(name, surname, sex, age)
        {
            Workplace = workplace;
            Salary = salary;
        }
    }
}
