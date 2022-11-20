using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Число {0} больше чем {1}", a, b);
            else
                Console.WriteLine("Число {0} больше чем {1}", b, a);
        }
    }
}
