using System;

namespace _09.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            string longerLine = GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);

            if (longerLine == "first")
            {
                string closestPoint = GetClosestPoint(x1, y1, x2, y2);
                if (closestPoint == "first")
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                string closestPoint = GetClosestPoint(x1, y1, x2, y2);
                if (closestPoint == "first")
                {
                    Console.WriteLine($"({x3}, {y3})({x4}{y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static string GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double length1 = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
            double length2 = Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2));
            if (length1 > length2)
            {
                return "first";
            }
            else
            {
                return "second";
            }
        }
        static string GetClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            // double distance3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            // double distance4 = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));
            if (distance1 > distance2)
            {
                return "second";
            }
            else
            {
                return "first";
            }
        }
    }
}

