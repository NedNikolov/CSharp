using System;
using System.Numerics;

namespace _05.IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());
            var converted = IntgrToBase(number, toBase);
            Console.WriteLine(converted);
        }
        static string IntgrToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var reminder = number % toBase;
                result = reminder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
