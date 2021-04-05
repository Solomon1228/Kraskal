using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_10
{
   
    class ProgramNom10
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person("Имя", 50),
                new Rabotyaga("Имя Работяги", 25, 2),
                new Enginer("Лапенко", 35, 10, 50000),
                new Employee("Рабочий", 30, 2)
            };

            foreach(var person in persons)
            {
                person.PrintInfo();
                person.PrintInformation();
            }

             
        }
    }
}
