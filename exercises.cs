using System;

namespace exercises
{
    class exercises
    {

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int result = GetMax(first, second);
                    Console.WriteLine(result);
                    break;
                case "char":
                    char firstSymbol = char.Parse(Console.ReadLine());
                    char secondSymbol = char.Parse(Console.ReadLine());
                   char resultSymbol= GetMax(firstSymbol, secondSymbol);
                    Console.WriteLine(resultSymbol);
                    break;
                case "string":
                    string firstText = Console.ReadLine();
                    string secondText = Console.ReadLine();
                    string resultText = GetMax(firstText, secondText);
                    Console.WriteLine(resultText);
                    
                    break;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            var result = first.CompareTo(second);
            if (result < 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
