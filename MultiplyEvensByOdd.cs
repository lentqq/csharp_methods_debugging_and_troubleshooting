using System;

namespace _09.MultiplyEvenByOdds
{
    class MultiplyEvensByOdd
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            int result = sumEvens * sumOdds;
            return result;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0 || n < 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0 || n < 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
