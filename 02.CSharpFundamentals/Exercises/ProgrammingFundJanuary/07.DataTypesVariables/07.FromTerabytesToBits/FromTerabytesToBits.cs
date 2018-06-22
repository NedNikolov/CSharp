using System;

namespace _07.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double bits = input * (1024d * 1024 * 1024 * 1024 * 8d);
            Console.WriteLine(bits);
        }
    }
}
