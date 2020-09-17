using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Task_3.Classes_Hierarchy
{
    class Bachelor : Employee
    {
        protected string post;
        
        //Сеттер
        public string Post { set { post = value; } }

        //Конструкторы
        public Bachelor() { }

        public Bachelor(string name, string surname, string sex, int age, string workplace, int salary, string post)
        : base(name, surname, sex, age, workplace, salary)
        {
            Post = post;
        }

    }
}
