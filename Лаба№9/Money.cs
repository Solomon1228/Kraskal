using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_9
{
    public class Money
    {
        int rubles;
        int kopeks;
        public int Rubles
        {
            get => rubles; set
            {
                if (value >= 0)
                {
                    rubles = value;
                }
                else
                {
                    rubles = 0;
                    Console.WriteLine("Вы ввели отрицательное кол-во рублей.");
                }
            }
        }
        public int Kopeks
        {
            get => kopeks; set
            {
                value = value + rubles * 100;
                if (value >= 0)
                {
                    rubles = value / 100;
                    kopeks = value % 100;
                }
                else
                {
                    rubles = 0;
                    kopeks = 0;
                    Console.WriteLine("Значения ниже нуля, счет обнулен.");
                }

            }
        }
        public Money() { rubles = 0; kopeks = 0; }
        public Money(int x, int y) { rubles = x; Kopeks = y; }
        public void GetMoney()
        {
            Console.WriteLine($"Рубли : {rubles} Копейки : {kopeks}");
        }
        public static Money operator +(Money a, int b)
        {
            a.Kopeks += b;
            return a;
        }
        public static Money operator ++(Money a)
        {
            a.Kopeks++;
            return a;
        }
        public static Money operator --(Money a)
        {
            a.Kopeks--;
            return a;
        }
        public static Money operator -(Money a, int b)
        {
            a.Kopeks -= b;
            return a;
        } 
        
        public static explicit operator int(Money eq)
        {
            return eq.Rubles;
        }
        
        public static implicit operator double(Money eq)
        {
            return eq.kopeks / 100.0;
        }

       
        public static bool operator <(Money a, Money b)
        {
            if (a.rubles < b.rubles)
            {
                return true;
            }
            else
            if (a.rubles == b.rubles)
            {
                return a.kopeks < b.kopeks;
            }
            else return false;
        }
        public static bool operator >(Money a, Money b)
        {
            if (a.rubles > b.rubles)
            {
                return true;
            }
            else
            if (a.rubles == b.rubles)
            {
                return a.kopeks > b.kopeks;
            }
            else return false;
        }
    }
}
