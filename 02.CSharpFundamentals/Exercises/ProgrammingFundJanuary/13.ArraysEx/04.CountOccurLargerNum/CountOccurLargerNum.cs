using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountOccurLargerNum
{
    class CountOccurLargerNum
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
