using System;

namespace Solomon
{
    public class Input
    {
        public static int Integer(string msg, int min = Int32.MinValue, int max = Int32.MaxValue)
        {

            bool f; int n;
            n = 0;
            do
            {
                try
                {
                    f = true;
                    Console.Write(msg);
                    string sw = Console.ReadLine();
                    n = Convert.ToInt32(sw);
                    if (n > max || n < min)
                    {
                        f = false;
                        Console.WriteLine("Выход за границу условия... \n ");
                    }
                }
                catch (FormatException)
                {
                    f = false;
                    Console.WriteLine("Неправильный формат ввода... ");
                }
            } while (!f);
            return n;
        }

        public static double Double(string msg, double min = System.Double.MinValue, double max = System.Double.MaxValue)
        {

            bool f; double n;
            do
            {
                Console.Write(msg);
                string sw = Console.ReadLine();
                f = System.Double.TryParse(sw, out n);
            } while (!f);
            return n;

        }
    }
}
