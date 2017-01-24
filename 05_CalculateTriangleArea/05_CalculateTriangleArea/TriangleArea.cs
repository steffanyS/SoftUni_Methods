using System;

namespace _05_CalculateTriangleArea
{
    class TriangleArea
    {
        public static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }

        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, height);
            Console.WriteLine(area);
        }
    }
}
