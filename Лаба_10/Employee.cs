using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_10
{
    class Employee : Person
    {
        int pos;

        public int Pos
        {
            get => pos;
            set
            {
                if (value == 1 || value == 2)
                {
                    switch (value)
                    {
                        case 1: Post = "Младший служащий"; break;
                        case 2: Post = "Старший служащий"; break;
                    }

                    pos = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильную должность...");
                    Post = "";
                    pos = 0;
                }
            }
        }

        public string Post
        {
            get; private set;
        }


        public Employee(string name, int age, int position) : base(name, age) { Pos = position; }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age} Должность : {Post}");
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age} Должность : {Post}");
        }
    }
}
