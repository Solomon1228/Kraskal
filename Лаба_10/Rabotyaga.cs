using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_10
{
    class Rabotyaga : Person
    {
        int Num;
        public int Workshop
        {
            get => Num;
            set
            {
                if (value >= 0)
                {
                    Num = value;
                }
                else
                {
                    Num = 0;
                    Console.WriteLine("Вы ввели отрицательный номер цеха.");
                }
            }
        }

        public Rabotyaga(string name, int age, int num) : base(name, age) { Workshop = num; }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age} Номер цеха : {Workshop}");
        }
        public override void PrintInformation()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age} Номер цеха : {Workshop}");
        }
    }
  
}
