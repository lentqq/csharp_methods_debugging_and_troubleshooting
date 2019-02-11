using System;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
        static bool IsPrime(long number)
        {
            bool prime = true;
            if (number < 2)
            {
                prime = false;
                return prime;
            }
            else
            {
                for (int i = 2; i <= Math .Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                        break; 
                    }
                }
            }
            return prime;
        }
    }
}
