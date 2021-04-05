using System;
using System.Collections.Generic;
using System.Text;
using Solomon;
namespace Лаба_9
{
    public class MoneyArray
    {
        Money[] arr = new Money[0];
        public int Length
        {
            get => arr.Length;// 
        }
        public Money[] Arr //
        {
            get => arr; set { arr = value; }
        }
        public MoneyArray() { }
        public MoneyArray(int len)
        {
            arr = new Money[len];
            int z;
            do
            {
                z = Input.Integer(@"
1. Заполнить массив случайными числами
2. Заполнить массив с клавиатуры
Выберите споспоб создания массива : "); // 
            
                switch (z)
                {
                    case 1:
                        for (int i = 0; i < len; i++)
                        {
                            int a, b;
                            a = new Random().Next(0, 10);
                            b = new Random().Next(0, 99);
                            arr[i] = new Money(a, b);
                        }
                        break;

                    case 2:
                        for (int i = 0; i < len; i++)
                        {
                            int a, b;
                            a = Input.Integer("Введите неотрицательное кол-во рублей : ", 0);//
                            b = Input.Integer("Введите неотрицательное кол-во копеек : ", 0);
                            arr[i] = new Money(a, b);
                        }
                        break;
                    default:
                        Console.WriteLine("Вы ввели не правильные данные, прочтите условие снова и введите корректные данные");
                        break;
                }
            } while ((z != 1) && (z != 2));
        }
        public Money this[int index]
        {
            get
            {
                if (index < Length && index >= 0)
                {
                    return arr[index];
                }
                else throw new Exception("Выход за пределы массива");
            }
            set
            {
                if (index < Length && index >= 0)
                {
                    arr[index] = value;
                }

            }
        }

        public void PrintMoneyArr()
        {
            if (Length == 0)
            {
                Console.WriteLine("Массив пуст, задайте массив...");
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    arr[i].GetMoney();//
                }
                Console.WriteLine();
                Console.WriteLine($"В массиве {Length} эл-тов");
            }
        }
        public Money FindMin(out int Number)
        {
            Number = 0;
            if (Length == 0)
                return null;
            Money min = arr[0];
            Number = 1;
            for (int i = 1; i < Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    Number = i + 1;
                }
            }
            return min;
        }
    }
    
}
