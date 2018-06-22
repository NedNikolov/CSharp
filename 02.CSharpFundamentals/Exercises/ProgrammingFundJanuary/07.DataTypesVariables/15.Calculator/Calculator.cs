using System;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            switch (symbol)
            {
                case "+": Console.WriteLine("{0} {1} {2} = {3}", a, symbol, b, a + b); break;
                case "-": Console.WriteLine("{0} {1} {2} = {3}", a, symbol, b, a - b); break;
                case "*": Console.WriteLine("{0} {1} {2} = {3}", a, symbol, b, a * b); break;
                case "/": Console.WriteLine("{0} {1} {2} = {3}", a, symbol, b, a / b); break;
            }
        }
    }
}
