using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_10
{
    class Enginer : Rabotyaga
    {
        int zp;
        public int Zarplata
        {
            get => zp;
            set
            {
                if (value >= 0)
                {
                    zp = value;
                }
                else
                {
                    zp = 0;
                    Console.WriteLine("Вы ввели отрицательное кол-во зарплаты.");
                }
            }
        }

        public Enginer(string name, int age, int num, int salary) : base(name, age, num) { Zarplata = salary; }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age} Номер цеха : {Workshop}  Зарплата в рублях : {Zarplata}");
        }
        public override void PrintInformation()
        {
            Console.WriteLine($"Имя : {Name} Возраст : {Age} Номер цеха : {Workshop}  Зарплата в рублях : {Zarplata}");
        }
    }
}