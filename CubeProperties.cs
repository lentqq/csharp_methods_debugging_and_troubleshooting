using System;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double lengthOfTheSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result;
            switch (parameter)
            {
                case "face":
                    {
                        result = GetFaceDiagonal(lengthOfTheSide);
                        Console.WriteLine($"{result:f2}");
                        break;
                    }
                case "space":
                    {
                        result = GetSpaseDiagonal(lengthOfTheSide);
                        Console.WriteLine($"{result:f2}");
                    }
                    break;
                case "volume":
                    {
                        result = GetVolume(lengthOfTheSide);
                        Console.WriteLine($"{result:f2}");
                    }
                    break;
                case "area":
                    {
                        result = GetSurface(lengthOfTheSide);
                        Console.WriteLine($"{result:f2}");
                    }
                    break;
            }
        }
        static double GetFaceDiagonal(double side)
        {
            return Math.Sqrt(Math.Pow(side, 2) * 2);
        }
        static double GetSpaseDiagonal(double side)
        {
            return Math.Sqrt(Math.Pow(side, 2) * 3);
        }
        static double GetVolume (double side)
        {
            return Math.Pow(side, 3);
        }
        static double GetSurface (double side)
        {
            return Math.Pow(side, 2) * 6;
        }
    }
}
