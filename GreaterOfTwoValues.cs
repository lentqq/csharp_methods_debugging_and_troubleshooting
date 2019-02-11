using System;

namespace _08.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    int result = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(result);
                    break;
                case "char":
                    char symbol1 = char.Parse(Console.ReadLine());
                    char symbol2 = char.Parse(Console.ReadLine());
                    char result2 = GetMax(symbol1, symbol2);
                    Console.WriteLine(result2);
                    break;
                case "string":
                    string word1 = Console.ReadLine();
                    string word2 = Console.ReadLine();
                    string result3 = GetMax(word1, word2);
                    Console.WriteLine(result3);
                    break;
            }
        }
        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
        static char GetMax(char first, char second)
        {
            if (first >= second)
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
            if (first.CompareTo(second) <= 0)
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
