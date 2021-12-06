using System;

namespace QuadradodsoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                if (num % 2 == 0)
                {
                    int b = num*num;
                    Console.WriteLine($"{num}^2 = {b}");
                }

            }
        }
    }
}
