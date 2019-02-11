using System;
using System.Text;
namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {           
            string number = Console.ReadLine();
            string reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }
        static string GetReversedNumber(string number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            return sb.ToString();
        }
    }
}
