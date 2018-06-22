using System;

namespace _05.CalcTriangleArea
{
    class CalcTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(width, height));
            double triangle = GetTriangleArea(width, height);
            Console.WriteLine(triangle);

        }
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }


    }
}
