using System;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = GetMax(firstNumber, GetMax(secondNumber, thirdNumber));
            Console.WriteLine(result);

        }
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
