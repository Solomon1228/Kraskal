using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_10
{
    class Person : IExecutable
    {
        int age;
        public string Name { get; set; }
        public int Age
        {
            get => age;
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                    Console.WriteLine("Вы ввели отрицательное кол-во лет.");
                }
            }
        }
        public Person(string name , int years){Name = name; Age = years; }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age}");
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age}");
        }
    }
    
}
