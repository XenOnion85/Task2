using System;

namespace VisGod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года:");
            int g = Convert.ToInt32(Console.ReadLine());
            if (g < 1000) Console.WriteLine("Несоответстующее значение");
            else
            {
                if ((g % 4 == 0 && g % 100 != 0) || (g % 400 == 0))
                {
                    Console.WriteLine("YES");
                }
                else Console.WriteLine("NO");
            }
        }
    }
}
