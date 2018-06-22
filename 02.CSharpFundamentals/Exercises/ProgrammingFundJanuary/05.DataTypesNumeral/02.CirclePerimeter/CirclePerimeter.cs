using System;

namespace _02.CirclePerimeter
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = 2 * Math.PI * input;

            Console.WriteLine("{0:f12}", result);
        }
    }
}
