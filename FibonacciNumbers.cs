using System;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int nextNum = GetFibonacciNumber(number);
            Console.WriteLine(nextNum);
        }
        static int GetFibonacciNumber(int number)
        {
            int num0 = 1;
            int num1 = 1;
            for (int i = 0; i < number - 1; i++)
            {
                int nextNum = num0 + num1;
                num0 = num1;
                num1 = nextNum;
            }
            return num1;
        }
    }
}
