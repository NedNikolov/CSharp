using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int numbers = int.Parse(input[i]);
                sum = sum + numbers;
                if (numbers > max)
                {
                    max = numbers;
                }
            }
            int sumNew = sum - max;
            if (sumNew ==  max)
            {
                Console.WriteLine("Yes, sum=" + max);
            }
            else
            {
                int diff = Math.Abs(sum - 2 * max);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}
