using System;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int bytes = 256;
            int n = int.Parse(Console.ReadLine());

            if (n < 256)
            {
                Console.WriteLine(n);
            } else
            {
                int counter = 0;
                while (n >= bytes)
                {
                    n -= 256;
                    counter++;
                }
                Console.WriteLine(n);
                Console.WriteLine("Overflowed {0} times", counter);
            }
        }
    }
}
