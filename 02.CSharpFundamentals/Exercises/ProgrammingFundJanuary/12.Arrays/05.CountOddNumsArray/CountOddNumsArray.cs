using System;
using System.Linq;

namespace _05.CountOddNumsArray
{
    class CountOddNumsArray
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) % 2 == 1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
