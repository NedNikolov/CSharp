using System;
using System.Threading;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = a; i >= 1; i--)
            {
                for (int j = 1; j <= b; j++)
                {
                    sum += (i * j) * 3;
                    counter++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, maxSum);
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
                
            }
            if (sum < maxSum)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
