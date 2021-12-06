using System;

namespace Xenlongão
{
    class Program
    {
        public static bool isDivQuantOdd(int a)
        {
            int divisores = 0;
            for (var i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    divisores++;
                }
            }
            if (divisores % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            int index = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < index; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int oddSpherCount = 0;
                for (var x = 0; x <= num; x++)
                {
                    bool oddCount = isDivQuantOdd(x);
                    if (oddCount)
                    {
                        oddSpherCount++;
                    }
                }
                Console.WriteLine(num - oddSpherCount);
            }
        }
    }
}
