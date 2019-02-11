using System;

namespace _12.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsDivisibleBy7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            int currentDigit = 0;
            bool isEven = false;
            while (i > 0)
            {
                currentDigit = i % 10;
                if (currentDigit % 2 == 0)
                {
                    isEven = true;
                    return isEven;
                }
                i /= 10;
            }
            return false;
        }

        private static bool SumOfDigitsDivisibleBy7(int i)
        {
            int sumOfDigits = 0;
            
            while (i > 0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPalindrome(int i)
        {
            int reversedDigit = 0;
            int oldDigit = i;
            while (i > 0)
            {
                reversedDigit *= 10;
                reversedDigit += i % 10;
                i /= 10;
            }
            if (reversedDigit == oldDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}