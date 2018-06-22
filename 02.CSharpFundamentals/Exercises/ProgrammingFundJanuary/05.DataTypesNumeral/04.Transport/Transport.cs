using System;

namespace _04.Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            double result = input / 24.0;
            Console.WriteLine("{0}", Math.Ceiling(result));
        }
    }
}
