using System;

namespace _01.HelloName
{
    class HalloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            WriteName(name);
        }
        static void WriteName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
}
