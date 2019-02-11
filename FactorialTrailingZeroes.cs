using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            BigInteger trailingZeroes = GetTrailingZeroes(numbers);
            if (trailingZeroes == 1)
            {
                Console.WriteLine("One trailing zero");
            }
            else
            {
                Console.WriteLine(trailingZeroes);
            }
        }

        private static BigInteger GetTrailingZeroes(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            BigInteger lastDigit;
            int counter = 0;
            while (factorial > 1)
            {
                lastDigit = factorial % 10;
                factorial /= 10;
                if (lastDigit != 0)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
    }
}
