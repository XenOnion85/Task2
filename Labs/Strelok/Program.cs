using System;

namespace Strelok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько раз вы хотите стрелять(от 1 до 10): ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Введите свой номер по списку: ");
            int n = int.Parse(Console.ReadLine());
            int b = 0;

            Random r = new Random();
            int x0 = r.Next(10);
            int y0 = r.Next(10);

            int xy1 = (x0 + 1) * (x0 + 1) * 100 + (y0 + 1) * (y0 + 1) * 100;
            int xy2 = (x0 + 2) * (x0 + 2) * 100 + (y0 + 2) * (y0 + 2) * 100;
            int xy3 = (x0 + 3) * (x0 + 3) * 100 + (y0 + 3) * (y0 + 3) * 100;

            for (int i = 1; i <= s; i += 1)
            {
                Console.WriteLine("Введите координаты выстрела:");
                Console.Write("x = ");
                double x = double.Parse(Console.ReadLine());
                x *= 10;
                Console.Write("y = ");
                double y = double.Parse(Console.ReadLine());
                y *= 10;
                if (n % 2 != 0)
                {
                    if (x * x + y * y < xy1)
                    {
                        b += 10;
                    }
                    else if (x * x + y * y < xy2)
                    {
                        b += 5;
                    }
                    else b += 0;
                }
                else
                {
                    if (x * x + y * y < xy1)
                    {
                        b += 10;
                    }
                    else if (x * x + y * y < xy2)
                    {
                        b += 5;
                    }
                    else if (x * x + y * y < xy3)
                    {
                        b += 1;
                    }
                    else b += 0;
                }
                Console.WriteLine("Ваши баллы: {0}", b);
            }
        }
    }
}
