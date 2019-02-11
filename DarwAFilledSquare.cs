using System;

namespace _04.DrawaAFilledSquare
{
    class DarwAFilledSquare
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeeaderAndFooterRow(number);
            for (int i = 0; i < number / 2; i++)
            {
                PrintMiddleRows(number);
            }
            PrintHeeaderAndFooterRow(number);
        }
        static void PrintHeeaderAndFooterRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRows(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
