using System;
using Solomon;
namespace Лаба4ЕрискинаЕеВеличествоЕкатеринаВикторовнаАспирантИТАС
{
    class Program
    {
        static void Main(string[] args)
        {
            int str = 0, col = 0, z = 0, length = 0, min = Int32.MaxValue;
            int n = Input.Integer("Введите кол-во городов(от 2 до 10) : ", 2, 10);
            int[,] arr = new int[n, n];
            string[] ost = new string[n-1];
            int[] kolvo = new int[n];
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i+1; j < arr.GetLength(1); j++)
                {
                     arr[i, j] = Input.Integer($"Введите расстояние между городом {i + 1} и {j + 1}(Не меньше 1) : ", 1);    
                }
            }

            for ( z = 0; z < n - 1; z++)
            {
                min = Int32.MaxValue;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    
                    for (int j = i+1; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                            str = i;
                            col = j;
                        }
                    }
                }
                length += min;
                kolvo[str]++;
                kolvo[col]++;
                arr[str, col] = 99;
                ost[z] = $"{str+1}-{col+1}";   
            }
            z--;
            Console.WriteLine("Остовное дерево до проверки");
            for (int i = 0; i < n - 1; i++) 
            {
                Console.WriteLine(ost[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Остовное дерево после проверки");
            for (int prov = 0; prov < n; prov++)
            {
                if (kolvo[prov] == 0)
                {
                    length -= min;
                    kolvo[str] -= 1;
                    kolvo[col] -= 1;
                    min = Int32.MaxValue;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = i + 1; j < arr.GetLength(1); j++)
                        {

                            if (arr[i, j] < min)
                            {
                                min = arr[i, j];
                                str = i;
                                col = j;
                            }
                        }
                    }
                    length += min;
                    kolvo[str]++;
                    kolvo[col]++;
                    arr[str, col] = 99;
                    ost[z] = $"{str + 1}-{col + 1}";
                }while (kolvo[prov] == 0) ;
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(ost[i]);
            }
            Console.WriteLine($"Длина остовного дерева равна : {length}") ;
        }
    }
}
