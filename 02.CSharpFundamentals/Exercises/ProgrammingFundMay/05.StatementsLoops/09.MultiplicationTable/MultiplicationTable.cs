using System;

namespace _09.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", input, i, input * i);
            }
        }
    }
}
