using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите m = ");
            int m = int.Parse(Console.ReadLine());
            int i;
            int s = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.WriteLine("Сумма: {0}", s);
        }
    }
}
