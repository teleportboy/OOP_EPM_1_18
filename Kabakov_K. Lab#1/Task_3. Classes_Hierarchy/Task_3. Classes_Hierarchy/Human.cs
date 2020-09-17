using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Classes_Hierarchy
{
    class Human
    {
        protected string name;
        protected string surname;
        protected string sex;
        protected int age;

        //Сеттеры
        public string Name { set { name = value; } }
        public string Surname { set { surname = value; } }
        public string Sex { set { sex = value; } }
        public int Age { set { age = value; } }

        public Human() { }

        public Human(string name, string surname, string sex, int age)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
        }
    }
}
