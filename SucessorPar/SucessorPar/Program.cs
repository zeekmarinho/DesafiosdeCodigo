using System;

namespace SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int s;
            if (x % 2 == 0)
            {
                s = x + 2;
            }
            else
            {
                s = x + 1;
            }
            Console.WriteLine(s);
        }
    }
}
