using System;
using Solomon;
namespace Лаба_9
{
   

    class ProgramNom9
    {

        static void PrintMenu()
        {
            Console.Write(
                "1. Создать массив эл-тов Money \n" +
                "2. Найти минимальный эл-нт Money \n" +
                "3. Демонстрация работы программы \n" + 
                "0. Выход\n\n" +
                "=> ");
        }
        
        static void Main(string[] args)
        {
            MoneyArray a = new MoneyArray();
            int n;
            int num = 0;
            do
            {
                Console.Clear();
                a.PrintMoneyArr();
                Console.WriteLine();
                Console.WriteLine("_________________________________________________________");
                PrintMenu();
                n = Input.Integer("");
                switch (n)
                {
                    case 1:
                        int len = Input.Integer("Введите неотрицательное кол-во эл-тов в массиве : ", 0);
                        a = new MoneyArray(len);
                        break;
                    case 2:
                        Money min = a.FindMin(out num);
                        if (num == 0)
                        {
                            Console.WriteLine("Ошибка, массив пуст, введите массив.");
                            Console.Read();
                        }
                        else
                        {
                            Console.Write($"Минимальный эл-нт => "); min.GetMoney(); Console.Write($"Его номер равен {num}");
                            Console.Read();
                        }
                        break;
                    case 3:
                        Money mon1 = new Money();
                        Money mon2 = new Money(1, 99);
                        Console.WriteLine("Конструктор без параметров");
                        mon1.GetMoney();
                        Console.WriteLine("Конструктор с параметрами (1, 99)");
                        mon2.GetMoney();
                        Console.WriteLine();
                        Console.WriteLine("Добавим каждому эл-ту Money одну копейку с помощью ++");
                        mon1++; 
                        mon2++;
                        Console.WriteLine("Теперь они выглядят вот так");
                        mon1.GetMoney(); mon2.GetMoney();
                        Console.WriteLine();
                        Console.WriteLine("Тогда нужно вычесть из каждого эл-та по 10 копеек");
                        mon1 = mon1 - 10;
                        mon2 -= 10;
                        Console.WriteLine("Теперь они выглядят вот так (Значение первого эл-та стало отрицательным как для копеек, так и для рублей, поэтому он обнуляется)");
                        mon1.GetMoney(); mon2.GetMoney();
                        Console.WriteLine();
                        Console.WriteLine("Создадим две переменные типов int и double соответсвенно и присвоим им значение второго эл-та Money");
                        int rublen = (int)mon2; double kopek = mon2;
                        Console.Write($"Переменная rublen равна {rublen} что соответствует кол-ву рублей во втором эл-те \n" +
                            $"А переменная kopek равна {kopek} что равно кол-ву копеек(в рублях) во втором эл-те Money \n");

                        Console.Read();

                        break;
                }
            } while (n != 0);
            
            

        }
    }
}