using System;

namespace _11.GeomtryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double result;
            switch (figureType)
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        result = GetTriangleArea(side, height);
                        Console.WriteLine($"{result:f2}");
                        break;
                    }
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        result = GetSquareArea(side);
                        Console.WriteLine($"{result:f2}");
                        break;
                    }
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        result = GetRectangleArea(width, height);
                        Console.WriteLine($"{result:f2}");
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        result = GetCircleArea(radius);
                        Console.WriteLine($"{result:f2}");
                        break;
                    }
            }
        }
        static double GetTriangleArea(double side,double height)
        {
            return side * height / 2;
        }
        static double GetSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }
        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
        static double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
